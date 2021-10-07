using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Query.
	/// </summary>
	public class Query
	{
		/// <summary>
		/// Gets or sets condition for the query.
		/// </summary>
		public string Condition { get; set; }

		/// <summary>
		/// Gets or sets list of sorts for the query.
		/// </summary>
		public List<Sort> Sorts { get; set; }
	}
}
