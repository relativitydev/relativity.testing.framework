namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the categories of file types or formats for basic imaging. Used by <see cref="NativeType"/> class.
	/// </summary>
	public enum BasicCategory
	{
		/// <summary>
		/// The category for the native type isn’t specified.
		/// </summary>
		Other = 0,

		/// <summary>
		/// The native type is a database.
		/// </summary>
		Database = 1,

		/// <summary>
		/// The native type is a graphics file.
		/// </summary>
		Graphic = 2,

		/// <summary>
		/// The native type is a multimedia file.
		/// </summary>
		Multimedia = 3,

		/// <summary>
		/// The native type is a spreadsheet.
		/// </summary>
		Spreadsheet = 4,

		/// <summary>
		/// The native type is a document.
		/// </summary>
		WordProcessor = 5,

		/// <summary>
		/// The native type can't be mapped.
		/// </summary>
		Unknown
	}
}
