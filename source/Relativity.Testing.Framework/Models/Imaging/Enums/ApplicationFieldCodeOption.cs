namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies how an application field code is handled during Imaging processing/>.
	/// </summary>
	public enum ApplicationFieldCodeOption
	{
		/// <summary>
		/// ApplicationFieldCodeOption is not set.
		/// </summary>
		NotSet = 0,

		/// <summary>
		/// Uses the default rendering behavior for a specific document type.
		/// </summary>
		DocumentDefault = 1,

		/// <summary>
		/// Renders the field code in the document.
		/// </summary>
		ShowFieldCode = 2,

		/// <summary>
		/// Doesn’t render any information for the field code.
		/// </summary>
		ShowNothing = 3,

		/// <summary>
		/// Replaces the default field code with a Relativity application field code.
		/// </summary>
		ReplaceWithRelativityField = 4,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
