using Moq;
using NUnit.Framework;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Tests.Versioning
{
	[TestFixture]
	[TestOf(typeof(VersionResolveServiceFixture))]
	public class VersionResolveServiceFixture
	{
		private const string _TEST_APP_VERSION = "3.0.0";
		private const string _DEFAULT_VERSION = "1.0.0";
		private IVersionResolveService _sut;

		[OneTimeSetUp]
		public void OTSetup()
		{
			Mock<IRelativityFacade> facadeMock = new Mock<IRelativityFacade>();
			facadeMock.Setup(m => m.RelativityInstanceVersion).Returns(_DEFAULT_VERSION);

			Mock<IRelativityApplicationVersionResolveService> rapServiceMock = new Mock<IRelativityApplicationVersionResolveService>();
			rapServiceMock.Setup(m => m.GetVersion(It.IsAny<ApplicationVersionRangeAttribute>())).Returns(_TEST_APP_VERSION);

			_sut = new VersionResolveService(facadeMock.Object, rapServiceMock.Object);
		}

		[Test]
		public void GetTargetVersion_ReturnsDefaultValue_WhenTypeIsVersionRange()
		{
			string targetVersion = _sut.GetTargetVersion(typeof(TestVersionAttribute));

			Assert.AreEqual(_DEFAULT_VERSION, targetVersion);
		}

		[Test]
		public void GetTargetVersion_ReturnsValueFromService_WhenTypeIsApplicationVersionRange()
		{
			string targetVersion = _sut.GetTargetVersion(typeof(TestApplicationVersionAttribute));

			Assert.AreEqual(_TEST_APP_VERSION, targetVersion);
		}

#pragma warning disable CA1812 // VersionResolveServiceFixture.TestApplicationVersionAttribute is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).
		[VersionRange(">=2.0.0")]
		private class TestVersionAttribute
		{
		}

		[ApplicationVersionRange("227ee259-6ce6-4b9c-bbdd-fc3c0b78f275", ">=2.0.0")]
		private class TestApplicationVersionAttribute
		{
		}
#pragma warning restore CA1812 // VersionResolveServiceFixture.TestApplicationVersionAttribute is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).
	}
}
