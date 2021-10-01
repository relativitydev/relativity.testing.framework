using System.ComponentModel;
using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Extensions;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Extensions
{
	[TestFixture]
	[TestOf(typeof(SqlFullTextLanguageExtensions))]
	public class SqlFullTextLanguageExtensionsFixture
	{
		[Test]
		public void ToFullName_HappyPath()
		{
			string fullName = SqlFullTextLanguage.ChineseSingapore.ToFullName();
			fullName.Should().Be("Chinese (Singapore)");
		}

		[Test]
		public void FromFullName_HappyPath()
		{
			SqlFullTextLanguageExtensions.FromFullName("Chinese (Singapore)").Should().Be(SqlFullTextLanguage.ChineseSingapore);
			SqlFullTextLanguageExtensions.FromFullName("Bokmål").Should().Be(SqlFullTextLanguage.Norwegian);
		}

		[Test]
		public void FromFullName_ShouldThrowInvalidEnamValue()
		{
			Assert.Throws<InvalidEnumArgumentException>(() =>
			SqlFullTextLanguageExtensions.FromFullName("random string not lang description"));
		}
	}
}
