# Relativity.Testing.Framework

This repository contains a C#/NuGet library that abstracts out common functionality for test setup and teardown.

## Build Tasks

This repository builds with the dotnet sdk.
It supports standard tasks like `dotnet build`, `dotnet test`, and `dotnet pack`.

## Local Testing

### Unit Testing

Run through the standard compile and (unit) test tasks. These can be done without any external environment to test on.

```PowerShell
dotnet build source
dotnet test source
```
