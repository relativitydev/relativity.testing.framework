﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Relativity.Testing.Framework.Extensions
{
	internal static class StringExtensions
	{
		public static bool IsUpper(this string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return false;
			}

			return value.ToCharArray().All(x => char.IsUpper(x));
		}

		public static string ToUpperFirstLetter(this string value)
		{
			if (value == null)
			{
				return null;
			}
			else if (value.Length > 1)
			{
				return char.ToUpper(value[0]) + value.Substring(1);
			}
			else
			{
				return value.ToUpper();
			}
		}

		public static string[] SplitIntoWords(this string value)
		{
			char[] chars = value.ToCharArray();

			List<char> wordChars = new List<char>();
			List<string> words = new List<string>();

			if (char.IsLetterOrDigit(chars[0]))
			{
				wordChars.Add(chars[0]);
			}

			Action endWord = () =>
			{
				if (wordChars.Any())
				{
					words.Add(new string(wordChars.ToArray()));
					wordChars.Clear();
				}
			};

			for (int i = 1; i < chars.Length; i++)
			{
				char current = chars[i];
				char prev = chars[i - 1];
				char? next = i + 1 < chars.Length ? (char?)chars[i + 1] : null;

				if (!char.IsLetterOrDigit(current))
				{
					endWord();
				}
				else if ((char.IsDigit(current) && char.IsLetter(prev)) ||
					(char.IsLetter(current) && char.IsDigit(prev)) ||
					(char.IsUpper(current) && char.IsLower(prev)) ||
					(char.IsUpper(current) && next != null && char.IsLower(next.Value)))
				{
					endWord();
					wordChars.Add(current);
				}
				else
				{
					wordChars.Add(current);
				}
			}

			endWord();

			return words.ToArray();
		}

		public static string ToCapitalized(this string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			string[] words = value.SplitIntoWords();

			if (!words.Any())
			{
				return string.Empty;
			}

			return string.Join(" ", words.Select(x => x.IsUpper() ? x : x.ToUpperFirstLetter()));
		}

		public static string ToCapitalizedString(this object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			return value.ToString().ToCapitalized();
		}

		public static string Sanitize(this string value, IEnumerable<char> invalidChars, string replaceWith = null)
		{
			if (invalidChars == null)
			{
				throw new ArgumentNullException(nameof(invalidChars));
			}

			if (string.IsNullOrEmpty(value))
			{
				return value;
			}

			return invalidChars.Aggregate(value, (current, c) => current.Replace(c.ToString(), replaceWith));
		}

		public static string SanitizeForFileName(this string value, string replaceWith = null)
		{
			return value.Sanitize(Path.GetInvalidFileNameChars(), replaceWith);
		}

		public static string SanitizeForPath(this string value, string replaceWith = null)
		{
			return value.Sanitize(Path.GetInvalidPathChars(), replaceWith);
		}
	}
}
