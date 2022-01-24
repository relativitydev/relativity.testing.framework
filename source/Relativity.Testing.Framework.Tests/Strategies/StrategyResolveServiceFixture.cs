using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Relativity.Testing.Framework.Strategies;
using Relativity.Testing.Framework.Tests.Versioning.TestVersionAttributeClasses;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Tests.Strategies
{
	[TestFixture]
	[TestOf(typeof(StrategyResolveServiceFixture))]
	public class StrategyResolveServiceFixture
	{
		private IStrategyResolveService _sut;

		[OneTimeSetUp]
		public void OTSetup()
		{
			_sut = new StrategyResolveService(new VersionRangeMatchService());
		}

		[Test]
		public void Resolve_ReturnsStrategy_BasedOnVersionRangeAttribute()
		{
			object[] strategies = new object[]
			{
				new TestVersionAttributeStrategyV1(),
				new TestVersionAttributeStrategyV2()
			};

			object resultV1 = _sut.Resolve(typeof(ITestVersionAttributeStrategy), strategies, "1.0.0");

			Assert.AreEqual(typeof(TestVersionAttributeStrategyV1), resultV1.GetType());

			object resultV2 = _sut.Resolve(typeof(ITestVersionAttributeStrategy), strategies, "2.0.0");

			Assert.AreEqual(typeof(TestVersionAttributeStrategyV2), resultV2.GetType());
		}

		[Test]
		public void Resolve_ReturnsStrategy_BasedOnApplicationVersionRangeAttribute()
		{
			object[] strategies = new object[]
			{
				new TestApplicationVersionAttributeStrategyV1(),
				new TestApplicationVersionAttributeStrategyV2()
			};

			object resultV1 = _sut.Resolve(typeof(ITestApplicationVersionAttributeStrategy), strategies, "1.0.0");

			Assert.AreEqual(typeof(TestApplicationVersionAttributeStrategyV1), resultV1.GetType());

			object resultV2 = _sut.Resolve(typeof(ITestApplicationVersionAttributeStrategy), strategies, "2.0.0");

			Assert.AreEqual(typeof(TestApplicationVersionAttributeStrategyV2), resultV2.GetType());
		}
	}
}
