# Contributing to Relativity.Testing.Framework

:+1::tada: Thanks for taking the time to contribute! :tada::+1:

## Table Of Contents

- [Contributing to Relativity.Testing.Framework](#contributing-to-relativitytestingframework)
  - [Code of Conduct](#code-of-conduct)
  - [How Can I Contribute?](#how-can-i-contribute)
    - [Code Contributions](#code-contributions)
      - [Development](#development)
        - [Updating the Changelog](#updating-the-changelog)
      - [Testing](#testing)
      - [Pull Requests](#pull-requests)
      - [Styleguides](#styleguides)
        - [Coding Standards](#coding-standards)
        - [Git Commit Messages](#git-commit-messages)
      - [Releasing](#releasing)

## Code of Conduct

Before contributing, please review [CODE_OF_CONDUCT.md](https://github.com/relativitydev/relativity.testing.framework/blob/master/CODE_OF_CONDUCT.md).

## How Can I Contribute?

### Code Contributions

Be sure to also review the CONTRIBUTING.md at the root of the repository you are working in for any information specific to that codebase.

#### Development

When forking the repository, please make sure you are working of the latest code in the master branch.
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

##### Coding Standards

We have automated as many of our coding standards as possible using StyleCop, but we might identify missing rules, and ask you to fix them in the meantime until we can update StyleCop.

##### Git Commit Messages

- Commit messages must describe what is changing.

e.g.

> Adding ObjectTypeGuidAttribute for use in RTF.Api ObjectManager. Adding ObjectTypeGuidResolver and tests.

#### Releasing

Feature branches will create a prerelease package and upload them as an artifact of the build.
Release branches will publish a golden package to NuGet.
