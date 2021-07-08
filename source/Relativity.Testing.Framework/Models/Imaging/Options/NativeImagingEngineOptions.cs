namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the options set on an <see cref="ImagingProfile"/> for use with native imaging jobs.
	/// </summary>
	public class NativeImagingEngineOptions
	{
		/// <summary>
		/// Gets or sets the resolution and density of an image in dots per inch (DPI).
		/// </summary>
		/// <remarks>Corresponds to the Native Image Output Quality (DPI) option under the Native Imaging Engine Options tab.</remarks>
		public int ImageOutputDpi { get; set; }

		/// <summary>
		/// Gets or sets the image format for files sent to the native imaging engine. The supported formats include JPEG or TIFF.
		/// </summary>
		/// <remarks>Corresponds to the Native Image Format Drop-down list in the Native Imaging Engine Options section.</remarks>
		public ImageFormatType NativeImageFormat { get; set; }

		/// <summary>
		/// Gets or sets a boolean value indicating whether to automatically render color pages as JPEG files. This property overrides the NativeImageFormat property if it is set to TIFF.
		/// </summary>
		/// <remarks>Corresponds to the Automatically detect and render color pages to JPEG option under Native Imaging Engine Options. This property is required if <see cref="ImageFormatType"/> is set to <see cref="ImageFormatType.Tiff"/>.</remarks>
		public bool? RenderColorPagesToJpeg { get; set; }

		/// <summary>
		/// Gets or sets the maximum number of document pages imaged per file.
		/// </summary>
		/// <remarks>Corresponds to the Maximum pages imaged per file option under the Native Imaging Engine Options tab.</remarks>
		public int? MaxPagesPerDoc { get; set; }

		/// <summary>
		/// Gets or sets the dithering algorithm used when imaging documents.
		/// </summary>
		/// <remarks>Corresponds to the Dithering Algorithm option in the Native Imaging Engine Options section. This property is required if <see cref="ImageFormatType"/> is set to <see cref="ImageFormatType.Tiff"/>.</remarks>
		public NativeImagingDitheringAlgorithm? DitheringAlgorithm { get; set; }

		/// <summary>
		/// Gets or sets the dithering threshold used to determine how color pixels are converted to black and white. This integer value can range from 0 - 255.
		/// </summary>
		/// <remarks>Corresponds to the Dithering Threshold option under the Native Imaging Engine Options tab. This property is required if <see cref="DitheringAlgorithm"/> is set to <see cref="NativeImagingDitheringAlgorithm.Threshold"/>.</remarks>
		public int? DitheringThreshold { get; set; }

		/// <summary>
		/// Gets or sets the date and time information in a document image, which is a <see cref="NamedArtifact"/> corresponding to the field on a document that stores the time zone.
		/// </summary>
		/// <remarks>Corresponds to the "Native Image Time Zone Emails only." option under Native Imaging Engine Options.</remarks>
		public NamedArtifact TimeZoneFieldOnDocument { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="NamedArtifact"/> corresponding to the field on a document that stores the last modified date.
		/// </summary>
		/// <remarks>Corresponds to the Native Image Date option under the Native Imaging Engine Options section.</remarks>
		public NamedArtifact LastModifiedDateOnDocument { get; set; }
	}
}
