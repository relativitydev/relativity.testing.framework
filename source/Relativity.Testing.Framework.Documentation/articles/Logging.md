RelativRelativity.Testing.Framework will provide trace logs for you, and if using the WebComponent, screenshots as well on failure.

This is done automatically for you, and the default output location is a "Results" folder inside of the bin directory where your tests dlls are.

# Using the LogService

The built in log service is built around NLog, and can be retrieved anytime after the CoreComponent has been relied on.


```
ILogService logger = RelativityFacade.Instance.Resolve<ILogService>();
logger.Info("Some useful information");
```

This will show up in the corresponding log in the Results folder that is created while running tests.

# Setting a custom Results folder

To make it easier to organize test output (especially when running multiple sets of tests at the same time), we have provided a ResultsLocation setting that can specify the output location.

If setting this through runsettings, it should look like this:

```
<RunSettings>
  <TestRunParameters>
    <Parameter name="ServerBindingType" value="https" />
    <Parameter name="RelativityHostAddress" value="P-DV-VM-CUP7WET" />
    <Parameter name="AdminUsername" value="relativity.admin@kcura.com" />
    <Parameter name="AdminPassword" value="APassword1234!" />
    <Parameter name="RestServicesHostAddress" value="P-DV-VM-CUP7WET" />
    <Parameter name="WebApiHostAddress" value="P-DV-VM-CUP7WET" />
    <Parameter name="ResultsLocation" value="D:\Results" /> <!-- Set output directory for trace logs and screenshots -->
  </TestRunParameters>
</RunSettings>
```

Output will then be sent to the location that is set in ResultsLocation.

Results inside of this folder are organized based on the fixture name and test name that is running. 

Here is a screenshot showing what that might look like:
![Logging Location Example](/images/LoggingLocationExample.png "Logging Location Example")
