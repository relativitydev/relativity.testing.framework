using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents part of a category in a layout.
	/// The assocaited <see cref="CategoryElement"/> also contains information about the category itself.
	/// </summary>
	public class Category
	{
		/// <summary>
		/// Gets or sets the list of CategoryElements associated with the Category.
		/// Note that CategoryElements have a list of <see cref="Element"/>s, which are the actual fields.
		/// </summary>
		public List<CategoryElement> Elements { get; set; }

		/// <summary>
		/// Gets or sets the artifactID of the category.
		/// </summary>
		public int GroupId { get; set; }

		/// <summary>
		/// Gets or sets the order of the category.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the tabbed display.
		/// </summary>
		public string TabbedDisplay { get; set; }
	}
}
