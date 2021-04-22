using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a Relativity Object Type used for data transfer.
	/// </summary>
	public class ObjectType : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the identifier for the parent object type.
		/// </summary>
		public ObjectType ParentObjectType { get; set; }

		/// <summary>
		/// Gets the value used as an identifier for an object type supported by Relativity.
		/// </summary>
		[FieldName("Artifact Type ID")]
		public int ArtifactTypeID { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether it is system object type.
		/// </summary>
		public bool System { get; internal set; }

		/// <summary>
		/// Gets the value used as an identifier for an object type supported by Relativity.
		/// </summary>
		[FieldName("Parent ArtifactTypeID")]
		public int ParentArtifactTypeID { get; internal set; }

		/// <summary>
		/// Gets or sets a value indicating whether Relativity will capture field values on instance delete.
		/// </summary>
		[FieldName("Snapshot Auditing Enabled On Delete")]
		public bool EnableSnapshotAuditingOnDelete { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether whether pivot funtionality is enabled.
		/// </summary>
		public bool Pivot { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether sampling funtionality is enabled.
		/// </summary>
		public bool Sampling { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether users can save lists of this object instances.
		/// </summary>
		public bool PersistentLists { get; set; }

		/// <summary>
		/// Gets or sets a nullable Boolean value indicating whether or not Layouts for object instances of this type will be shown in Relativity Forms.
		/// </summary>
		public bool? UseRelativityForms { get; set; }

		/// <summary>
		/// Gets or sets the array of Relativity applications represented by ObjectIdentifier objects, which contain the Artifact ID and GUIDs for an application.
		/// </summary>
		public NamedArtifact[] RelativityApplications { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether instances of this object type will be copied when the workspace is used as a template for another.
		/// </summary>
		[FieldName("Copy Instances On Workspace Creation")]
		public bool CopyInstanceOnWorkspaceCreation { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether instances of this object type will be copied when the parent of those instances are copied.
		/// </summary>
		[FieldName("Copy Instances on Parent Copy")]
		public bool CopyInstanceOnParentCopy { get; set; }
	}
}
