using System;
using System.Collections.Generic;
using System.Linq;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the changeset of generic permission.
	/// </summary>
	public class GenericPermissionChangeset
	{
		private readonly GenericPermissionsChangeset _parent;

		private readonly IEnumerable<string> _structureNames;

		internal GenericPermissionChangeset(GenericPermissionsChangeset parent, IEnumerable<string> structureNames)
		{
			_parent = parent;
			_structureNames = structureNames;
		}

		/// <summary>
		/// Updates the <see cref="GroupPermissionsChangeset"/>.
		/// </summary>
		/// <param name="name">The Name.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GenericPermissionChangeset this[string name] => new GenericPermissionChangeset(_parent, _structureNames.Concat(new[] { name }));

		/// <summary>
		/// Enables the permission.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Enable()
		{
			return Do((GenericPermission permission) => permission.Enable());
		}

		/// <summary>
		/// Disables the permission.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Disable()
		{
			return Do((GenericPermission permission) => permission.Disable());
		}

		/// <summary>
		/// Enables the permission and all its child permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableAll()
		{
			return Do((GenericPermission permission) => permission.EnableAll());
		}

		/// <summary>
		/// Disables the permission and all its child permissions.
		/// </summary>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset DisableAll()
		{
			return Do((GenericPermission permission) => permission.DisableAll());
		}

		/// <summary>
		/// Enables the permission and all its child permissions with particular names.
		/// </summary>
		/// <param name="childPermissionNames">The child permission names.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableWith(params string[] childPermissionNames)
		{
			return EnableWith(childPermissionNames.AsEnumerable());
		}

		/// <summary>
		/// Enables the permission and all its child permissions with particular names.
		/// </summary>
		/// <param name="childPermissionNames">The child permission names.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableWith(IEnumerable<string> childPermissionNames)
		{
			return Do((GenericPermission permission) => permission.EnableWith(childPermissionNames));
		}

		internal GroupPermissionsChangeset Do(Action<GenericPermission> action)
		{
			return _parent.DoFor(_structureNames, action);
		}

		/// <summary>
		/// Executes the specified action that can modify the permission changeset.
		/// </summary>
		/// <param name="action">The action.</param>
		/// <returns>An instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset Do(Action<GenericPermissionChangeset> action)
		{
			action?.Invoke(this);

			return _parent.Owner;
		}
	}
}
