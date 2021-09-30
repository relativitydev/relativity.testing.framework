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
		public void ToDescription_happyPath()
		{
			string fullLangDescription = SqlFullTextLanguage.ChineseSingapore.ToDescription();
			fullLangDescription.Should().Be("Chinese (Singapore)");
		}

		[Test]
		public void FromDescription_happyPath()
		{
			SqlFullTextLanguageExtensions.FromDescription("Chinese (Singapore)").Should().Be(SqlFullTextLanguage.ChineseSingapore);
			SqlFullTextLanguageExtensions.FromDescription("Bokmål").Should().Be(SqlFullTextLanguage.Norwegian);
		}

		[Test]
		public void FromDescription_ShouldThrowInvalidEnamValue()
		{
			Assert.Throws<InvalidEnumArgumentException>(() =>
			SqlFullTextLanguageExtensions.FromDescription("random string not lang description"));
		}
	}
}
