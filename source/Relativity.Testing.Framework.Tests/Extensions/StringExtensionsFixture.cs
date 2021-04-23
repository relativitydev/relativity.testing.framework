using NUnit.Framework;
using Relativity.Testing.Framework.Extensions;

namespace Relativity.Testing.Framework.Tests.Extensions
{
	[TestFixture]
	public class StringExtensionsFixture
	{
		[TestCase(
			"MassOpCopyTest",
			"Mass Op Copy Test",
			Description = "We make a conventional assupmtion that pascal-cased class names have a space separator in Relativity.")]
		public void Test(string input, string expected)
		{
			var actual = input.ToCapitalized();

			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
