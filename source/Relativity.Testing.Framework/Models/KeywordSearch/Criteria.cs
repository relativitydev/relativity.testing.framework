namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Singular Criteria class.
	/// </summary>
	public class Criteria : BaseCriteria
	{
		/// <summary>
		/// Gets or sets criteria Condition.
		/// In project represents like <see cref="CriteriaCondition"/> or <see cref="CriteriaDateCondition"/>.
		/// </summary>
		public Condition Condition { get; set; }

		/// <summary>
		/// Gets or sets indicates if current user has permission to view criteria.
		/// </summary>
		public bool? HasPermission { get; set; }
	}
}
