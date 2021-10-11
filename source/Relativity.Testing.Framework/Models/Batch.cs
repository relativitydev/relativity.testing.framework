using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a Relativity Batch used to manipulate documents.
	/// </summary>
	public class Batch : Artifact
	{
		/// <summary>
		/// Gets  the batch name.
		/// </summary>
		[FieldName("Batch")]
		[OnlyReadable]
		public string BatchName { get; internal set; }

		/// <summary>
		/// Gets or sets user id that current batch is assigned to.
		/// </summary>
		public Artifact AssignedTo { get; set; }

		/// <summary>
		/// Gets or sets the batch status.
		/// </summary>
		public string BatchStatus { get; set; }

		/// <summary>
		/// Gets the batch set that the batch belongs to.
		/// </summary>
		[OnlyReadable]
		public string BatchSet { get; internal set; }

		/// <summary>
		/// Gets the batch size.
		/// </summary>
		[OnlyReadable]
		public int BatchSize { get; internal set; }

		/// <summary>
		/// Gets the number of documents in the batch that have been reviewed.
		/// </summary>
		[OnlyReadable]
		public int Reviewed { get; internal set; }

		/// <summary>
		/// Gets or sets the batch unit assigned to the batch.
		/// </summary>
		public string BatchUnit { get; set; }

		/// <summary>
		/// Gets a number assigned to batch.
		/// </summary>
		[OnlyReadable]
		public int BatchNumber { get; internal set; }
}
}
