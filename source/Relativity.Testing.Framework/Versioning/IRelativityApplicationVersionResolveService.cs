using System;

namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Represents the service that resolves the version of a Relativity Application.
	/// </summary>
	public interface IRelativityApplicationVersionResolveService
	{
		/// <summary>
		/// Gets the RAP version.
		/// </summary>
		/// <param name="appVersionInfo">Object containing identifying info for the Relativity Application and version range.</param>
		/// <returns>Current version of the RAP installed on Relativity.</returns>
		string GetVersion(ApplicationVersionRangeAttribute appVersionInfo);

		/// <summary>
		/// Gets the RAP version.
		/// </summary>
		/// <param name="rapGuid">The RAP Guid.</param>
		/// <returns>Current version of the RAP installed on Relativity.</returns>
		string GetVersion(Guid rapGuid);
	}
}
