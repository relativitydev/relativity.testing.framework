namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a custom text on a category.
	/// </summary>
	public class CategoryCustomText : CategoryElement
	{
		/// <summary>
		/// Gets or sets the artifact id of the custom text.
		/// </summary>
		public int ArtifactID { get; set; }

		/// <summary>
		/// Gets or sets the value of the custom text.
		/// </summary>
		public string Value { get; set; }
	}
}
