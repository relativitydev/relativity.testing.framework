## My test is failing with an exception about Castle.Windsor

### The error message might look like this:  

> OneTimeSetUp: System.MethodAccessException : Attempt by method 'Castle.MicroKernel.SubSystems.Configuration.DefaultConfigurationStore..ctor()' to access method 'System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>..ctor()' failed.
> Exception doesn't have a stacktrace

### Solution 

Reference the same version of Castle.Windsor that we use in Relativity.Testing.Framework (3.3.0).
Newer versions of Castle.Windsor are not tested in our build, and are not guaranteed to work.

## I made an API request to get an object, and some of the fields aren't filled out all the way

This could be happening for one of two reasons.

1. When we make a request to ObjectManager, it only gives us the name back on the objects associated with it.
  * e.g. The ResourcePool from a Workspace request
2. We missed something in our modeling

### Solution 

If you run into this issue, use an API client (e.g. [PowerShell](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/invoke-restmethod?view=powershell-7.1) or [PostMan](https://www.postman.com/)) to make the same request to ObjectManager.

If the request returns you more information about the dependent objects, we can map those, if not, you will need to get that information in your test after making the initial request.

## My test is failing when trying to map a type

### The error message might look like this:  

> OneTimeSetUp: Relativity.Testing.Framework.MappingException : Failed to map "Type" property for Relativity.Testing.Framework.ResourceServer type. Property "RelativityOne Compute" value of System.String type cannot be converted to Relativity.Testing.Framework.ResourceServerType type.
> ----> System.Collections.Generic.KeyNotFoundException : The given key was not present in the dictionary.

Some object models in RTF use enums to maintain a list of the available options for the value.  

If the object we are modeling is a system artifact, there should be a static list of these options, and we should only need to add/remove/update them as they are changed in Relativity.

If this is the case, please open up a ticket with <help-testengineering@relativity.com> and let us know how the model should be changed.

However, there are also some objects that normally behave like system artifacts, but are actually choices in disguise!  
If we've mistakenly identified something as an enum, please open up a ticket with <help-testengineering@relativity.com> and let us know which part of the model should not be an enum.
