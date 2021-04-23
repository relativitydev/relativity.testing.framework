namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the response from the SaveFieldsAndCustomText endpoint.
	/// </summary>
	public class SaveFieldsAndCustomTextResponse
	{
		/// <summary>
		/// Gets or sets a value indicating whether the request was successful.
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// Gets or sets the message of the response.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the details of the response.
		/// </summary>
		public string Details { get; set; }
	}
}
