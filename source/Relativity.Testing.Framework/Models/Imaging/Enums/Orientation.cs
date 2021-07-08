namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Specifies the page orientation for images generated from an <see cref="ImagingProfile"/> instance.
	/// </summary>
	public enum Orientation
	{
		/// <summary>
		/// Specifies a portrait orientation for imaging outputs.
		/// </summary>
		Portrait = 0,

		/// <summary>
		/// Specifies a landscape orientation for imaging outputs.
		/// </summary>
		Landscape = 1,,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
