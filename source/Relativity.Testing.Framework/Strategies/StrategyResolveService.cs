using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Strategies
{
	internal class StrategyResolveService : IStrategyResolveService
	{
		private readonly IVersionRangeMatchService _versionRangeMatchService;

		private readonly ConcurrentDictionary<Type, string> _typeVersionRangeCache = new ConcurrentDictionary<Type, string>();

		public StrategyResolveService(IVersionRangeMatchService versionRangeMatchService)
		{
			_versionRangeMatchService = versionRangeMatchService;
		}

		public T Resolve<T>(T[] strategies, string version)
		{
			return (T)Resolve(typeof(T), strategies.Cast<object>().ToArray(), version);
		}

		public object Resolve(Type strategyType, object[] strategies, string version)
		{
			if (strategies is null)
			{
				throw new ArgumentNullException(nameof(strategies));
			}

			if (version is null)
			{
				throw new ArgumentNullException(nameof(version));
			}

			object strategy = strategies.FirstOrDefault(x => MatchVersion(x, version));

			return strategy ?? throw new StrategyNotFoundException($"Failed to find an appropriate strategy for {strategyType.FullName} type for {version} version.");
		}

		private bool MatchVersion(object strategy, string version)
		{
			string range = GetVersionRange(strategy.GetType());
			return _versionRangeMatchService.IsVersionInRange(version, range);
		}

		private string GetVersionRange(Type type)
		{
			return _typeVersionRangeCache.GetOrAdd(type, ExtractVersionRangeFromType);
		}

		private static string ExtractVersionRangeFromType(Type type)
		{
			return ResolveNonCastleType(type).
				GetCustomAttributes<VersionRangeAttribute>().FirstOrDefault()?.VersionRange ?? "x";
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
