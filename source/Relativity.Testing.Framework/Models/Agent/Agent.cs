using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity agent object.
	/// </summary>
	public class Agent : Artifact
	{
		public const int RunIntervalDefault = 3600;

		/// <summary>
		/// Gets or sets the agent name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the enabled agent state.
		/// </summary>
		public bool Enabled { get; set; } = true;

		/// <summary>
		/// Gets or sets the number of seconds that the agent should wait before checking the database for available jobs.
		/// </summary>
		[FieldName("Run Interval (seconds)")]
		public int RunInterval { get; set; }

		/// <summary>
		/// Gets or sets the value indicating the message type that the system logs in the Event Viewer.
		/// </summary>
		public AgentLoggingLevelType LoggingLevel { get; set; } = AgentLoggingLevelType.Warning;

		/// <summary>
		/// Gets or sets the kind of job that the agent executes.
		/// </summary>
		public NamedArtifact AgentType { get; set; }

		/// <summary>
		/// Gets or sets the server where the agent is to be added.
		/// </summary>
		public NamedArtifact AgentServer { get; set; }

		/// <summary>
		/// Gets or sets the message for the agent.
		/// This property is only used for the response, so it will be ignored if you populate it as part of the request.
		/// </summary>
		public string Message { get; set; }
	}
}
