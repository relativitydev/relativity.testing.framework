using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents an interface of the Relativity component.
	/// </summary>
	public interface IRelativityComponent
	{
		/// <summary>
		/// Ensures that component has a connection to Relativity and is able to normally work.
		/// </summary>
		/// <param name="container">The <see cref="IWindsorContainer"/>.</param>
		void Ensure(IWindsorContainer container);

		/// <summary>
		/// This method should invoke all the <see cref="IWindsorInstaller" />s
		/// necessary for initializing the <see cref="IRelativityComponent" />.
		/// </summary>
		/// <param name="container">The <see cref="IWindsorContainer"/> container to use for component services registration.</param>
		void Initialize(IWindsorContainer container);
	}
}
