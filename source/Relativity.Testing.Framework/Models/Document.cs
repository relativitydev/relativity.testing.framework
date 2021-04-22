using System;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity document object.
	/// </summary>
	public class Document : Artifact
	{
		/// <summary>
		/// Gets the control number.
		/// </summary>
		public string ControlNumber { get; internal set; }

		/// <summary>
		/// Gets or sets the extracted text.
		/// </summary>
		public string ExtractedText { get; set; }

		/// <summary>
		/// Gets a value indicating whether document has native.
		/// </summary>
		[OnlyReadable]
		public bool HasNative { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether document has images.
		/// </summary>
		[OnlyReadable]
		public NamedArtifact HasImages { get; internal set; }

		/// <summary>
		/// Gets the date and time in UTC when the document was created.
		/// </summary>
		[OnlyReadable]
		public DateTime? SystemCreatedOn { get; internal set; }
	}
}
