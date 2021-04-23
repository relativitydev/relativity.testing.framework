namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the Range values for when the DateTimeConditionEnum is set to 'In'.
	/// </summary>
	public enum DateTimeRange
	{
		/// <summary>
		/// Not Set
		/// </summary>
		NotSet,

		/// <summary>
		/// This Week
		/// </summary>
		ThisWeek,

		/// <summary>
		/// This Month
		/// </summary>
		ThisMonth,

		/// <summary>
		/// Next Week
		/// </summary>
		NextWeek,

		/// <summary>
		/// Last Week
		/// </summary>
		LastWeek,

		/// <summary>
		/// Last 7 Days
		/// </summary>
		Last7Days,

		/// <summary>
		/// Last 30 Days,
		/// </summary>
		Last30Days,

		/// <summary>
		/// The Month of [Month]
		/// </summary>
		MonthOf,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
