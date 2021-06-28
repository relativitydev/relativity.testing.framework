using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Relativity.Testing.Framework.Attributes;
using Relativity.Testing.Framework.Extensions;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for object field to property mapping.
	/// </summary>
	internal static class ObjectFieldMapping
	{
		/// <summary>
		/// Gets the name of the property or <see langword="null"/> if missing.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>The name of the property or <see langword="null"/> if missing.</returns>
		public static string GetPropertyNameOrNull<T>(string fieldName)
		{
			return ContainsField<T>(fieldName)
				? GetPropertyName<T>(fieldName)
				: null;
		}

		/// <summary>
		/// Gets the name of the property.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>The name of the property.</returns>
		public static string GetPropertyName<T>(string fieldName)
		{
			return GetPropertyName(typeof(T), fieldName);
		}

		/// <summary>
		/// Gets the name of the property.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>The name of the property.</returns>
		public static string GetPropertyName(Type type, string fieldName)
		{
			return Get(type)[fieldName];
		}

		/// <summary>
		/// Gets the name of the field.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>The name of the field.</returns>
		public static string GetFieldName<T>(string propertyName, ObjectFieldMappingOptions options = null)
		{
			return GetFieldName(typeof(T), propertyName, options);
		}

		/// <summary>
		/// Gets the name of the field.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>The name of the field.</returns>
		public static string GetFieldName(Type type, string propertyName, ObjectFieldMappingOptions options = null)
		{
			return Get(type, options).First(x => x.Value == propertyName).Key;
		}

		/// <summary>
		/// Determines whether the specified <typeparamref name="T"/> type contains a field with the specified name.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>
		/// <c>true</c> if the specified field name exists; otherwise, <c>false</c>.
		/// </returns>
		public static bool ContainsField<T>(string fieldName)
		{
			return ContainsField(typeof(T), fieldName);
		}

		/// <summary>
		/// Determines whether the specified <paramref name="type"/> contains a field with the specified name.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>
		/// <c>true</c> if the specified field name exists; otherwise, <c>false</c>.
		/// </returns>
		public static bool ContainsField(Type type, string fieldName)
		{
			return Get(type).ContainsKey(fieldName);
		}

		/// <summary>
		/// Determines whether the specified <typeparamref name="T"/> type contains a property with the specified name.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="propertyName">The name of the property.</param>
		/// <returns>
		/// <c>true</c> if the specified property name exists; otherwise, <c>false</c>.
		/// </returns>
		public static bool ContainsProperty<T>(string propertyName)
		{
			return ContainsProperty(typeof(T), propertyName);
		}

		/// <summary>
		/// Determines whether the specified <paramref name="type"/> contains a property with the specified name.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>
		/// <c>true</c> if the specified property name exists; otherwise, <c>false</c>.
		/// </returns>
		public static bool ContainsProperty(Type type, string propertyName, ObjectFieldMappingOptions options = null)
		{
			return Get(type, options).ContainsValue(propertyName);
		}

		/// <summary>
		/// Gets all field names of specific <typeparamref name="T"/> type.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>The collection of field names.</returns>
		public static IEnumerable<string> GetFieldNames<T>()
		{
			return GetFieldNames(typeof(T));
		}

		/// <summary>
		/// Gets all field names of specific <paramref name="type"/>.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <returns>The collection of field names.</returns>
		public static IEnumerable<string> GetFieldNames(Type type)
		{
			return Get(type).Keys;
		}

		/// <summary>
		/// Gets all property names of specific <typeparamref name="T"/> type.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>The collection of property names.</returns>
		public static IEnumerable<string> GetPropertyNames<T>()
		{
			return GetPropertyNames(typeof(T));
		}

		/// <summary>
		/// Gets all property names of specific <paramref name="type"/>.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>The collection of property names.</returns>
		public static IEnumerable<string> GetPropertyNames(Type type, ObjectFieldMappingOptions options = null)
		{
			return Get(type, options).Values;
		}

		/// <summary>
		/// Gets the mapping of field/property for specific <paramref name="type"/>.
		/// Returns the mapping as a <see cref="Dictionary{TKey, TValue}"/>, where key is a field name and value is a property name.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>The mapping as a <see cref="Dictionary{TKey, TValue}"/>.</returns>
		public static Dictionary<string, string> Get(Type type, ObjectFieldMappingOptions options = null)
		{
			return CreateMapping(type, options);
		}

		private static Dictionary<string, string> CreateMapping(Type type, ObjectFieldMappingOptions options = null)
		{
			var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty).
				Where(x => x.CanWrite && x.GetIndexParameters().Length == 0).
				Where(x => x.GetCustomAttribute<NonFieldAttribute>() == null);

			if (options != null && options.OnlyReadableSkip)
			{
				properties = properties.Where(x => x.GetCustomAttribute<OnlyReadableAttribute>() == null);
			}

			var result = properties.ToDictionary(x => BuildFieldName(x, options), x => x.Name);

			return result;
		}

		private static string BuildFieldName(PropertyInfo property, ObjectFieldMappingOptions options = null)
		{
			Guid guid = FieldGuidResolver.Resolve(property);
			if (guid != Guid.Empty)
			{
				return guid.ToString();
			}

			int artifactId = FieldArtifactIdResolver.Resolve(property);
			if (artifactId != 0)
			{
				return artifactId.ToString();
			}

			string propertyName = property.GetCustomAttribute<FieldNameAttribute>()?.Name;
			if (propertyName != null)
			{
				return propertyName;
			}

			return (options == null || options.UseCapitalized)
				? property.Name.ToCapitalized() : property.Name;
		}
	}
}
