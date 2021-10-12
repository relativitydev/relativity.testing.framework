using System;
using Relativity.Testing.Framework.Extensions;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the changeset of group permissions.
	/// </summary>
	public class GroupPermissionsChangeset : ICloneable
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GroupPermissionsChangeset"/> class.
		/// </summary>
		public GroupPermissionsChangeset()
		{
			ObjectPermissions = new ObjectPermissionsChangeset(this);
			TabVisibility = new GenericPermissionsChangeset(this);
			AdminPermissions = new GenericPermissionsChangeset(this);
			BrowserPermissions = new GenericPermissionsChangeset(this);
			MassActionPermissions = new GenericPermissionsChangeset(this);
		}

		/// <summary>
		/// Gets the changeset of object permissions.
		/// </summary>
		public ObjectPermissionsChangeset ObjectPermissions { get; }

		/// <summary>
		/// Gets the changeset of tab visibility permissions.
		/// </summary>
		public GenericPermissionsChangeset TabVisibility { get; }

		/// <summary>
		/// Gets the changeset of browser permissions.
		/// </summary>
		public GenericPermissionsChangeset BrowserPermissions { get; }

		/// <summary>
		/// Gets the changeset of mass action permissions.
		/// </summary>
		public GenericPermissionsChangeset MassActionPermissions { get; }

		/// <summary>
		/// Gets the changeset of admin permissions.
		/// </summary>
		public GenericPermissionsChangeset AdminPermissions { get; }

		/// <summary>
		/// Enables all permissions.
		/// </summary>
		/// <returns>The same instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableAll()
		{
			ObjectPermissions.EnableAll();
			TabVisibility.EnableAll();
			AdminPermissions.EnableAll();
			BrowserPermissions.EnableAll();
			MassActionPermissions.EnableAll();

			return this;
		}

		/// <summary>
		/// Disables all permissions.
		/// </summary>
		/// <returns>The same instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset DisableAll()
		{
			ObjectPermissions.DisableAll();
			TabVisibility.DisableAll();
			AdminPermissions.DisableAll();
			BrowserPermissions.DisableAll();
			MassActionPermissions.DisableAll();

			return this;
		}

		internal void Execute(GroupPermissions permissions)
		{
			ObjectPermissions.Execute(permissions.ObjectPermissions);
			TabVisibility.Execute(permissions.TabVisibility);
			AdminPermissions.Execute(permissions.AdminPermissions);
			BrowserPermissions.Execute(permissions.BrowserPermissions);
			MassActionPermissions.Execute(permissions.MassActionPermissions);
		}

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		object ICloneable.Clone() => Clone();

		/// <summary>
		/// Clones this instance.
		/// </summary>
		/// <returns>A copy of this instance.</returns>
		public GroupPermissionsChangeset Clone()
		{
			return this.Copy();
		}
	}
}
