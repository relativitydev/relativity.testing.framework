namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the page orientation for images generated from an <see cref="ImagingProfile"/> instance.
	/// </summary>
	public enum ImagingEmailOrientation
	{
		/// <summary>
		/// Specifies a portrait orientation for imaging outputs.
		/// </summary>
		Portrait = 0,

		/// <summary>
		/// Specifies a landscape orientation for imaging outputs.
		/// </summary>
		Landscape = 1,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
