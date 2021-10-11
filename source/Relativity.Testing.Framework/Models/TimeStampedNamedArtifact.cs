using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The representation of a TimeStampedNamedArtifact.
	/// </summary>
	public class TimeStampedNamedArtifact : NamedArtifact
	{
		/// <summary>
		/// Gets or sets who the artifact is created by.
		/// </summary>
		public NamedArtifact CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="DateTime"/> when the artifact was created.
		/// </summary>
		public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets who last modified the object.
		/// </summary>
		public NamedArtifact LastModifiedBy { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="DateTime"/> when the artifact was last modified.
		/// </summary>
		public DateTime LastModifiedOn { get; set; }
	}
}
