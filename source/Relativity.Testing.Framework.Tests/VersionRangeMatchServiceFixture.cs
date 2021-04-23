using NUnit.Framework;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Tests
{
	[TestFixture]
	[TestOf(typeof(VersionRangeMatchService))]
	public class VersionRangeMatchServiceFixture
	{
		private VersionRangeMatchService _sut;

		[SetUp]
		public void SetUp()
		{
			_sut = new VersionRangeMatchService();
		}

		[TestCase("10.3.0", "x", ExpectedResult = true)]
		[TestCase("10.3.0.0", "x", ExpectedResult = true)]
		[TestCase("10.3.0.0", ">= 10.3", ExpectedResult = true)]
		[TestCase("10.3.0.0", "> 10.3", ExpectedResult = false)]
		[TestCase("10.3.0.0", "~10", ExpectedResult = true)]
		[TestCase("10.3.0.0", "~11", ExpectedResult = false)]
		[TestCase("10.3.0.0", ">=10.0 <=10.3", ExpectedResult = true)]
		[TestCase("10.3.0.0", ">=10.0 <=10.2", ExpectedResult = false)]
		[TestCase("10.3.0.0", "10.x", ExpectedResult = true)]
		[TestCase("10.3.0.0", "10.1 || 10.3", ExpectedResult = true)]
		[TestCase("10.3.0.0", "10.1 || 10.4", ExpectedResult = false)]
		public bool VersionRangeMatchService_IsVersionInRange(string version, string range)
		{
			return _sut.IsVersionInRange(version, range);
		}
	}
}
