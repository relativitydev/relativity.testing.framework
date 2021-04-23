using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the changeset of object permission.
	/// </summary>
	public class ObjectPermissionChangeset
	{
		private readonly ObjectPermissionsChangeset _parent;

		private readonly string _name;

		internal ObjectPermissionChangeset(ObjectPermissionsChangeset parent, string name)
		{
			_parent = parent;
			_name = name;

			CustomPermissions = new PermissionDetailsChangeset(this, x => x.CustomPermissions);
			SubPermissions = new PermissionDetailsChangeset(this, x => x.SubPermissions);
		}

		/// <summary>
		/// Gets the changeset of custom permissions.
		/// </summary>
		public PermissionDetailsChangeset CustomPermissions { get; }

		/// <summary>
		/// Gets the changeset of sub-permissions.
		/// </summary>
		public PermissionDetailsChangeset SubPermissions { get; }

		/// <summary>
		/// Sets the specified object permission kind.
		/// </summary>
		/// <param name="kind">The kind of object permission.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Set(ObjectPermissionKinds kind)
		{
			return Do((ObjectPermission permission) => permission.Set(kind));
		}

		/// <summary>
		/// Enables all permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableAll()
		{
			Set(ObjectPermissionKinds.Full);
			CustomPermissions.SetAll(true);
			SubPermissions.SetAll(true);

			return _parent.Owner;
		}

		/// <summary>
		/// Disables all permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset DisableAll()
		{
			Set(ObjectPermissionKinds.None);
			CustomPermissions.SetAll(false);
			SubPermissions.SetAll(false);

			return _parent.Owner;
		}

		internal GroupPermissionsChangeset Do(Action<ObjectPermission> action)
		{
			return _parent.DoFor(_name, action);
		}

		/// <summary>
		/// Executes the specified action that can modify the permission changeset.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Do(Action<ObjectPermissionChangeset> action)
		{
			action?.Invoke(this);

			return _parent.Owner;
		}
	}
}
