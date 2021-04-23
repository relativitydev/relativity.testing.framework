using SemVer;

namespace Relativity.Testing.Framework.Versioning
{
	internal class VersionRangeMatchService : IVersionRangeMatchService
	{
		public bool IsVersionInRange(string version, string range)
		{
			Range rangeObject = new Range(range);
			Version versionObject = new Version(version, loose: true).BaseVersion();

			return rangeObject.IsSatisfied(versionObject);
		}
	}
}
