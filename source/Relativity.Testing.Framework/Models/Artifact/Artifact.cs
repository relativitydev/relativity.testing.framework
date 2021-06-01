namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity artifact object.
	/// </summary>
	public class Artifact
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Artifact"/> class.
		/// </summary>
		public Artifact()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Artifact"/> class.
		/// </summary>
		/// <param name="artifactID">The artifact ID.</param>
		public Artifact(int artifactID)
		{
			ArtifactID = artifactID;
		}

		/// <summary>
		/// Gets or sets the artifact ID.
		/// </summary>
		public int ArtifactID { get; set; }

		/// <summary>
		/// Gets or sets the artifact type ID.
		/// </summary>
		public virtual int ArtifactTypeID { get; set; }
	}
}
