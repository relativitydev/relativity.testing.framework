namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the categories of file types or formats for native imaging. Used by <see cref="NativeType"/> class.
	/// </summary>
	public enum NativeCategory
	{
		/// <summary>
		/// The category for the native type isn’t specified.
		/// </summary>
		Other = 0,

		/// <summary>
		/// The native type is a spreadsheet.
		/// </summary>
		Spreadsheet = 1,

		/// <summary>
		/// The native type is an email message.
		/// </summary>
		Email = 2,

		/// <summary>
		/// The native type is a word processor document.
		/// </summary>
		WordProcessor = 3,

		/// <summary>
		///  The native type is a presentation format, such as Microsoft PowerPoint.
		/// </summary>
		Presentation = 4,

		/// <summary>
		/// The native type is an HTML document.
		/// </summary>
		Html = 5,

		/// <summary>
		/// The native type can't be mapped.
		/// </summary>
		Unknown
	}
}
