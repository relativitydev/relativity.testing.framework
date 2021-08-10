namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity matter object with extended metadata.
	/// </summary>
	public class MatterWithExtendedMetadata : Matter
	{
		/// <summary>
		/// Gets or sets additional information available as extended metadata.
		/// </summary>
		public Meta Meta { get; set; }
	}
}
