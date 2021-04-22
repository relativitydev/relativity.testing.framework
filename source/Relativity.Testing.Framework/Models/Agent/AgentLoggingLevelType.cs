using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the different levels of logging for Agents.
	/// </summary>
	public enum AgentLoggingLevelType
	{
		None,
		[ChoiceName("Log critical errors only")]
		Critical = 1,
		[ChoiceName("Log warnings and errors")]
		Warning = 5,
		[ChoiceName("Log all messages")]
		All = 10,
		Unknown
	}
}
