using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Represents the spreadsheet options set on an <see cref="ImagingProfile"/> instance.
	/// </summary>
	public class SpreadsheetOptions
	{
		/// <summary>
		/// Gets or sets the option for paper size and orientation used to render the pages in a spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the  Paper size/Orientation drop-down list under the Spreadsheet Options tab.</remarks>
		public PaperSizeOrientation PaperSizeOrientation { get; set; }

		/// <summary>
		/// Gets or sets the order used to render the pages in a spreadsheet, such as vertical or horizontal overflow.
		/// </summary>
		/// <remarks>Corresponds to the Page Order option under the Spreadsheet Options tab.</remarks>
		public PageOrder PageOrder { get; set; }

		/// <summary>
		/// Gets or sets the print area in a spreadsheet used for an imaging job.
		/// </summary>
		/// <remarks>corresponds to the Print Area option under Spreadsheet Options tab.</remarks>
		public PrintArea PrintArea { get; set; }

		/// <summary>
		/// Gets or sets the option controlling the maximum number of consecutive blank rows or columns.
		/// </summary>
		/// <remarks>Corresponds to the Hide and page break after ___ consecutive blank rows and columns option under the Spreadsheet Options tab.</remarks>
		public int HideAndPageBreakAfterConsecutiveBlankRowCol { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to display modifications made through the Track Changes option in Excel.
		/// </summary>
		/// <remarks>Corresponds to the Show track changes in spreadsheet option in Spreadsheet Options.</remarks>
		public bool ShowTrackChanges { get; set; }

		/// <summary>
		/// Gets or sets the option for rendering row headings (1, 2, 3, etc.) and column headings (A, B, C, etc.) in a spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the Include Headers and footers under the Spreadsheet Options tab.</remarks>
		public IncludeElement IncludeRowAndColumnHeadings { get; set; }

		/// <summary>
		/// Gets or sets the option for rendering headers and footers in the spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the Include headers and footers option under the Spreadsheet Options tab.</remarks>
		public IncludeElement IncludeHeadersAndFooters { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to render comments added to a spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the "Include Comments" option under the Spreadsheet Options tab.</remarks>
		public bool IncludeComments { get; set; }

		/// <summary>
		/// Gets or sets the option for rendering the gridlines between rows and columns in the spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the Include Gridlines option under the Spreadsheet Options tab.</remarks>
		public IncludeElement IncludeGridlines { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to render the borders in a spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the "Include Borders" option under Spreadsheet Options.</remarks>
		public bool IncludeBorders { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to display hidden worksheets.
		/// </summary>
		/// <remarks>Corresponds to the Unhide Hidden Worksheets option under the Spreadsheet Options tab.</remarks>
		public bool UnhideHiddenWorksheets { get; set; }

		/// <summary>
		/// Gets or sets the option that controls the number of pages to render.
		/// </summary>
		/// <remarks>corresponds to the Limit spreadsheet rendering to ____ page(s) under the Spreadsheet Options tab.</remarks>
		public int? LimitToPages { get; set; }

		/// <summary>
		/// Gets or sets the option for setting the zoom level on a spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the "Zoom Level %" option under the Spreadsheet Options tab.</remarks>
		public int? ZoomLevelPercentage { get; set; }

		/// <summary>
		/// Gets or sets the option for resetting the page width for a spreadsheet.
		/// </summary>
		/// <remarks>Corresponds to the Fit to ___ pages wide option under the Spreadsheet Options tab.</remarks>
		public int? FitToPagesWide { get; set; }

		/// <summary>
		/// Gets or sets the option for resetting the page height for a spreadsheet.
		/// </summary>
		/// <remarks>
		/// 		Corresponds to the Fit to ___ pages tall option under the Spreadsheet Options tab.
		/// </remarks>
		public int? FitToPagesTall { get; set; }

		/// <summary>
		/// Gets or sets the options for formatting a spreadsheet, such as auto-fit rows and columns, and clearing empty rows and columns.
		/// </summary>
		/// <remarks>
		/// 		Formatting options under the Spreadsheet Options tab.
		/// </remarks>
		public HashSet<Formatting> Formatting { get; set; }

		/// <summary>
		/// Gets or sets the options for text visibility by controlling background and font color.
		/// </summary>
		/// <remarks>
		/// 		Corresponds to the Text Visibility option under the Spreadsheet Options tab.
		/// </remarks>
		public HashSet<TextVisibility> TextVisibility { get; set; }
	}
}
