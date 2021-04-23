using System;
using System.Collections.Generic;
using System.Linq;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the changeset of generic permissions.
	/// </summary>
	public class GenericPermissionsChangeset
	{
		private readonly List<Action<List<GenericPermission>>> _actions = new List<Action<List<GenericPermission>>>();

		internal GenericPermissionsChangeset(GroupPermissionsChangeset owner)
		{
			Owner = owner;
		}

		internal GroupPermissionsChangeset Owner { get; }

		/// <summary>
		/// Gets the <see cref="GenericPermissionChangeset"/> for permission with the specified name.
		/// </summary>
		/// <value>
		/// The <see cref="GenericPermissionChangeset"/>.
		/// </value>
		/// <param name="name">The permission name.</param>
		/// <returns>An instance of <see cref="GenericPermissionChangeset"/>.</returns>
		public GenericPermissionChangeset this[string name] => new GenericPermissionChangeset(this, new[] { name });

		private GroupPermissionsChangeset Do(Action<List<GenericPermission>> action)
		{
			if (action != null)
			{
				_actions.Add(action);
			}

			return Owner;
		}

		internal GroupPermissionsChangeset DoFor(IEnumerable<string> structureNames, Action<GenericPermission> action)
		{
			if (action != null && structureNames != null && structureNames.Any())
			{
				_actions.Add(items =>
				{
					GenericPermission permission = FindInHierarchy(items, structureNames);
					action.Invoke(permission);
				});
			}

			return Owner;
		}

		private static GenericPermission FindInHierarchy(IEnumerable<GenericPermission> permissions, IEnumerable<string> structureNames)
		{
			GenericPermission permission = permissions.First(x => x.Name == structureNames.First());

			return structureNames.Count() > 1
				? FindInHierarchy(permission.Children, structureNames.Skip(1))
				: permission;
		}

		/// <summary>
		/// Enables all permissions together with their child permissions.
		/// </summary>
		/// <returns>The same instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset EnableAll()
		{
			return Do(permissions =>
			{
				foreach (GenericPermission permission in permissions)
				{
					permission.EnableAll();
				}
			});
		}

		/// <summary>
		/// Disables all permissions together with their child permissions.
		/// </summary>
		/// <returns>The same instance of <see cref="GroupPermissionsChangeset"/>.</returns>
		public GroupPermissionsChangeset DisableAll()
		{
			return Do(permissions =>
			{
				foreach (GenericPermission permission in permissions)
				{
					permission.DisableAll();
				}
			});
		}

		internal void Execute(List<GenericPermission> permissions)
		{
			foreach (var action in _actions)
			{
				action.Invoke(permissions);
			}
		}
	}
}
