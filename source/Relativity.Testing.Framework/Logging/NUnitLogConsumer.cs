using System.Globalization;
using System.Text;
using NUnit.Framework;

namespace Relativity.Testing.Framework.Logging
{
	/// <summary>
	/// Represents the log consumer that writes logs to NUnit output.
	/// </summary>
	public class NUnitLogConsumer : ILogConsumer
	{
		/// <summary>
		/// Gets or sets the text parts separator.
		/// The default value is <c>" "</c>.
		/// </summary>
		public string Separator { get; set; } = " ";

		/// <summary>
		/// Gets or sets the timestamp format.
		/// The default value is <c>"yyyy-MM-dd HH:mm:ss.ffff"</c>.
		/// </summary>
		public string TimestampFormat { get; set; } = "yyyy-MM-dd HH:mm:ss.ffff";

		/// <inheritdoc/>
		void ILogConsumer.Initialize(string logPath)
		{
			// Nothing to initialize here.
		}

		/// <summary>
		/// Logs the specified event information.
		/// </summary>
		/// <param name="eventInfo">The event information.</param>
		public void Log(LogEventInfo eventInfo)
		{
			string completeMessage = BuildCompleteMessage(eventInfo);
			TestContext.WriteLine(completeMessage);
		}

		private string BuildCompleteMessage(LogEventInfo eventInfo)
		{
			StringBuilder builder = new StringBuilder();

			builder
				.Append(eventInfo.Timestamp.ToString(TimestampFormat, CultureInfo.InvariantCulture))
				.Append(Separator)
				.Append(eventInfo.Level.ToString().ToUpper())
				.Append(Separator)
				.Append(eventInfo.Message);

			if (eventInfo.Exception != null)
			{
				if (!string.IsNullOrWhiteSpace(eventInfo.Message))
				{
					builder.Append(Separator);
				}

				builder.Append(eventInfo.Exception.ToString());
			}

			return builder.ToString();
		}
	}
}
