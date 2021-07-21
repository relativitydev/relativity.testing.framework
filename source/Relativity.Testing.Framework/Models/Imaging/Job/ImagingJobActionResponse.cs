namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a response from the imaging engine that indicates whether action (stopping or updating priority)
	/// on imaging job was successful.
	/// </summary>
	public class ImagingJobActionResponse
	{
		/// <summary>
		/// Gets or sets a value indicating whether the action on imaging job was completed.
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// Gets or sets a string representing an error message
		/// that occurred when performing the action on the imaging job.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
