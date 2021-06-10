# Contributing to Relativity Testing Framework

:+1::tada: Welcome to Relativity Testing Framework. Thanks for taking the time to contribute! :tada::+1:

## Table Of Contents

* [Where to get help](#where-to-get-help)
* [What should I know before I get started?](#what-should-i-know-before-i-get-started)
  * [Relativity Testing Framework and Packages](#relativity-testing-framework-and-packages)
    * [Relativity.Testing.Framework](#relativity-testing-framework)
    * [Relativity.Testing.Framework.Api](#relativity-testing-framework-api)
* [How Can I Contribute?](#how-can-i-contribute)
  * [Reporting Bugs](#reporting-bugs)
  * [Suggesting Enhancements](#suggesting-enhancements)
  * [Code Contributions](#code-contributions)
    * [Development](#development)
    * [Testing](#testing)
    * [Pull Requests](#pull-requests)
    * [Styleguides](#styleguides)
      * [DotNet Analyzers](#dotnet-styleguide)
      * [Git Commit Messages](#git-commit-messages)
  * [Releasing](#releasing)

## <a name="where-to-get-help">Where to get help</a>

* For general help and questions, please use the `#relativity-testing-framework` slack channel
* For feature requests or bugs, see those [contributing sections](#how-can-i-contribute).

## <a name="what-should-i-know-before-i-get-started">What should I know before I get started?</a>

### <a name="relativity-testing-framework-and-packages">Relativity Testing Framework and Packages</a>

The [Relativity Testing Framework](https://github.com/relativitydev/relativity.testing.framework) and [Relativity Testing Framework Api](https://github.com/relativitydev/relativity.testing.framework.api) are repositories that comprise Relativity Testing Framework.

A brief overview of the important repositories will be provided here to help guide contributors to the correct libraries.

#### <a name="relativity-testing-framework">Relativity.Testing.Framework</a>

[Relativity.Testing.Framework](https://git.kcura.com/projects/TT/repos/relativity.testing.framework/browse/README.md) is a library that uses Inversion of Control to provide functionality from the other libraries in the RTF collection.

This library provides the CoreComponent that is used to help configure dependent libraries.

This library also provides object models and helper classes that are generally useful to all dependent libraries.

If you are working in this repository, you should have at least a basic understanding of [Inversion of Control](http://www.castleproject.org/projects/windsor/), and the Relativity Object Model.

##### Components

* RelativityFacade - A container housing the components that a test will RelyOn.
  * RelativityFacade - [source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/RelativityFacade.cs), [docs](/api/Relativity.Testing.Framework.RelativityFacade.html)
* Object Modeling and Mapping - Defines models for the Objects that are created, and maps the responses from the API requests back to them.
  * Attributes - [source](https://github.com/relativitydev/relativity.testing.framework/tree/master/source/Relativity.Testing.Framework/Attributes), [docs](/api/Relativity.Testing.Framework.Attributes.html)
  * Models - [source](https://github.com/relativitydev/relativity.testing.framework/tree/master/source/Relativity.Testing.Framework/Models), [docs](/api/Relativity.Testing.Framework.Models.html)
  * Mapping - [source](https://github.com/relativitydev/relativity.testing.framework/tree/master/source/Relativity.Testing.Framework/Mapping), [docs](/api/Relativity.Testing.Framework.Mapping.html)
* Configuration Management - Reads in configuration and provides the values to other components.
  * CoreComponent - [source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/CoreComponent.cs), [docs](/api/Relativity.Testing.Framework.CoreComponent.html)
  * Configuration - [source](https://github.com/relativitydev/relativity.testing.framework/tree/master/source/Relativity.Testing.Framework/Configuration), [docs](/api/Relativity.Testing.Framework.Configuration.html)
* Logging - Additional logging methods that can be used to log information while running tests.
  * Logging - [source](https://github.com/relativitydev/relativity.testing.framework/tree/master/source/Relativity.Testing.Framework/Logging), [docs](/api/Relativity.Testing.Framework.Logging.html)
* Versioning - Handles Relativity version checking to determine which version of methods to used.
  * Versioning - [source](https://github.com/relativitydev/relativity.testing.framework/tree/master/source/Relativity.Testing.Framework/Versioning), [docs](/api/Relativity.Testing.Framework.Versioning.html)

#### <a name="relativity-testing-framework-api">Relativity.Testing.Framework.Api</a>

[Relativity.Testing.Framework.Api](https://github.com/relativitydev/relativity.testing.framework.api/tree/master) is a library that provides an API surface over the disparate APIs that Relativity provides.

This library provides the ApiComponent that is used to facilitate sending the requests, and mapping the results back to the provided models from the Relativity.Testing.Framework package.

If you are working in this repository, you should have at least a basic understanding of REST requests, and [Relativity's API surface](https://platform.relativity.com/RelativityOne/Content/REST_API/REST_API.htm).

##### Components

* ApiComponent - Handles all API interactions with Relativity.
  * ApiComponent - [source](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/ApiComponent.cs), [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.ApiComponent.html)
  * HttpService - [source](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/Services/HttpService.cs), [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Services.HttpService.html)
  * RestService - [source](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/Services/RestService.cs), [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Services.RestService.html)
  * Kepler - Privides a service factory to interact with KeplerServices
    * Kepler - [source](https://github.com/relativitydev/relativity.testing.framework.api/tree/master/source/Relativity.Testing.Framework.Api/Kepler), [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Kepler.IKeplerServiceFactory.html)
  * ObjectManager - Handles interaction with ObjectManager endpoints
    * ObjectManagement - [source](https://github.com/relativitydev/relativity.testing.framework.api/tree/master/source/Relativity.Testing.Framework.Api/ObjectManagement) [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.ObjectManagement.html)
    * Querying - [source](https://github.com/relativitydev/relativity.testing.framework.api/tree/master/source/Relativity.Testing.Framework.Api/Querying), [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Querying.html)
  * Services - Houses a collection of similar strategies for hitting individual endpoints
    * Services - [source](https://github.com/relativitydev/relativity.testing.framework.api/tree/master/source/Relativity.Testing.Framework.Api/Services), [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Services.html)
    * Strategies - The individual wrappers around the Relativity endpoints
      * Strategies - [source](https://github.com/relativitydev/relativity.testing.framework.api/tree/master/source/Relativity.Testing.Framework.Api/Strategies)m [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Strategies.html)
* AccountPool - An abstraction around user setup that is useful when you want to make a lot of them.
  * AccountPool - [source](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/Services/AccountPoolService.cs) [docs](https://glowing-spork-1e23a31b.pages.github.io/api/Relativity.Testing.Framework.Api.Services.IAccountPoolService.html)

## <a name="how-can-i-contribute">How Can I Contribute?</a>

### <a name="reporting-bugs">Reporting Bugs</a>

This section guides you through submitting a bug report for Relativity.Testing.Framework.
Following these guidelines helps us in understanding the request and provide a quicker response time.

#### Before Submitting A Bug Report

* **If you are a new user of RTF, check the [RTF Documentation](https://probable-happiness-2926a3e8.pages.github.io/index.html)** to make sure that you're following one of the common usage patterns.
* **Ensure that you are testing against a supported version of Relativity.** Relativity.Testing.Framework is only [tested against the last few current templates in hopper](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/ApiComponent.cs). Official support is not provided for issues relating to versions of Relativity outside of this range.
* **Determine [which library the problem is likely coming from](#relativity-testing-framework-and-packages)**.
* **Perform a quick search in the [Relativity Testing Framework Jira Project](https://jira.kcura.com/browse/RTF-1023?jql=project%20%3D%20%22ENG%3A%20Relativity%20Testing%20Framework%22%20%20order%20by%20id%20DESC)** to see if the problem has already been reported. If it has and the issue is still open, add a comment to the existing issue instead of opening a new one.

> **Note:** If you find a **Closed** issue that seems like it is the same thing that you're experiencing, open a new issue and include a link to the original issue in the body of your new one.

#### How Do I Submit A Good Bug Report?

Send an email to <help-testengineering@relativity.com> to create a Jira ticket for us. We will triage the ticket, and move it to the appropriate location.
Be sure to include the following information:

* **Use a clear and descriptive title** for the issue to identify the problem.
* In the description **Include the names of the libraries** that you think the issue is coming from.
* **Describe the steps which reproduce the problem**.
* **Provide specific examples to demonstrate the steps**. If there is a test that can be run to reproduce the issue, please include a link to it.
* **Describe the behavior you observed after following the steps** and point out what exactly is the problem with that behavior. Please include any errors or stacktraces, if applicable.
* **Explain which behavior you expected to see instead and why**.

Provide more context by answering these questions:

* **Did the problem start happening recently** (e.g. after updating to a new version of Relativity.Testing.Framework) or was this always a problem?
* If the problem started happening recently, **can you reproduce the problem in an older version of Relativity.Testing.Framework?** What's the most recent version in which the problem doesn't happen?
* **Can you reliably reproduce the issue?** If not, provide details about how often the problem happens and under which conditions it normally happens.

Include details about your configuration and environment:

* **Which version of Relativity.Testing.Framework components are you using?**
* **What type and version of environment are you testing against?**

### <a name="suggesting-enhancements">Suggesting Enhancements</a>

This section guides you through submitting an enhancement suggestion for Relativity.Testing.Framework, including completely new features and minor improvements to existing functionality.
Following these guidelines helps us in understanding the request and provide a quicker response time.

#### Before Submitting An Enhancement Suggestion

* **Determine [which repository the enhancement belongs to](#relativity-testing-framework-and-packages).**
* **Perform a quick search in the [Relativity Testing Framework Jira Project](https://jira.kcura.com/browse/RTF-1023?jql=project%20%3D%20%22ENG%3A%20Relativity%20Testing%20Framework%22%20%20order%20by%20id%20DESC)** to see if the enhancement has already been suggested. If it has, add a comment to the existing issue instead of opening a new one.

#### How Do I Submit A Good Enhancement Suggestion?

Send an email to <help-testengineering@relativity.com> to create a Jira ticket for us. We will triage the ticket, and move it to the appropriate location.
Be sure to include the following information:

* **Use a clear and descriptive title** for the issue to identify the suggestion.
* In the description **Include the names of the libraries** that you would like to see the enhancement in.
* **Provide a step-by-step description of the suggested enhancement** in as many details as possible.
* If possible, **Provide specific examples to demonstrate the steps** that you imagine you would take if the feature you're requesting.
* **Describe the current behavior** and **explain which behavior you expected to see instead** and why.
* **Explain why this enhancement would be useful** to most Relativity.Testing.Framework users.

### <a name="code-contributions">Code Contributions</a>

Be sure to also review the CONTRIBUTING.md at the root of the repository you are working in for any information specific to that codebase.

#### <a name="development">Development</a>

All development work should be done in feature branches off of the develop branch.
Branch names should include the ID of the story in Jira.

##### Updating the Changelog

All changes must be logged in the [CHANGELOG.md](https://github.com/relativitydev/relativity.testing.framework/blob/master/CHANGELOG.md) at the root of the repository being changed.

#### <a name="testing">Testing</a>

Unit and/or functional tests are expected for all changes unless otherwise indicated.
Tests should be added in the FunctionalTests project in a fixture that mirrors the structure of library.
e.g. [WorkspaceGetByNameStrategy](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/Strategies/Workspaces/WorkspaceGetByNameStrategy.cs) should be tested in [WorkspaceGetByNameStrategyFixture](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api.FunctionalTests/Strategies/Workspaces/WorkspaceGetByNameStrategyFixture.cs)

All testing for these repositories can be done through conventional means with a TestVM.
In general, this process includes:

* [Setting up a TestVM](https://einstein.kcura.com/x/PwGwBg)
* Creating a [runsettings file](https://einstein.kcura.com/pages/viewpage.action?pageId=233734697#HowToRunADSCI/CDTestsAgainstYourTestVM-ConfiguringTestParameters) or environment variables that point to that TestVM
  * Configure VisualStudio to use your runsettings file, if using that
* Running the tests with the test explorer in VisualStudio

#### <a name="pull-requests">Pull Requests</a>

Opening a pull request to any of the Relativity.Testing.Framework codebases will automatically add the repository owners to it.

The following must be happen before the pull request can be merged in:

* One of the default reviewers must approve it
* All tests must be passing
* All tasks on the pull request must be completed
* If the story requires changes across multiple repositories, pull requests should be opened for all of them at the same time, and referenced together.
  * i.e. If you are [making a change to Relativity.Testing.Framework](https://git.kcura.com/projects/TT/repos/relativity.testing.framework/pull-requests/391/overview) that you intend to [consume in Relativity.Testing.Framework.Api](https://git.kcura.com/projects/TT/repos/relativity.testing.framework.api/pull-requests/10/overview), we need to see that the integration works before they can be approved.

While the prerequisites above must be satisfied prior to having your pull request reviewed, the reviewer(s) may ask you to complete additional design work, tests, or other changes before your pull request can be ultimately accepted.

#### <a name="styleguides">Styleguides</a>

##### <a name="dotnet-styleguide">DotNet Styleguide</a>

In general, just follow the [C# Coding Standards](https://einstein.kcura.com/x/I6D5AQ) and any conventions that are in place in the repository.
Analyzers are already in place in the projects to enforce most of these.

##### <a name="git-commit-messages">Git Commit Messages</a>

* Commit messages must contain the Jira story id.
* Commits should be squshed into a single one for each pull request.
* Commit messages must describe what is changing.

e.g.

> [RTF-1019] Adding ObjectTypeGuidAttribute for use in RTF.Api ObjectManager. Adding ObjectTypeGuidResolver and tests.

#### <a name="releasnig">Releasing</a>

The develop branch of these repositories will create a prerelease package for testing purposes.
Once a sprint, the Test Engineering team will merge the develop branch into master to create the finalized version for all the changes introduced in the sprint.
