namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Represents the basic options used for imaging, such as image output quality (DPI), image size, and image format.
	/// </summary>
	public class BasicImagingEngineOptions
	{
		/// <summary>
		/// Gets or sets the image output quality (DPI).
		/// </summary>
		public int ImageOutputDpi { get; set; }

		/// <summary>
		/// Gets or sets the basic image format as a JPEG or TIFF.
		/// </summary>
		/// <remarks>This property represents the Basic Image Format drop-down list under the Basic Imaging Engine Options section.</remarks>
		public ImageFormat BasicImageFormat { get; set; }

		/// <summary>
		/// Gets or sets the basic image size, such as original setting, letter, A4, or legal.
		/// </summary>
		/// <remarks>Corresponds to the Basic Image Size option under the Basic Imaging Engine Options section.</remarks>
		public ImageSize ImageSize { get; set; }

		/// <summary>
		/// Gets or sets the maximum of height of custom images in inches for the imaging profile.
		/// </summary>
		/// <remarks>Corresponds to the Maximum Image Height (Inches) option under the Basic Imaging Engine Options section.</remarks>
		public decimal? MaximumImageHeight { get; set; }

		/// <summary>
		/// Gets or sets the maximum width of custom images in inches for the imaging profile.
		/// </summary>
		/// <remarks>Corresponds to the Maximum Image Width (Inches) option under the Basic Imaging Engine Options section.</remarks>
		public decimal? MaximumImageWidth { get; set; }
	}
}
