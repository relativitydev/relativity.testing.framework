namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents base criteria object.
	/// </summary>
	public class BaseCriteria
	{
		/// <summary>
		/// Gets or sets post Condition Operator.
		/// Used to join multiple Criteria.
		/// </summary>
		public BooleanOperator BooleanOperator { get; set; }
	}
}
