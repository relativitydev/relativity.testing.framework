using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Models
{
	[TestFixture]
	[TestOf(typeof(Tab))]
	public class TabFixture
	{
		[Test]
		public void FillRequiredProperties_SetsNameIfNull()
		{
			Tab tab = new Tab();

			tab.FillRequiredProperties();

			tab.Name.Should().NotBeNullOrEmpty();
		}

		[Test]
		public void FillRequiredProperties_SetsNameIfEmpty()
		{
			Tab tab = new Tab
			{
				Name = string.Empty
			};

			tab.FillRequiredProperties();

			tab.Name.Should().NotBeNullOrEmpty();
		}

		[Test]
		public void FillRequiredProperties_SetsNameIfWhiteSpace()
		{
			Tab tab = new Tab
			{
				Name = " "
			};

			tab.FillRequiredProperties();

			tab.Name.Should().NotBeNullOrEmpty();
		}

		[Test]
		public void FillRequiredProperties_DoesNotSetNameIfAlreadySet()
		{
			string expectedName = "SomeTab";

			Tab tab = new Tab
			{
				Name = expectedName
			};

			tab.FillRequiredProperties();

			tab.Name.Should().Be(expectedName);
		}
	}
}
