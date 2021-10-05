using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Provides a set of methods for data randomization.
	/// </summary>
	public static class Randomizer
	{
		private const string PasswordPrefix = "aQ1@";

		/// <summary>
		/// The default random string length.
		/// </summary>
		public const int DefaultStringLength = 24;

		/// <summary>
		/// The default random email address length.
		/// </summary>
		public const int DefaultEmailAddressLength = 35;

		/// <summary>
		/// Returns a non-negative random integer that is less than the specified maximum.
		/// </summary>
		/// <param name="max">The exclusive upper bound of the random number to be generated. Must be greater than or equal to <c>0</c>.</param>
		/// <returns>The random <see cref="int"/> value.</returns>
		public static int GetInt(int max)
		{
			return CreateRandom().Next(max);
		}

		/// <summary>
		/// Returns a random integer that is within a specified range.
		/// </summary>
		/// <param name="min">The inclusive lower bound of the random number returned.</param>
		/// <param name="max">The inclusive upper bound of the random number returned. Must be greater than or equal to <paramref name="min"/>.</param>
		/// <returns>The random <see cref="int"/> value.</returns>
		public static int GetInt(int min, int max)
		{
			return CreateRandom().Next(min, max + 1);
		}

		/// <summary>
		/// Gets the random string.
		/// </summary>
		/// <param name="format">The format, that can contain <c>{0}</c> for random value insertion.</param>
		/// <param name="length">The length.</param>
		/// <returns>The random string.</returns>
		/// <exception cref="ArgumentException">
		/// The length should be positive.
		/// Or the length of string is not greater than the format length.
		/// </exception>
		public static string GetString(string format = "{0}", int length = DefaultStringLength)
		{
			if (length < 1)
			{
				throw new ArgumentException("The length should be positive.", nameof(length));
			}

			string normalizedFormat = NormalizeStringFormat(format);

			StringBuilder builder = new StringBuilder();

			int randomPartLength = length - normalizedFormat.Replace("{0}", string.Empty).Length;

			if (randomPartLength <= 0)
			{
				throw new ArgumentException($"The length {length} of string is not greater than the \"{format}\" format length.", nameof(length));
			}

			string validChars = "abcdefghijklmnopqrstuvwxyz0123456789";

			for (int i = 0; i < randomPartLength; i++)
			{
				char randomChar = validChars[CreateRandom().Next(0, validChars.Length)];
				builder.Append(randomChar);
			}

			return string.Format(normalizedFormat, builder);
		}

		private static string NormalizeStringFormat(string format)
		{
			if (string.IsNullOrEmpty(format))
			{
				return "{0}";
			}
			else if (!format.Contains("{0}"))
			{
				return format + "{0}";
			}
			else
			{
				return format;
			}
		}

		/// <summary>
		/// Gets the random email address.
		/// </summary>
		/// <param name="length">The length.</param>
		/// <returns>The random email address string.</returns>
		/// <exception cref="ArgumentException">
		/// The length should be positive.
		/// Or the length of string is not greater than the format length.
		/// </exception>
		public static string GetEmailAddress(int length = DefaultEmailAddressLength)
		{
			return GetString("at_{0}@mail.com", length);
		}

		/// <summary>
		/// Gets a randomly generated password according to secure requirements.
		/// </summary>
		/// <returns>The random password.</returns>
		public static string GetPassword()
		{
			const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			StringBuilder stringBuilder = new StringBuilder();
			using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				int length = DefaultStringLength - PasswordPrefix.Length;

				byte[] uintBuffer = new byte[sizeof(uint)];

				while (length-- > 0)
				{
					rngCryptoServiceProvider.GetBytes(uintBuffer);
					uint num = BitConverter.ToUInt32(uintBuffer, 0);
					stringBuilder.Append(characters[(int)(num % (uint)characters.Length)]);
				}

				return $"{PasswordPrefix}{stringBuilder}";
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Random CreateRandom()
		{
			return new Random(Guid.NewGuid().GetHashCode());
		}
	}
}
