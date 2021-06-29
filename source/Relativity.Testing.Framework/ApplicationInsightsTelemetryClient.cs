using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace Relativity.Testing.Framework
{
	internal class ApplicationInsightsTelemetryClient : IApplicationInsightsTelemetryClient
	{
		private readonly TelemetryClient _telemetryClient;

		public ApplicationInsightsTelemetryClient()
		{
			using (var telemetryConfiguration = TelemetryConfiguration.CreateDefault())
			{
				telemetryConfiguration.InstrumentationKey = "8ce871da-721e-4721-b1b6-047f00b8f406";
				_telemetryClient = new TelemetryClient(telemetryConfiguration);
			}
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
