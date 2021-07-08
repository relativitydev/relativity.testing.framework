namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Specifies the image format for images generated from a specific <see cref="ImagingProfile"/> instance.
	/// </summary>
	public enum ImageFormat
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
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
