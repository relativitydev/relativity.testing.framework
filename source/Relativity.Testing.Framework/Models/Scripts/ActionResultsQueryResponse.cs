using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the results that are returned as part of an <see cref="ActionQueryRequest"/>.
	/// </summary>
	public class ActionResultsQueryResponse
	{
		/// <summary>
		/// Gets or sets the total number of rows returned by the query.
		/// </summary>
		/// <value>The count.</value>
		public int TotalCount { get; set; }

		/// <summary>
		/// Gets or sets the list of objects in the read results from the query.
		/// </summary>
		/// <value>The rows.</value>
		public List<ActionResultRow> Rows { get; set; }

		/// <summary>
		/// Gets or sets the list of columns returned.
		/// </summary>
		/// <value>The columns.</value>
		public List<ActionColumn> Columns { get; set; }

		/// <summary>
		/// Gets or sets the starting index for a result item in a query result set.
		/// </summary>
		/// <value>The index.</value>
		public int CurrentStartIndex { get; set; }

		/// <summary>
		/// Gets or sets the number of result rows returned by the current query.
		/// </summary>
		/// <value>The count.</value>
		public int ResultCount { get; set; }
	}
}
