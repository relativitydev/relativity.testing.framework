using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enumeration of <see cref="User"/> document skip options.
	/// </summary>
	[ChoiceType(1000003)]
	public enum UserDocumentSkip
	{
		/// <summary>
		/// The enabled value for versions lower than 11.3.
		/// </summary>
		Enabled,

		/// <summary>
		/// The disabled value for versions lower than 11.3.
		/// </summary>
		Disabled,

		/// <summary>
		/// The force enabled value for versions lower than 11.3.
		/// </summary>
		ForceEnabled,

		/// <summary>
		/// The enabled value for version 11.3.
		/// </summary>
		True,

		/// <summary>
		/// The disabled value for version 11.3.
		/// </summary>
		False,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
