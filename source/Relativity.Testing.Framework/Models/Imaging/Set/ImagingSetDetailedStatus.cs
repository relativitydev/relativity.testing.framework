namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represent the detialed status for Imaging Set.
	/// </summary>
	public class ImagingSetDetailedStatus : ImagingSetStatus
	{
		/// <summary>
		/// Gets or sets the Job Type indicating if the job is in progress.
		/// </summary>
		public ImagingJobType JobType { get; set; }

		/// <summary>
		/// Gets or sets the job status as enum <see cref="ImagingJobStatus"/>. If imaging job does not exist then returns enum <see cref="ImagingJobStatus.Default"/>.
		/// </summary>
		public ImagingJobStatus JobStatus { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the job exists. True indicates existence, false indicates job completion or nonexistence.
		/// </summary>
		public bool JobExists { get; set; }

		/// <summary>
		/// Gets or sets total number of documents in the imaging set.
		/// </summary>
		public int NumberOfDocuments { get; set; }

		/// <summary>
		/// Gets or sets number of documents hidden for QC review.
		/// </summary>
		public int NumberOfDocumentsHidden { get; set; }

		/// <summary>
		/// Gets or sets number of documents visible for QC review.
		/// </summary>
		public int NumberOfDocumentsViewable { get; set; }

		/// <summary>
		/// Gets or sets number of documents that have associated warnings.
		/// </summary>
		public int NumberOfDocumentsWithWarnings { get; set; }

		/// <summary>
		/// Gets or sets the number of documents completed. Will be 0 for an imaging set job until it has been submitted to invariant.
		/// </summary>
		public int NumberOfDocumentsCompleted { get; set; }

		/// <summary>
		/// Gets or sets the number of documents skipped. Will be 0 for an imaging set job until it has been submitted to invariant.
		/// </summary>
		public int NumberOfDocumentsSkipped { get; set; }

		/// <summary>
		/// Gets or sets the number of documents waiting to be converted to images.
		/// </summary>
		public int NumberOfDocumentsWaiting { get; set; }

		/// <summary>
		/// Gets or sets the number of documents in an error state. Will be 0 for an imaging set job until it has been submitted to invariant.
		/// </summary>
		public int NumberOfDocumentsErrored { get; set; }

		/// <summary>
		/// Gets or sets the number of documents submitted in the job.
		/// </summary>
		public int NumberOfDocumentsSubmitted { get; set; }
	}
}
