namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Represents the native imaging options set on an <see cref="ImagingProfile"/> instance used when imaging email messages.
	/// </summary>
	public class EmailOptions
	{
		/// <summary>
		/// Gets or sets the option indicating whether the orientation of email messages is portrait or landscape.
		/// </summary>
		/// <remarks>Corresponds to the Orientation option under the Email Options tab.</remarks>
		public Orientation Orientation { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to modify images to fit the page size.
		/// </summary>
		/// <remarks>Corresponds to the Resize images to fit page option in the Email Options tab.</remarks>
		public bool ResizeImagesToFitPage { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to modify tables to fit the page size.
		/// </summary>
		/// <remarks>Corresponds to the Resize tables to fit page option in the Email Options tab.</remarks>
		public bool ResizeTablesToFitPage { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to determine if oversized tables should be split and re-printed.
		/// </summary>
		public bool SplitTablesToFitPageWidth { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether allow downloading images from the Internet.
		/// </summary>
		/// <remarks>Corresponds to the Download images from Internet option in the Email Options tab.</remarks>
		public bool DownloadImagesFromInternet { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to remove tabs from the display of email threads.
		/// </summary>
		/// <remarks>Corresponds to the Clear Indentations option in the Email Options tab.</remarks>
		public bool ClearIndentations { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether an email's code page should be overridden during imaging.
		/// </summary>
		/// <remarks>Corresponds to the Detect Character Encoding option in the Email Options tab.</remarks>
		public bool DetectCharacterEncoding { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to display SMTP addresses in the UI.
		/// </summary>
		/// <remarks>Corresponds the Display SMTP addresses option under the Email Options tab.</remarks>
		public bool DisplaySmtpAddresses { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to identify the image as a message, appointment, distribution list, or other entity.
		/// </summary>
		/// <remarks>Corresponds to the Show message type in header option under tab Email Options tab.</remarks>
		public bool ShowMessageTypeInHeader { get; set; }
	}
}
