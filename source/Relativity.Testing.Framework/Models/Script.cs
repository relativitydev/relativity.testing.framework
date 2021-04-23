using System.Collections.Generic;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a script model.
	/// </summary>
	[ObjectTypeName("Relativity Script")]
	public class Script : NamedArtifact
	{
		/// <summary>
		/// Gets or sets a string used to define the script type.
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// Gets or sets the description of the script.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets a value indicating whether the script is imported from the admin script library.
		/// </summary>
		public bool IsLinkedScript { get; private set; }

		/// <summary>
		/// Gets the value used to lock a script within Relativity. A locked script cannot be modified.
		/// </summary>
		public string Key { get; private set; }

		/// <summary>
		/// Gets a custom page URL that can be used to create new tabs for displaying scripts of the same category.
		/// </summary>
		public string ReportGroupURL { get; private set; }

		/// <summary>
		/// Gets or sets the body of the script that will be executed. It must include the name property.
		/// </summary>
		public string ScriptBody { get; set; }

		/// <summary>
		/// Gets the internal script version.
		/// </summary>
		public string Version { get; private set; }

		/// <summary>
		/// Gets or sets a list of identifiers of associated Relativity Applications for the script.
		/// </summary>
		public List<Artifact> RelativityApplications { get; set; }
	}
}
