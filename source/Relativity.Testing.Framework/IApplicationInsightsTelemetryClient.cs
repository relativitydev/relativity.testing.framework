using Microsoft.ApplicationInsights;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents an interface of the Insights telemetry client component.
	/// </summary>
	public interface IApplicationInsightsTelemetryClient
	{
		/// <summary>
		/// Gets instance of <c ref="TelemetryClient">TelemetryClient</c>.
		/// </summary>
		TelemetryClient Instance { get; }

		/// <summary>
		/// Flushes <c ref="TelemetryClient">TelemetryClient</c>.
		/// </summary>
		void Flush();
	}
}
