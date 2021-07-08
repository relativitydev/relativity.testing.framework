namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies spreadsheet formatting as a multiple choice option on the <see cref="ImagingSpreadsheetOptions"/> instance.
	/// </summary>
	public enum ImagingSpreadsheetFormatting
	{
		/// <summary>
		/// The row dimensions automatically accommodate the content size.
		/// </summary>
		AutoFitRows = 0,

		/// <summary>
		/// The column dimensions automatically accommodate the content size.
		/// </summary>
		AutoFitColumns = 1,

		/// <summary>
		/// The formatting is removed from empty rows.
		/// </summary>
		ClearFormattingInEmptyRows = 2,

		/// <summary>
		/// The formatting is removed from empty columns.
		/// </summary>
		ClearFormattingInEmptyColumns = 3,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
