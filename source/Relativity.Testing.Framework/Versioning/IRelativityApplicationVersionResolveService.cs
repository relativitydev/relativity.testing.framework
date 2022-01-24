namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Represents the service that resolves the version of a Relativity Application.
	/// </summary>
	public interface IRelativityApplicationVersionResolveService
	{
		/// <summary>
		/// Gets the Application version string.
		/// </summary>
		/// <param name="appVersionInfo">Object containing identifying info for the Relativity Application and version range.</param>
		/// <returns>Current version of the RAP installed on Relativity.</returns>
		string GetVersion(ApplicationVersionRangeAttribute appVersionInfo);
	}
}
