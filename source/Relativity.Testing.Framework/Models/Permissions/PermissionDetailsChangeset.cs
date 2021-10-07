using System;
using System.Collections.Generic;
using System.Linq;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the changeset of permission details.
	/// </summary>
	public class PermissionDetailsChangeset
	{
		private readonly ObjectPermissionChangeset _parent;

		private readonly Func<ObjectPermission, List<PermissionDetail>> _permissionDetailListGetter;

		internal PermissionDetailsChangeset(ObjectPermissionChangeset parent, Func<ObjectPermission, List<PermissionDetail>> permissionDetailListGetter)
		{
			_parent = parent;
			_permissionDetailListGetter = permissionDetailListGetter;
		}

		/// <summary>
		/// Enables the permissions with the specified names.
		/// </summary>
		/// <param name="names">The permission names.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Enable(params string[] names)
		{
			return Enable(names.AsEnumerable());
		}

		/// <summary>
		/// Enables the permissions with the specified names.
		/// </summary>
		/// <param name="names">The permission names.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Enable(IEnumerable<string> names)
		{
			return SetSelected(names, true);
		}

		/// <summary>
		/// Disables the permissions with the specified names.
		/// </summary>
		/// <param name="names">The permission names.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Disable(params string[] names)
		{
			return Disable(names.AsEnumerable());
		}

		/// <summary>
		/// Disables the permissions with the specified names.
		/// </summary>
		/// <param name="names">The permission names.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Disable(IEnumerable<string> names)
		{
			return SetSelected(names, false);
		}

		private GroupPermissionsChangeset SetSelected(IEnumerable<string> names, bool selected)
		{
			return _parent.Do(op =>
			{
				var items = _permissionDetailListGetter(op);

				if (items != null)
				{
					foreach (var item in items.Where(x => names.Contains(x.Name)))
					{
						item.Selected = selected;
					}
				}
			});
		}

		/// <summary>
		/// Enables all permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableAll()
		{
			return SetAll(true);
		}

		/// <summary>
		/// Disables all permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset DisableAll()
		{
			return SetAll(false);
		}

		/// <summary>
		/// Sets the specified selected state to all permissions.
		/// </summary>
		/// <param name="selected">Whether to select permissions.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset SetAll(bool selected)
		{
			return _parent.Do(permission =>
			{
				var items = _permissionDetailListGetter(permission);

				if (items != null)
				{
					foreach (var item in items)
					{
						item.Selected = selected;
					}
				}
			});
		}
	}
}
