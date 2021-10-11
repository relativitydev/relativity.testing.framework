namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the information on the headers and footers of produced pages.
	/// </summary>
	public class ProductionHeaderFooter
	{
		/// <summary>
		/// Gets or sets the header/footer type.
		/// </summary>
		public HeaderFooterType Type { get; set; }

		/// <summary>
		/// Gets or sets a value if the the header/footer is of type field, then this property specifies the document field to be used.
		/// </summary>
		public NamedArtifact Field { get; set; }

		/// <summary>
		/// Gets or sets if the header/footer is of type free text, then this property specifies the text.
		/// </summary>
		public string FreeText { get; set; }

		/// <summary>
		/// Gets or sets if the header/footer is of type advanced formatting, then this property specifies the advanced formatting.
		/// </summary>
		public string AdvancedFormatting { get; set; }

		/// <summary>
		/// Gets or sets a value of a descriptive name of the header or footer object.
		/// </summary>
		public string FriendlyName { get; set; }
	}
}
