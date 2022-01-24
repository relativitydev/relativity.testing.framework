using System;

namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Represents the service that resolves the version for either Relativity or a RAP.
	/// </summary>
	public interface IVersionResolveService
	{
		/// <summary>
		/// Gets the target version that is used to resolve a strategy object. Defaults to RelativityInstance version.
		/// </summary>
		/// <param name="t">The type of object that needs to be resolved.</param>
		/// <returns>Target version needed for resolving a type (e.g. Relativity Instance version or RAP version).</returns>
		public string GetTargetVersion(Type t);

		/// <summary>
		/// Gets the target version that is used to resolve a strategy object.
		/// </summary>
		/// <param name="t">The type of object that needs to be resolved.</param>
		/// <param name="defaultVersion">Default vaule to return.</param>
		/// <returns>Target version needed for resolving a type (e.g. Relativity Instance version or RAP version).</returns>
		public string GetTargetVersion(Type t, string defaultVersion);
	}
}
