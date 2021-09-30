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
		public void ToDescription_HappyPath()
		{
			string fullLangDescription = SqlFullTextLanguage.ChineseSingapore.ToFullName();
			fullLangDescription.Should().Be("Chinese (Singapore)");
		}

		[Test]
		public void FromDescription_HappyPath()
		{
			SqlFullTextLanguageExtensions.FromFullName("Chinese (Singapore)").Should().Be(SqlFullTextLanguage.ChineseSingapore);
			SqlFullTextLanguageExtensions.FromFullName("Bokmål").Should().Be(SqlFullTextLanguage.Norwegian);
		}

		[Test]
		public void FromDescription_ShouldThrowInvalidEnamValue()
		{
			Assert.Throws<InvalidEnumArgumentException>(() =>
			SqlFullTextLanguageExtensions.FromFullName("random string not lang description"));
		}
	}
}
