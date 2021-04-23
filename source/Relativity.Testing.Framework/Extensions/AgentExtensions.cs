using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Extensions
{
	internal static class AgentExtensions
	{
		internal static AgentRequest ToAgentRequest(this Agent agent)
		{
			AgentRequest agentRequest = new AgentRequest
			{
				AgentType = new Securable<Artifact>
				{
					Secured = false,
					Value = new Artifact
					{
						ArtifactID = agent.AgentType.ArtifactID
					}
				},
				AgentServer = new Securable<Artifact>
				{
					Secured = false,
					Value = new Artifact
					{
						ArtifactID = agent.AgentServer.ArtifactID
					}
				},
				Enabled = agent.Enabled,
				Interval = agent.RunInterval,
				LoggingLevel = agent.LoggingLevel
			};

			return agentRequest;
		}
	}
}
