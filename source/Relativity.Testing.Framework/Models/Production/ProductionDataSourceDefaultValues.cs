namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a Production Data Source.
	/// </summary>
	public class ProductionDataSourceDefaultValues
	{
		/// <summary>
		/// Gets or sets whether to use an image placeholder.
		/// </summary>
		public DefaultFieldValue<NamedArtifact> UseImagePlaceholder { get; set; }

		/// <summary>
		/// Gets or sets whether to burn redactions.
		/// </summary>
		public DefaultFieldValue<bool> BurnRedactions { get; set; }
	}
}
