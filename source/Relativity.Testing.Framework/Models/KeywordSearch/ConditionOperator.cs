namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the types of comparison operators available against Criteria Conditions.
	/// </summary>
	public enum ConditionOperator
	{
		/// <summary>
		/// Unknown operator.
		/// </summary>
		Unknown,

		/// <summary>
		/// All of These condition
		/// </summary>
		AllOfThese,

		/// <summary>
		/// Any of These condition
		/// </summary>
		AnyOfThese,

		/// <summary>
		/// Contains condition
		/// </summary>
		Contains,

		/// <summary>
		/// Is greater than condition
		/// </summary>
		GreaterThan,

		/// <summary>
		/// Greater than or Equal to condition
		/// </summary>
		GreaterThanOrEqualTo,

		/// <summary>
		/// In condition
		/// </summary>
		In,

		/// <summary>
		/// Is condition
		/// </summary>
		Is,

		/// <summary>
		/// Is Like condition
		/// </summary>
		IsLike,

		/// <summary>
		/// Is Logged in User condition
		/// </summary>
		IsLoggedInUser,

		/// <summary>
		/// Is Set condition
		/// </summary>
		IsSet,

		/// <summary>
		/// Is less than condition
		/// </summary>
		LessThan,

		/// <summary>
		/// Less than or Equal to condition
		/// </summary>
		LessThanOrEqualTo,

		/// <summary>
		/// Lucene Search Condition
		/// </summary>
		LuceneSearch,

		/// <summary>
		/// Starts With Condition
		/// </summary>
		StartsWith,

		/// <summary>
		/// Ends With condition
		/// </summary>
		EndsWith
	}
}
