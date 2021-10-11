namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents class for date condition.
	/// </summary>
	public class CriteriaDateCondition : Condition
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaDateCondition"/> class.
		/// </summary>
		public CriteriaDateCondition()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaDateCondition" /> class.
		/// </summary>
		/// <param name="fieldIdentifier">The field identifier.</param>
		/// <param name="op">The comparison operator.</param>
		/// <param name="value">The value.</param>
		public CriteriaDateCondition(NamedArtifact fieldIdentifier, DateConditionOperator op, object value)
		{
			FieldIdentifier = fieldIdentifier;
			Value = value;
			Operator = op;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaDateCondition" /> class.
		/// </summary>
		/// <param name="fieldIdentifier">The field identifier.</param>
		/// <param name="op">The comparison operator.</param>
		/// <param name="dateTimeRange">A value from the DateTimeRange enumeration.</param>
		/// <param name="month">Optionally used to set the month when the DateTimeRange is set to MonthOf.</param>
		public CriteriaDateCondition(NamedArtifact fieldIdentifier, DateConditionOperator op, DateTimeRange dateTimeRange, Month month = Month.NotSet)
		{
			FieldIdentifier = fieldIdentifier;
			Operator = op;
			Value = dateTimeRange;
			Month = month;
		}

		/// <summary>
		/// Gets or sets the comparison operator.
		/// </summary>
		/// <value>The operator.</value>
		public DateConditionOperator Operator { get; set; }

		/// <summary>
		/// Gets or sets the DateTimeRange for a Saved Search DateTimeCondtion.
		/// </summary>
		/// <value>The value.</value>
		public Month Month { get; set; }

		/// <inheritdoc/>
		public override string ConditionType { get; set; } = "CriteriaDate";
	}
}
