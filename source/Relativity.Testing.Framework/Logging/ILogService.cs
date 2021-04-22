using System;

namespace Relativity.Testing.Framework.Logging
{
	/// <summary>
	/// Represents the logging service.
	/// </summary>
	public interface ILogService
	{
		/// <summary>
		/// Writes trace log message.
		/// </summary>
		/// <param name="message">The message.</param>
		void Trace(string message);

		/// <summary>
		/// Writes debug log message.
		/// </summary>
		/// <param name="message">The message.</param>
		void Debug(string message);

		/// <summary>
		/// Writes informational log message.
		/// </summary>
		/// <param name="message">The message.</param>
		void Info(string message);

		/// <summary>
		/// Writes warning log message.
		/// </summary>
		/// <param name="message">The message.</param>
		void Warn(string message);

		/// <summary>
		/// Writes warning log message.
		/// </summary>
		/// <param name="exception">The exception.</param>
		void Warn(Exception exception);

		/// <summary>
		/// Writes warning log message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="exception">The exception.</param>
		void Warn(string message, Exception exception);

		/// <summary>
		/// Writes error log message.
		/// </summary>
		/// <param name="message">The message.</param>
		void Error(string message);

		/// <summary>
		/// Writes error log message.
		/// </summary>
		/// <param name="exception">The exception.</param>
		void Error(Exception exception);

		/// <summary>
		/// Writes error log message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="exception">The exception.</param>
		void Error(string message, Exception exception);

		/// <summary>
		/// Writes fatal log message.
		/// </summary>
		/// <param name="message">The message.</param>
		void Fatal(string message);

		/// <summary>
		/// Writes fatal log message.
		/// </summary>
		/// <param name="exception">The exception.</param>
		void Fatal(Exception exception);

		/// <summary>
		/// Writes fatal log message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="exception">The exception.</param>
		void Fatal(string message, Exception exception);
	}
}
