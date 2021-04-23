namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Representing the numbering scheme for production documents.
	/// The Numbering property of the Production.
	/// </summary>
	public class ProductionNumbering
	{
		/// <summary>
		/// Gets or sets document numbering type to be used. Valid values are defined by the NumberingType enum.
		/// </summary>
		public NumberingType NumberingType { get; set; }

		/// <summary>
		/// Gets or sets document field that holds the attachment relational number.
		/// </summary>
		public NamedArtifact AttachmentRelationalField { get; set; }

		/// <summary>
		/// Gets or sets Bates prefix text.
		/// </summary>
		public string BatesPrefix { get; set; }

		/// <summary>
		/// Gets or sets Bates suffix text.
		/// </summary>
		public string BatesSuffix { get; set; }

		/// <summary>
		/// Gets or sets Bates start number.
		/// </summary>
		public int BatesStartNumber { get; set; }

		/// <summary>
		/// Gets or sets the number of digits to be used for document level numbering. The range is from 1 to 7.
		/// </summary>
		public int NumberOfDigitsForDocumentNumbering { get; set; }

		/// <summary>
		/// Gets or sets document field that will be used as the Bates number.
		/// </summary>
		public NamedArtifact NumberingField { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to include page numbers. If true, a unique number is added to each page following the document number.
		/// </summary>
		public bool IncludePageNumbers { get; set; }

		/// <summary>
		/// Gets or sets the separator between document and page numbers if IncludePageNumbers is set to true. Underscore, hyphen, and period are allowed characters.
		/// </summary>
		public string DocumentNumberPageNumberSeparator { get; set; }

		/// <summary>
		/// Gets or sets the number of digits for page numbering if IncludePageNumbers is set to true. The range is from 1 to 4.
		/// </summary>
		public int NumberOfDigitsForPageNumbering { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to start page numbering on the second page of the document.
		/// </summary>
		public bool StartNumberingOnSecondPage { get; set; }

		/// <summary>
		/// Gets or sets a value of an existing production artifact.
		/// </summary>
		public NamedArtifact ExistingProduction { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to merge the numbering with the existing production.
		/// </summary>
		public bool MergeWithExistingSet { get; set; }
	}
}
