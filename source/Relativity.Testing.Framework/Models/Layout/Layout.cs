using System.Collections.Generic;
using Newtonsoft.Json;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a Layout.
	/// </summary>
	public class Layout : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the <see cref="NamedArtifact"/> identifier for the object type associated to the layout.
		/// </summary>
		public NamedArtifact ObjectType { get; set; }

		/// <summary>
		/// Gets or sets where the layout displays in the Layouts drop down list.
		/// </summary>
		public string Order { get; set; } = "9999";

		/// <summary>
		/// Gets or sets a value indicating whether the layout could be edited while another process is editing it.
		/// </summary>
		public bool OverwriteProtection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the layout support copy from previous document. It only applies for document layouts at workspace level.
		/// </summary>
		public bool AllowCopyFromPrevious { get; set; }

		/// <summary>
		/// Gets or sets a list of identifiers of associated Relativity Applications for the layout.
		/// </summary>
		public List<NamedArtifact> RelativityApplications { get; set; } = new List<NamedArtifact>();

		/// <summary>
		///  Gets or sets  <see cref="NamedArtifactWithGuids"/> identifier for the user who owns the layout.
		/// </summary>
		[JsonProperty("Owner", NullValueHandling = NullValueHandling.Ignore)]
		public NamedArtifactWithGuids Owner { get; set; }
	}
}
