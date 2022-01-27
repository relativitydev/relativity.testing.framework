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

			ApplicationVersionRangeAttribute versionAttribute = null;
			foreach (object type in types)
			{
				if (versionAttribute == null)
				{
					versionAttribute = ResolveNonCastleType(type.GetType()).GetCustomAttributes<ApplicationVersionRangeAttribute>().FirstOrDefault();
				}
			}

			if (versionAttribute != null)
			{
				version = _rapVersionService.GetVersion(versionAttribute);
			}

			return version;
		}

		private static Type ResolveNonCastleType(Type type)
		{
			if (type.Namespace.StartsWith("Castle.Proxies"))
			{
				var targetField = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).
					First(x => x.Name.ToLower().Contains("target"));

				return targetField.FieldType;
			}
			else
			{
				return type;
			}
		}
	}
}
