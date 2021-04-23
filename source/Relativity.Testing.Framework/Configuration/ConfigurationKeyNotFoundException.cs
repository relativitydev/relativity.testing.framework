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
			: base($"Configuration '{keyName}' key not found.")
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
