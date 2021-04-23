namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the behavior of blank relational values <see cref="Field"/> on import.
	/// </summary>
	public enum FieldImportBehavior
	{
		/// <summary>
		/// Has no value.
		/// </summary>
		None,

		/// <summary>
		/// Leave blank values unchanged.
		/// </summary>
		LeaveBlankValuesUnchanged,

		/// <summary>
		/// Replace blank values with Identifier.
		/// </summary>
		ReplaceBlankValuesWithIdentifier,

		/// <summary>
		/// Object field contains Artifact ID.
		/// </summary>
		ObjectFieldContainsArtifactId,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
