namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the possible strategies for overwriting documents when doing an import.
	/// </summary>
	public enum DocumentOverwriteMode
	{
		Append = 0,
		Overlay = 1,
		AppendOverlay = 2,
		Unknown
	}
}
