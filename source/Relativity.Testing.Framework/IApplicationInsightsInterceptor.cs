namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents an interface of the Insights telemetry interceptor component.
	/// </summary>
	public interface IApplicationInsightsInterceptor
	{
		/// <summary>
		/// Gets or sets a value indicating whether the interceptor is enabled.
		/// </summary>
		bool IsEnabled { get; set; }
	}
}
