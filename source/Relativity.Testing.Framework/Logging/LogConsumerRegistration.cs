using System;

namespace Relativity.Testing.Framework.Logging
{
	/// <summary>
	/// Represents the registration item of <see cref="ILogConsumer"/>.
	/// </summary>
	public class LogConsumerRegistration
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LogConsumerRegistration"/> class.
		/// </summary>
		/// <param name="consumer">The log consumer.</param>
		/// <param name="minLevel">The minimum log level.</param>
		public LogConsumerRegistration(ILogConsumer consumer, LogLevel minLevel = LogLevel.Trace)
		{
			Consumer = consumer ?? throw new ArgumentNullException(nameof(consumer));
			MinLevel = minLevel;
		}

		/// <summary>
		/// Gets the consumer.
		/// </summary>
		public ILogConsumer Consumer { get; }

		/// <summary>
		/// Gets or sets the minimum log level.
		/// </summary>
		public LogLevel MinLevel { get; set; }
	}
}
