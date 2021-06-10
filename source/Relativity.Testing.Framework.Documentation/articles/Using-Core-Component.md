# Default Configuration

The [CoreComponent](/api/Relativity.Testing.Framework.CoreComponent.html) handles reading in configuration values and delivering them to the other components that will be using them.  

Before using any of the other components, you need to rely on the [CoreComponent](/api/Relativity.Testing.Framework.CoreComponent.html) so that it can populate these values.


```
[OneTimeSetUp]
public void Setup()
{
    RelativityFacade.Instance.RelyOn<CoreComponent>();
}
```
By default, this will read in environment variables and NUnit test parameters to populate ready to use properties for common values.  

This means that if you are generating FunctionalTestSettings using something like the [New-TestSettings.ps1 file](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/DevelopmentScripts/New-TestSettings.ps1), and running your tests using NUnit from the command line, you should not need to do anything further to configure the [CoreComponent](/api/Relativity.Testing.Framework.CoreComponent.html).

# Custom Configuration

The [CoreComponent](/api/Relativity.Testing.Framework.CoreComponent.html) does however allow you to generate your own ConfigurationRoot and use that to populate the configs.  

The following example will also look for an appsettings.json file at the base directory where the tests are running from.


```
[OneTimeSetUp]
public void Setup()
{
    IConfigurationRoot configurationRoot = new ConfigurationBuilder().
        SetBasePath(AppDomain.CurrentDomain.BaseDirectory).
        AddJsonFile("appsettings.json").
        AddEnvironmentVariables().
        AddNUnitParameters().
        Build();
 
    RelativityFacade.Instance.RelyOn(new CoreComponent { ConfigurationRoot = configurationRoot });
}
```
# Getting Config Values

The [CoreComponent](/api/Relativity.Testing.Framework.CoreComponent.html) will auto-populate some common properties for you when it reads in the ConfigurationRoot. 

These are the common properties and some example values for them:  

* AdminPassword: "SecretPassword"
* AdminUsername: "relativity.admin@kcura.com"
* RapDirectory: "..\..\Artifacts"
* RelativityHostAddress: "P-DV-VM-THE1SUT"
* RestServicesHostAddress: "P-DV-VM-THE1SUT"
* ServerBindingType: "https"
* WebApiHostAddress: "P-DV-VM-THE1SUT"

The common properties are all accessible as properties on [RelativityFacade.Instance.Config.RelativityInstance](/api/Relativity.Testing.Framework.Configuration.IConfigurationService.html#Relativity_Testing_Framework_Configuration_IConfigurationService_RelativityInstance)

Using AdminUsername as an example, we can access the it like this:

```
[OneTimeSetUp]
public void Setup()
{
    RelativityFacade.Instance.RelyOn<CoreComponent>();
 
 
    Console.WriteLine(RelativityFacade.Instance.Config.RelativityInstance.AdminUsername);
}
```

# Custom Config Values

Relativity Testing Framework also allows you to get any non-common config values that you might need in your tests.
To do so, you don't need to do anything special with the config files, or how you read them in. They just need to be present like any other configuration value.  

To access these properties, you can use the [RelativityFacade.Instance.Config.GetValue function](/api/Relativity.Testing.Framework.Configuration.IConfigurationService.html#Relativity_Testing_Framework_Configuration_IConfigurationService_GetValue_System_String_).  

In the example below, we are getting the value of the UniqueProperty config value.

```
[OneTimeSetUp]
public void Setup()
{
    RelativityFacade.Instance.RelyOn<CoreComponent>();
 
 
    Console.WriteLine(RelativityFacade.Instance.Config.GetValue("UniqueProperty"));
}
```
