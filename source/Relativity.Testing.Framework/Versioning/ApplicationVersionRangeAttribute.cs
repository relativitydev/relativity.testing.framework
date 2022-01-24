using System;

namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Specifies the Relativity Application version range of class for test.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class ApplicationVersionRangeAttribute : VersionRangeAttribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationVersionRangeAttribute"/> class.
		/// </summary>
		/// <param name="rapGuid">The Relativity Application Guid.</param>
		/// <param name="versionRange">The version range.</param>
		public ApplicationVersionRangeAttribute(string rapGuid, string versionRange)
			: base(versionRange)
		{
			if (Guid.TryParse(rapGuid, out Guid appGuid))
			{
				ApplicationGuid = appGuid;
			}
			else
			{
				throw new ArgumentException($"You must use the Relativity Application Guid with {typeof(ApplicationVersionRangeAttribute)}.");
			}
		}

		/// <summary>
		/// Gets the Guid for the Relativity Application.
		/// </summary>
		public Guid ApplicationGuid { get; }
	}
}
