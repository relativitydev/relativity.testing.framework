namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity agent object.
	/// </summary>
	internal class AgentRequest
	{
		public Securable<Artifact> AgentType { get; set; }

		public Securable<Artifact> AgentServer { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the enabled agent state.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the enabled agent state.
		/// </summary>
		public int Interval { get; set; }

		/// <summary>
		/// Gets or sets the logging level of the agent.
		/// </summary>
		public AgentLoggingLevelType LoggingLevel { get; set; }

		/// <summary>
		/// Sets the Interval to the default agent run interval if it's not already set to some value higher than 0.
		/// </summary>
		/// <param name="interval">The interval to set the valu tot if it's not already set. Defaults to <see cref="Agent.RunIntervalDefault"/>.</param>
		public void SetIntervalIfNotSet(int interval = Agent.RunIntervalDefault)
		{
			Interval = Interval > 0 ? Interval : interval;
		}
	}
}
