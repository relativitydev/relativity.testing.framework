# Relativity.Testing.Framework

:+1::tada: Welcome to Relativity.Testing.Framework! :tada::+1:

The [Relativity.Testing.Framework](https://github.com/relativitydev/relativity.testing.framework) and [Relativity.Testing.Framework.Api](https://github.com/relativitydev/relativity.testing.framework.api) are repositories that comprise Relativity.Testing.Framework.

At a high level, Relativity.Testing.Framework handles configuration management and object models, while Relativity.Testing.Framework.Api handles the interactions with the Relativity APIs.

This repository contains a C#/NuGet library that abstracts out common functionality for test setup and teardown.

## Table of Contents

- [Relativity.Testing.Framework](#relativitytestingframework)
  - [Table of Contents](#table-of-contents)
  - [Supported Relativity Versions](#supported-relativity-versions)
  - [Documentation](#documentation)
  - [Where to get help](#where-to-get-help)
  - [Build Tasks](#build-tasks)
  - [Local Testing](#local-testing)
    - [Unit Testing](#unit-testing)
  - [Contributing](#contributing)
  - [Maintainers](#maintainers)
  - [Creating Support Tickets](#creating-support-tickets)
  - [Feature Enhancements](#feature-enhancements)

## Supported Relativity Versions

- Official support is only provided for the following versions.
  - RelativityOne current and preview versions
  - Relativity Server 2022 (12.1) and later

## Documentation

For more details and common usage patterns check out [our documentation](https://relativitydev.github.io/relativity.testing.framework/).

## Where to get help

- For general help and questions, please use slack [#help-relativity-testing-framework](https://kcura-pd.slack.com/archives/CMG6M7D6D).

## Build Tasks

This repository builds with the [dotnet sdk](https://dotnet.microsoft.com/download).
It supports standard tasks like `dotnet build`, `dotnet test`, and `dotnet pack`.

## Local Testing

### Unit Testing

Run through the standard compile and (unit) test tasks. These can be done without any external environment to test on.

```PowerShell
dotnet build source
dotnet test source
```

## Contributing

See [CONTRIBUTING.md](https://github.com/relativitydev/relativity.testing.framework/blob/master/CONTRIBUTING.md).

## Maintainers

The [Developer Environments](https://einstein.kcura.com/x/ehUcBg) team is the primary care-taker of this repository. Contact and support information may be found on the linked team page.

## Creating Support Tickets

For issues with relativity.testing.framework please email "help-esys@relativity.com".  Please Include "relativity.testing.framework" in the email subject with all important aspects of the issue in the email body,  ie. Errors, exceptions, failures, screenprints.  The email will generate a support ticket the Developer Environments team will look at.

## Feature Enhancements

For feature enhancements, please open a PR against the repository.  Maintainers of the repository will be notified and review the PR.