namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a Relativity BatchSet used to organize batches.
	/// </summary>
	public class BatchSet : NamedArtifact
	{
		/// <summary>
		/// Gets or sets batch prefix.
		/// </summary>
		public string BatchPrefix { get; set; } = "AT";

		/// <summary>
		/// Gets or sets batch size.
		/// </summary>
		public int BatchSize { get; set; } = 100;

		/// <summary>
		/// Gets or sets data source for a batch set.
		/// </summary>
		public NamedArtifact DataSource { get; set; }

		/// <summary>
		/// Gets or sets batch unit field.
		/// </summary>
		public NamedArtifact BatchUnitField { get; set; }

		/// <summary>
		/// Gets or sets batch family field.
		/// </summary>
		public NamedArtifact FamilyField { get; set; }

		/// <summary>
		/// Gets or sets reviewed field.
		/// </summary>
		public NamedArtifact ReviewedField { get; set; }

		/// <summary>
		/// Gets or sets settings for auto batching.
		/// </summary>
		public AutoBatchSettings AutoBatchSettings { get; set; }

		/// <summary>
		/// Gets or sets the result for the Batch Process.
		/// </summary>
		public BatchProcessResult BatchProcessResult { get; set; }

		/// <summary>
		/// Gets or sets Keywords.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets Notes.
		/// </summary>
		public string Notes { get; set; } = string.Empty;
	}
}
