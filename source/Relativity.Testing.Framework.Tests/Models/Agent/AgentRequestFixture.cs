using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Models
{
	[TestFixture]
	[TestOf(typeof(AgentRequest))]
	public class AgentRequestFixture
	{
		[Test]
		public void SetDefaultIntervalIfNotSet_SetsIntervalToTheDefaultIfNotSet()
		{
			AgentRequest agentRequest = new AgentRequest();
			agentRequest.SetIntervalIfNotSet(Agent.RunIntervalDefault);

			agentRequest.Interval.Should().Be(Agent.RunIntervalDefault);
		}

		[Test]
		public void SetDefaultIntervalIfNotSet_DoesNothingIfIntervalIsSet()
		{
			AgentRequest agentRequest = new AgentRequest
			{
				Interval = 1
			};
			agentRequest.SetIntervalIfNotSet();

			agentRequest.Interval.Should().Be(1);
		}
	}
}
