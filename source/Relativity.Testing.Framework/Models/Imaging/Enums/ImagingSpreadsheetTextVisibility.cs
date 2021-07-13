﻿namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies the visibility of the text in a spreadsheet by controlling background and font color.
	/// </summary>
	public enum ImagingSpreadsheetTextVisibility
	{
		/// <summary>
		/// Removes background color and formats hidden text or rows so they appear in the spreadsheet.
		/// </summary>
		RemoveBackgroundFillColors = 0,

		/// <summary>
		/// Displays the font color as black and formats any hidden text so it appears in the spreadsheet.
		/// </summary>
		SetTextColorToBlack = 1,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
