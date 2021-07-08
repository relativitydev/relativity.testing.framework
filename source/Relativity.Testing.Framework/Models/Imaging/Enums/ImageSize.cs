namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Specifies the size of images generated from a specific <see cref="ImagingProfile"/> instance.
	/// </summary>
	/// <remarks>The ImageSize enumeration includes the same image size options available from the Basic Imaging Engine Options drop-down in the Relativity UI. </remarks>
	public enum ImageSize
	{
		/// <summary>
		/// Generates the images in the size used by the original document settings.
		/// </summary>
		OriginalSetting = 0,

		/// <summary>
		/// Generates the images in the standard letter size (8.5 in x 11 in).
		/// </summary>
		Letter = 1,

		/// <summary>
		/// Generates the images in A4 size (210 mm x 297 mm).
		/// </summary>
		A4 = 2,

		/// <summary>
		/// Generates the images in legal paper size (8.5 in x 14 in).
		/// </summary>
		Legal = 3,

		/// <summary>
		/// Generates the images in a custom size specified by the MaximumImageWidth and MaximumImageHeight properties associated with the <see cref="ImagingProfile"/> instance.
		/// </summary>
		Custom = 4,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
