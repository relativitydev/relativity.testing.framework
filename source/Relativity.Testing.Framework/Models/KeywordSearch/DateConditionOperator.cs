namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the types of comparison operators available against Criteria Date Conditions.
	/// </summary>
	public enum DateConditionOperator
	{
		/// <summary>
		/// Unknown operator.
		/// </summary>
		Unknown,

		/// <summary>
		/// Between condition
		/// </summary>
		Between,

		/// <summary>
		/// In condition
		/// </summary>
		In,

		/// <summary>
		/// Is condition
		/// </summary>
		Is,

		/// <summary>
		/// Is After condition
		/// </summary>
		IsAfter,

		/// <summary>
		/// Is After Or On condition
		/// </summary>
		IsAfterOrOn,

		/// <summary>
		/// Is Before condition
		/// </summary>
		IsBefore,

		/// <summary>
		/// Is Before Or On condition
		/// </summary>
		IsBeforeOrOn,

		/// <summary>
		/// Is Set condition
		/// </summary>
		IsSet,
	}
}
