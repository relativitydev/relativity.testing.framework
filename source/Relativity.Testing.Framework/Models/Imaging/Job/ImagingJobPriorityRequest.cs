namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The request object for updating the priority of an imaging job.
	/// </summary>
	public class ImagingJobPriorityRequest : ImagingJobBase
	{
		/// <summary>
		/// Gets or sets the new priority.
		/// </summary>
		public int Priority { get; set; }
	}
}
