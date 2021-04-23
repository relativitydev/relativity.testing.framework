namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Search Type.
	/// </summary>
	public enum ScopeType
	{
		/// <summary>
		/// Search the entire case.
		/// </summary>
		EntireCase = 0,

		/// <summary>
		/// Search folders.
		/// </summary>
		Folders = 1,

		/// <summary>
		/// Search subfolders.
		/// </summary>
		Subfolders = 2,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
