namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Describes how to sort Query results.
	/// </summary>
	public class Sort
	{
		/// <summary>
		/// Gets or sets the Field identifier to be tested by the Condition.
		/// </summary>
		/// <value>The field identifier.</value>
		public NamedArtifact FieldIdentifier { get; set; }

		/// <summary>
		/// Gets or sets value when more than one Sort is defined, the Order defines the precedence order of the sorts.
		/// </summary>
		/// <value>The order.</value>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets sorting direction.
		/// </summary>
		/// <value>The sorting direction.</value>
		public SortDirection Direction { get; set; }
	}
}
