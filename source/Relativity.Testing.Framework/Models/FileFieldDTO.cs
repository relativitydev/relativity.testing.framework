using System;
using System.IO;
using Newtonsoft.Json;
using Relativity.Testing.Framework.Models.Fields;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents model for operations on File Field.
	/// </summary>
	public class FileFieldDTO
	{
		/// <summary>
		/// Gets or sets field that is associated with the file. Should have ArtifactId or Name.
		/// </summary>
		public FileField Field { get; set; }

		/// <summary>
		/// Gets or sets a reference to the object that contains or will contain the file.
		/// Should have ArtifactId set.
		/// </summary>
		public Artifact ObjectRef { get; set; }

		/// <summary>
		/// Gets or sets the name of the file.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Gets or sets the filestream of the field file.
		/// </summary>
		[JsonIgnore]
		public Stream FileStream { get; set; }

		/// <summary>
		/// Gets or sets the GUID used to identify the uploaded file in temprorary storage.
		/// </summary>
		public Guid? UploadedFileGuid { get; set; }
	}
}
