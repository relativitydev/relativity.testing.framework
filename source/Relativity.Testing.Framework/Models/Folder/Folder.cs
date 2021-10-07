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
		/// Gets a value indicating whether access control list is inhetited.
		/// </summary>
		public bool AccessControlListIsInherited { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether folder has children (subfolders).
		/// </summary>
		public bool HasChildren { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether the folder is selected.
		/// </summary>
		public bool Selected { get; internal set; }

		/// <summary>
		/// Gets the folder Permissions.
		/// </summary>
		public FolderPermission Permissions { get; internal set; }

		/// <summary>
		/// Gets folder chidren (subfolders).
		/// </summary>
		public List<Folder> Children { get; internal set; }

		/// <summary>
		/// Gets the date time of folder creation.
		/// </summary>
		public DateTime SystemCreatedOn { get; internal set; }

		/// <summary>
		/// Gets the date time of folder last modification.
		/// </summary>
		public DateTime SystemLastModifiedOn { get; internal set; }
	}
}
