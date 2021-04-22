namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents base class for Criteria Conditions.
	/// </summary>
	public class Condition
	{
		/// <summary>
		/// Gets or sets the Field identifier to be tested by the Condition.
		/// </summary>
		/// <value>The field identifier.</value>
		public NamedArtifact FieldIdentifier { get; set; }

		/// <summary>
		/// Gets or sets the value against which the field will be compared.
		/// </summary>
		public object Value { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether set to true to negate the condition operator.
		/// </summary>
		public bool NotOperator { get; set; }

		/// <summary>
		/// Gets or sets a condition type.
		/// </summary>
		public virtual string ConditionType { get; set; }
	}
}
