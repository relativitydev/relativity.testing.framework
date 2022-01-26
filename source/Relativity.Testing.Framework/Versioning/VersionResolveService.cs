using System;
using System.Linq;
using System.Reflection;
using Castle.MicroKernel;

namespace Relativity.Testing.Framework.Versioning
{
	/// <inheritdoc/>
	public class VersionResolveService : IVersionResolveService
	{
		private readonly IKernel _kernel;
		private readonly IRelativityFacade _facade;
		private readonly IRelativityApplicationVersionResolveService _rapVersionService;

		/// <summary>
		/// Initializes a new instance of the <see cref="VersionResolveService"/> class.
		/// </summary>
		/// <param name="kernel">Castle Windsor Micro Kernel.</param>
		/// <param name="facade">The Relativity Facade so you can get the Relativity Version.</param>
		/// <param name="rapVersionService">Service for obtaining a version of a RAP.</param>
		public VersionResolveService(
			IKernel kernel,
			IRelativityFacade facade,
			IRelativityApplicationVersionResolveService rapVersionService)
		{
			_kernel = kernel;
			_facade = facade;
			_rapVersionService = rapVersionService;
		}

		/// <inheritdoc/>
		public string GetTargetVersion(Type t)
		{
			string targetVersion = GetTargetVersion(t, _facade.RelativityInstanceVersion);
			return targetVersion;
		}

		/// <inheritdoc/>
		public string GetTargetVersion(Type t, string defaultVersion)
		{
			string version = defaultVersion;

			// Interfaces are passed into this method, which do not have attributes.
			// Resolve the interface and get the attribute off the implemented types.
			Array types = _kernel.ResolveAll(t);
			Type concreteType = types.GetValue(0).GetType();

			VersionRangeAttribute versionAttribute = concreteType.GetCustomAttributes<VersionRangeAttribute>().FirstOrDefault();
			if (versionAttribute is ApplicationVersionRangeAttribute attr)
			{
				version = _rapVersionService.GetVersion(attr);
			}

			return version;
		}
	}
}
