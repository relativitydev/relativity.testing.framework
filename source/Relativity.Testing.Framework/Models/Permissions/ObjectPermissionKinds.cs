using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enumeration of <see cref="ObjectPermission"/> kinds.
	/// </summary>
	[Flags]
	public enum ObjectPermissionKinds
	{
		None = 0,
		View = 1,
		Edit = 2,
		Delete = 4,
		Add = 8,
		EditSecurity = 16,

		ViewEdit = View | Edit,
		ViewAdd = View | Add,
		ViewEditDelete = View | Edit | Delete,
		ViewEditDeleteAdd = View | Edit | Delete | Add,
		ViewEditAdd = View | Edit | Add,
		ViewAndEditSecurity = View | EditSecurity,
		ViewEditAndEditSecurity = View | Edit | EditSecurity,
		ViewAddAndEditSecurity = View | Add | EditSecurity,
		ViewEditDeleteAndEditSecurity = View | Edit | Delete | EditSecurity,
		ViewEditDeleteAddAndEditSecurity = View | Edit | Delete | Add | EditSecurity,
		ViewEditAddAndEditSecurity = View | Edit | Add | EditSecurity,
		Full = ViewEditDeleteAddAndEditSecurity
	}
}
