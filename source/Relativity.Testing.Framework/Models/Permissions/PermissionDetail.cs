using System.Diagnostics;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the information about a specific permission.
	/// </summary>
	[DebuggerDisplay("{Name} IsSelected:{Selected}")]
	public class PermissionDetail
	{
		/// <summary>
		/// Gets or sets the permission ID.
		/// </summary>
		public int PermissionID { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this permission is selected.
		/// </summary>
		public bool Selected { get; set; }
	}
}
