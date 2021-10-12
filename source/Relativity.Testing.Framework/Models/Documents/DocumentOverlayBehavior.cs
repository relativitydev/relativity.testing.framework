namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the possible strategies for overlaying documents when doing an import.
	/// </summary>
	public enum DocumentOverlayBehavior
	{
		UseRelativityDefaults = 0,
		MergeAll = 1,
		ReplaceAll = 2,
		Unknown
	}
}
