namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enumeration of <see cref="Client"/> statuses.
	/// </summary>
	public enum ClientStatus
	{
		/// <summary>
		/// The active status.
		/// </summary>
		Active,

		/// <summary>
		/// The inactive status.
		/// </summary>
		Inactive,

		/// <summary>
		/// Someone made a different status in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
