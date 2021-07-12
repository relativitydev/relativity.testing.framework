namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	///  Represents the Job Type indicating if the Imaging job is in progress.
	/// </summary>
	public enum ImagingJobType
	{
		NoRunningJob = 0,
		FullImagingJob = 1,
		ImagingJobWithRetryErrors = 2,
		Unknown
	}
}
