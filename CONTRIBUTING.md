# Contributing to Relativity.Testing.Framework

:+1::tada: Welcome to Relativity.Testing.Framework! Thanks for taking the time to contribute! :tada::+1:

## Table Of Contents

- [Where to get help](#where-to-get-help)
- [What should I know before I get started?](#what-should-i-know-before-i-get-started)
  - [Relativity.Testing.Framework Packages](#relativitytestingframework-packages)
- [How Can I Contribute?](#how-can-i-contribute)
  - [Reporting Issues](#reporting-issues)
  - [Code Contributions](#code-contributions)
    - [Development](#development)
      - [Updating the Changelog](#updating-the-changelog)
    - [Testing](#testing)
    - [Pull Requests](#pull-requests)
    - [Styleguides](#styleguides)
      - [Git Commit Messages](#git-commit-messages)
    - [Releasing](#releasing)

## Where to get help

- Official support is only provided for the following versions.
  - RelativityOne current and preview versions
  - Relativity Server 2022 (12.1) and later
- Check the [Relativity.Testing.Framework Documentation](https://relativitydev.github.io/relativity.testing.framework/) to find common usage patterns.
- For general help and questions, please start a [Discussion](https://github.com/relativitydev/relativity.testing.framework/discussions).
- For feature enhancements or bug reports, please create an [Issue](https://github.com/relativitydev/relativity.testing.framework/issues) using the respective template. For further information, see [How can I contribute](#how-can-i-contribute).

## What should I know before I get started?

### Relativity.Testing.Framework Packages

The [Relativity.Testing.Framework](https://github.com/relativitydev/relativity.testing.framework) and [Relativity.Testing.Framework.Api](https://github.com/relativitydev/relativity.testing.framework.api) are repositories that comprise Relativity.Testing.Framework.

At a high level, Relativity.Testing.Framework handles configuration management and object models, while Relativity.Testing.Framework.API handles the interactions with the Relativity APIs.

## How Can I Contribute?

### Reporting Issues

Before reporting an issue, please follow these guidelines. It helps us in understanding the request and provide a quicker response time.

- Determine if it's a bug report or a feature enhancement.
- Perform a quick search in the [issue tracker](https://github.com/relativitydev/relativity.testing.framework/issues) to see if the issue has already been reported. If it has, add a comment to the existing issue instead of opening a new one.
- If you find a **Closed** issue that seems like it is the same thing that you're experiencing, open a new issue and include a link to the original issue in the body of your new one.

### Code Contributions

Be sure to also review the CONTRIBUTING.md at the root of the repository you are working in for any information specific to that codebase.

#### Development

All development work should be done in feature branches off of the master branch.
Branch names should indicate the [issue](https://github.com/relativitydev/relativity.testing.framework/issues) that they are solving.
The code should follow the architecture described [here](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/docs/dev/architecture.md).

##### Updating the Changelog

All changes must be logged in the [CHANGELOG.md](https://github.com/relativitydev/relativity.testing.framework/blob/master/CHANGELOG.md) at the root of the repository being changed.

#### Testing

Unit and/or functional tests are expected for all changes unless otherwise indicated.
Tests should be added in the FunctionalTests project in a fixture that mirrors the structure of library.
e.g. [WorkspaceGetByNameStrategy](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api/Strategies/Workspaces/WorkspaceGetByNameStrategy.cs) should be tested in [WorkspaceGetByNameStrategyFixture](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/source/Relativity.Testing.Framework.Api.FunctionalTests/Strategies/Workspaces/WorkspaceGetByNameStrategyFixture.cs)

All testing for these repositories can be done through conventional means against a Relativity server.
In general, this process includes:

- Acquiring a server to test against
- Generating test parameters to point to that server
  - [New-TestSettings.ps1](https://github.com/relativitydev/relativity.testing.framework.api/blob/master/DevelopmentScripts/New-TestSettings.ps1) is a good way to generate test parameters.
    - Configure Visual Studio to use your runsettings file, if using that
- Running the tests with the test explorer in Visual Studio

#### Pull Requests

Opening a pull request to any of the Relativity.Testing.Framework codebases will automatically add the repository owners to it.

The following must be happen before the pull request can be merged in:

- One of the default reviewers must approve it
- All tests must be passing
- All tasks on the pull request must be completed
- If the story requires changes across multiple repositories, pull requests should be opened for all of them at the same time, and referenced together.
  - i.e. If you are [making a change to Relativity.Testing.Framework](https://github.com/relativitydev/relativity.testing.framework/pull/63) that you intend to [consume in Relativity.Testing.Framework.Api](https://github.com/relativitydev/relativity.testing.framework.api/pull/88), we need to see that the integration works before they can be approved.

While the prerequisites above must be satisfied prior to having your pull request reviewed, the reviewer(s) may ask you to complete additional design work, tests, or other changes before your pull request can be ultimately accepted.

#### Styleguides

##### Git Commit Messages

- Commit messages must describe what is changing.

e.g.

> Adding ObjectTypeGuidAttribute for use in RTF.Api ObjectManager. Adding ObjectTypeGuidResolver and tests.

#### Releasing

Feature branches will create a prerelease package and upload them as an artifact of the build.
Release branches will publish a golden package to NuGet.
