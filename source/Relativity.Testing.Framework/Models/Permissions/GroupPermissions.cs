using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity group permissions.
	/// </summary>
	[DebuggerDisplay("ArtifactID:{ArtifactID} GroupId:{GroupID}")]
	public class GroupPermissions : Artifact
	{
		/// <summary>
		/// Gets or sets the group ID.
		/// </summary>
		public int GroupID { get; set; }

		/// <summary>
		/// Gets or sets the object permissions.
		/// </summary>
		public List<ObjectPermission> ObjectPermissions { get; set; } = new List<ObjectPermission>();

		/// <summary>
		/// Gets or sets the tab visibility permissions.
		/// </summary>
		public List<GenericPermission> TabVisibility { get; set; } = new List<GenericPermission>();

		/// <summary>
		/// Gets or sets the browser permissions.
		/// </summary>
		public List<GenericPermission> BrowserPermissions { get; set; } = new List<GenericPermission>();

		/// <summary>
		/// Gets or sets the mass action permissions.
		/// </summary>
		public List<GenericPermission> MassActionPermissions { get; set; } = new List<GenericPermission>();

		/// <summary>
		/// Gets or sets the admin permissions.
		/// </summary>
		public List<GenericPermission> AdminPermissions { get; set; } = new List<GenericPermission>();

		/// <summary>
		/// Gets or sets the last modified date/time.
		/// </summary>
		public DateTime LastModified { get; set; } = DateTime.MinValue;
	}
}
