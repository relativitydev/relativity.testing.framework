using System;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a Relativity Workspace used for data transfer.
	/// </summary>
	public class Workspace : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the client.
		/// </summary>
		[FieldName("Client Name")]
		public NamedArtifact Client { get; set; }

		/// <summary>
		/// Gets or sets the matter.
		/// </summary>
		[FieldName("Matter Name")]
		public NamedArtifact Matter { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// Gets or sets the SQL full text language.
		/// </summary>
		public SqlFullTextLanguage SqlFullTextLanguage { get; set; }

		/// <summary>
		/// Gets or sets the SQL server.
		/// </summary>
		public NamedArtifact SqlServer { get; set; }

		/// <summary>
		/// Gets or sets the production resrictions.
		/// </summary>
		public NamedArtifact ProductionRestrictions { get; set; }

		/// <summary>
		/// Gets or sets the workspace admin group.
		/// </summary>
		public Group WorkspaceAdminGroup { get; set; }

		/// <summary>
		/// Gets or sets the resource pool.
		/// </summary>
		public NamedArtifact ResourcePool { get; set; }

		/// <summary>
		/// Gets or sets the default file repository.
		/// </summary>
		[FieldName("Default File Location")]
		public NamedArtifact DefaultFileRepository { get; set; }

		/// <summary>
		/// Gets or sets the data grid file repository.
		/// </summary>
		[FieldName("Default Grid File Location")]
		public NamedArtifact DataGridFileRepository { get; set; }

		/// <summary>
		/// Gets or sets the default cache location.
		/// </summary>
		public NamedArtifact DefaultCacheLocation { get; set; }

		/// <summary>
		/// Gets or sets the database location.
		/// </summary>
		public NamedArtifact DatabaseLocation { get; set; }

		/// <summary>
		/// Gets or sets the download handler URL.
		/// </summary>
		[FieldName("Download Handler URL")]
		public string DownloadHandlerUrl { get; set; }

		/// <summary>
		/// Gets or sets the template workspace.
		/// </summary>
		public NamedArtifact TemplateWorkspace { get; set; }

		/// <summary>
		/// Gets or sets the date and time when the workspace was created.
		/// </summary>
		public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the keywords.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		public string Notes { get; set; } = string.Empty;
	}
}
