namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies what to do about the native files when importing.
	/// </summary>
	public enum NativeFileCopyMode
	{
		/// <summary>
		/// Import documents without their native files.
		/// </summary>
		DoNotImportNativeFiles = 0,

		/// <summary>
		/// Copy native files into the workspace.
		/// </summary>
		CopyFiles = 1,

		/// <summary>
		/// Link to the native files but do not copy them.
		/// </summary>
		SetFileLinks = 2,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
