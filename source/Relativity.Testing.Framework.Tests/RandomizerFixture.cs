using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Relativity.Testing.Framework.Tests
{
	[TestFixture]
	[TestOf(typeof(Randomizer))]
	public class RandomizerFixture
	{
		[Test]
		public void Randomizer_GetString()
		{
			string result = Randomizer.GetString();

			result.Length.Should().Be(Randomizer.DefaultStringLength);
		}

		[TestCase(1)]
		[TestCase(50)]
		[TestCase(1000)]
		public void Randomizer_GetString_WithLength(int length)
		{
			string result = Randomizer.GetString(length: length);

			result.Length.Should().Be(length);
		}

		[TestCase(0)]
		[TestCase(-1)]
		public void Randomizer_GetString_WithInvalidLength(int length)
		{
			var exception = Assert.Throws<ArgumentException>(() =>
				Randomizer.GetString(length: length));

			exception.ParamName.Should().Be(nameof(length));
		}

		[TestCase("AT{0}")]
		[TestCase("{0}AT")]
		[TestCase("Pref{0}Suf")]
		public void Randomizer_GetString_WithFormat(string format)
		{
			string result = Randomizer.GetString(format: format);

			result.Length.Should().Be(Randomizer.DefaultStringLength);

			result.Should().Match(format.Replace("{0}", "*"));
		}

		[TestCase("AT{0}!", 75)]
		[TestCase("{0}AT", 3)]
		public void Randomizer_GetString_WithFormatAndLength(string format, int length)
		{
			string result = Randomizer.GetString(format, length);

			result.Length.Should().Be(length);

			result.Should().Match(format.Replace("{0}", "*"));
		}

		[TestCase("AT{0}abc", 5)]
		[TestCase("xyz{0}", 2)]
		public void Randomizer_GetString_WithLengthNotGreaterThanFormat(string format, int length)
		{
			var exception = Assert.Throws<ArgumentException>(() =>
				Randomizer.GetString(format, length));

			exception.ParamName.Should().Be(nameof(length));
		}

		[Test]
		public static void Randomizer_GetPassword_ReturnsAString()
		{
			string password = Randomizer.GetPassword();

			Assert.That(!string.IsNullOrEmpty(password));
		}

		[Test]
		public static void Randomizer_GetPassword_ReturnsAStringWithUppercaseLetters()
		{
			string password = Randomizer.GetPassword();
			var passwordAsCharList = new List<char>(password);

			Assert.That(passwordAsCharList.Any(x => char.IsUpper(x)));
		}

		[Test]
		public static void Randomizer_GetPassword_ReturnsAStringWithLowercaseLetters()
		{
			string password = Randomizer.GetPassword();
			var passwordAsCharList = new List<char>(password);

			Assert.That(passwordAsCharList.Any(x => char.IsLower(x)));
		}

		[Test]
		public static void Randomizer_GetPassword_ReturnsAStringWithNumericCharacter()
		{
			string password = Randomizer.GetPassword();
			var passwordAsCharList = new List<char>(password);

			Assert.That(passwordAsCharList.Any(x => char.IsNumber(x)));
		}

		[Test]
		public static void Randomizer_GetPassword_ReturnsAStringWithSpecialCharacter()
		{
			string password = Randomizer.GetPassword();
			var passwordAsCharList = new List<char>(password);

			Assert.That(passwordAsCharList.Any(x => char.IsSymbol(x) || char.IsPunctuation(x)));
		}
	}
}
