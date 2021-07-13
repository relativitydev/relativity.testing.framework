namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies whether to render element or not.
	/// </summary>
	public enum ImagingIncludeElement
	{
		/// <summary>
		/// Render the element using the original settings.
		/// </summary>
		OriginalSetting = 0,

		/// <summary>
		/// Render the element.
		/// </summary>
		Yes = 1,

		/// <summary>
		/// Don’t render the element.
		/// </summary>
		No = 2,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
