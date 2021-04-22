using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Relativity.Testing.Framework.Attributes;
using Relativity.Testing.Framework.Extensions;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for choice name to enum mapping.
	/// </summary>
	public static class ChoiceNameToEnumMapper
	{
		private static readonly ConcurrentDictionary<Type, Dictionary<string, string>> _typeMap =
			new ConcurrentDictionary<Type, Dictionary<string, string>>();

		/// <summary>
		/// Gets the enum value associated with the specified choice name.
		/// </summary>
		/// <param name="enumType">The type of the enum.</param>
		/// <param name="choiceName">The name of the choice.</param>
		/// <returns>The enum value.</returns>
		public static object GetEnumValue(Type enumType, string choiceName)
		{
			if (enumType is null)
			{
				throw new ArgumentNullException(nameof(enumType));
			}

			if (choiceName is null)
			{
				throw new ArgumentNullException(nameof(choiceName));
			}

			string valueName = null;

			try
			{
				valueName = GetMapping(enumType)[choiceName];
			}
			catch
			{
				valueName = "Unknown";
			}

			return Enum.Parse(enumType, valueName);
		}

		/// <summary>
		/// Gets the choice name associated with the specified enum value.
		/// </summary>
		/// <param name="enumValue">The enum value.</param>
		/// <returns>The choice name.</returns>
		public static string GetName(Enum enumValue)
		{
			if (enumValue is null)
			{
				throw new ArgumentNullException(nameof(enumValue));
			}

			string valueName = enumValue.ToString();
			return GetMapping(enumValue.GetType()).First(x => x.Value == valueName).Key;
		}

		private static Dictionary<string, string> GetMapping(Type type)
		{
			return _typeMap.GetOrAdd(type, CreateMapping);
		}

		private static Dictionary<string, string> CreateMapping(Type type)
		{
			return Enum.GetNames(type).
				ToDictionary(x => BuildChoiceName(type, x), x => x);
		}

		private static string BuildChoiceName(Type type, string valueName)
		{
			return GetChoiceNameAttribute(type, valueName)?.Name
				?? valueName.ToCapitalized();
		}

		private static ChoiceNameAttribute GetChoiceNameAttribute(Type type, string valueName)
		{
			MemberInfo memberInfo = type.GetMember(valueName)[0];

			return memberInfo.GetCustomAttribute<ChoiceNameAttribute>(false);
		}
	}
}
