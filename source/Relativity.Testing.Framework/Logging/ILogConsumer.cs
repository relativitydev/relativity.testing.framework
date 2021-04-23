namespace Relativity.Testing.Framework.Logging
{
	/// <summary>
	/// Defines a method to log the event information.
	/// </summary>
	public interface ILogConsumer
	{
		/// <summary>
		/// Initializes the log consumer.
		/// </summary>
		/// <param name="logPath"> The path to log results to.</param>
		void Initialize(string logPath);

		/// <summary>
		/// Logs the specified event information.
		/// </summary>
		/// <param name="eventInfo">The event information.</param>
		void Log(LogEventInfo eventInfo);
	}
}
