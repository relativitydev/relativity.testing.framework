namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents sorting information for query results.
	/// </summary>
	public class ActionColumnSort
	{
		/// <summary>
		/// Gets or sets the name of the column to sort.
		/// </summary>
		public string ColumnName { get; set; }

		/// <summary>
		/// Gets or sets the sort order as either ascending or descending.
		/// </summary>
		public SortDirection Direction { get; set; }
	}
}
