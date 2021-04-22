namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the available statuses of a script run job.
	/// </summary>
	public enum RunJobStatus
	{
		/// <summary>
		/// The job has been successfully submitted and is queued to be run.
		/// </summary>
		Queued = 0,

		/// <summary>
		/// The job is actively being run.
		/// </summary>
		InProgress = 1,

		/// <summary>
		/// All actions have been run and completed without error.
		/// </summary>
		Completed = 2,

		/// <summary>
		/// All actions have been run and one or more have errored.
		/// </summary>
		CompletedWithErrors = 3,

		/// <summary>
		/// The job failed to complete.
		/// </summary>
		FailedToComplete = 4,

		/// <summary>
		/// The Agent has missed multiple consecutive check-ins.
		/// </summary>
		AgentHasNotCheckedIn = 5,

		/// <summary>
		/// All actions have been run and one or more have errored.
		/// </summary>
		Errored = 6,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
