using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a tab.
	/// </summary>
	public class Tab : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the order of the Tab.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the identifier for object type of the Tab.
		/// </summary>
		public NamedArtifact ObjectType { get; set; }

		/// <summary>
		/// Gets or sets the link for the Tab.
		/// </summary>
		public string Link { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether flag is default.
		/// </summary>
		public bool IsDefault { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether flag of the Tab is visible.
		/// </summary>
		public bool IsVisible { get; set; }

		/// <summary>
		/// Gets or sets a list of identifiers of associated Relativity Applications for the Tab.
		/// </summary>
		public List<NamedArtifact> RelativityApplications { get; set; } = new List<NamedArtifact>();

		/// <summary>
		/// Gets or sets the link type of the Tab.
		/// </summary>
		public TabLinkType LinkType { get; set; } = TabLinkType.Object;

		/// <summary>
		/// Gets or sets the identifier for parent of the Tab.
		/// </summary>
		public Artifact Parent { get; set; }
	}
}
