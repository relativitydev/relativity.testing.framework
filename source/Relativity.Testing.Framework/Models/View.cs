using System;
using System.Collections.Generic;
using System.Diagnostics;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the view object type.
	/// </summary>
	[DebuggerDisplay("{ArtifactID} {Name}")]
	public class View : NamedArtifact, IFillsRequiredProperties<View>
	{
		/// <summary>
		/// Gets or sets the artifact type ID.
		/// </summary>
		[FieldName("ArtifactTypeID")]
		public int ArtifactTypeId { get; set; }

		/// <summary>
		/// Gets or sets the artifact type information for the object that the view is assigned to.
		/// </summary>
		public NamedArtifact ObjectType { get; set; }

		/// <summary>
		/// Gets or sets the position of the view in the view drop-down list.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the view is visible in the view drop-down list.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool VisibleInDropdown { get; set; }

		/// <summary>
		/// Gets or sets a string parameter used to optimize the view.
		/// </summary>
		public string QueryHint { get; set; }

		/// <summary>
		/// Gets or sets the relativity applications associated with the view.
		/// </summary>
		public List<NamedArtifact> RelativityApplications { get; set; }

		/// <summary>
		/// Gets or sets the fields to be included in the view result set.
		/// This fields are specified as a collection of Fields objects.
		/// You must include at least one field in the view.
		/// </summary>
		public NamedArtifact[] Fields { get; set; }

		/// <summary>
		/// Gets or sets the user who owns the view.
		/// The default value is <see langword="Public"/>.
		/// </summary>
		public NamedArtifact Owner { get; set; }

		/// <summary>
		/// Gets or sets a dashboard object contains properties that include the Artifact ID of the dashboard, its name, and a list of GUIDs associated with it.
		/// </summary>
		public NamedArtifact Dashboard { get; set; }

		/// <summary>
		/// Gets or sets the sort order for view results specified as a collection of Sort objects.
		/// This field indicates whether the results are sorted in ascending or descending order, identifies a field by Artifact ID and GUID, and specifies a sort order.
		/// </summary>
		public List<Sort> Sorts { get; set; }

		/// <summary>
		/// Gets or sets the search criteria specified as a CriteriaCollection object.
		/// This object contains the list of conditions specified in the query.
		/// </summary>
		public CriteriaCollection SearchCriteria { get; set; }

		/// <summary>
		/// Gets or sets group definition field artifactID associated with the view.
		/// </summary>
		[FieldName("GroupDefinitionFieldArtifactID")]
		public string GroupDefinitionFieldArtifactId { get; set; }

		/// <summary>
		/// Gets or sets the user who created the view. The user is identified with a name and Artifact ID.
		/// </summary>
		public NamedArtifact SystemCreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the date and time in UTC when the view was created.
		/// </summary>
		public DateTime? SystemCreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the user who last modified the view.
		/// </summary>
		public NamedArtifact SystemLastModifiedBy { get; set; }

		/// <summary>
		/// Gets or sets the date and time in UTC when the view was last modified.
		/// </summary>
		public DateTime? SystemLastModifiedOn { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the view is visible in the system.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool IsVisible { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the view is a system view.
		/// Relativity contains system views that are provided as part of the application by default.
		/// You can't edit all system views, such as the workspace system view.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool IsSystemView { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the view is used to display relational fields.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool IsRelationalFieldView { get; set; }

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="View"/> object instance.</returns>
		public View FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = Randomizer.GetString("AT_");
			}

			if (ArtifactTypeId == 0)
			{
				ArtifactTypeId = 10;
			}

			if (ObjectType == null)
			{
				ObjectType = new NamedArtifact { Name = "Document" };
			}

			if (Order == 0)
			{
				Order = Randomizer.GetInt(101, 99999);
			}

			return this;
		}
	}
}
