using System;
using System.Collections.Generic;
using System.Linq;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the changeset of object permissions.
	/// </summary>
	public class ObjectPermissionsChangeset
	{
		private readonly List<Action<List<ObjectPermission>>> _actions = new List<Action<List<ObjectPermission>>>();

		internal ObjectPermissionsChangeset(GroupPermissionsChangeset owner)
		{
			Owner = owner;
		}

		internal GroupPermissionsChangeset Owner { get; }

		/// <summary>
		/// Gets the <see cref="ObjectPermissionChangeset"/> for permission with the specified name.
		/// </summary>
		/// <value>
		/// The <see cref="ObjectPermissionChangeset"/>.
		/// </value>
		/// <param name="name">The permission name.</param>
		/// <returns>An instance of <see cref="ObjectPermissionChangeset"/>.</returns>
		public ObjectPermissionChangeset this[string name] => new ObjectPermissionChangeset(this, name);

		private GroupPermissionsChangeset Do(Action<List<ObjectPermission>> action)
		{
			if (action != null)
			{
				_actions.Add(action);
			}

			return Owner;
		}

		internal GroupPermissionsChangeset DoFor(string name, Action<ObjectPermission> action)
		{
			if (action != null)
			{
				_actions.Add(items => action.Invoke(items.First(x => x.Name == name)));
			}

			return Owner;
		}

		/// <summary>
		/// Enables all permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableAll()
		{
			return Do(permissions =>
			{
				foreach (ObjectPermission permission in permissions)
				{
					permission.Set(ObjectPermissionKinds.Full);

					if (permission.SubPermissions != null)
					{
						foreach (var child in permission.SubPermissions)
						{
							child.Selected = true;
						}
					}

					if (permission.CustomPermissions != null)
					{
						foreach (var child in permission.CustomPermissions)
						{
							child.Selected = true;
						}
					}
				}
			});
		}

		/// <summary>
		/// Disables all permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset DisableAll()
		{
			return Do(permissions =>
			{
				foreach (ObjectPermission permission in permissions)
				{
					permission.Set(ObjectPermissionKinds.None);

					if (permission.SubPermissions != null)
					{
						foreach (var child in permission.SubPermissions)
						{
							child.Selected = false;
						}
					}

					if (permission.CustomPermissions != null)
					{
						foreach (var child in permission.CustomPermissions)
						{
							child.Selected = false;
						}
					}
				}
			});
		}

		internal void Execute(List<ObjectPermission> permissions)
		{
			foreach (var action in _actions)
			{
				action.Invoke(permissions);
			}
		}
	}
}
