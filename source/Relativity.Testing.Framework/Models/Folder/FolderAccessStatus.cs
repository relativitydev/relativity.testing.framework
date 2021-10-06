namespace Relativity.Testing.Framework.Models.Folder
{
	/// <summary>
	/// Represents the Folder access status.
	/// </summary>
	public class FolderAccessStatus
	{
		/// <summary>
		/// Gets or sets a value indicating whether folder exists.
		/// </summary>
		public bool Exists { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the user has view access to the folder.
		/// </summary>
		public bool CanView { get; set; }
	}
}
