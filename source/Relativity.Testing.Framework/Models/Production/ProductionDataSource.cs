using Newtonsoft.Json;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a DataSource that holds documents to be included in the production.
	/// </summary>
	public class ProductionDataSource : NamedArtifact
	{
		/// <summary>
		///  Gets or sets the production artifact ID.
		/// </summary>
		[JsonIgnore]
		public int ProductionId { get; set; }

		/// <summary>
		/// Gets or sets the type of production that applies to this data source, for example, Images Only or Natives Only. Valid values are defined by ProductionType enum.
		/// </summary>
		public ProductionType ProductionType { get; set; }

		/// <summary>
		/// Gets or sets a reference object representing the saved search that contains the documents to be produced.
		/// </summary>
		public NamedArtifact SavedSearch { get; set; }

		/// <summary>
		/// Gets or sets option for when to use image placeholder. Valid values are defined by UseImagePlaceholderOption enum.
		/// </summary>
		public UseImagePlaceholderOption UseImagePlaceholder { get; set; }

		/// <summary>
		/// Gets or sets placeholder to be used with the DataSource.
		/// </summary>
		/// <remarks>This property will be ignored when ProductionType is Image, and UseImagePlaceholder is set to NeverUseImagePlaceholder.</remarks>
		public NamedArtifact Placeholder { get; set; }

		/// <summary>
		/// Gets or sets markup set to be used with the DataSource.
		/// </summary>
		/// <remarks>This property will be ignored when Burn Redaction is set to False.</remarks>
		public NamedArtifact MarkupSet { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether indicates whether or not to burn redactions when producing image type productions.
		/// </summary>
		public bool BurnRedactions { get; set; }
	}
}
