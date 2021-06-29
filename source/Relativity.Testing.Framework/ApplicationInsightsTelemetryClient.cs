using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace Relativity.Testing.Framework
{
	public class ApplicationInsightsTelemetryClient
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
	}
}
