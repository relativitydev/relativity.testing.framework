using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the library application object.
	/// </summary>
	public class LibraryApplication : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the version of application.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Gets or sets the RAP file name.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Gets or sets an array of GUIDs used to identify the library application.
		/// </summary>
		public Guid[] Guids { get; set; }

		/// <summary>
		/// Gets or sets different components that make up the application in JSON format.
		/// </summary>
		public string TreeView { get; set; }

		/// <summary>
		/// Gets or sets the date and time when the library application was added to Relativity.
		/// </summary>
		public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the date and time when the library application was most recently modified.
		/// </summary>
		public DateTime? LastModifiedOn { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="NamedArtifact"/> (ArtifactID and Name) of the user who created the library application.
		/// </summary>
		public NamedArtifact CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="NamedArtifact"/> (ArtifactID and Name) of the user who recently updated the library application.
		/// </summary>
		public NamedArtifact LastModifiedBy { get; set; }
	}
}
