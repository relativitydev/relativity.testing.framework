namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Option for orientation of a given element used by <see cref="ImagingProfile"/>.
	/// </summary>
	public enum ImagingElementOrientation
	{
		/// <summary>
		/// Renders the original orientation for the elements.
		/// </summary>
		OriginalSetting = 0,

		/// <summary>
		/// Renders the elements in portrait orientation.
		/// </summary>
		Portrait = 1,

		/// <summary>
		/// Renders the elements in landscape orientation.
		/// </summary>
		Landscape = 2,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
