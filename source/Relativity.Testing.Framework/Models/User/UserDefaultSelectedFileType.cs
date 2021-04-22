using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enumeration of <see cref="User"/> file types for default selection.
	/// </summary>
	[ChoiceType(1)]
	public enum UserDefaultSelectedFileType
	{
		/// <summary>
		/// Use default value.
		/// </summary>
		Default,

		/// <summary>
		/// The viewer file type.
		/// </summary>
		Viewer,

		/// <summary>
		/// The image file type.
		/// </summary>
		Image,

		/// <summary>
		/// The long text file type.
		/// </summary>
		LongText,

		/// <summary>
		/// The production file type.
		/// </summary>
		Production,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
