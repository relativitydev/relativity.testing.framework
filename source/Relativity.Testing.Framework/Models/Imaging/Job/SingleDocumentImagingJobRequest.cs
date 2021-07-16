namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Request used for running a job to image an individual documents.
	/// </summary>
	public class SingleDocumentImagingJobRequest : ImagingJobRequest
	{
		/// <summary>
		/// Gets or sets the id of the imaging profile to use.
		/// </summary>
		public int ProfileID { get; set; }

		/// <summary>
		/// Gets or sets optional - location of an alternate native to use while imaging the document
		/// This file will not be attached to the document, it is only used to generate images.
		/// </summary>
		public string AlternateNativeLocation { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether if alternate native files are specified,
		/// remove them after they are imaged.
		/// </summary>
		public bool RemoveAlternateNativeAfterImaging { get; set; }
	}
}
