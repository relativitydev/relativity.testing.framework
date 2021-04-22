FormatTaskName "------- Executing Task: {0} -------"

properties {
    $SourceDir = Join-Path $PSScriptRoot "source"
    $Solution = ((Get-ChildItem -Path $SourceDir -Filter *.sln -File)[0].FullName)
    $ArtifactsDir = Join-Path $PSScriptRoot "Artifacts"
    $LogsDir = Join-Path $ArtifactsDir "Logs"
    $LogFilePath = Join-Path $LogsDir "buildsummary.log"
    $ErrorLogFilePath = Join-Path $LogsDir "builderrors.log"
}

Task default -Depends Analyze, Compile, Test, Package -Description "Build and run unit tests. All the steps for a local build.";

Task Analyze -Description "Run build analysis" {
    # Placeholder task
}

Task Compile -Description "Compile code for this repo" {
    Initialize-Folder $ArtifactsDir -Safe
    Initialize-Folder $LogsDir -Safe

    exec { dotnet @("build", $Solution,
        ("/property:Configuration=$BuildConfig"),
        ("/consoleloggerparameters:Summary"),
        ("/nodeReuse:False"),
        ("/maxcpucount"),
        ("/nologo"),
        ("/fileloggerparameters1:LogFile=`"$LogFilePath`""),
        ("/fileloggerparameters2:errorsonly;LogFile=`"$ErrorLogFilePath`"")) 
    }
}

Task Test -Description "Run unit tests that don't require a deployed environment." {
    $TestResultsPath = Join-Path $LogsDir "{assembly}.{framework}.TestResults.xml"
    $CoveragePath = Join-Path $LogsDir "Coverage.xml"
    exec { & dotnet @("test", $Solution,
        "--filter", "TestCategory!=FunctionalTests"
        ("/p:collectcoverage=true"),
        ("/p:CoverletOutputFormat=cobertura"),
        ("--logger:nunit;LogFilePath=$TestResultsPath"))
    }

    $coverageReports = [string]::Empty
    Get-ChildItem $PSScriptRoot -Filter "*.cobertura.xml" -Recurse | ForEach-Object { $coverageReports += "$($_.FullName);" }
    exec { & $ReportGenerator @(
        ("-reports:$coverageReports"),
        ("-targetdir:$LogsDir"),
        ("-reporttypes:Cobertura"))
    }
    Move-Item (Join-Path $LogsDir Cobertura.xml) $CoveragePath -Force
}

Task Sign -Description "Sign all files" {
    Get-ChildItem $PSScriptRoot -recurse `
    | Where-Object {$_.Directory.FullName -notmatch "Vendor" -and $_.Directory.FullName -notmatch "packages" -and $_.Directory.FullName -notmatch "buildtools" -and $_.Directory.FullName -notmatch "obj" -and @(".dll",".msi",".exe") -contains $_.Extension} `
    | Select-Object -expand FullName `
    | Set-DigitalSignature -ErrorAction Stop
}

Task Package -Description "Package up the build artifacts" {
    Initialize-Folder $ArtifactsDir -Safe

    exec { dotnet @("pack", $Solution,
        ("--no-build"),
        ("/property:Configuration=$BuildConfig"),
        ("/consoleloggerparameters:Summary"),
        ("/maxcpucount"),
        ("/nologo"))
    }

    Save-PDBs -SourceDir $SourceDir -ArtifactsDir $ArtifactsDir
}

Task Clean -Description "Delete build artifacts" {
    Initialize-Folder $ArtifactsDir

    Write-Verbose "Running Clean target on $Solution"
    exec { dotnet @("msbuild", $Solution,
        ("/target:Clean"),
        ("/property:Configuration=$BuildConfig"),
        ("/consoleloggerparameters:Summary"),
        ("/nodeReuse:False"),
        ("/maxcpucount"),
        ("/nologo"))
    }
}

Task Rebuild -Description "Do a rebuild" {
    Initialize-Folder $ArtifactsDir

    Write-Verbose "Running Rebuild target on $Solution"
    exec { dotnet @("msbuild", $Solution,
        ("/target:Rebuild"),
        ("/property:Configuration=$BuildConfig"),
        ("/consoleloggerparameters:Summary"),
        ("/nodeReuse:False"),
        ("/maxcpucount"),
        ("/nologo"),
        ("/fileloggerparameters1:LogFile=`"$LogFilePath`""),
        ("/fileloggerparameters2:errorsonly;LogFile=`"$ErrorLogFilePath`""))
    }
}

Task Help -Alias ? -Description "Display task information" {
    WriteDocumentation
}

<#
.SYNOPSIS
    Initialize a folder.
.DESCRIPTION
    Initialize a folder. Optionally, do not delete any pre-existing contents.
.PARAMETER Path
    Path of the folder to initialize. By default, if this path already exists, any contents will be deleted.
.PARAMETER Safe
    If set, any pre-existing contents od the folder will be left on disk.
.EXAMPLE
    Initialize-Folder "C:\MyFolder"
.EXAMPLE
    "C:\MyFolder" | Initialize-Folder -Safe
#>
Function Initialize-Folder
{
    param(
        [Parameter(Mandatory = $true, Position = 0)]
        [String] $Path,
        [Parameter()]
        [switch] $Safe
    )

    if ((Test-Path $Path) -and $Safe)
    {
        Return
    }

    if (Test-Path $Path)
    {
        Remove-Item -Recurse -Force $Path -ErrorAction Stop
    }

    $null = New-Item -Type Directory $Path -Force -ErrorAction Stop -Verbose:$VerbosePreference
}

<#
.SYNOPSIS
    Copies PDBs to artifacts folder for publishing.
.DESCRIPTION
    Copies PDBs from sources directories (maintaining relative paths) to the artifacts folder and compresses them into a ZIP file called PDBs.zip. This is useful if you wish to load PDB's as part of debugging a published package.
.PARAMETER SourceDir
    Required: Path to the root location of the compiled source that contains PDBs.
.PARAMETER ArtifactsDir
    Required: Path to the root location of the output artifacts (packages and PDBs.)
.PARAMETER NoCompress
    Optional: If set, this switch option will NOT compress the PDB folder into a single zip file (and leave the artifact PDBs folder in tact.) Otherwise, the default is to create a single ZIP file of PDBs for publishing.
.PARAMETER IncludeTestPDBs
    Optional: If set, PDBs whose folder paths contain the string "tests" will be included in the PDB output. Otherwise, those PDBs are ignored.
.PARAMETER IncludePackagePDBs
    Optional: If set, PDBs whose folder paths contain the string "package" will be included in the PDB output. Otherwise, those PDBs are ignored.
.EXAMPLE
    Normal usage
    ------------
    Save-PDBs -SourceDir '.\Source' -ArtifactsDir '.\Artifacts'
    Save-PDBs -SourceDir '.\Source' -ArtifactsDir '.\Artifacts' -NoCompress

    Other use-cases
    ---------------------
    If you want to include PDBs that were created under tests folders, use the -IncludeTestPDBs flag:
    Save-PDBs -SourceDir '.\Source' -ArtifactsDir '.\Artifacts' -IncludeTestPDBs

    If you want to include PDBs that were downloaded as part of external NuGet packages, use -IncludePackagePDBs:
    Save-PDBs -SourceDir '.\Source' -ArtifactsDir '.\Artifacts' -IncludePackagePDBs
#>
Function Save-PDBs
{
    [CmdletBinding()]
    param(
        [parameter(Mandatory = $True)]
        [string] $SourceDir,

        [parameter(Mandatory = $True)]
        [string] $ArtifactsDir,

        [parameter()]
        [switch] $NoCompress,

        [parameter()]
        [switch] $IncludeTestPDBs,

        [parameter()]
        [switch] $IncludePackagePDBs
    )

    BEGIN
    {
        Write-Verbose "Begin creating PDB artifacts."
    }

    PROCESS
    {
        $artifactsPDBFolder = (Join-Path $ArtifactsDir "PDBs")
        $pdbZipFilePath = (Join-Path $ArtifactsDir "PDBs.zip")
        $fqSourcePath = Resolve-Path -Path $SourceDir

        Write-Verbose "`$SourceDir: $SourceDir"
        Write-Verbose "`$ArtifactsDir: $ArtifactsDir"
        Write-Verbose "`$artifactsPDBFolder: $artifactsPDBFolder"
        Write-Verbose "`$pdbZipFilePath: $pdbZipFilePath"
        Write-Verbose "`$fqSourcePath: $fqSourcePath"
        Write-Verbose "`$NoCompress: $NoCompress"
        Write-Verbose "`$IncludeTestPDBs: $IncludeTestPDBs"
        Write-Verbose "`$IncludePackagePDBs: $IncludePackagePDBs"

        # If the PDB folder exists, delete it.
        if (Test-Path -Path $artifactsPDBFolder)
        {
            Write-Verbose "Cleanup: Removing pre-existing folder: $artifactsPDBFolder"
            Remove-Item -Path $artifactsPDBFolder -Recurse -Force
        }

        # If the PDB zip file exists, delete it.
        if (Test-Path -Path $pdbZipFilePath)
        {
            Write-Verbose "Cleanup: Removing pre-existing file: $pdbZipFilePath"
            Remove-Item -Path $pdbZipFilePath -Force
        }

        New-Item -Path $artifactsPDBFolder -ItemType Directory -ErrorAction Stop | Out-Null

        $foundPDBFiles = (Get-ChildItem -Path "$SourceDir\*" -Include *.pdb -Exclude (Join-Path $SourceDir "packages") -Recurse)

        Write-Verbose "Number of PDB files found using Get-ChildItem in $SourceDir\*: $($foundPDBFiles.Length)"

        foreach ($pdbfile in $foundPDBFiles)
        {
            if ((-not $IncludeTestPDBs) -and ($pdbfile.FullName -imatch 'tests'))
            {
                Write-Verbose "Skipping file `"$($pdbfile.FullName)`" because it contains `"tests`" in the path name."

            }
            elseif ((-not $IncludePackagePDBs) -and ($pdbfile.FullName -imatch 'package'))
            {
                Write-Verbose "Skipping file `"$($pdbfile.FullName)`" because it contains `"package`" in the path name."

            }
            else
            {
                Write-Verbose "Copying file `"$($pdbfile.FullName)`"..."
                $FullDestinationFilePath = Join-Path $artifactsPDBFolder $pdbfile.FullName.Replace($fqSourcePath.Path, "")
                $PathOnly = Split-Path $FullDestinationFilePath
                if (-not (Test-Path $PathOnly))
                {
                    New-Item -Path $PathOnly -ItemType Directory -ErrorAction Stop | Out-Null
                }
                Copy-Item -Path $pdbfile.FullName -Destination $FullDestinationFilePath -Force
            }
        }

        if ($NoCompress)
        {
            Write-Verbose "-NoCompress was specified, leaving the PDBs folder intact and not generating a zip file."
        }
        else
        {
            Write-Verbose "Compressing PDBs folder into zip file."
            Compress-Archive -Path $artifactsPDBFolder -CompressionLevel Optimal -DestinationPath $pdbZipFilePath

            Write-Verbose "Removing PDBs folder."
            Remove-Item -Path $artifactsPDBFolder -Recurse -Force
        }

    }

    END
    {
        Write-Verbose "Done creating PDB artifacts."
    }
}

<#
.SYNOPSIS
    Signs an array of files
.DESCRIPTION
    Signs a set of files using a trusted timestamp server
.PARAMETER Files
    Array of paths to files to sign.
.PARAMETER Certificate
    The certificate to use to sign the files. If one is not passed in,
    a CodeSigningCert will be grabbed from cert:\CurrentUser\my
.EXAMPLE
    Get-ChildItem "C:\Example" -recurse | select -expand FullName | Set-DigitalSignature
.EXAMPLE
    $Cert = Get-ChildItem -Path cert:\LocalMachine\Trust\B2E92EA3B4FA88521C14A070C82DFA86911E7328
    Get-ChildItem "C:\Example" -recurse | select -expand FullName | Set-DigitalSignature -Certificate $Cert
#>
Function Set-DigitalSignature
{
    [CmdletBinding()]
    param(
        [parameter(ValueFromPipeline = $true, Mandatory = $true)]
        [string[]] $File,

        [parameter()]
        [System.Security.Cryptography.X509Certificates.X509Certificate2] $Certificate,

        [parameter()]
        [string[]] $TimestampServer = @("http://timestamp.digicert.com",
            "http://timestamp.comodoca.com/authenticode",
            "http://tsa.starfieldtech.com")
    )

    BEGIN
    {
        if ($Certificate)
        {
            Write-Verbose "The following certificate was passed in:`n$Certificate"
        }
        else
        {
            $Certificate = (Get-ChildItem -Path cert:\CurrentUser\my -CodeSigningCert | Where-Object { $_.NotAfter -gt (Get-Date) })[0]
            Write-Verbose "Using the following certificate:`n$Certificate"
        }

        Write-Verbose "`nUsing the following timestamp servers to sign files:`n$TimestampServer `n"

        Function Get-IsSigned ([String]$FileToSign)
        {
            $signature = (Get-AuthenticodeSignature $FileToSign -Verbose:$VerbosePreference)
            $signatureStatus = $signature.Status
            $signatureTimeStamp = $signature.TimeStamperCertificate
            Write-Verbose "Status: $signatureStatus"
            ($signatureStatus -eq "Valid") -and ($null -ne $signatureTimeStamp)
        }
    }

    PROCESS
    {
        foreach ($fileToSign in $File)
        {
            Write-Verbose "Checking file $File"
            $isSigned = Get-IsSigned $fileToSign
            Write-Verbose "File is signed? $isSigned"
            if (!$isSigned)
            {
                foreach ($Server in $TimestampServer)
                {
                    Write-Verbose "Signing with $Server"
                    Set-AuthenticodeSignature -FilePath $fileToSign -Certificate $Certificate -TimestampServer $Server -Verbose:$VerbosePreference
                    # This makes sure that the file was signed with a valid certificate.
                    # It is possible to have files signed with garbage certificates, in which case
                    # we'd want to check the exit code of Set-AuthenticodeSignature instead.
                    $isSigned = Get-IsSigned $fileToSign
                    if ($isSigned)
                    {
                        Write-Verbose "Signing was successful."
                        break
                    }
                }

                if (!$isSigned)
                {
                    Throw "Failed to sign $FileToSign"
                }
            }
        }
    }

    END
    {
        Write-Verbose "Finished signing files."
    }
}