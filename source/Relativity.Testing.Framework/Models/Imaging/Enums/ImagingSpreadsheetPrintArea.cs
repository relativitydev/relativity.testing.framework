namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies a print area in a spreadsheet used for an imaging job.
	/// </summary>
	public enum ImagingSpreadsheetPrintArea
	{
		/// <summary>
		/// Uses the same print area settings as the original spreadsheet.
		/// </summary>
		OriginalSetting = 0,

		/// <summary>
		/// Images the entire spreadsheet, and ignores any print area settings specified in the spreadsheet.
		/// </summary>
		IgnorePrintArea = 1,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
