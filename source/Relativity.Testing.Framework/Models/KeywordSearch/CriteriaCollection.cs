using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the collection of criteria conditions.
	/// </summary>
	public class CriteriaCollection : BaseCriteria
	{
		/// <summary>
		/// Gets or sets collection of Criteria conditions.
		/// In project represents like <see cref="CriteriaCollection"/> or <see cref="Criteria"/>.
		/// </summary>
		public List<BaseCriteria> Conditions { get; set; }
	}
}
