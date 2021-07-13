namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the basic or native imaging option defined on an <see cref="ImagingProfile"/> instance.
	/// </summary>
	public enum ImagingProfileType
	{
		/// <summary>
		/// Specifies basic imaging, which limits the availability of imaging options that can be set on the <see cref="ImagingProfile"/> instance.
		/// <remarks>The <see cref="ImagingProfileType"/> must be set to Basic if the resource pool isn't set up to perform native imaging.</remarks>
		/// </summary>
		Basic = 0,

		/// <summary>
		/// Specifies native imaging, which offers multiple imaging options that can be set on the <see cref="ImagingProfile"/> instance.
		/// </summary>
		Native = 1,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
