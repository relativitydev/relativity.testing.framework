using System;
using System.IO;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Relativity.Testing.Framework.Logging
{
	internal class NLogConsumer : ILogConsumer, IDisposable
	{
		private bool _isDisposed;

		private FileTarget _fileTarget;

		/// <inheritdoc/>
		public void Initialize(string logPath)
		{
			string filePath = Path.Combine(
				"${basedir}",
				logPath,
				"${event-properties:test-fixture-name-sanitized}",
				"${event-properties:test-name-sanitized}",
				"Trace.log");

			_fileTarget = new FileTarget("File")
			{
				FileName = filePath,
				Layout = "${shortdate} ${time} ${uppercase:${level}} ${message}${onexception:inner= }${exception:format=toString}"
			};

			var config = new LoggingConfiguration();
			config.AddRuleForAllLevels(_fileTarget);

			LogManager.Configuration = config;
		}

		/// <summary>
		/// Logs the specified event information.
		/// </summary>
		/// <param name="eventInfo">The event information.</param>
		public void Log(LogEventInfo eventInfo)
		{
			var nLogEvent = new NLog.LogEventInfo();

			nLogEvent.TimeStamp = eventInfo.Timestamp;
			nLogEvent.Level = NLog.LogLevel.FromString(eventInfo.Level.ToString());
			nLogEvent.Message = eventInfo.Message;
			nLogEvent.Exception = eventInfo.Exception;

			var properties = nLogEvent.Properties;

			properties["test-name"] = eventInfo.TestName;
			properties["test-name-sanitized"] = eventInfo.TestNameSanitized;
			properties["test-fixture-name"] = eventInfo.TestFixtureName;
			properties["test-fixture-name-sanitized"] = eventInfo.TestFixtureNameSanitized;

			Logger logger = LogManager.GetCurrentClassLogger();
			logger.Log(nLogEvent);
		}

		/// <summary>
		/// Releases unmanaged and optionally managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!_isDisposed)
			{
				if (disposing)
				{
					_fileTarget?.Dispose();
				}

				_isDisposed = true;
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
		}
	}
}
