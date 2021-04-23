namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a Relativity Server used for data transfer.
	/// </summary>
	public class ResourceServer : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		public ResourceServerType Type { get; set; }

		/// <summary>
		/// Gets the status.
		/// </summary>
		public Choice Status { get; internal set; }
	}
}
