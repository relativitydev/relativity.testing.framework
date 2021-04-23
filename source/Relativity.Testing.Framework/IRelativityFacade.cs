using System;
using Relativity.Testing.Framework.Configuration;
using Relativity.Testing.Framework.Logging;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents an interface of facade over Relativity.
	/// </summary>
	public interface IRelativityFacade : IDisposable
	{
		/// <summary>
		/// Gets the Relativity instance version.
		/// </summary>
		string RelativityInstanceVersion { get; }

		/// <summary>
		/// Gets the <see cref="IConfigurationService"/> that represents configuration.
		/// </summary>
		IConfigurationService Config { get; }

		/// <summary>
		/// Gets the <see cref="ILogService"/> that provides a set of methods for logging.
		/// </summary>
		ILogService Log { get; }

		/// <summary>
		/// Registers an <see cref="IRelativityComponent"/>.
		/// </summary>
		/// <typeparam name="T">Type that implements <see cref="IRelativityComponent"/>.</typeparam>
		/// <returns>The same <see cref="IRelativityFacade"/> instance.</returns>
		IRelativityFacade RelyOn<T>()
			where T : class, IRelativityComponent, new();

		/// <summary>
		/// Registers a <paramref name="component"/>.
		/// </summary>
		/// <typeparam name="T">Type that implements <see cref="IRelativityComponent" />.</typeparam>
		/// <param name="component">The component of <typeparamref name="T"/> type implementing <see cref="IRelativityComponent"/>.</param>
		/// <returns>The same <see cref="IRelativityFacade" /> instance.</returns>
		IRelativityFacade RelyOn<T>(T component)
			where T : class, IRelativityComponent;

		/// <summary>
		/// Returns the <see cref="IRelativityComponent"/> of the given type that was registered.
		/// </summary>
		/// <typeparam name="T">Type that implements <see cref="IRelativityComponent"/>.</typeparam>
		/// <returns>An instance of <see cref="IRelativityComponent"/>.</returns>
		T GetComponent<T>()
			where T : class, IRelativityComponent;

		/// <summary>
		/// Resolves and returns a service by interface.
		/// </summary>
		/// <typeparam name="T">The type of service interface.</typeparam>
		/// <returns>The <typeparamref name="T"/> service.</returns>
		T Resolve<T>();

		/// <summary>
		/// Resolves and returns a service by interface type.
		/// </summary>
		/// <param name="service">The type of service interface.</param>
		/// <returns>The service instance.</returns>
		object Resolve(Type service);

		/// <summary>
		/// Resets the RelativityFacade so that it can be recreated with a new user context.
		/// </summary>
		void ResetFacade();
	}
}
