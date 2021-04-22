namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Represents the service that determines whether the version is in the specified range.
	/// </summary>
	public interface IVersionRangeMatchService
	{
		/// <summary>
		/// Determines whether the version is in the specified range.
		/// </summary>
		/// <param name="version">The version.</param>
		/// <param name="range">The range.</param>
		/// <returns>
		/// <see langword="true"/> if the version in range; otherwise, <see langword="false"/>.
		/// </returns>
		bool IsVersionInRange(string version, string range);
	}
}
