using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Object representing a request body for the LayoutBuilderManager's ReadSingleAsync endpoint.
	/// </summary>
	public class ReadSingleAsyncRequest
	{
		/// <summary>
		/// Gets or sets the artifact id of the workspace.
		/// </summary>
		[FieldName("workspaceID")]
		public int WorkspaceID { get; set; }

		/// <summary>
		/// Gets or sets the artifact id of the layout.
		/// </summary>
		public int LayoutID { get; set; }
	}
}
