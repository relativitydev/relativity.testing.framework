using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity item level security object.
	/// </summary>
	public class ItemLevelSecurity : Artifact
	{
		/// <summary>
		/// Gets or sets a value indicating whether edit this item turned on.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets last modified timestamp.
		/// </summary>
		public DateTime LastModified { get; set; }
	}
}
