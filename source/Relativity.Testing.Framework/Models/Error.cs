using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity error object.
	/// </summary>
	public class Error : Artifact
	{
		/// <summary>
		/// Gets or sets a brief message summarizing the error.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets a detailed error message, such as a stack trace.
		/// </summary>
		public string FullError { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the server where the error occurred.
		/// </summary>
		public string Server { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the component of the Relativity application where the error occurred,
		/// such as the web, or agent.
		/// </summary>
		public string Source { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the URL at which the error occurred.
		/// </summary>
		public string URL { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the steps to recreate the error.
		/// </summary>
		public string StepsToReproduce { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the Workspace identifier associated with this error.
		/// </summary>
		public NamedArtifact Workspace { get; set; } = new NamedArtifact();

		/// <summary>
		/// Gets or sets a value indicating whether to send a notification message when an error occurs.
		/// </summary>
		public bool? SendNotification { get; set; }

		/// <summary>
		/// Gets or sets the DateTime that the error was created.
		/// </summary>
		public DateTime Timestamp { get; set; }
	}
}
