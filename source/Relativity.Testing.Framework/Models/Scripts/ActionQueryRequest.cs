using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Describes conditions and sorts to be returned for a Script result query call.
	/// </summary>
	public class ActionQueryRequest
	{
		/// <summary>
		/// Gets or sets the search criteria. It can be a simple, single-field condition or a complex expression made by combining conditions.
		/// </summary>
		/// <value>The condition.</value>
		public string Condition { get; set; }

		/// <summary>
		/// Gets or sets the sort order for view results specified as a collection of Sort objects. See <see cref="ActionColumnSort"/>.
		/// </summary>
		/// <value>The sorts.</value>
		public List<ActionColumnSort> Sorts { get; set; } = new List<ActionColumnSort>();

		/// <summary>
		/// Gets or sets the names of the columns to include in the results.
		/// </summary>
		/// <value>The column names.</value>
		public List<string> ColumnNames { get; set; } = new List<string> { "*" };
	}
}
