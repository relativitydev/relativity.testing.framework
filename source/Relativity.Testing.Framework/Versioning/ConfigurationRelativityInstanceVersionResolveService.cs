using Relativity.Testing.Framework.Configuration;

namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Represents the service that resolves the version of Relativity instance by getting the version from the configuration.
	/// </summary>
	internal class ConfigurationRelativityInstanceVersionResolveService : IRelativityInstanceVersionResolveService
	{
		public const string VersionConfigurationKey = "RelativityInstanceVersion";

		private readonly IConfigurationService _configurationService;

		public ConfigurationRelativityInstanceVersionResolveService(IConfigurationService configurationService)
		{
			_configurationService = configurationService;
		}

		public string GetVersion()
		{
			return _configurationService.GetValue(VersionConfigurationKey);
		}
	}
}
