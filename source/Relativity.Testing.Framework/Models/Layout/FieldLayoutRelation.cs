namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a relation between a field and layout.
	/// </summary>
	public class FieldLayoutRelation
	{
		/// <summary>
		/// Gets or sets the artifact id of the field.
		/// </summary>
		public int FieldArtifactID { get; set; }

		/// <summary>
		/// Gets or sets the artifact id of the layout.
		/// </summary>
		public int LayoutID { get; set; }
	}
}
