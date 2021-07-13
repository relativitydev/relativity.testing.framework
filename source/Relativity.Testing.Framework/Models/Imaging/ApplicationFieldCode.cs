using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Contains information regarding how to handle certain application fields in Imaging Sets.
	/// </summary>
	public class ApplicationFieldCode : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the field code available in a specific application, such as Microsoft Word, Excel, or Visio.
		/// </summary>
		public string FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the option identifying the application associated with a field code.
		/// </summary>
		public ApplicationType Application { get; set; }

		/// <summary>
		/// Gets or sets the option controlling whether the field code is displayed, replaced with a Relativity application field code, or some other action is taken.
		/// </summary>
		public ApplicationFieldCodeOption Option { get; set; }

		/// <summary>
		/// Gets or sets the Relativity field defined for the application field code.
		/// </summary>
		public NamedArtifactWithGuids RelativityField { get; set; }

		/// <summary>
		/// Gets or sets the collection of ImagingProfles linked to the current ApplicationFieldCode instance.
		/// </summary>
		public IEnumerable<NamedArtifact> ImagingProfiles { get; set; }
	}
}
