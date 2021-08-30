# Architecture

This document describes the components that are provided by the Relativity.Testing.Framework package.
This is a good first place to look to get an understanding of the logical groupings of this codebase.

## Table of Contents

- [Architecture](#architecture)
  - [Table of Contents](#table-of-contents)
  - [Code Map](#code-map)
    - [Inversion of Control](#inversion-of-control)
      - [RelativityFacade](#relativityfacade)
      - [IRelativityComponent](#irelativitycomponent)
      - [CoreComponent](#corecomponent)
    - [ConfigurationService](#configurationservice)
    - [LogService](#logservice)
    - [Object Models and Mapping](#object-models-and-mapping)
      - [Models](#models)
      - [Mapping](#mapping)

## Code Map

### Inversion of Control
  
Relativity.Testing.Framework uses [Inversion of Control](https://en.wikipedia.org/wiki/Inversion_of_control) to provide an extensible framework for end users while only requiring them to take on the dependencies that they are actually using.
[Castle.Windsor](http://www.castleproject.org/projects/windsor/) is used to create a container that is then used to register and retrieve components.

#### RelativityFacade

This is the entry point for all Relativity.Testing.Framework and dependent packages.

This houses the Windsor container, and it is what all components register with.

The Relativity Facade is a [singleton](https://en.wikipedia.org/wiki/Singleton_pattern), so there can not be multiple of them instantiated at one time.
This is a forceful approach to make the facade available more universially within a process

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/RelativityFacade.cs)

#### IRelativityComponent

This is the interface that all Relativity Components must implement.
There are two methods that must be implemented:
* Initialize
  * The component must Install itself into the passed in container as well as register all of the components that it provides with the same container.
* Ensure
  * The component should perform any setup here to make sure that it is in a functioning state.

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/IRelativityComponent.cs)

#### CoreComponent

The CoreComponent is the main piece of the Relativity.Testing.Framework repository, and implements the IRelativityComponent interface.
As described in [IRelativityComponent](#irelativitycomponent) CoreComponent houses the rest of the functionality described in this document, and registers them with the container.

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/CoreComponent.cs)

### ConfigurationService

The ConfigurationService is used to read in configuration values and supply them to other components.

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/Configuration)

### LogService

The LogService provides traditional logging methods that all consumers of Relativity.Testing.Framework can utilize at any point in their tests.

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/Logging)

### Object Models and Mapping

#### Models

The Models namespace contains a set of DTOs or Classes that define the structure of the objects in Relativity.
These are general purpose, and not necessarially tied to one specific interaction with Relativity.
i.e. The structure of the Requests and Responses to the Relativity APIs may differ from the base models, and may need additional transformation.

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/Models)

#### Mapping

The Mapping namespace contains methods that assist with mapping object in Relativity to the model representation of them.

[source](https://github.com/relativitydev/relativity.testing.framework/blob/master/source/Relativity.Testing.Framework/Mapping)
