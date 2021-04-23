namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents class for Criteria Condition.
	/// </summary>
	public class CriteriaCondition : Condition
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaCondition" /> class.
		/// </summary>
		public CriteriaCondition()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaCondition" /> class.
		/// </summary>
		/// <param name="fieldIdentifier">The field identifier.</param>
		/// <param name="op">The comparison operator.</param>
		/// <param name="value">The value.</param>
		public CriteriaCondition(NamedArtifact fieldIdentifier, ConditionOperator op, object value)
		{
			FieldIdentifier = fieldIdentifier;
			Value = value;
			Operator = op;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaCondition" /> class.
		/// </summary>
		/// <param name="fieldIdentifier">The field identifier.</param>
		/// <param name="op">The comparison operator.</param>
		public CriteriaCondition(NamedArtifact fieldIdentifier, ConditionOperator op)
		{
			FieldIdentifier = fieldIdentifier;
			Operator = op;
		}

		/// <summary>
		/// Gets or sets the comparison operator.
		/// </summary>
		/// <value>The operator.</value>
		public ConditionOperator Operator { get; set; }

		public override string ConditionType { get; set; } = "Criteria";
	}
}
