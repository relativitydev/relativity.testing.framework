using System;
using Microsoft.Extensions.Configuration;

namespace Relativity.Testing.Framework.Configuration
{
	internal class ConfigurationService : IConfigurationService
	{
		public ConfigurationService(IConfigurationRoot configurationRoot)
		{
			ConfigurationRoot = configurationRoot ?? throw new ArgumentNullException(nameof(configurationRoot));
		}

		public IConfigurationRoot ConfigurationRoot { get; }

		public RelativityInstanceConfiguration RelativityInstance =>
			Get<RelativityInstanceConfiguration>() ?? new RelativityInstanceConfiguration();

		public T Get<T>()
		{
			return ConfigurationRoot.Get<T>();
		}

		public T GetValue<T>(string key)
		{
			IConfigurationSection section = ConfigurationRoot.GetSection(key);

			if (section.Exists())
			{
				return section.Get<T>();
			}
			else
			{
				throw new ConfigurationKeyNotFoundException(key);
			}
		}

		public string GetValue(string key)
		{
			return GetValue<string>(key);
		}

		public T GetValueOrDefault<T>(string key)
		{
			return GetValueOrDefault(key, default(T));
		}

		public T GetValueOrDefault<T>(string key, T defaultValue)
		{
			return ConfigurationRoot.GetValue(key, defaultValue);
		}

		public string GetValueOrDefault(string key)
		{
			return GetValueOrDefault(key, default);
		}

		public string GetValueOrDefault(string key, string defaultValue)
		{
			return GetValueOrDefault<string>(key, defaultValue);
		}
	}
}
