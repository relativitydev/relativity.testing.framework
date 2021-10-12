using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// An action that can be performed on the given static object.
	/// </summary>
	public class HttpAction
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HttpAction"/> class.
		/// </summary>
		public HttpAction()
		{
			Reason = new List<string>();
		}

		/// <summary>
		/// Gets or sets the action the user has permission to perform on the given static object.
		/// </summary>
		/// <remarks>
		/// For example, "Delete" means this object can be deleted, "Update" means this object can be updated.
		/// </remarks>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the url for the Kepler service that performs this action.
		/// </summary>
		public string Href { get; set; }

		/// <summary>
		/// Gets or sets the HTTP verb to use when calling the Kepler service to perform the action.
		/// </summary>
		/// <remarks>
		/// For example, "DELETE" to delete the object, "PUT" to update the object.
		/// </remarks>
		public string Verb { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not the action is available on the given static object.
		/// </summary>
		public bool IsAvailable { get; set; }

		/// <summary>
		/// Gets or sets reasons the action may not be available.
		/// </summary>
		/// <remarks>
		/// For example, the given static object may not be available for update or deletion because it is part of a locked application.
		/// </remarks>
		public List<string> Reason { get; set; }
	}
}
