namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The available codes for an application install status.
	/// </summary>
	public enum RelativityApplicationInstallStatusCode
	{
		/// <summary>
		/// Unknown is not used by Relativity and represents an uninitialized status value.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The application install task has been queued and is waiting to be picked up by an agent.
		/// </summary>
		Pending = 1,

		/// <summary>
		/// The agent is in the process of executing the application install task.
		/// </summary>
		InProgress = 2,

		/// <summary>
		/// The application install task failed due to a validation failure or an unexpected error.
		/// </summary>
		Failed = 3,

		/// <summary>
		/// The application install task is complete.
		/// </summary>
		Completed = 4,

		/// <summary>
		/// The application install task was canceled before an agent could pick it up.
		/// </summary>
		Canceled = 5
	}
}
