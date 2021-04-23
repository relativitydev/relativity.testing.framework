namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity agent update request.
	/// </summary>
	internal class AgentUpdateRequest
	{
		/// <summary>
		/// Gets or sets the <see cref="AgentRequest"/> that represents a request for creating or updating an agent.
		/// </summary>
		public AgentRequest AgentRequest { get; set; }
	}
}
