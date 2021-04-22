namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines valid values for production header and footer types.
	/// </summary>
	public enum HeaderFooterType
	{
		/// <summary>
		/// None.
		/// </summary>
		None = 0,

		/// <summary>
		/// Uses the Bates number associated with each document page. Available for page-level numbering only.
		/// </summary>
		ProductionBatesNumber = 1,

		/// <summary>
		/// Uses the value in the selected document field for branding on each image created for a document.
		/// </summary>
		Field = 2,

		/// <summary>
		/// Uses any combination of text, tokens, and carriage returns that you define. However, Relativity doesn't support multi-reflected, multi-object, relational, file, user, and system fields for branding. You can use carriage returns to position the header or the footer closer to the top and bottom margins respectively.
		/// </summary>
		FreeText = 3,

		/// <summary>
		/// Uses the original page ID assigned by Relativity.
		/// </summary>
		OriginalImageNumber = 4,

		/// <summary>
		/// Uses the document identifier with the page number appended to it. This option sets the first page number to 1 even when the document contains only a single page. The following pages are numbered incrementally. The page number is padded with up to four digits.
		/// </summary>
		DocumentIdentifierAndPageNumber = 5,

		/// <summary>
		/// Uses advanced formatting using a subset of HTML and Liquid template syntax.
		/// </summary>
		AdvancedFormatting = 6,

		/// <summary>
        /// Someone made a different choice in the environment, and we're not able to map it back to an enum.
        /// </summary>
		Unknown
	}
}
