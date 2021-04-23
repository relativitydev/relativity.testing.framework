using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the object field artifact id of the property.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class FieldArtifactIdAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FieldArtifactIdAttribute"/> class.
		/// </summary>
		/// <param name="artifactId">The artifact id of the field.</param>
		public FieldArtifactIdAttribute(int artifactId)
		{
			ArtifactId = artifactId;
		}

		/// <summary>
		/// Gets the artifact id.
		/// </summary>
		public int ArtifactId { get; }
	}
}
