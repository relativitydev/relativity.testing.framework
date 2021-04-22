namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// CriteriaOperator enumeration.
	/// </summary>
	public enum BooleanOperator
	{
		/// <summary>
		/// None
		/// </summary>
		None,

		/// <summary>
		/// Logical AND
		/// </summary>
		And,

		/// <summary>
		/// Logical OR
		/// </summary>
		Or,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
