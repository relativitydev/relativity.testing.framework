namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines valid values for Use Image Placeholder option.
	/// </summary>
	public enum UseImagePlaceholderOption
	{
		/// <summary>
		/// Only use image placeholder when images do not exist
		/// </summary>
		WhenNoImageExists = 0,

		/// <summary>
		/// Never use image placeholder
		/// </summary>
		NeverUseImagePlaceholder = 1,

		/// <summary>
		/// Always use the image placeholder, even if image exists
		/// </summary>
		AlwaysUseImagePlaceholder = 2,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
