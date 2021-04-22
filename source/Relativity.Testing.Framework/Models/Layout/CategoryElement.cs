using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents part of a category in a layout.
	/// The parent <see cref="Category"/> also contains information about the category itself.
	/// </summary>
	public class CategoryElement
	{
		/// <summary>
		/// Gets or sets the artifact id of the category.
		/// </summary>
		public int CategoryID { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the category is collapsible.
		/// </summary>
		public bool Collapsible { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the category is collapsed by default.
		/// </summary>
		public bool DefaultCollapsed { get; set; }

		/// <summary>
		/// Gets or sets the fields of the category.
		/// </summary>
		public List<Element> Elements { get; set; }

		/// <summary>
		/// Gets or sets the order of the category.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the title of the category.
		/// </summary>
		public string Title { get; set; }
	}
}
