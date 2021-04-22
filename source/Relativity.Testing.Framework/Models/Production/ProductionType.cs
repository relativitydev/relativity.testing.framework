namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines valid values for Relativity production types.
	/// </summary>
	public enum ProductionType
	{
		/// <summary>
		/// Produces images only.
		/// </summary>
		ImagesOnly = 0,

		/// <summary>
		/// Produces natives only.
		/// </summary>
		NativesOnly = 1,

		/// <summary>
		/// Produces images and natives.
		/// </summary>
		ImagesAndNatives = 2,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
