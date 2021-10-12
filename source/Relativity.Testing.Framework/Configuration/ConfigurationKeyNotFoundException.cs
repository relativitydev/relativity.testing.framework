using System;
using System.Runtime.Serialization;

namespace Relativity.Testing.Framework.Configuration
{
	/// <summary>
	/// Represents error when configuration key is missing.
	/// </summary>
	[Serializable]
	public class ConfigurationKeyNotFoundException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationKeyNotFoundException"/> class.
		/// </summary>
		public ConfigurationKeyNotFoundException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationKeyNotFoundException"/> class.
		/// </summary>
		/// <param name="keyName">The missing key.</param>
		public ConfigurationKeyNotFoundException(string keyName)
			: base($"Configuration '{keyName}' key not found.{Environment.NewLine}See https://relativitydev.github.io/relativity.testing.framework/articles/Using-Core-Component.html for details on how to specify configuration values.")
		{
			KeyName = keyName;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationKeyNotFoundException"/> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public ConfigurationKeyNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationKeyNotFoundException"/> class.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext" /> that contains contextual information about the source or destination.</param>
		protected ConfigurationKeyNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <summary>
		/// Gets the Key name.
		/// </summary>
		public string KeyName { get; }
	}
}
