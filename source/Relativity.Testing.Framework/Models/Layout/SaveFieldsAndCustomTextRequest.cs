using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Object representing a request body for the LayoutBuilderManager's SaveFieldsAndCustomText endpoint.
	/// </summary>
	public class SaveFieldsAndCustomTextRequest
	{
		/// <summary>
		/// Gets or sets the Artifact ID of the Workspace.
		/// </summary>
		public int AppId { get; set; }

		/// <summary>
		/// Gets or sets the Artifact ID of the Layout.
		/// </summary>
		public int LayoutId { get; set; }

		/// <summary>
		/// Gets or sets the fields to delete from the Layout.
		/// </summary>
		public List<FieldLayoutRelation> FieldsToDelete { get; set; } = new List<FieldLayoutRelation> { };

		/// <summary>
		/// Gets or sets the fields to add to or update on the Layout.
		/// </summary>
		public List<CategoryField> FieldsToTrack { get; set; } = new List<CategoryField> { };

		/// <summary>
		/// Gets or sets the custom text to add to or update on the Layout.
		/// </summary>
		public List<CategoryCustomText> CtToTrack { get; set; } = new List<CategoryCustomText> { };

		/// <summary>
		/// Gets or sets the IDs of the custom text to delete from the layout.
		/// </summary>
		public List<int> CtToDelete { get; set; } = new List<int> { };
	}
}
