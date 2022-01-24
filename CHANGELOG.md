# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [7.2.0] - 2022-01-24

### Added
- Ability to use strategy based on RAP version.

## [7.1.0] - 2021-10-08

### Added

- Folder models.
- Query, QueryResult and QuerySingleResult models.

## [7.0.0] - 2021-10-01

### Changed

- SqlFullTextLanguage property of Workspace model changed to Enum object.

## [6.4.0] - 2021-09-28

### Added

- Properties for Group: Guids, Actions, Meta, CreatedBy, CreatedOn, LastModifiedBy, LastModifiedOn.

## [6.3.0] - 2021-09-28

### Added

- A model for Production Data Source Default Field Values

## [6.2.0] - 2021-09-20

### Added

- IApplicationInsightsTelemetryClient now has a TrackEvent method that accepts a <string, double> dictionary of metrics.

## [6.1.0] - 2021-09-17

### Changed

Added a message property to the Agent model.

## [6.0.1] - 2021-09-16

### Changed

- IApplicationInsightsTelemetryClient now exposes `Track[Metric|Event|Exception]()` members instead of requiring consumers to use `TelemetryClient`.

## [6.0.0] - 2021-09-10

### Removed

- Models used for Async Relativity.Testing.Framework.Api strategies.

## [5.1.0] - 2021-09-08

### Added

- DefaultFieldValue model.

## [5.0.1] - 2021-08-18

### Fixed

- Integer value collision between TabIconIdentifier.Tab and TabIconIdentifier.Unknown enum values.
	* TabIconIdentifier.Tab stays as 1
	* TabIconIdentifier.Unknown is changed to 23

## [5.0.0] - 2021-08-10

### Changed

- ScriptAction renamed to HttpAction.

### Added

- TimeStampedNamedArtifact model added with fields: CreatedOn, CreatedBy, LastModifiedOn, LastModifiedBy.
- TimeStampedNamedArtifact fields, Actions and Meta field added to Matter.

## [4.14.0] - 2021-08-06

### Added

- ICreateStrategyWithAsync and CreateStrategyWithAsync: strategies for asynchronous creation of Artifacts.

## [4.13.0] - 2021-07-29

### Changed

- ScriptInput model updated.

### Added

- Toggle model.

## [4.12.0] - 2021-07-23

### Changed

- Layout model updated, new property Owner added to match V1 API response model.

## [4.11.0] - 2021-07-21

### Added

- IsShownInSidebar and IconIdentifier properties to the Tab Model.
- Moved FillRequiredProperties to be a method on the Tab Model.

## [4.10.0] - 2021-07-16

### Added

- Models for Imaging Job.

## [4.9.0] - 2021-07-13

### Added

- Models for Application Field Code.

## [4.8.0] - 2021-07-12

### Added

- Models for Imaging Set.

## [4.7.0] - 2021-07-12

### Added

- Models for Native Type.

## [4.6.0] - 2021-07-08

### Added

- Models for Imaging Profile.

## [4.5.0] - 2021-07-07

### Changed

- KeyboardShortcut Action changed from enum to string.

### Removed

- KeyboardShortcutAction enum.

## [4.4.0] - 2021-07-07

### Added

- Adding missing enum values for KeyboardShortcutAction.

## [4.3.0] - 2021-07-07

### Added

- Models for DocumentStatusManager.

## [4.2.0] - 2021-07-06

### Added

- Models for Keyboard Shortcuts.

## [4.1.0] - 2021-06-29

### Added

- Public interface for ApplicationInsightsTelemetryClient.

## [4.0.1] - 2021-06-28

### Changed

