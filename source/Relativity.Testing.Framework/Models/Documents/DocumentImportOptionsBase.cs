using System.Text;

namespace Relativity.Testing.Framework.Models
{
	public class DocumentImportOptionsBase
	{
		/// <summary>
		/// Gets or sets a value indicating whether records should be appended or overlaid.
		/// The default mode is append.
		/// </summary>
		public DocumentOverwriteMode OverwriteMode { get; set; }

		/// <summary>
		/// Gets or sets a value indicating the method for overlay imports with multiple choice and multiple object fields.
		/// </summary>
		public DocumentOverlayBehavior OverlayBehavior { get; set; }

		/// <summary>
		/// Gets or sets the field to be used as an identifier while importing.
		/// </summary>
		public string DocumentIdentifierField { get; set; } = "Control Number";

		/// <summary>
		/// Gets or sets a value indicating whether the Extracted Text field contains a path to the extracted text
		/// file or contains the actual extracted text.
		/// </summary>
		public bool ExtractedTextFieldContainsFilePath { get; set; }

		/// <summary>
		/// Gets or sets the encoding of the extracted text files.
		/// </summary>
		public Encoding ExtractedTextEncoding { get; set; } = Encoding.ASCII;
	}
}
