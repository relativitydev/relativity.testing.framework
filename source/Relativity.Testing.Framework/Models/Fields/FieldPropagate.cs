using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	public class FieldPropagate
	{
		/// <summary>
		/// Gets or sets a value indicating whether the application contains items that the current user doesn't have permission to access.
		/// </summary>
		public bool HasSecuredItems { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether an array of identifier objects for items that are accessible to the current user.
		/// </summary>
		public List<Artifact> ViewableItems { get; set; }
	}
}
