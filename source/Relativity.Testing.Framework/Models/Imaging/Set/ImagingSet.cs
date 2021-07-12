namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Image Set which consists of an imaging profile
	/// and a search containing the documents to image.
	/// Necessary to run imaging job.
	/// </summary>
	public class ImagingSet : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the imaging profile associated with the imaging set.
		/// </summary>
		public Artifact ImagingProfile { get; set; }

		/// <summary>
		/// Gets or sets the Artifact ID of the saved search containing the documents for imaging.
		/// </summary>
		public int DataSourceId { get; set; }

		/// <summary>
		/// Gets or sets the Imaging Set Status.
		/// </summary>
		public ImagingSetStatus Status { get; set; }
	}
}
