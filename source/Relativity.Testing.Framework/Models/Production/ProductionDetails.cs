using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the details of a production as captured by the Production Details section on the Relativity UI.
	/// Referenced by the ProductionDetails property of the Production class.
	/// </summary>
	public class ProductionDetails
	{
		/// <summary>
		/// Gets or sets the date on which production set has been produced.
		/// </summary>
		public DateTime? DateProduced { get; set; }

		/// <summary>
		/// Gets or sets the list of of email recipients of notifications about this production.
		/// </summary>
		public string EmailRecipients { get; set; }

		/// <summary>
		/// Gets or sets the font to be used when branding the production.
		/// </summary>
		public string BrandingFont { get; set; }

		/// <summary>
		/// Gets or sets the font size to be used when branding the production.
		/// </summary>
		public int BrandingFontSize { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to scale the branding font.
		/// </summary>
		public bool ScaleBrandingFont { get; set; }

		/// <summary>
		/// Gets or sets a value indicating the image format of branded placeholders.
		/// </summary>
		public PlaceholderImageFormat PlaceholderImageFormat { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether branding text should wrap if the content of two adjacent footers or headers are likely to overlap.
		/// </summary>
		public bool WrapBrandingText { get; set; }
	}
}
