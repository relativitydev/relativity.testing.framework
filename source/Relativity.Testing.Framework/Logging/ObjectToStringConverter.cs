using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Relativity.Testing.Framework.Logging
{
	internal static class ObjectToStringConverter
	{
		public const string NullString = "null";

		public static string ToString(IEnumerable collection)
		{
			return ToString(collection?.Cast<object>());
		}

		public static string ToString<T>(IEnumerable<T> collection)
		{
			return collection == null
				? NullString
				: $"[{string.Join(", ", collection.Select(x => x.ToString()).ToArray())}]";
		}

		public static string ToString(object value)
		{
			if (Equals(value, null))
			{
				return NullString;
			}
			else if (value is string)
			{
				return $"\"{value}\"";
			}
			else if (value is ValueType)
			{
				return value.ToString();
			}
			else if (value is IEnumerable enumerableValue)
			{
				return ToString(enumerableValue);
			}
			else
			{
				return $"{{{value}}}";
			}
		}
	}
}
