namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents request for ImaginingSet create and update operations.
	/// </summary>
	public class ImagingSetRequest
	{
		/// <summary>
		/// Gets or sets the Artifact ID of the saved search containing the documents for imaging.
		/// </summary>
		public int DataSourceID { get; set; }

		/// <summary>
		/// Gets or sets the Artifact ID of the imaging profile associated with the imaging set.
		/// </summary>
		public int ImagingProfileID { get; set; }

		/// <summary>
		///  Gets or sets the user-friendly name of the imaging set.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a list of email addresses for users
		/// who are notified after the associated imaging job completes.
		/// </summary>
		public string EmailNotificationRecipients { get; set; } = string.Empty;
	}
}
