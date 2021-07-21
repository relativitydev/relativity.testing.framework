using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Imaging Job Request.
	/// </summary>
	public class ImagingJobRequest
	{
		/// <summary>
		/// Gets or sets optional unique identifier for the caller of this method. Can be used to differentiate ImagingDocumentRequests
		/// from different sources.
		/// </summary>
		public Guid? OriginationID { get; set; }
	}
}
