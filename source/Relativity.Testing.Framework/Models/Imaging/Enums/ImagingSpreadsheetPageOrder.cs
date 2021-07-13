﻿namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the order used to render the pages in spreadsheets.
	/// </summary>
	public enum ImagingSpreadsheetPageOrder
	{
		/// <summary>
		/// Renders pages in the original order used by the spreadsheet.
		/// </summary>
		OriginalSetting = 0,

		/// <summary>
		/// Renders the pages for vertical overflow first, and then for horizontal.
		/// </summary>
		DownThenOver = 1,

		/// <summary>
		/// Renders the pages for horizontal overflow first, and then for vertical.
		/// </summary>
		OverThenDown = 2,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
