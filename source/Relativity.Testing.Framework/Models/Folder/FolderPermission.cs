namespace Relativity.Testing.Framework.Models.Folder
{
	/// <summary>
	/// Represents Foldeer permissions.
	/// </summary>
	public class FolderPermission
	{
		/// <summary>
		/// Gets or sets a value indicating whether user has permission for Add operation.
		/// </summary>
		public bool Add { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether user has permission for Delete operation.
		/// </summary>
		public bool Delete { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether user has permission for Edit operation.
		/// </summary>
		public bool Edit { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether user has permission for Secure operation.
		/// </summary>
		public bool Secure { get; set; }
	}
}
