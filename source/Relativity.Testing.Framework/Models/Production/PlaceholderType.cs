namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines valid values for placeholder types.
	/// </summary>
	public enum PlaceholderType
	{
		/// <summary>
		/// Uses custom text with rich formatting.
		/// </summary>
		Custom = 0,

		/// <summary>
		/// Uses image files. Relativity supports TIF, JPEG, PNG, BMP, and GIF files for image placeholders.
		/// </summary>
		Image = 1,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
