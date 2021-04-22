using System;
using System.Collections.Generic;
using System.Linq;
using Relativity.Testing.Framework.Session;

namespace Relativity.Testing.Framework.Logging
{
	internal class LogService : ILogService
	{
		private readonly IEnumerable<LogConsumerRegistration> _logConsumers;

		public LogService(IEnumerable<LogConsumerRegistration> logConsumers)
		{
			_logConsumers = logConsumers;
		}

		public void Trace(string message)
		{
			Log(LogLevel.Trace, message);
		}

		public void Debug(string message)
		{
			Log(LogLevel.Debug, message);
		}

		public void Info(string message)
		{
			Log(LogLevel.Info, message);
		}

		public void Warn(string message)
		{
			Log(LogLevel.Warn, message);
		}

		public void Warn(Exception exception)
		{
			Log(LogLevel.Warn, null, exception);
		}

		public void Warn(string message, Exception exception)
		{
			Log(LogLevel.Warn, message, exception);
		}

		public void Error(string message)
		{
			Log(LogLevel.Error, message);
		}

		public void Error(Exception exception)
		{
			Log(LogLevel.Error, null, exception);
		}

		public void Error(string message, Exception exception)
		{
			Log(LogLevel.Error, message, exception);
		}

		public void Fatal(string message)
		{
			Log(LogLevel.Fatal, message);
		}

		public void Fatal(Exception exception)
		{
			Log(LogLevel.Fatal, null, exception);
		}

		public void Fatal(string message, Exception exception)
		{
			Log(LogLevel.Fatal, message, exception);
		}

		private void Log(LogLevel level, string message, Exception exception = null)
		{
			string testFixtureName = TestSession.TestFixtureName;
			string testName = TestSession.TestName;

			var logEvent = new LogEventInfo(testFixtureName, testName)
			{
				Level = level,
				Message = message,
				Exception = exception
			};

			Log(logEvent);
		}

		private void Log(LogEventInfo eventInfo)
		{
			var appropriateConsumers = _logConsumers.
				Where(x => eventInfo.Level >= x.MinLevel).
				Select(x => x.Consumer);

			foreach (ILogConsumer logConsumer in appropriateConsumers)
			{
				logConsumer.Log(eventInfo);
			}
		}
	}
}
