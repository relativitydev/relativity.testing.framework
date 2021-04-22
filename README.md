# Relativity.Testing.Framework

This repository contains a C#/NuGet library that abstracts out common functionality for test setup and teardown.

## Build Tasks

This repository builds with Powershell through the `.\build.ps1` script.
It supports standard tasks like `.\build.ps1 compile`, `.\build.ps1 test`, and `.\build.ps1 package`.

## Local Testing

### Unit Testing

Run through the standard compile and (unit) test tasks. These can be done without any external environment to test on.

```PowerShell
.\build.ps1 compile
.\build.ps1 test
```
