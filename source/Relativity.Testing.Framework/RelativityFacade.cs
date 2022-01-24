using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Relativity.Testing.Framework.Configuration;
using Relativity.Testing.Framework.Logging;
using Relativity.Testing.Framework.Strategies;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents the facade over Relativity.
	/// Is a root point for RTF usage.
	/// </summary>
	public class RelativityFacade : IRelativityFacade
	{
		private static readonly Lazy<RelativityFacade> _lazyInstance = new Lazy<RelativityFacade>(() => new RelativityFacade());

		private readonly ISet<IRelativityComponent> _reliantComponents = new HashSet<IRelativityComponent>();

		private readonly object _relativityInstanceVersionLock = new object();

		private Lazy<IWindsorContainer> _lazyContainer;

		private string _relativityInstanceVersion;

		private bool _disposed;

		internal RelativityFacade()
		{
			_lazyContainer = new Lazy<IWindsorContainer>(CreateWindsorContainer);

			AppDomain currentAppDomain = AppDomain.CurrentDomain;
			currentAppDomain.ProcessExit += OnDomainProcessExit;
			currentAppDomain.DomainUnload += OnDomainUnload;
		}

		/// <summary>
		/// Gets the default <see cref="RelativityFacade"/> instance.
		/// </summary>
		public static IRelativityFacade Instance => _lazyInstance.Value;

		/// <inheritdoc/>
		string IRelativityFacade.RelativityInstanceVersion => RelativityInstanceVersion;

		private string RelativityInstanceVersion => ResolveRelativityInstanceVersion();

		private IWindsorContainer WindsorContainer => _lazyContainer.Value;

		/// <inheritdoc/>
		IConfigurationService IRelativityFacade.Config =>
			IsThereCoreComponent() ? WindsorContainer.Resolve<IConfigurationService>() : null;

		/// <inheritdoc/>
		ILogService IRelativityFacade.Log =>
			IsThereCoreComponent() ? WindsorContainer.Resolve<ILogService>() : null;

		/// <summary>
		/// Resets the RelativityFacade so that it can be recreated with a new user context.
		/// </summary>
		public void ResetFacade()
		{
			Dispose();
			_disposed = false;
			_reliantComponents.Clear();
			_relativityInstanceVersion = null;
			_lazyContainer = new Lazy<IWindsorContainer>(CreateWindsorContainer);
		}

		private IWindsorContainer CreateWindsorContainer()
		{
			IWindsorContainer container = new WindsorContainer();

			container.AddFacility<TypedFactoryFacility>();

			container.Register(
				Component.For<IRelativityFacade>().
				Instance(this));

			return container;
		}

		/// <inheritdoc/>
		IRelativityFacade IRelativityFacade.RelyOn<T>()
		{
			T component = new T();
			RelyOn<T>(component);

			return this;
		}

		/// <inheritdoc/>
		IRelativityFacade IRelativityFacade.RelyOn<T>(T component)
		{
			if (component is null)
			{
				throw new ArgumentNullException(nameof(component));
			}

			RelyOn<T>(component);

			return this;
		}

		private void RelyOn<T>(T component)
			where T : class, IRelativityComponent
		{
			if (WindsorContainer.ResolveAll<T>().Any())
			{
				Instance.Log?.Info($"You try to RelyOn '{typeof(T)}' component twice.");
				return;
			}

			WindsorContainer.Register(
				Component.For<T>().
				Instance(component));

			var applicationInsightsInterceptor = WindsorContainer.ResolveAll<IApplicationInsightsInterceptor>().FirstOrDefault();
			bool shouldReenableInterceptor = false;

			if (applicationInsightsInterceptor != null && applicationInsightsInterceptor.IsEnabled)
			{
				applicationInsightsInterceptor.IsEnabled = false;
				shouldReenableInterceptor = true;
			}

			_reliantComponents.Add(component);

			try
			{
				component.Initialize(WindsorContainer);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException($"Unable to initialize {component.GetType().FullName}.", exception);
			}

			if (ShouldEnsureComponent<T>())
			{
				try
				{
					component.Ensure(WindsorContainer);
				}
				catch (Exception exception) when (!(exception is RelativityComponentEnsuringException))
				{
					throw new RelativityComponentEnsuringException($"{component.GetType().FullName} ensuring failed.", exception);
				}
			}

			if (shouldReenableInterceptor)
			{
				applicationInsightsInterceptor.IsEnabled = true;
			}
		}

		private bool ShouldEnsureComponent<T>()
		{
			if (WindsorContainer.Kernel.HasComponent(typeof(IConfigurationService)))
			{
				IConfigurationService configuirationService = WindsorContainer.Resolve<IConfigurationService>();

				string ensureKey = $"{typeof(T).Name}.Ensure";

				return configuirationService.GetValueOrDefault(ensureKey, true);
			}

			return true;
		}

		/// <inheritdoc/>
		T IRelativityFacade.GetComponent<T>()
		{
			return WindsorContainer.Resolve<T>();
		}

		/// <inheritdoc/>
		T IRelativityFacade.Resolve<T>()
		{
			Type type = typeof(T);

			return type.Name.Contains("Strategy") && type.Name != nameof(IStrategyResolveService)
				? ResolveStrategy<T>()
				: WindsorContainer.Resolve<T>();
		}

		private T ResolveStrategy<T>()
		{
			T[] strategies = WindsorContainer.ResolveAll<T>();

			if (strategies == null || !strategies.Any())
			{
				throw new ComponentNotFoundException(typeof(T));
			}

			IVersionResolveService versionResolver = WindsorContainer.Resolve<IVersionResolveService>();
			string targetVersion = versionResolver.GetTargetVersion(typeof(T));
			IStrategyResolveService strategyResolver = WindsorContainer.Resolve<IStrategyResolveService>();
			return strategyResolver.Resolve(strategies, targetVersion);
		}

		/// <inheritdoc/>
		object IRelativityFacade.Resolve(Type service)
		{
			var strategies = WindsorContainer.ResolveAll(service);

			if (strategies == null || strategies.Length == 0)
			{
				throw new ComponentNotFoundException(service);
			}

			object[] strategiesAsArray = new object[strategies.Length];

			Array.Copy(strategies, strategiesAsArray, strategies.Length);

			IVersionResolveService versionResolver = WindsorContainer.Resolve<IVersionResolveService>();
			string targetVersion = versionResolver.GetTargetVersion(service);
			IStrategyResolveService strategyResolver = WindsorContainer.Resolve<IStrategyResolveService>();
			return strategyResolver.Resolve(service, strategiesAsArray, targetVersion);
		}

		private string ResolveRelativityInstanceVersion()
		{
			var applicationInsightsInterceptor = WindsorContainer.ResolveAll<IApplicationInsightsInterceptor>().FirstOrDefault();
			bool shouldReenableInterceptor = false;

			if (applicationInsightsInterceptor != null && applicationInsightsInterceptor.IsEnabled)
			{
				applicationInsightsInterceptor.IsEnabled = false;
				shouldReenableInterceptor = true;
			}

			if (_relativityInstanceVersion == null)
			{
				lock (_relativityInstanceVersionLock)
				{
					if (_relativityInstanceVersion == null)
					{
						var versionResolveService = WindsorContainer.Resolve<IRelativityInstanceVersionResolveService>();
						_relativityInstanceVersion = versionResolveService.GetVersion();
					}
				}
			}

			if (shouldReenableInterceptor)
			{
				applicationInsightsInterceptor.IsEnabled = true;
			}

			return _relativityInstanceVersion;
		}

		/// <summary>
		/// Releases unmanaged and optionally managed resources.
		/// </summary>
		/// <param name="disposing"><see langword="true"/> to release both managed and unmanaged resources; <see langword="false"/> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					FlushApplicationInsights();

					foreach (IRelativityComponent component in _reliantComponents)
					{
						ReleaseComponent(component);
					}

					WindsorContainer.Dispose();
				}

				_disposed = true;
			}
		}

		private void ReleaseComponent(IRelativityComponent component)
		{
			WindsorContainer.Release(component);
			(component as IDisposable)?.Dispose();
		}

		private bool IsThereCoreComponent()
		{
			return _reliantComponents.OfType<CoreComponent>().Any();
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private static void OnDomainProcessExit(object sender, EventArgs e)
		{
			Instance?.Dispose();
		}

		private static void OnDomainUnload(object sender, EventArgs e)
		{
			Instance?.Dispose();
		}

		private void FlushApplicationInsights()
		{
			var applicationInsightsInterceptor = WindsorContainer.ResolveAll<IApplicationInsightsTelemetryClient>().FirstOrDefault();
			if (applicationInsightsInterceptor != null)
			{
				applicationInsightsInterceptor.Flush();
				Thread.Sleep(5000);
			}
		}
	}
}
