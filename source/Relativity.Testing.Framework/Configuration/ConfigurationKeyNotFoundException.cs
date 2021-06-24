using System;
using System.Runtime.Serialization;

namespace Relativity.Testing.Framework.Configuration
{
	[Serializable]
	public class ConfigurationKeyNotFoundException : Exception
	{
		public ConfigurationKeyNotFoundException()
		{
		}

		public ConfigurationKeyNotFoundException(string keyName)
			: base($"Configuration '{keyName}' key not found.{Environment.NewLine}See https://probable-happiness-2926a3e8.pages.github.io/articles/Using-Core-Component.html for details on how to specify configuration values.")
		{
			KeyName = keyName;
		}

		public ConfigurationKeyNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected ConfigurationKeyNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public string KeyName { get; }
	}
}
