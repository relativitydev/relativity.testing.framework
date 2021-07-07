using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Contains data about Imaging status of a Document.
	/// </summary>
	public class DocumentStatus
	{
		/// <summary>
		/// Gets or sets the number of images for this Document.
		/// </summary>
		public int ImageCount { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="DocumentError"/> connected to this Document.
		/// </summary>
		public DocumentError Error { get; set; }

		/// <summary>
		/// Gets or sets the collection of <see cref="DocumentWarning"/> connected to this Document.
		/// </summary>
		public IList<DocumentWarning> Warnings { get; set; }

		/// <summary>
		/// Gets or sets the HasImages value of this Document. Possible values are Yes, No, Pending, Error.
		/// </summary>
		public HasImagesStatus HasImages { get; set; }
	}
}
