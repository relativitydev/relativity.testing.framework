namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Determines the document source to be used for creating its Images.
	/// </summary>
	public enum ImagingSourceType
	{
		/// <summary>
		/// Document native is used to generate Images.
		/// </summary>
		Native = 0,

		/// <summary>
		/// Document PDF is used to generate Images.
		/// </summary>
		RenderedPdf = 1,

		/// <summary>
		/// Unknown value to which the Imaging Source Type defaults
		/// if the value does not match any defined value
		/// </summary>
		Unknown
	}
}
