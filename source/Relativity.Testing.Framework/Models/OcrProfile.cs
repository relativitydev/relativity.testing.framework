using System.Collections.Generic;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a optical character recognition profile.
	/// </summary>
	[ObjectTypeName("OCR Profile")]
	public class OcrProfile : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the keywords.
		/// </summary>
		public string Keywords { get; set; }

		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// Gets or sets the image timeout.
		/// </summary>
		[FieldName("Image Timeout (Seconds)")]
		public int ImageTimeout { get; set; } = 60;

		/// <summary>
		/// Gets or sets a value indicating whether ocr runs on partial errors.
		/// </summary>
		[FieldName("On Partial Error")]
		public bool OnPartialError { get; set; }

		/// <summary>
		/// Gets or sets the languages.
		/// </summary>
		public List<NamedArtifact> Languages { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether ocr has auto rotate images.
		/// </summary>
		[FieldName("Auto-Rotate Images")]
		public bool AutoRotateImages { get; set; }

		/// <summary>
		/// Gets or sets the accuracy.
		/// </summary>
		public NamedArtifact Accuracy { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether ocr need to preprocess images.
		/// </summary>
		[FieldName("Preprocess Images")]
		public bool PreprocessImages { get; set; }
	}
}
