using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the different levels of logging for Agents.
	/// </summary>
	public enum AgentLoggingLevelType
	{
		/// <summary>
		/// Log nothing
		/// </summary>
		None,

		/// <summary>
		/// Log critical errors only
		/// </summary>
		[ChoiceName("Log critical errors only")]
		Critical = 1,

		/// <summary>
		/// Log warnings and errors
		/// </summary>
		[ChoiceName("Log warnings and errors")]
		Warning = 5,

		/// <summary>
		/// Log all messages
		/// </summary>
		[ChoiceName("Log all messages")]
		All = 10,

		/// <summary>
		/// Unknown
		/// </summary>
		Unknown
	}
}
