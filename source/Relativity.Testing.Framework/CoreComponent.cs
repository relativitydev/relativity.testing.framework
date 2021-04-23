using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Microsoft.Extensions.Configuration;
using Relativity.Testing.Framework.Configuration;
using Relativity.Testing.Framework.Logging;
using Relativity.Testing.Framework.Mapping;
using Relativity.Testing.Framework.Strategies;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents the core component of Relativity Testing Framework that provides configuration management and other core functionality.
	/// <see cref="CoreComponent"/> should be registered in <see cref="RelativityFacade"/> thru <see cref="IRelativityFacade.RelyOn{T}()"/> method before other components.
	/// Custom configuraton providers, when needed, can be added by setting <see cref="ConfigurationRoot"/> property with the custom value.
	/// </summary>
	public class CoreComponent : IRelativityComponent, IWindsorInstaller
	{
		/// <summary>
		/// Gets or sets the configuration root used by <see cref="IConfigurationService"/>.
		/// If the value is not set, then during <see cref="IRelativityComponent.Initialize(IWindsorContainer)"/>
		/// will create default <see cref="IConfigurationRoot"/> that use enviroment variables and NUnit parameters as the configuration providers.
		/// </summary>
		public IConfigurationRoot ConfigurationRoot { get; set; }

		/// <summary>
		/// Gets the list of log consumers.
		/// <para>
		/// By default consist of:
		/// <list type="bullet">
		/// <item><see cref="NUnitLogConsumer"/></item>
		/// <item><see cref="NLogConsumer"/></item>
		/// </list>
		/// </para>
		/// </summary>
		public List<LogConsumerRegistration> LogConsumers { get; } = new List<LogConsumerRegistration>
		{
			new LogConsumerRegistration(new NUnitLogConsumer()),
			new LogConsumerRegistration(new NLogConsumer())
		};

		void IRelativityComponent.Ensure(IWindsorContainer container)
		{
			// There is nothing to ensure here.
		}

		void IRelativityComponent.Initialize(IWindsorContainer container)
		{
			container.Install(this);
		}

		void IWindsorInstaller.Install(IWindsorContainer container, IConfigurationStore store)
		{
			IConfigurationRoot configurationRoot = ConfigurationRoot
				?? CreateDefaultConfigurationRoot();

			var configurationService = new ConfigurationService(configurationRoot);

			container.Register(
				Component.For<IConfigurationService>().
				Instance(configurationService));

			string logPath = configurationService.GetValueOrDefault("ResultsLocation", "Results");

			foreach (var logConsumer in LogConsumers)
			{
				logConsumer.Consumer.Initialize(logPath);
			}

			var logService = new LogService(LogConsumers);

			container.Register(
				Component.For<ILogService>().
				Instance(logService));

			container.Register(
				Component.For<IRelativityInstanceVersionResolveService>().
				ImplementedBy<ConfigurationRelativityInstanceVersionResolveService>().
				LifestyleSingleton().
				IsFallback());

			container.Register(
				Component.For<IVersionRangeMatchService>().
				ImplementedBy<VersionRangeMatchService>().
				LifestyleSingleton());

			container.Register(
				Component.For<IStrategyResolveService>().
				ImplementedBy<StrategyResolveService>().
				LifestyleSingleton());

			container.Register(
				Component.For<IObjectMappingService>().
				ImplementedBy<ObjectMappingService>().
				LifestyleSingleton());

			container.Register(
				Component.For<IJsonObjectMappingService>().
				ImplementedBy<JsonObjectMappingService>().
				LifestyleSingleton());

			container.Register(
				Component.For<ApplicationInsightsTelemetryClient>().
				LifestyleSingleton());

			container.Register(
				Component.For<LoggingInterceptor>().
				LifestyleSingleton());

			container.Kernel.Resolver.AddSubResolver(
				new StrategyDependencyResolver(container.Kernel));
		}

		private static IConfigurationRoot CreateDefaultConfigurationRoot()
		{
			return new ConfigurationBuilder().
				AddEnvironmentVariables().
				AddNUnitParameters().
				Build();
		}
	}
}
