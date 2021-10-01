using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Extensions
{
	public static class SqlFullTextLanguageExtensions
	{
		private static Dictionary<string, SqlFullTextLanguage> _sqlFullTextLanguageDescriptionMap;

		static SqlFullTextLanguageExtensions()
		{
			_sqlFullTextLanguageDescriptionMap = new Dictionary<string, SqlFullTextLanguage>();
			foreach (SqlFullTextLanguage lang in Enum.GetValues(typeof(SqlFullTextLanguage)))
			{
				_sqlFullTextLanguageDescriptionMap.Add(lang.ToFullName(), lang);
			}
		}

		public static string ToFullName(this SqlFullTextLanguage value)
		{
			FieldInfo field = value.GetType().GetField(value.ToString());
			DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
			return attribute == null ? value.ToString() : attribute.Description;
		}

		public static SqlFullTextLanguage FromFullName(string langName)
		{
			if (!_sqlFullTextLanguageDescriptionMap.ContainsKey(langName))
			{
				throw new InvalidEnumArgumentException($"Language name {langName} not found.");
			}

			SqlFullTextLanguage result;
			_sqlFullTextLanguageDescriptionMap.TryGetValue(langName, out result);
			return result;
		}
	}
}
