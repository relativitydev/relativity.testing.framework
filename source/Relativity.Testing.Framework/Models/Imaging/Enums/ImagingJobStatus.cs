namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the status of the imaging job.
	/// </summary>
	public enum ImagingJobStatus
	{
		Unknown = 0,

		/// <summary>
		/// An invalid job.
		/// </summary>
		Invalid = 1,

		/// <summary>
		/// The imaging job isn't initialized. This value is returned if the imaging job doesn't exist.
		/// </summary>
		Default = 2,

		/// <summary>
		/// The imaging job has been created.
		/// </summary>
		Created = 3,

		/// <summary>
		/// The Imaging job has been flagged for cancellation.
		/// </summary>
		CancelRequested = 4,

		/// <summary>
		/// The Imaging Request agent has picked up the job.
		/// </summary>
		PickedUpByAgent = 5,

		/// <summary>
		/// The documents in the imaging job have been submitted to Invariant.
		/// </summary>
		SubmittedToInvariant = 6
	}
}
