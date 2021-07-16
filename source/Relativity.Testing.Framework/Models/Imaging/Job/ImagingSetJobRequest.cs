namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a job request sent to the imaging engine to generated a set of documents identified by a specific <see cref="ImagingSet"/> instance.
	/// </summary>
	public class ImagingSetJobRequest : ImagingJobRequest
	{
		/// <summary>
		/// Gets or sets the optional property QcEnabled. If true, the run job will hide images by default.  If false, the run job will show images by default.  If unset, the setting from the previous
		/// imaging set run is used.
		/// </summary>
		public bool? QcEnabled { get; set; }
	}
}
