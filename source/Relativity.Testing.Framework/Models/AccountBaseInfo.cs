namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the base information of account.
	/// </summary>
	public class AccountBaseInfo
	{
		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Gets the full name.
		/// </summary>
		public string FullName => $"{LastName}, {FirstName}";
	}
}
