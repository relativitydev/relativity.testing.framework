using System;

namespace Relativity.Testing.Framework.Versioning
{
	/// <summary>
	/// Specifies the Relativity instance version range of class or test.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class VersionRangeAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="VersionRangeAttribute"/> class.
		/// </summary>
		/// <param name="versionRange">The version range.</param>
		public VersionRangeAttribute(string versionRange)
		{
			VersionRange = versionRange;
		}

		/// <summary>
		/// Gets the version range.
		/// </summary>
		public string VersionRange { get; }
	}
}
