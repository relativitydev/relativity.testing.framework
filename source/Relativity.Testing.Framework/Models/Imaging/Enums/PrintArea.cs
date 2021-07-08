namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Specifies a print area in a spreadsheet used for an imaging job.
	/// </summary>
	public enum PrintArea
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
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
