using System;
using System.Linq;
using System.Reflection;
using Castle.Windsor;

namespace Relativity.Testing.Framework.Versioning
{
	internal class VersionResolveService : IVersionResolveService
	{
		private readonly IRelativityFacade _facade;
		private readonly IRelativityApplicationVersionResolveService _rapVersionService;

		public VersionResolveService(
			IRelativityFacade facade,
			IRelativityApplicationVersionResolveService rapVersionService)
		{
			_facade = facade;
			_rapVersionService = rapVersionService;
		}

		public string GetTargetVersion(Type t)
		{
			return GetTargetVersion(t, _facade.RelativityInstanceVersion);
		}

		public string GetTargetVersion(Type t, string defaultVersion)
		{
			string version = defaultVersion;

			VersionRangeAttribute versionAttribute = ExtractVersionAttributeFromType(t);
			if (versionAttribute is ApplicationVersionRangeAttribute attr)
			{
				version = _rapVersionService.GetVersion(attr);
			}

			return version;
		}

		private static VersionRangeAttribute ExtractVersionAttributeFromType(Type type)
		{
			return ResolveNonCastleType(type).
				GetCustomAttributes<VersionRangeAttribute>().FirstOrDefault();
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
