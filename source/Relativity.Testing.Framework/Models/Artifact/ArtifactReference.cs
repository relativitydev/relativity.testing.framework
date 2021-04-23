using Newtonsoft.Json;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity artifact reference object.
	/// </summary>
	public class ArtifactReference
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ArtifactReference"/> class.
		/// </summary>
		public ArtifactReference()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArtifactReference"/> class.
		/// </summary>
		/// <param name="artifactID">The artifact ID.</param>
		public ArtifactReference(int artifactID)
		{
			ArtifactID = artifactID;
		}

		/// <summary>
		/// Gets or sets the artifact ID.
		/// </summary>
		[JsonProperty("Artifact ID")]
		public int ArtifactID { get; set; }

		public static implicit operator Artifact(ArtifactReference artifactReference)
		{
			return new Artifact { ArtifactID = artifactReference.ArtifactID };
		}
	}
}
