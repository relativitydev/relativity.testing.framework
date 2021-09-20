using System;
using System.Collections.Generic;
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
		/// Sends a metric value to the configured telemetry client.
		/// </summary>
		/// <param name="metricName">The name of the metric being sent.</param>
		/// <param name="metricValue">An individual metric value.</param>
		/// <param name="properties">A related dictionary of properties to associate with the metric.</param>
		void TrackMetric(string metricName, double metricValue, Dictionary<string, string> properties);

		/// <summary>
		/// Sends an arbitrary event to the configured telemetry client.
		/// </summary>
		/// <param name="metricName">The name of the event being sent.</param>
		/// <param name="properties">A related dictionary of properties to associate with the event.</param>
		void TrackEvent(string metricName, Dictionary<string, string> properties);

		/// <summary>
		/// Sends an arbitrary event with related metrics to the configured telemetry client.
		/// </summary>
		/// <param name="metricName">The name of the event being sent.</param>
		/// <param name="properties">A related dictionary of properties to associate with the event.</param>
		/// <param name="metrics">A relevant set of metrics associated with the event.</param>
		void TrackEvent(string metricName, Dictionary<string, string> properties, Dictionary<string, double> metrics);

		/// <summary>
		/// Sends an exception to the configured telemetry client.
		/// </summary>
		/// <param name="ex">The exception that occurred.</param>
		void TrackException(Exception ex);

		/// <summary>
		/// Sends an exception to the configured telemetry client with extra information.
		/// </summary>
		/// <param name="ex">The exception that occurred.</param>
		/// <param name="properties">A related dictionary of properties to associate with the exception.</param>
		void TrackException(Exception ex, Dictionary<string, string> properties);

		/// <summary>
		/// Flushes <c ref="TelemetryClient">TelemetryClient</c>.
		/// </summary>
		void Flush();
	}
}
