namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the message of the day (MotD) object.
	/// </summary>
	public class MessageOfTheDay
	{
		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the message of the day functionality is enabled.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the message of the day can be dismissed.
		/// </summary>
		public bool AllowDismiss { get; set; } = true;
	}
}
