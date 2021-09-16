using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace Relativity.Testing.Framework
{
	internal class ApplicationInsightsTelemetryClient : IApplicationInsightsTelemetryClient
	{
		private readonly TelemetryClient _telemetryClient;

		public ApplicationInsightsTelemetryClient()
		{
			var telemetryConfiguration = TelemetryConfiguration.Active;
			telemetryConfiguration.InstrumentationKey = "8ce871da-721e-4721-b1b6-047f00b8f406";
			_telemetryClient = new TelemetryClient(telemetryConfiguration);
		}

		public TelemetryClient Instance
		{
			get { return _telemetryClient; }
			private set => value = _telemetryClient;
		}

		public void Flush()
		{
			_telemetryClient.Flush();
		}

		public void TrackEvent(string metricName, Dictionary<string, string> properties)
		{
			_telemetryClient.TrackEvent(metricName, properties);
		}

		public void TrackException(Exception ex)
		{
			_telemetryClient.TrackException(ex);
		}

		public void TrackException(Exception ex, Dictionary<string, string> properties)
		{
			_telemetryClient.TrackException(ex, properties);
		}

		public void TrackMetric(string metricName, double metricValue, Dictionary<string, string> properties)
		{
			_telemetryClient.TrackMetric(metricName, metricValue, properties);
		}
	}
}
