namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Represents the service that resolves the version of Relativity instance.
	/// </summary>
	public interface IRelativityInstanceVersionResolveService
	{
		/// <summary>
		/// Gets the version string.
		/// </summary>
		/// <returns>The version string.</returns>
		string GetVersion();
	}
}
