namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the sort direction for a Sort.
	/// </summary>
	public enum SortDirection
	{
		/// <summary>
		/// Ascending Condition
		/// </summary>
		Ascending,

		/// <summary>
		/// Descending Condition
		/// </summary>
		Descending,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
