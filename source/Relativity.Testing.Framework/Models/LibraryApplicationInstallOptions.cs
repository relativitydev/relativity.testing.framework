namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a request for creating or updating a Library Application.
	/// </summary>
	public class LibraryApplicationInstallOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether enables or disables version checks. By default, only
		/// upgrades with a higher application version than the version currently installed
		/// are allowed.
		/// </summary>
		public bool IgnoreVersion { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether an application is created when it doesn't already exist
		/// in the library. By default, if the application is missing, it will be created.
		/// </summary>
		public bool CreateIfMissing { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether the custom pages should be refreshed
		/// up front or later when the application is installed to a workspace.
		/// </summary>
		public bool RefreshCustomPages { get; set; }

		/// <summary>
		/// Gets or sets the optional name of the RAP file for the application.
		/// </summary>
		public string FileName { get; set; }
	}
}
