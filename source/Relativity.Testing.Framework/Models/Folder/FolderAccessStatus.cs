namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Folder access status.
	/// </summary>
	public class FolderAccessStatus
	{
		/// <summary>
		/// Gets a value indicating whether folder exists.
		/// </summary>
		public bool Exists { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether the user has view access to the folder.
		/// </summary>
		public bool CanView { get; internal set; }
	}
}
