using System;
using Castle.MicroKernel;
using Moq;
using NUnit.Framework;
using Relativity.Testing.Framework.Tests.Versioning.TestVersionAttributeClasses;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Tests.Versioning
{
	[TestFixture]
	[TestOf(typeof(VersionResolveServiceFixture))]
	public class VersionResolveServiceFixture
	{
		private const string _TEST_APP_VERSION = "3.0.0";
		private const string _DEFAULT_VERSION = "1.0.0";

		private Mock<IRelativityFacade> _facadeMock;
		private Mock<IRelativityApplicationVersionResolveService> _rapServiceMock;
		private Mock<IKernel> _kernelMock;

		[SetUp]
		public void Setup()
		{
			_facadeMock = new Mock<IRelativityFacade>();
			_facadeMock.Setup(m => m.RelativityInstanceVersion).Returns(_DEFAULT_VERSION);

			_rapServiceMock = new Mock<IRelativityApplicationVersionResolveService>();
			_rapServiceMock.Setup(m => m.GetVersion(It.IsAny<ApplicationVersionRangeAttribute>())).Returns(_TEST_APP_VERSION);

			_kernelMock = new Mock<IKernel>();
		}

		[Test]
		public void GetTargetVersion_ReturnsDefaultValue_WhenTypeIsVersionRange()
		{
			_kernelMock = new Mock<IKernel>();
			_kernelMock.Setup(m => m.ResolveAll(It.IsAny<Type>())).Returns(new object[]
			{
				new TestVersionAttributeStrategyV1()
			});

			VersionResolveService sut = new VersionResolveService(_kernelMock.Object, _facadeMock.Object, _rapServiceMock.Object);

			string targetVersion = sut.GetTargetVersion(typeof(TestVersionAttributeStrategyV1), _DEFAULT_VERSION);

			Assert.AreEqual(_DEFAULT_VERSION, targetVersion);
		}

		[Test]
		public void GetTargetVersion_ReturnsValueFromService_WhenTypeIsApplicationVersionRange()
		{
			_kernelMock = new Mock<IKernel>();
			_kernelMock.Setup(m => m.ResolveAll(It.IsAny<Type>())).Returns(new object[]
			{
				new TestApplicationVersionAttributeStrategyV1()
			});

			VersionResolveService sut = new VersionResolveService(_kernelMock.Object, _facadeMock.Object, _rapServiceMock.Object);

			string targetVersion = sut.GetTargetVersion(typeof(TestApplicationVersionAttributeStrategyV1), _DEFAULT_VERSION);

			Assert.AreEqual(_TEST_APP_VERSION, targetVersion);
		}
	}
}
