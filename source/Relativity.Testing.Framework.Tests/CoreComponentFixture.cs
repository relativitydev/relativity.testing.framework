using System.Collections.Generic;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Relativity.Testing.Framework.Configuration;

namespace Relativity.Testing.Framework.Tests
{
	[TestFixture]
	[TestOf(typeof(CoreComponent))]
	public class CoreComponentFixture
	{
		private IRelativityFacade _facade;

		[SetUp]
		public void SetUp()
		{
			_facade = new RelativityFacade();
		}

		[TearDown]
		public void TearDown()
		{
			_facade.Dispose();
		}

		[Test]
		public void RelyOn_Default()
		{
			_facade.RelyOn<CoreComponent>();

			_facade.Resolve<IConfigurationService>().
				Should().NotBeNull();
		}

		[Test]
		public void RelyOn_WithConfigurationRootSet()
		{
			IConfigurationRoot configurationRoot = new ConfigurationBuilder()
				.AddInMemoryCollection(new Dictionary<string, string>
				{
					["somekey"] = "somevalue"
				}).
				Build();

			_facade.RelyOn(new CoreComponent
			{
				ConfigurationRoot = configurationRoot
			});

			_facade.Resolve<IConfigurationService>().
				GetValue("somekey").Should().Be("somevalue");
		}
	}
}
