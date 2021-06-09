# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [3.1.4] - 2021-06-09

### Fixed

- Updating links in CONTRIBUTING.MD to github sources and documentation. - [RTF-1190](https://jira.kcura)

## [3.1.3] - 2021-06-08

### Fixed

- ArtifactTypeId field for ObjectType class. - [TESTENG-1106](https://jira.kcura.com/browse/TESTENG-1106)

## [3.1.2] - 2021-06-04

### Fixed

- ArtifactTypeId field for ObjectType class. - [TESTENG-1106](https://jira.kcura.com/browse/TESTENG-1106)

## [3.1.1] - 2021-06-02

### Fixed

- ArtifactTypeId field serialization for Artifact class. - [TESTENG-1106](https://jira.kcura.com/browse/TESTENG-1106)

## [3.1.0] - 2021-06-01

### Changed

- ArtifactTypeId added to base Artifact class. - [TESTENG-1106](https://jira.kcura.com/browse/TESTENG-1106)

## [3.0.0] - 2021-05-25

### Changed

- Properties in ObjectType class to reflect properties of ObjectType API DTOs. - [TESTENG-898](https://jira.kcura.com/browse/TESTENG-898) 

## [2.0.2] - 2021-05-13

### Migrating to GitHub. No Changes to package.

## [2.0.1] - 2021-05-04

### Fixed

- Generated passwords no longer use random UTF8 characters, since Relativity doesn't support them. - [RTF-1193](https://jira.kcura.com/browse/RTF-1193)

## [2.0.0] - 2021-05-03

### Added

- FileField and FileFieldDTO models. - [RTF-1129](https://jira.kcura.com/browse/RTF-1129)
- IdentityFieldId setting for Image import Job. - [TESTENG-1045](https://jira.kcura.com/browse/TESTENG-1045)
- Name property on User class. - [RTF-768](https://jira.kcura.com/browse/RTF-768)

### Removed

- DefaultPassword const on User model - [RTF-1013](https://jira.kcura.com/browse/RTF-1013)

### Changed

- The default password for users is now randomly generated. - [RTF-1013](https://jira.kcura.com/browse/RTF-1013)/[RTF-1193](https://jira.kcura.com/browse/RTF-1193)
- License is now checked into the repository instead of generated at build time. - [RTF-1012](https://jira.kcura.com/browse/RTF-1012)

### Fixed

- The link to releaseNotes in the nuspec file. - [RTF-1009](https://jira.kcura.com/browse/RTF-1009)

## [1.0.0] - 2021-04-16

### Changed

- Updated namespaces to better follow standards. [RTF-1081](https://jira.kcura.com/browse/RTF-1081)
- Allowed version of Castle.Windsor and Castle.Core to >=3.3.0 and <4.0. [RTF-1121](https://jira.kcura.com/browse/RTF-1121)
- Enums now default to "Unknown" if the enum value can not be found. - [RTF-1047](https://jira.kcura.com/browse/RTF-1047)

## [0.29.1] - 2021-04-06

### Fixed

- Made ToCategoryField public - [RTF-1142](https://jira.kcura.com/browse/RTF-1142)

## [0.29.0] - 2021-04-02

### Added

- Models for building Layouts [RTF-1098](https://jira.kcura.com/browse/RTF-1098)

### Removed

- Moved TestArrangement code and related strategies to API repository [RTF-963](https://jira.kcura.com/browse/RTF-963)
- Default Agent RunInterval value, but left the const for it so that we can look it up if not specified during Create requests - [RTF-1138](https://jira.kcura.com/browse/RTF-1138)

### Changed

- Agent RunInterval field population - [RTF-1036](https://jira.kcura.com/browse/RTF-1036)
- Changed the way how ObjectMappingService is geting Choice Name - [RTF-953](https://jira.kcura.com/browse/RTF-953)
- Internal modifier removed from property ExtractedText in Document model - [RTF-1116](https://jira.kcura.com/browse/RTF-1116)

## [0.28.0] - 2021-03-09

### Added

- Choice mapping for fields and resource servers will now default to "unknown" if it can't find any appropriate value to map to. - [RTF-1068](https://jira.kcura.com/browse/RTF-1068)

### Changed

- RelativityFacade.RelyOn will no longer throw an error if the component is already registered. - [RTF-1031](https://jira.kcura.com/browse/RTF-1031)

## [0.27.0] - 2021-02-12

### Added

- Attributes and Resolvers for ObjectTypeGuid - [RTF-919](https://jira.kcura.com/browse/RTF-919)
- Attributes and Resolvers for Field:ArtifactID and Field:Guid - [RTF-1021](https://jira.kcura.com/browse/RTF-1021)
- Contributing guide - [RTF-92](https://jira.kcura.com/browse/RTF-92)
- Models for Script actions - [RTF-969](https://jira.kcura.com/browse/RTF-969)

### Changed

- Use enum instead of string for ImportBehavior property in FixedLengthTextField class - [RTF-1000](https://jira.kcura.com/browse/RTF-1000)
- ApplicationInsightsInterceptor now only explicitly flushes when being disposed. - [RTF-992](https://jira.kcura.com/browse/RTF-992)
- ObjectFieldMapping now uses Attributes to parse ArtifactID and Guid - [RTF-1021](https://jira.kcura.com/browse/RTF-1021)

## [0.26.0] - 2021-01-30

### Removed

- Made most all strategy interfaces internal and moved most of them over to the API package. - [RTF-754](https://jira.kcura.com/browse/RTF-754)
- Migrate IAccountPoolService into RTF.API - [RTF-997](https://jira.kcura.com/browse/RTF-997)

## [0.25.0] - 2021-01-15

### Added

- OCR Profile Model. - [RTF-872](https://jira.kcura.com/browse/RTF-872)
- Expanded the use of the VersionRange Attribute to also work on fixtures. - [RTF-909](https://jira.kcura.com/browse/RTF-909)

### Changed

- Made various properties on the Agent, LibraryApplication models more public. - [RTF-889](https://jira.kcura.com/browse/RTF-889)
- ClientStatus from an Enum to a NamedArtifact, to allow arbitrary statuses that might be used. - [RTF-947](https://jira.kcura.com/browse/RTF-947)

## [0.24.0] - 2020-12-22

- No changes.

## [0.23.0] - 2020-12-07

- No changes.

## [0.22.0] - 2020-11-23

- No changes.

## [0.21.0] - 2020-11-09

### Added

- StandardAccountClient to AccountPool so that the client of the pooled users can be configured - [TESTENG-551](https://jira.kcura.com/browse/TESTENG-551)

## [0.20.0] - 2020-10-26

### Added

- ResultsLocation configuration property to specify where to save logs and screenshots to.

### Changed

- Lower Nunit version requirement from 3.12 to 3.10 - [RTF-737](https://jira.kcura.com/browse/RTF-737)
- Raised Microsoft.ApplicationInsights minimum version to 2.15

## [0.19.0] - 2020-10-12

### Added

- StandardAccountType to AccountPool so that the type of the pooled users can be configured - [TESTENG-533](https://jira.kcura.com/browse/TESTENG-533)

### Fixed

- Namespaces and xml documentation in Production models have the subnamespaces removed to match the rest of Relativity Testing Framework. - [RTF-739](https://jira.kcura.com/browse/RTF-739)

## [0.18.0] - 2020-09-28

### Changed

- UserType enum on User object to be a string - [RTF-664](https://jira.kcura.com/browse/RTF-664)
- MatterStatus enum to be a string - [RTF-656](https://jira.kcura.com/browse/RTF-656)
- WorkspaceStatus enum to be a string - [RTF-655](https://jira.kcura.com/browse/RTF-655)
- Lowered Castle.Windsor requirement to from 5.0.1 to 3.3.0 - [RTF-600](https://jira.kcura.com/browse/RTF-600)

## [0.17.0] - 2020-09-14

### Added

- "Distributed SQL" field name for SqlDistributed ResourceServer.

## [0.16.0] - 2020-08-31

- No changes.

## [0.15.0] - 2020-08-17

### Added

- Mayapple support - [RTF-576](https://jira.kcura.com/browse/RTF-576)

## [0.14.0] - 2020-08-03

- No changes.

## [0.13.0] - 2020-07-20

### Added

- Extend test arrangement functionality for workspace level objects - [RTF-522](https://jira.kcura.com/browse/RTF-522)

## [0.12.0] - 2020-07-06

### Added

- Implement RTF Logging system - [RTF-490](https://jira.kcura.com/browse/RTF-490)
  - Core functionality - [RTF-491](https://jira.kcura.com/browse/RTF-491)
  - Implement logging into NUnit source - [RTF-492](https://jira.kcura.com/browse/RTF-492)
  - Implement logging into NLog source - [RTF-493](https://jira.kcura.com/browse/RTF-493)
  - Update Atata configuration - [RTF-494](https://jira.kcura.com/browse/RTF-494)
  - Add Interceptor to forward API requests to other sources - [RTF-495](https://jira.kcura.com/browse/RTF-495)
- Add ResetFacade to enable users to change user context mid test - [RTF-511](https://jira.kcura.com/browse/RTF-511)

## [0.11.0] - 2020-06-22

### Added

- Add possibility to disable auto cleanup of created entities - [RTF-28](https://jira.kcura.com/browse/RTF-28)
- Extend test session for workspace entities - [RTF-386](https://jira.kcura.com/browse/RTF-386)

## [0.10.0] - 2020-06-08

- No changes

## [0.9.0] - 2020-05-25

### Added

- Choice Model - [RTF-417](https://jira.kcura.com/browse/RTF-417)
- Message Of The Day (MOTD) Model - [RTF-399](https://jira.kcura.com/browse/RTF-399)

#### Note - Items below this point are for Api, web, and core

## [0.8.0] - 2020-05-08

### Added

- Agent Model [RTF-374](https://jira.kcura.com/browse/RTF-374)
- Agent Type Model [RTF-375](https://jira.kcura.com/browse/RTF-375)
- Agent Server Model [RTF-376](https://jira.kcura.com/browse/RTF-376)
- Add Web project to RTF repository - [RTF-394](https://jira.kcura.com/browse/RTF-394)
- Add ability to create and dispose of driver - [RTF-395](https://jira.kcura.com/browse/RTF-395)
- Login PageObject - [RTF-398](https://jira.kcura.com/browse/RTF-398)
- Capture screenshots - [RTF-396](https://jira.kcura.com/browse/RTF-396)
- Agent Strategies
  - GetAgentType - [RTF-76](https://jira.kcura.com/browse/RTF-76)
  - GetAllAgents - [RTF-78](https://jira.kcura.com/browse/RTF-78)
  - GetAvailableAgentServers - [RTF-79](https://jira.kcura.com/browse/RTF-79)
  - Create - [RTF-77](https://jira.kcura.com/browse/RTF-77)
  - Delete - [RTF-377](https://jira.kcura.com/browse/RTF-377)
- Field Strategies
  - Get - [RTF-403](https://jira.kcura.com/browse/RTF-403)
  - Create - [RTF-402](https://jira.kcura.com/browse/RTF-402)
  - Update - [RTF-404](https://jira.kcura.com/browse/RTF-404)
  - Delete - [RTF-405](https://jira.kcura.com/browse/RTF-405)

## [0.7.0] - 2020-04-27

### Added

- Object Type Model [RTF-367](https://jira.kcura.com/browse/RTF-367)
- Object Type Strategies
  - Get - [RTF-368](https://jira.kcura.com/browse/RTF-368)
  - Create - [RTF-369](https://jira.kcura.com/browse/RTF-369)
  - Delete - [RTF-371](https://jira.kcura.com/browse/RTF-371)
  - Update - [RTF-370](https://jira.kcura.com/browse/RTF-370)
  - Require - [RTF-372](https://jira.kcura.com/browse/RTF-372)
- Field Models [RTF-366](https://jira.kcura.com/browse/RTF-366)
- TestArrangement functionality - [RTF-384](https://jira.kcura.com/browse/RTF-384)

## [0.6.0] - 2020-04-13

### Added

- Library Application Strategies
  - Install - [RTF-332](https://jira.kcura.com/browse/RTF-332)
- InstanceSettings Strategies
  - Delete - [RTF-322](https://jira.kcura.com/browse/RTF-322)
  - RequireContains - [RTF-355](https://jira.kcura.com/browse/RTF-355)
  - RequireNotContains - [RTF-356](https://jira.kcura.com/browse/RTF-356)
- Permissions Strategies
  - GetItemGroupSelector - [RTF-359](https://jira.kcura.com/browse/RTF-359)
  - ItemAddRemoveGroups - [RTF-360](https://jira.kcura.com/browse/RTF-360)
  - AddItemToGroup - [RTF-361](https://jira.kcura.com/browse/RTF-361)
  - RemoveItemFromGroup - [RTF-362](https://jira.kcura.com/browse/RTF-362)
- Keep entities in session and delete them on teardown - [RTF-336](https://jira.kcura.com/browse/RTF-336)

### Fixed

- NuGet packages now declare dependencies - [RTF-347](https://jira.kcura.com/browse/RTF-347)

## [0.5.0] - 2020-03-30

### Added

- Workspace Strategies
  - Create - [RTF-48](https://jira.kcura.com/browse/RTF-48)
  - Delete - [RTF-52](https://jira.kcura.com/browse/RTF-52)
  - GetAll - [RTF-311](https://jira.kcura.com/browse/RTF-311)
- GroupPermissions Model [RTF-312](https://jira.kcura.com/browse/RTF-312)
- Group permissions changeset functionality [RTF-313](https://jira.kcura.com/browse/RTF-313)
- Permissions Strategies
  - GetWorkspaceGroupSelector - [RTF-67](https://jira.kcura.com/browse/RTF-67)
  - AddRemoveWorkspaceGroups - [RTF-68](https://jira.kcura.com/browse/RTF-68)
  - GetWorkspaceGroupPermissions - [RTF-65](https://jira.kcura.com/browse/RTF-65)
  - SetWorkspaceGroupPermissions - [RTF-66](https://jira.kcura.com/browse/RTF-66)
- Create InsanceSettings model - [RTF-318](https://jira.kcura.com/browse/RTF-318)
- InstanceSettings Strategies
  - Create - [RTF-319](https://jira.kcura.com/browse/RTF-319)
  - Get  - [RTF-321](https://jira.kcura.com/browse/RTF-321)
  - Update - [RTF-320](https://jira.kcura.com/browse/RTF-320)

## [0.4.0] - 2020-03-16

### Added

- Workspace Model [RTF-296](https://jira.kcura.com/browse/RTF-296)
- ResourcePool Model [RTF-295](https://jira.kcura.com/browse/RTF-295)
- ResourceServer Model [RTF-294](https://jira.kcura.com/browse/RTF-294)
- User Strategies
  - AddToGroup - [RTF-266](https://jira.kcura.com/browse/RTF-266)
- Application Strategies
  - IsInstalledInWorkspace - [RTF-273](https://jira.kcura.com/browse/RTF-273)
- Workspace Strategies
  - Get - [RTF-51](https://jira.kcura.com/browse/RTF-51)
  - GetAllByClientName - [RTF-50](https://jira.kcura.com/browse/RTF-50)
- Create services for the objects we support [RTF-297](https://jira.kcura.com/browse/RTF-297)
- Inject strategies resolving into Castle Windsor container [RTF-310](https://jira.kcura.com/browse/RTF-310)

## [0.3.0] - 2020-03-02

### Added

- RelativityApplication Model [RTF-270](https://jira.kcura.com/browse/RTF-270)
- Application Strategies
  - Get - [RTF-272](https://jira.kcura.com/browse/RTF-272)
  - InstallToWorkspace - [RTF-274](https://jira.kcura.com/browse/RTF-274)
- User Strategies
  - Create - [RTF-226](https://jira.kcura.com/browse/RTF-226)
  - Get - [RTF-228](https://jira.kcura.com/browse/RTF-228)
  - Exists - [RTF-229](https://jira.kcura.com/browse/RTF-229)
  - Delete - [RTF-57](https://jira.kcura.com/browse/RTF-57)

### Changed

- Updated testing namespaces to follow Relativity C# coding standards - [RTF-276](https://jira.kcura.com/browse/RTF-276)

## [0.2.0] - 2020-02-17

### Added

- Ability to select version of method to use based on strategy [RTF-105](https://jira.kcura.com/browse/RTF-105)
- API component now gets the Relativity version that it is testing against to use with the version strategies [RTF-104](https://jira.kcura.com/browse/RTF-104)
- Client Strategies
  - Create - [RTF-205](https://jira.kcura.com/browse/RTF-205)
  - Get - [RTF-206](https://jira.kcura.com/browse/RTF-206)
  - Delete - [RTF-207](https://jira.kcura.com/browse/RTF-207)
- Matter Strategies
  - Create - [RTF-212](https://jira.kcura.com/browse/RTF-212)
  - Get - [RTF-213](https://jira.kcura.com/browse/RTF-213)
  - Delete - [RTF-214](https://jira.kcura.com/browse/RTF-214)
- Group Strategies
  - Create - [RTF-217](https://jira.kcura.com/browse/RTF-217)
  - Get - [RTF-218](https://jira.kcura.com/browse/RTF-218)
  - Delete - [RTF-219](https://jira.kcura.com/browse/RTF-219)
- Choice Strategies
  - GetAll - [RTF-227](https://jira.kcura.com/browse/RTF-227)
- Testing events are now sent to ApplicationInsights [RTF-182](https://jira.kcura.com/browse/RTF-182)
- Junpier support [RTF-268](https://jira.kcura.com/browse/RTF-268)

## [0.1.0] - 2019-12-16

### Added

- Reading in configuration values - [RTF-102](https://jira.kcura.com/browse/RTF-102)
- HTTP service - [RTF-109](https://jira.kcura.com/browse/RTF-109)
- REST service - [RTF-145](https://jira.kcura.com/browse/RTF-145)
- RSAPI service - [RTF-144](https://jira.kcura.com/browse/RTF-144)
- Handling for missing keys in ConfigurationService - [RTF-113](https://jira.kcura.com/browse/RTF-113)

### Changed

- Replaced CSharpGuidelineAnalyzers with FxCop and StyleCop - [RTF-107](https://jira.kcura.com/browse/RTF-107) [RTF-108](https://jira.kcura.com/browse/RTF-108)
- Updated documentation on RelativityInstanceConfiguration - [RTF-114](https://jira.kcura.com/browse/RTF-114)
