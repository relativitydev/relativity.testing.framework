namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity agent type object.
	/// </summary>
	public class AgentType : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the name of the application associated with this agent type.
		/// </summary>
		public string ApplicationName { get; set; }

		/// <summary>
		/// Gets or sets the name of the company that implemented or provided the agent.
		/// </summary>
		public string CompanyName { get; set; }

		/// <summary>
		/// Gets or sets the number of seconds that the agent manager will wait between each agent execution.
		/// </summary>
		public decimal? DefaultInterval { get; set; }

		/// <summary>
		/// Gets or sets the value indicating the message type that the system logs in the Event Viewer.
		/// </summary>
		public int? DefaultLoggingLevel { get; set; }
	}
}