- Update version of ApplicationInsights dependency being used from 2.15 to 2.17. Also changing the implementation from the disposable `CreateDefault` to `Active`. [42](https://github.com/relativitydev/relativity.testing.framework/issues/42)

## [4.0.0] - 2021-06-28

### Changed

- Move classes from public to internal
	*JTokenExtensions
	*ObjectCopyExtensions
	*ChoiceNameToEnumMapper
	*FieldArtifactIdResolver
	*FieldGuidResolver
	*ObjectFieldMapping
	*ObjectTypeGuidResolver
	*ObjectTypeNameResolver

## [3.3.2] - 2021-06-25

### Changed

- Using a more environmentally appropriate newline in the exception message.

## [3.3.1] - 2021-06-23

### Changed

- Updated the ConfigurationKeyNotFoundException to link to the documentation for the CoreComponent.

## [3.3.0] - 2021-06-23

### Changed

- Updated NUnit package to 3.13.2.

## [3.2.0] - 2021-06-17

### Changed

- Made the ChoiceRequest used by the Choice APIs into a model class.

### Fixed

- Choice model now maps Parent objects correctly.

## [3.1.3] - 2021-06-08

### Fixed

- ArtifactTypeId field for ObjectType class.

## [3.1.2] - 2021-06-04

### Fixed

- ArtifactTypeId field for ObjectType class.

## [3.1.1] - 2021-06-02

### Fixed

- ArtifactTypeId field serialization for Artifact class.

## [3.1.0] - 2021-06-01

### Changed

- ArtifactTypeId added to base Artifact class.

## [3.0.0] - 2021-05-25

### Changed

- Properties in ObjectType class to reflect properties of ObjectType API DTOs.

## [2.0.2] - 2021-05-13

### Migrating to GitHub. No Changes to package.

## [2.0.1] - 2021-05-04

### Fixed

- Generated passwords no longer use random UTF8 characters, since Relativity doesn't support them.

## [2.0.0] - 2021-05-03

### Added

- FileField and FileFieldDTO models.
- IdentityFieldId setting for Image import Job.
- Name property on User class.

### Removed

- DefaultPassword const on User model.

### Changed

- The default password for users is now randomly generated.
- License is now checked into the repository instead of generated at build time.

### Fixed

- The link to releaseNotes in the nuspec file.

## [1.0.0] - 2021-04-16

### Changed

- Updated namespaces to better follow standards.
- Allowed version of Castle.Windsor and Castle.Core to >=3.3.0 and <4.0.
- Enums now default to "Unknown" if the enum value can not be found.

## [0.29.1] - 2021-04-06

### Fixed

- Made ToCategoryField public.

## [0.29.0] - 2021-04-02

### Added

- Models for building Layouts.

### Removed

- Moved TestArrangement code and related strategies to API repository.
- Default Agent RunInterval value, but left the const for it so that we can look it up if not specified during Create requests.

### Changed

- Agent RunInterval field population.
- Changed the way how ObjectMappingService is geting Choice Name.
- Internal modifier removed from property ExtractedText in Document model.

## [0.28.0] - 2021-03-09

### Added

- Choice mapping for fields and resource servers will now default to "unknown" if it can't find any appropriate value to map to.

### Changed

- RelativityFacade.RelyOn will no longer throw an error if the component is already registered.

## [0.27.0] - 2021-02-12

### Added

- Attributes and Resolvers for ObjectTypeGuid.
- Attributes and Resolvers for Field:ArtifactID and Field:Guid.
- Contributing guide.
- Models for Script actions.

### Changed

- Use enum instead of string for ImportBehavior property in FixedLengthTextField class.
- ApplicationInsightsInterceptor now only explicitly flushes when being disposed.
- ObjectFieldMapping now uses Attributes to parse ArtifactID and Guid.

## [0.26.0] - 2021-01-30

### Removed

- Made most all strategy interfaces internal and moved most of them over to the API package.
- Migrate IAccountPoolService into RTF.API.

## [0.25.0] - 2021-01-15

### Added

- OCR Profile Model.
- Expanded the use of the VersionRange Attribute to also work on fixtures.

### Changed

- Made various properties on the Agent, LibraryApplication models more public.
- ClientStatus from an Enum to a NamedArtifact, to allow arbitrary statuses that might be used.

## [0.24.0] - 2020-12-22

- No changes.

## [0.23.0] - 2020-12-07

- No changes.

## [0.22.0] - 2020-11-23

- No changes.

## [0.21.0] - 2020-11-09

### Added

- StandardAccountClient to AccountPool so that the client of the pooled users can be configured.

## [0.20.0] - 2020-10-26

### Added

- ResultsLocation configuration property to specify where to save logs and screenshots to.

### Changed

- Lower Nunit version requirement from 3.12 to 3.10.
- Raised Microsoft.ApplicationInsights minimum version to 2.15.

## [0.19.0] - 2020-10-12

### Added

- StandardAccountType to AccountPool so that the type of the pooled users can be configured.

### Fixed

- Namespaces and xml documentation in Production models have the subnamespaces removed to match the rest of Relativity Testing Framework.

## [0.18.0] - 2020-09-28

### Changed

- UserType enum on User object to be a string
- MatterStatus enum to be a string
- WorkspaceStatus enum to be a string
- Lowered Castle.Windsor requirement to from 5.0.1 to 3.3.0

## [0.17.0] - 2020-09-14

### Added

- "Distributed SQL" field name for SqlDistributed ResourceServer.

## [0.16.0] - 2020-08-31

- No changes.

## [0.15.0] - 2020-08-17

### Added

- Mayapple support

## [0.14.0] - 2020-08-03

- No changes.

## [0.13.0] - 2020-07-20

### Added

- Extend test arrangement functionality for workspace level objects

## [0.12.0] - 2020-07-06

### Added

- Implement RTF Logging system
  - Core functionality
  - Implement logging into NUnit source
  - Implement logging into NLog source
  - Update Atata configuration
  - Add Interceptor to forward API requests to other sources
- Add ResetFacade to enable users to change user context mid test

## [0.11.0] - 2020-06-22

### Added

- Add possibility to disable auto cleanup of created entities
- Extend test session for workspace entities

## [0.10.0] - 2020-06-08

- No changes

## [0.9.0] - 2020-05-25

### Added

- Choice Model
- Message Of The Day (MOTD) Model

#### Note - Items below this point are for Api, web, and core

## [0.8.0] - 2020-05-08

### Added

- Agent Model
- Agent Type Model
- Agent Server Model
- Add Web project to RTF repository
- Add ability to create and dispose of driver
- Login PageObject
- Capture screenshots
- Agent Strategies
  - GetAgentType
  - GetAllAgents
  - GetAvailableAgentServers
  - Create
  - Delete
- Field Strategies
  - Get
  - Create
  - Update
  - Delete

## [0.7.0] - 2020-04-27

### Added

- Object Type Model
- Object Type Strategies
  - Get
  - Create
  - Delete
  - Update
  - Require
- Field Models
- TestArrangement functionality

## [0.6.0] - 2020-04-13

### Added

- Library Application Strategies
  - Install
- InstanceSettings Strategies
  - Delete
  - RequireContains
  - RequireNotContains
- Permissions Strategies
  - GetItemGroupSelector
  - ItemAddRemoveGroups
  - AddItemToGroup
  - RemoveItemFromGroup
- Keep entities in session and delete them on teardown

### Fixed

- NuGet packages now declare dependencies

## [0.5.0] - 2020-03-30

### Added

- Workspace Strategies
  - Create
  - Delete
  - GetAll
- GroupPermissions Model
- Group permissions changeset functionality
- Permissions Strategies
  - GetWorkspaceGroupSelector
  - AddRemoveWorkspaceGroups
  - GetWorkspaceGroupPermissions
  - SetWorkspaceGroupPermissions
- Create InsanceSettings model
- InstanceSettings Strategies
  - Create
  - Get 
  - Update

## [0.4.0] - 2020-03-16

### Added

- Workspace Model
- ResourcePool Model
- ResourceServer Model
- User Strategies
  - AddToGroup
- Application Strategies
  - IsInstalledInWorkspace
- Workspace Strategies
  - Get
  - GetAllByClientName
- Create services for the objects we support
- Inject strategies resolving into Castle Windsor container

## [0.3.0] - 2020-03-02

### Added

- RelativityApplication Model
- Application Strategies
  - Get
  - InstallToWorkspace
- User Strategies
  - Create
  - Get
  - Exists
  - Delete

### Changed

- Updated testing namespaces to follow Relativity C# coding standards

## [0.2.0] - 2020-02-17

### Added

- Ability to select version of method to use based on strategy
- API component now gets the Relativity version that it is testing against to use with the version strategies
- Client Strategies
  - Create
  - Get
  - Delete
- Matter Strategies
  - Create
  - Get
  - Delete
- Group Strategies
  - Create
  - Get
  - Delete
- Choice Strategies
  - GetAll
- Testing events are now sent to ApplicationInsights
- Junpier support

## [0.1.0] - 2019-12-16

### Added

- Reading in configuration values
- HTTP service
- REST service
- RSAPI service
- Handling for missing keys in ConfigurationService

### Changed

- Replaced CSharpGuidelineAnalyzers with FxCop and StyleCop
- Updated documentation on RelativityInstanceConfiguration
