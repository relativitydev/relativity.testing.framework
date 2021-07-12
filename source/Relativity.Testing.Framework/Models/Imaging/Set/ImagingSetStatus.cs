namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represent the Status of <see cref="ImagingSet"/>.
	/// </summary>
	public class ImagingSetStatus
	{
		/// <summary>
		/// Gets or sets an error on the previous job for this imaging set.
		/// </summary>
		public string LastRunError { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether a quality control review
		/// was enabled on the last job for this imaging set.
		/// </summary>
		public bool QCEnabledOnLastRun { get; set; }

		/// <summary>
		/// Gets or sets the imaging set status string.
		/// </summary>
		public string Status { get; set; }
	}
}
