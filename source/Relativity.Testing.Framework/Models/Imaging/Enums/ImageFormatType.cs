namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the image format for images generated from a specific <see cref="ImagingProfile"/> instance.
	/// </summary>
	public enum ImageFormatType
	{
		/// <summary>
		/// Specifies TIFF as the file format for image outputs.
		/// </summary>
		Tiff = 0,

		/// <summary>
		/// Specifies JPEG as the file format for image outputs.
		/// </summary>
		Jpeg = 1,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
