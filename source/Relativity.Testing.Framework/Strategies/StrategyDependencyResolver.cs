using System.Linq;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;

namespace Relativity.Testing.Framework.Strategies
{
	internal class StrategyDependencyResolver : ISubDependencyResolver
	{
		private readonly IKernel _kernel;

		public StrategyDependencyResolver(IKernel kernel)
		{
			_kernel = kernel;
		}

		public bool CanResolve(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency)
		{
			var name = dependency.TargetType.Name;

			return name.EndsWith("Strategy") || name.EndsWith("Strategy`1");
		}

		public object Resolve(CreationContext context, ISubDependencyResolver contextHandlerResolver, ComponentModel model, DependencyModel dependency)
		{
			var strategies = _kernel.ResolveAll(dependency.TargetType);

			if (strategies == null || strategies.Length == 0)
			{
				throw new ComponentNotFoundException(dependency.TargetType);
			}

			IStrategyResolveService strategyResolver = _kernel.Resolve<IStrategyResolveService>();
			string relativityInstanceVersion = _kernel.Resolve<IRelativityFacade>().RelativityInstanceVersion;

			return strategyResolver.Resolve(
				dependency.TargetType,
				strategies.Cast<object>().ToArray(),
				relativityInstanceVersion);
		}
	}
}
