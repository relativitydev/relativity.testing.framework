using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enumeration of <see cref="User"/> skip default preference options.
	/// </summary>
	[ChoiceType(1000004)]
	public enum UserSkipDefaultPreference
	{
		/// <summary>
		/// The normal value.
		/// </summary>
		Normal,

		/// <summary>
		/// The skip value.
		/// </summary>
		Skip,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
