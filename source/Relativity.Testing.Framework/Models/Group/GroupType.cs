namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the different values for the available types of groups.
	/// </summary>
	public enum GroupType
	{
		/// <summary>
		/// The system admin type.
		/// </summary>
		SystemAdmin = 1,

		/// <summary>
		/// The system group type.
		/// </summary>
		SystemGroup,

		/// <summary>
		/// The personal type.
		/// </summary>
		Personal,

		/// <summary>
		/// The everyone type.
		/// </summary>
		Everyone,

		/// <summary>
		/// The workspace admin type.
		/// </summary>
		WorkspaceAdmin,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
