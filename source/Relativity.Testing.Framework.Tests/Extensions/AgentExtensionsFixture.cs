using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Extensions;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Extensions
{
	[TestFixture]
	[TestOf(typeof(AgentExtensions))]
	public class AgentExtensionsFixture
	{
		[Test]
		public void ToAgentRequest_CopiesPropertiesFromAgent()
		{
			Agent agent = new Agent
			{
				AgentServer = new AgentServer
				{
					ArtifactID = 1
				},
				AgentType = new AgentType
				{
					ArtifactID = 2
				},
				Enabled = true,
				RunInterval = 12345,
				LoggingLevel = AgentLoggingLevelType.Warning
			};

			AgentRequest agentRequest = agent.ToAgentRequest();

			agentRequest.AgentType.Secured.Should().Be(false);
			agentRequest.AgentType.Value.ArtifactID.Should().Be(agent.AgentType.ArtifactID);
			agentRequest.AgentServer.Secured.Should().Be(false);
			agentRequest.AgentServer.Value.ArtifactID.Should().Be(agent.AgentServer.ArtifactID);
			agentRequest.Enabled.Should().Be(true);
			agentRequest.Interval.Should().Be(agent.RunInterval);
			agentRequest.LoggingLevel.Should().Be(agent.LoggingLevel);
		}
	}
}
