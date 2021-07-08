namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Specifies the dithering algorithm used for an <see cref="ImagingProfile"/> instance.
	/// </summary>
	public enum DitheringAlgorithm
	{
		/// <summary>
		/// Specifies the use of clustered 6x6 dithering for the imaging job.
		/// </summary>
		Clustered6X6 = 0,

		/// <summary>
		/// Specifies the use of clustered 8x8 dithering for the imaging job.
		/// </summary>
		Clustered8X8 = 1,

		/// <summary>
		/// Specifies the use of clustered 16x16 dithering for the imaging job.
		/// </summary>
		Clustered16X16 = 2,

		/// <summary>
		/// Specifies the use of dispersed 4x4 dithering for the imaging job.
		/// </summary>
		Dispersed4X4 = 3,

		/// <summary>
		/// Specifies the use of dispersed 8x8 dithering for the imaging job.
		/// </summary>
		Dispersed8X8 = 4,

		/// <summary>
		/// Specifies the use of dispersed 16x16 dithering for the imaging job.
		/// </summary>
		Dispersed16X16 = 5,

		/// <summary>
		/// Specifies the use of the Floyd-Steinberg dithering algorithm for the imaging job.
		/// </summary>
		FloydAndSteinberg = 6,

		/// <summary>
		/// Specifies the use of threshold dithering for the imaging job.
		/// </summary>
		Threshold = 7,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
