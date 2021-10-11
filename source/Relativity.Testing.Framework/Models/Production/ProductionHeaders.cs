namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the set of headers on produced page. You can add a left header, a right header, and a center header.
	/// </summary>
	public class ProductionHeaders
	{
		/// <summary>
		/// Gets or sets left header on a produced page.
		/// </summary>
		public ProductionHeaderFooter LeftHeader { get; set; }

		/// <summary>
		/// Gets or sets right header on a produced page.
		/// </summary>
		public ProductionHeaderFooter RightHeader { get; set; }

		/// <summary>
		/// Gets or sets center header on a produced page.
		/// </summary>
		public ProductionHeaderFooter CenterHeader { get; set; }
	}
}
