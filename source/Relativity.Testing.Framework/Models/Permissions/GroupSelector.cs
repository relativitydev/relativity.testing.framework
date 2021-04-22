using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the selector of enabled/disabled groups for an entity.
	/// </summary>
	public class GroupSelector
	{
		/// <summary>
		/// Gets or sets the collection of disabled groups.
		/// </summary>
		public List<NamedArtifact> DisabledGroups { get; set; }

		/// <summary>
		/// Gets or sets the collection of enabled groups.
		/// </summary>
		public List<NamedArtifact> EnabledGroups { get; set; }

		/// <summary>
		/// Gets or sets last modified timestamp.
		/// </summary>
		public DateTime LastModified { get; set; }
	}
}
