namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Enum of all the possible email preferences for the user's email preference.
	/// </summary>
	public enum UserEmailPreference
	{
		/// <summary>
		/// Use default value for EmailPreference property
		/// </summary>
		Default = 0,

		/// <summary>
		/// Receive all emails
		/// </summary>
		All = 1,

		/// <summary>
		/// Receive emails on errors only
		/// </summary>
		ErrorOnly = 2,

		/// <summary>
		/// Receive no emails
		/// </summary>
		None = 3,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
