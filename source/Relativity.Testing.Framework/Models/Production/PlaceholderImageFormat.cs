namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines the valid values for placeholder image format.
	/// </summary>
	public enum PlaceholderImageFormat
	{
		/// <summary>
		/// Brands placeholders as Group IV TIFF files
		/// </summary>
		Tiff = 0,

		/// <summary>
		/// Brands placeholders as JPEG files
		/// </summary>
		Jpeg = 1,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
