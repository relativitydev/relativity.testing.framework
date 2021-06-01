using System.Collections.Generic;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a Relativity Object Type used for data transfer.
	/// </summary>
	public class ObjectType : NamedArtifactWithGuids
	{
		/// <summary>
		/// Gets or sets the parent object type.
		/// </summary>
		public WrappedObjectType ParentObjectType { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether it is system object type.
		/// </summary>
		public bool IsSystem { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether it is dynamic object type.
		/// </summary>
		public bool IsDynamic { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether it is view enabled.
		/// </summary>
		public bool IsViewEnabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether Relativity will capture field values on instance delete.
		/// </summary>
		[FieldName("Snapshot Auditing Enabled On Delete")]
		public bool EnableSnapshotAuditingOnDelete { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether whether pivot funtionality is enabled.
		/// </summary>
		public bool PivotEnabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether sampling funtionality is enabled.
		/// </summary>
		public bool SamplingEnabled { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether users can save lists of this object instances.
		/// </summary>
		public bool PersistentListsEnabled { get; set; }

		/// <summary>
		/// Gets or sets the Relativity applications wrapped in DTO object.
		/// </summary>
		public WrappedRelativityApplications RelativityApplications { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether instances of this object type will be copied when the workspace is used as a template for another.
		/// </summary>
		[FieldName("Copy Instances On Workspace Creation")]
		public bool CopyInstancesOnCaseCreation { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether instances of this object type will be copied when the parent of those instances are copied.
		/// </summary>
		[FieldName("Copy Instances on Parent Copy")]
		public bool CopyInstancesOnParentCopy { get; set; }

		/// <summary>
		/// A representation of a WrappedRelativityApplications used for data transfer in ObjectType API.
		/// </summary>
		public class WrappedRelativityApplications
		{
			/// <summary>
			/// Gets or sets the array of Relativity applications represented by ObjectIdentifier objects, which contain the Artifact ID and Names for an application.
			/// </summary>
			public List<NamedArtifact> ViewableItems { get; set; }
		}

		/// <summary>
		/// A representation of a WrappedObjectType used for data transfer in ObjectType API.
		/// </summary>
		public class WrappedObjectType
		{
			/// <summary>
			/// Gets or sets a Relativity Object Type used for data transfer.
			/// </summary>
			public ObjectType Value { get; set; }
		}
	}
}
