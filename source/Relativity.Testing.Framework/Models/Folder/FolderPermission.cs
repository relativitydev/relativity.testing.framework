namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents Folder permissions.
	/// </summary>
	public class FolderPermission
	{
		/// <summary>
		/// Gets a value indicating whether user has permission for Add operation.
		/// </summary>
		public bool Add { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether user has permission for Delete operation.
		/// </summary>
		public bool Delete { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether user has permission for Edit operation.
		/// </summary>
		public bool Edit { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether user has permission for Secure operation.
		/// </summary>
		public bool Secure { get; internal set; }
	}
}
