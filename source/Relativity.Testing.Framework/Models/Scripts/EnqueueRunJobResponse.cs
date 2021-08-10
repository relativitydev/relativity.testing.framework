using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the result of enqueuing a script to be run.
	/// </summary>
	public class EnqueueRunJobResponse
	{
		/// <summary>
		/// Gets or sets the ID of the script run job.
		/// </summary>
		public Guid RunJobID { get; set; }

		/// <summary>
		/// Gets or sets a list of RESTful operations that a user has permissions to perform on the enqueued job.
		/// </summary>
		public List<Action> Actions { get; set; }
	}
}
