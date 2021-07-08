namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the paper size and orientation used to render the pages in a spreadsheet.
	/// </summary>
	public enum ImagingSpreadsheetPaperSizeOrientation
	{
		/// <summary>
		/// Renders the spreadsheet in its original size and orientation.
		/// </summary>
		OriginalSetting = 0,

		/// <summary>
		/// Renders the spreadsheet in letter size (8.5 in x 11 in) and portrait orientation.
		/// </summary>
		Letter8Point5X11 = 1,

		/// <summary>
		/// Renders the spreadsheet in letter size (11 in x 8.5 in) and landscape orientation.
		/// </summary>
		Letter11X8Point5 = 2,

		/// <summary>
		/// Renders the spreadsheet in tabloid size (11 in x 17 in) and landscape orientation.
		/// </summary>
		Tabloid = 3,

		/// <summary>
		/// Renders the spreadsheet in ledger (17 in x 11 in) and portrait orientation.
		/// </summary>
		Ledger = 4,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
