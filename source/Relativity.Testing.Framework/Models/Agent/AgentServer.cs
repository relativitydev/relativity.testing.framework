namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity agent server object.
	/// </summary>
	public class AgentServer : ResourceServer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentServer"/> class.
		/// </summary>
		public AgentServer()
		{
			Type = ResourceServerType.Agent;
		}

		/// <summary>
		/// Gets or sets the number of cores that the server has.
		/// </summary>
		public int ProcessorCores { get; set; }

		/// <summary>
		/// Gets or sets the number of agents currently added to the server.
		/// </summary>
		public int NumberOfAgents { get; set; }
	}
}
