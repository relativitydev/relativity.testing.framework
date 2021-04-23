namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity agent create request.
	/// </summary>
	internal class AgentCreateRequest
	{
		/// <summary>
		/// Gets or sets the <see cref="AgentRequest"/> that represents a request for creating or updating an agent.
		/// </summary>
		public AgentRequest AgentRequest { get; set; }

		/// <summary>
		/// Gets or sets the number of agents to create. This field only required when you want to create more that one agent.
		/// </summary>
		public int Count { get; set; }
	}
}
