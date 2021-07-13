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
		public List<Artifact> RelativityApplications { get; set; } = new List<Artifact>();

		/// <summary>
		/// Gets or sets the link type of the Tab.
		/// </summary>
		public TabLinkType LinkType { get; set; } = TabLinkType.Object;

		/// <summary>
		/// Gets or sets the identifier for parent of the Tab.
		/// </summary>
		public Artifact Parent { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the tab should be displayed in the sidebar.
		/// </summary>
		public bool IsShownInSidebar { get; set; }

		/// <summary>
		/// Gets or sets the string identifier for the icon displayed when the tab is listed in the sidebar.
		/// </summary>
		public TabIconIdentifier IconIdentifier { get; set; }

		/// <summary>
		/// Fills the required properties that should be programatically set if left blank.
		/// </summary>
		/// <returns>The same <see cref="Tab"/>instance.</returns>
		public Tab FillRequiredProperties()
		{
			if (string.IsNullOrEmpty(Name))
			{
				Name = Randomizer.GetString("AT_");
			}

			return this;
		}
	}
}
