using System.Collections.Generic;
using System.Diagnostics;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the object permission.
	/// </summary>
	[DebuggerDisplay("{Name} View:{ViewSelected} Edit:{EditSelected} Delete:{DeleteSelected} Add:{AddSelected} EditSecurity:{EditSecuritySelected}")]
	public class ObjectPermission
	{
		/// <summary>
		/// Gets or sets the artifact grouping ID.
		/// </summary>
		public int ArtifactGroupingID { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "View" permission is selected.
		/// </summary>
		public bool ViewSelected { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Edit" permission is editable.
		/// </summary>
		public bool EditEditable { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Edit" permission is selected.
		/// </summary>
		public bool EditSelected { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Delete" permission is editable.
		/// </summary>
		public bool DeleteEditable { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Delete" permission is selected.
		/// </summary>
		public bool DeleteSelected { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Add" permission is editable.
		/// </summary>
		public bool AddEditable { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Add" permission is selected.
		/// </summary>
		public bool AddSelected { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Edit Security" permission is editable.
		/// </summary>
		public bool EditSecurityEditable { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the "Edit Security" permission is selected.
		/// </summary>
		public bool EditSecuritySelected { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether all permissions can be removed.
		/// </summary>
		public bool CanRemovePermissions { get; set; }

		/// <summary>
		/// Gets or sets the sub-permissions.
		/// </summary>
		public List<PermissionDetail> SubPermissions { get; set; } = new List<PermissionDetail>();

		/// <summary>
		/// Gets or sets the custom permissions.
		/// </summary>
		public List<PermissionDetail> CustomPermissions { get; set; } = new List<PermissionDetail>();

		/// <summary>
		/// Gets or sets a value indicating whether there are child permissions.
		/// </summary>
		public bool HasChildPermissions { get; set; }

		/// <summary>
		/// Gets or sets the current indent of this permission hierarchy.
		/// </summary>
		public int HierarchyIndent { get; set; }

		/// <summary>
		/// Gets or sets the artifact type ID.
		/// </summary>
		public int ArtifactTypeID { get; set; }

		/// <summary>
		/// Gets or sets the parent artifact type ID.
		/// </summary>
		public int ParentArtifactTypeID { get; set; }

		/// <summary>
		/// Sets the specified object permission kind.
		/// </summary>
		/// <param name="kind">The kind of object permission.</param>
		public void Set(ObjectPermissionKinds kind)
		{
			ViewSelected = kind.HasFlag(ObjectPermissionKinds.View);
			EditSelected = EditEditable && kind.HasFlag(ObjectPermissionKinds.Edit);
			DeleteSelected = DeleteEditable && kind.HasFlag(ObjectPermissionKinds.Delete);
			AddSelected = AddEditable && kind.HasFlag(ObjectPermissionKinds.Add);
			EditSecuritySelected = EditSecurityEditable && kind.HasFlag(ObjectPermissionKinds.EditSecurity);
		}
	}
}
