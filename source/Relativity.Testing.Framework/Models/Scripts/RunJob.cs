using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a script run job.
	/// </summary>
	public class RunJob
	{
		/// <summary>
		/// Gets or sets the current status of the job.
		/// </summary>
		public RunJobStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the script actions that are associated with this run job.
		/// </summary>
		public List<ActionJob> ActionJobs { get; set; }

		/// <summary>
		/// Gets or sets the error message when a script run errors.
		/// </summary>
		/// <remarks>
		/// This error is only populated when there is an error with the script run job.
		/// Action errors will listed with the associated <see cref="ActionJob"/> as part of the <see cref="ActionJobs"/> property.
		/// </remarks>
		public string ErrorMessage { get; set; }

		/// <summary>
		/// Gets or sets a list of RESTful operations that a user has permissions to perform on the script run job.
		/// </summary>
		public List<HttpAction> Actions { get; set; }

		/// <summary>
		/// Gets or sets a list of unsupported and read-only properties on the script run job.
		/// </summary>
		public Meta Meta { get; set; }
	}
}
