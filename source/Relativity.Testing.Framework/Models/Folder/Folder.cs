using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models.Folder
{
	/// <summary>
	/// Represents the Relativity Folder object.
	/// </summary>
	public class Folder : NamedArtifact
	{
		/// <summary>
		/// Gets or sets parent of the folder.
		/// </summary>
		public NamedArtifact ParentFolder { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether access control list is inhetited.
		/// </summary>
		public bool AccessControlListIsInherited { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether folder has children (subfolders).
		/// </summary>
		public bool HasChildren { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the folder is selected.
		/// </summary>
		public bool Selected { get; set; }

		/// <summary>
		/// Gets or sets the folder Permissions.
		/// </summary>
		public FolderPermission Permissions { get; set; }

		/// <summary>
		/// Gets or sets folder chidren (subfolders).
		/// </summary>
		public List<Folder> Children { get; set; }

		/// <summary>
		/// Gets or sets the date time of folder creation.
		/// </summary>
		public DateTime SystemCreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the date time of folder last modification.
		/// </summary>
		public DateTime SystemLastModifiedOn { get; set; }
	}
}
