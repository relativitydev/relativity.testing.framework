using System;
using Relativity.Testing.Framework.Extensions;

namespace Relativity.Testing.Framework.Logging
{
	/// <summary>
	/// Represents the logging event information raised by Atata framework.
	/// </summary>
	public class LogEventInfo
	{
		internal LogEventInfo(string testFixtureName, string testName)
		{
			Timestamp = DateTime.Now;

			TestFixtureName = testFixtureName;
			TestFixtureNameSanitized = testFixtureName.SanitizeForPath();

			TestName = testName;
			TestNameSanitized = testName.SanitizeForPath();
		}

		/// <summary>
		/// Gets the timestamp of the logging event.
		/// </summary>
		public DateTime Timestamp { get; private set; }

		/// <summary>
		/// Gets the level of the logging event.
		/// </summary>
		public LogLevel Level { get; internal set; }

		/// <summary>
		/// Gets the log message.
		/// </summary>
		public string Message { get; internal set; }

		/// <summary>
		/// Gets the exception information.
		/// </summary>
		public Exception Exception { get; internal set; }

		/// <summary>
		/// Gets the name of the test fixture.
		/// </summary>
		public string TestFixtureName { get; private set; }

		/// <summary>
		/// Gets the name of the test fixture sanitized for file path/name.
		/// </summary>
		public string TestFixtureNameSanitized { get; private set; }

		/// <summary>
		/// Gets the name of the test.
		/// </summary>
		public string TestName { get; private set; }

		/// <summary>
		/// Gets the name of the test sanitized for file path/name.
		/// </summary>
		public string TestNameSanitized { get; private set; }
	}
}
