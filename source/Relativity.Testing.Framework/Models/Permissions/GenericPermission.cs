using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the generic permission.
	/// </summary>
	[DebuggerDisplay("{Name} Editable:{Editable} Selected:{Selected}")]
	public class GenericPermission
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this permission is editable.
		/// </summary>
		public bool Editable { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this permission is selected.
		/// </summary>
		public bool Selected { get; set; }

		/// <summary>
		/// Gets or sets the value (artifact ID).
		/// </summary>
		public int Value { get; set; }

		/// <summary>
		/// Gets or sets the child permissions.
		/// </summary>
		public List<GenericPermission> Children { get; set; } = new List<GenericPermission>();

		/// <summary>
		/// Enables this permission.
		/// </summary>
		public void Enable()
		{
			if (Editable)
			{
				Selected = true;
			}
		}

		/// <summary>
		/// Disables this permission.
		/// </summary>
		public void Disable()
		{
			if (Editable)
			{
				Selected = false;
			}
		}

		/// <summary>
		/// Enables this permission and all its child permissions.
		/// </summary>
		public void EnableAll()
		{
			SetSelectedToAll(true);
		}

		/// <summary>
		/// Disables this permission and all its child permissions.
		/// </summary>
		public void DisableAll()
		{
			SetSelectedToAll(false);
		}

		private void SetSelectedToAll(bool selected)
		{
			if (Editable)
			{
				Selected = selected;

				if (Children != null)
				{
					foreach (GenericPermission childPermission in Children)
					{
						childPermission.SetSelectedToAll(selected);
					}
				}
			}
		}

		/// <summary>
		/// Enables this permission and all its child permissions with particular names.
		/// </summary>
		/// <param name="childPermissionNames">The child permission names.</param>
		public void EnableWith(IEnumerable<string> childPermissionNames)
		{
			if (Editable)
			{
				Selected = true;
			}

			if (Children != null)
			{
				foreach (GenericPermission childPermission in Children.Where(x => childPermissionNames.Contains(x.Name)))
				{
					childPermission.Enable();
				}
			}
		}
	}
}
