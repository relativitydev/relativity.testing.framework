namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the set of footers on produced page. You can add a left footer, a right footer, and a center footer.
	/// </summary>
	public class ProductionFooters
	{
		/// <summary>
		/// Gets or sets Left footer on a produced page.
		/// </summary>
		public HeaderFooter LeftFooter { get; set; }

		/// <summary>
		/// Gets or sets right footer on a produced page.
		/// </summary>
		public HeaderFooter RightFooter { get; set; }

		/// <summary>
		/// Gets or sets center footer on a produced page.
		/// </summary>
		public HeaderFooter CenterFooter { get; set; }
	}
}
