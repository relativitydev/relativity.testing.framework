using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the settings used to image a group of documents.
	/// </summary>
	public class ImagingProfile : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the imaging method used for running jobs with the imaging profile. The method options are basic or native.
		/// </summary>
		public ImagingProfileType ImagingMethod { get; set; }

		/// <summary>
		/// Gets or sets the basic options used for imaging, such as image output quality (DPI), image size, and image format.
		/// </summary>
		public BasicImagingEngineOptions BasicOptions { get; set; }

		/// <summary>
		/// Gets or sets the native imaging options used by this imaging profile, such as image format, dithering algorithm, and output quality (DPI).
		/// </summary>
		public NativeImagingEngineOptions NativeOptions { get; set; }

		/// <summary>
		/// Gets or sets the spreadsheet options used for native imaging, such as page orientation, page size, and the display of row and column headings.
		/// </summary>
		/// <seealso cref="ImagingSpreadsheetOptions"/>
		public ImagingSpreadsheetOptions SpreadsheetOptions { get; set; }

		/// <summary>
		/// Gets or sets the email options used for native imaging, such as page orientation, the removal of indentations, and the display of SMTP addresses.
		/// </summary>
		public ImagingEmailOptions EmailOptions { get; set; }

		/// <summary>
		/// Gets or sets word processing options used for native imaging, such as page orientation, or displaying field codes, comments, and hidden text.
		/// </summary>
		public ImagingWordOptions WordProcessingOptions { get; set; }

		/// <summary>
		/// Gets or sets options used for native imaging documents from presentation software, such as Microsoft PowerPoint.
		/// </summary>
		public ImagingPresentationOptions PresentationOptions { get; set; }

		/// <summary>
		/// Gets or sets the HTML option used for the imaging profile. It removes non-breaking spaces codes.
		/// </summary>
		public ImagingHtmlOptions HtmlOptions { get; set; }

		/// <summary>
		/// Gets or sets the Native Types linked to this imaging profile.
		/// </summary>
		public IEnumerable<NamedArtifact> NativeTypes { get; set; }

		/// <summary>
		/// Gets or sets the collection of Application Field Codes linked to this imaging profile.
		/// </summary>
		public IEnumerable<NamedArtifact> ApplicationFieldCodes { get; set; }

		/// <summary>
		/// Gets or sets the Keywords field.
		/// </summary>
		public string Keywords { get; set; }

		/// <summary>
		/// Gets or sets Notes Keywords field.
		/// </summary>
		public string Notes { get; set; }
	}
}
