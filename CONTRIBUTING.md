# Contributing to Relativity Testing Framework

:+1::tada: Welcome to Relativity Testing Framework. Thanks for taking the time to contribute! :tada::+1:

## Table Of Contents

- [Contributing to Relativity Testing Framework](#contributing-to-relativity-testing-framework)
  - [Table Of Contents](#table-of-contents)
  - [<a name="where-to-get-help">Where to get help</a>](#where-to-get-help)
  - [<a name="what-should-i-know-before-i-get-started">What should I know before I get started?</a>](#what-should-i-know-before-i-get-started)
    - [<a name="relativity-testing-framework-packages">Relativity Testing Framework Packages</a>](#relativity-testing-framework-packages)
  - [<a name="how-can-i-contribute">How Can I Contribute?</a>](#how-can-i-contribute)
    - [<a name="reporting-bugs">Reporting Bugs</a>](#reporting-bugs)
      - [Before Submitting A Bug Report](#before-submitting-a-bug-report)
    - [<a name="suggesting-enhancements">Suggesting Enhancements</a>](#suggesting-enhancements)
      - [Before Submitting An Enhancement Suggestion](#before-submitting-an-enhancement-suggestion)
    - [<a name="code-contributions">Code Contributions</a>](#code-contributions)
      - [<a name="development">Development</a>](#development)
        - [Coding Standards](#coding-standards)
        - [Updating the Changelog](#updating-the-changelog)
      - [<a name="testing">Testing</a>](#testing)
      - [<a name="pull-requests">Pull Requests</a>](#pull-requests)
      - [<a name="styleguides">Styleguides</a>](#styleguides)
        - [<a name="git-commit-messages">Git Commit Messages</a>](#git-commit-messages)
      - [<a name="releasing">Releasing</a>](#releasing)

## <a name="where-to-get-help">Where to get help</a>

* For general help and questions, please start a [Discussion](https://github.com/relativitydev/relativity.testing.framework/discussions).
* For feature enhancements or bug reports, please create an [Issue](https://github.com/relativitydev/relativity.testing.framework/issues) using the respective template. For further information, see [How can I contribute](#how-can-i-contribute).

## <a name="what-should-i-know-before-i-get-started">What should I know before I get started?</a>

### <a name="relativity-testing-framework-packages">Relativity Testing Framework Packages</a>

The [Relativity Testing Framework](https://github.com/relativitydev/relativity.testing.framework) and [Relativity Testing Framework Api](https://github.com/relativitydev/relativity.testing.framework.api) are repositories that comprise Relativity Testing Framework.

At a high level, Relativity Testing Framework handles configuration management and object models, while Relativity Testing Framework API handles the interactions with the Relativity APIs.

## <a name="how-can-i-contribute">How Can I Contribute?</a>

### <a name="reporting-bugs">Reporting Bugs</a>

This section guides you through submitting a bug report for Relativity.Testing.Framework.
Following these guidelines helps us in understanding the request and provide a quicker response time.

#### Before Submitting A Bug Report

* **If you are a new user of RTF, check the [RTF Documentation](https://probable-happiness-2926a3e8.pages.github.io/index.html)** to make sure that you're following one of the common usage patterns.
* **Ensure that you are testing against a supported version of Relativity.** Relativity.Testing.Framework is only [tested against the last few current templates in hopper](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/ApiComponent.cs). Official support is not provided for issues relating to versions of Relativity outside of this range.
* **Determine [which library the problem is likely coming from](#relativity-testing-framework-and-packages)**.
* **Perform a quick search in the [issue tracker](https://github.com/relativitydev/relativity.testing.framework/issues)** to see if the problem has already been reported. If it has and the issue is still open, add a comment to the existing issue instead of opening a new one.

> **Note:** If you find a **Closed** issue that seems like it is the same thing that you're experiencing, open a new issue and include a link to the original issue in the body of your new one.

### <a name="suggesting-enhancements">Suggesting Feature Enhancements</a>

This section guides you through submitting an enhancement suggestion for Relativity.Testing.Framework, including completely new features and minor improvements to existing functionality.
Following these guidelines helps us in understanding the request and provide a quicker response time.

#### Before Submitting A Feature Enhancement Issue

* **Perform a quick search in the [issue tracker](https://github.com/relativitydev/relativity.testing.framework/issues)** to see if the feature enhancement has already been suggested. If it has, add a comment to the existing issue instead of opening a new one.

### <a name="code-contributions">Code Contributions</a>

Be sure to also review the CONTRIBUTING.md at the root of the repository you are working in for any information specific to that codebase.

#### <a name="development">Development</a>

All development work should be done in feature branches off of the master branch.
Branch names should indicate the [issue](https://github.com/relativitydev/relativity.testing.framework/issues) that they are solving.
The code should follow the architecture described [here](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/docs/dev/architecture.md).

##### Coding Standards

Please follow the existing naming and casing conventions as best as possible.

| Tokens                            | Casing Style                                           |
| :---                              |                                                  ----: |
| Types, Methods                    | Pascal                                                 |
| Local Variables, Method Arguments | Camel                                                  |
| Private Member Variables          | Camel, underscore prefix                               |
| Non-Private Member Variables      | Avoid, use C# Properties                               |
| Private Constants                 | All caps, underscore-separated, underscore prefix      |
| Non-private Constants             | All caps, underscore-separated, no prefix              |

##### Updating the Changelog

All changes must be logged in the [CHANGELOG.md](https://github.com/relativitydev/relativity.testing.framework/blob/master/CHANGELOG.md) at the root of the repository being changed.

#### <a name="testing">Testing</a>

Unit and/or functional tests are expected for all changes unless otherwise indicated.
Tests should be added in the FunctionalTests project in a fixture that mirrors the structure of library.
e.g. [WorkspaceGetByNameStrategy](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/Strategies/Workspaces/WorkspaceGetByNameStrategy.cs) should be tested in [WorkspaceGetByNameStrategyFixture](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api.FunctionalTests/Strategies/Workspaces/WorkspaceGetByNameStrategyFixture.cs)

All testing for these repositories can be done through conventional means against a Relativity server.
In general, this process includes:

* Acquiring a server to test against
* Generating test parameters to point to that server
  * [New-TestSettings.ps1](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/DevelopmentScripts/New-TestSettings.ps1) is a good way to generate test parameters.
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

##### <a name="git-commit-messages">Git Commit Messages</a>

* Commits should be squshed into a single one for each pull request.
* Commit messages must describe what is changing.

e.g.

> [RTF-1019] Adding ObjectTypeGuidAttribute for use in RTF.Api ObjectManager. Adding ObjectTypeGuidResolver and tests.

#### <a name="releasing">Releasing</a>

Feature branches will create a prerelease package and upload them as an artifact of the build.
Release branches will publish a golden package to NuGet.
