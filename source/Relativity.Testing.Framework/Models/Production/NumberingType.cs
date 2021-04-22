namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines valid values for Relativity production numbering type.
	/// </summary>
	public enum NumberingType
	{
		/// <summary>
		/// Page-level numbering allows you to generate a new incremental number (also known as a Bates number) on every page across your document set. This number is branded on the images in your production.
		/// </summary>
		PageLevel = 0,

		/// <summary>
		/// Document-level numbering allows you to generate a new document number for each document. The number is branded on the images in your production.
		/// </summary>
		DocumentLevel = 1,

		/// <summary>
		/// Original image numbering allows you to retain the identifiers originally associated with your images. For example, you may want to retain the Bates or other numbers already assigned to images uploaded to Relativity. Relativity utilizes these values to create the production and attachment numbers.
		/// </summary>
		OriginalImage = 2,

		/// <summary>
		/// Existing production numbering allows you to retain the identifiers originally associated with your images. For example, you may want to retain the Bates or other numbers already assigned to images uploaded to Relativity. Relativity utilizes these values to create the production and attachment numbers.
		/// </summary>
		ExistingProduction = 3,

		/// <summary>
		/// Document field numbering allows you to use any fixed-length text field on the Document object for your numbering. For example, you could choose control number as the field and produce documents using the control number as the Bates field to maintain the original numbering of the documents.
		/// </summary>
		DocumentField = 4,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
