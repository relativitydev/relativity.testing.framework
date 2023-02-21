using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for object data mapping.
	/// </summary>
	internal class ObjectMappingService : IObjectMappingService
	{
		private static readonly string[] _artifactIDFieldNames = new[] { "Artifact ID", "ArtifactID" };

		/// <summary>
		/// Maps the specified <paramref name="propertiesMap"/> to <paramref name="destination"/> object using <paramref name="options"/> as mapping options.
		/// </summary>
		/// <param name="propertiesMap">The properties map.</param>
		/// <param name="destination">The destination object.</param>
		/// <param name="options">The mapping options.</param>
		public void Map(Dictionary<string, object> propertiesMap, object destination, MappingOptions options = null)
		{
			Type destinationType = destination.GetType();

			foreach (var item in propertiesMap)
			{
				Map(item.Key, item.Value, destination, destinationType, options);
			}
		}

		/// <summary>
		/// Maps the specified value into the property with specified name of <paramref name="destination"/> object using <paramref name="options"/> as mapping options.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="propertyValue">The property value.</param>
		/// <param name="destination">The destination object.</param>
		/// <param name="options">The mapping options.</param>
		public void Map(string propertyName, object propertyValue, object destination, MappingOptions options = null)
		{
			Map(propertyName, propertyValue, destination, destination.GetType(), options);
		}

		private void Map(string propertyName, object propertyValue, object destination, Type destinationType, MappingOptions options = null)
		{
			options = options ?? MappingOptions.Default;

			PropertyInfo property = destinationType.GetProperty(
				propertyName,
				BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.IgnoreCase);

			if (property == null)
			{
				if (!options.SkipMissingProperty)
				{
					throw new MappingException(destinationType, propertyName, "Property is not found.");
				}
			}
			else
			{
				Type propertyValueType = propertyValue?.GetType();
				Type propertyType = property.PropertyType;
				Type underlyingPropertyType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;

				try
				{
					object valueToSet = propertyValue != null && !(propertyType.IsAssignableFrom(propertyValueType) || underlyingPropertyType.IsAssignableFrom(propertyValueType))
						? ConvertValue(propertyValue, underlyingPropertyType)
						: propertyValue;

					property.SetValue(destination, valueToSet, null);
				}
				catch (Exception exception)
				{
					string additionalMessage = propertyValue == null
						? $"Property null value cannot be converted to {propertyType} type."
						: $"Property \"{propertyValue}\" value of {propertyValueType} type cannot be converted to {propertyType} type.";

					throw new MappingException(destinationType, propertyName, additionalMessage, exception);
				}
			}
		}

		private static object ConvertValue(object sourceValue, Type destinationType)
		{
			if (sourceValue is JArray jArray)
			{
				return ConvertJArray(jArray, destinationType);
			}
			else if (sourceValue is JValue jValue)
			{
				return ConvertJToken(jValue, destinationType);
			}
			else if (sourceValue is JObject jObject)
			{
				return ConvertJObject(jObject, destinationType);
			}
			else if (destinationType.IsEnum)
			{
				return ConvertToEnum(destinationType, sourceValue);
			}
			else if (destinationType == typeof(TimeSpan))
			{
				return ConvertToTimeSpan(sourceValue);
			}
			else if (typeof(NamedArtifact).IsAssignableFrom(destinationType) && sourceValue is string stringValue)
			{
				var instance = Activator.CreateInstance(destinationType);
				PropertyInfo property = destinationType.GetProperties().First(x => x.Name == nameof(NamedArtifact.Name));
				property.SetValue(instance, stringValue, null);
				return instance;
			}
			else if (destinationType == typeof(FieldPropagate))
			{
				return Activator.CreateInstance(destinationType);
			}
			else if (sourceValue is double doubleValue && destinationType == typeof(decimal))
			{
				return ConvertDoubleToDecimal(doubleValue);
			}
			else
			{
				TypeConverter typeConverter = TypeDescriptor.GetConverter(sourceValue.GetType());

				return typeConverter.CanConvertTo(destinationType)
					? typeConverter.ConvertTo(sourceValue, destinationType)
					: sourceValue;
			}
		}

		private static object ConvertJArray(JArray value, Type destinationType)
		{
			if (destinationType.IsArray)
			{
				return ConvertJArrayToArrayOfObjects(value, destinationType);
			}
			else if (destinationType.IsGenericType && destinationType.GetGenericTypeDefinition() == typeof(List<>))
			{
				return ConvertJArrayToListOfObjects(value, destinationType);
			}
			else
			{
				return ConvertJToken(value, destinationType);
			}
		}

		private static object ConvertJArrayToListOfObjects(JArray value, Type destinationType)
		{
			Type itemType = destinationType.GetGenericArguments()[0];
			object[] convertedItems = ConvertJArrayToObjectArray(value, itemType);

			IList list = (IList)Activator.CreateInstance(destinationType);

			foreach (object item in convertedItems)
			{
				list.Add(item);
			}

			return list;
		}

		private static object ConvertJArrayToArrayOfObjects(JArray value, Type destinationType)
		{
			Type itemType = destinationType.GetElementType();
			object[] convertedItems = ConvertJArrayToObjectArray(value, itemType);

			Array array = Array.CreateInstance(itemType, convertedItems.Length);
			convertedItems.CopyTo(array, 0);

			return array;
		}

		private static object[] ConvertJArrayToObjectArray(JArray value, Type itemType)
		{
			return value.Children().Select(x => x is JObject jObject ? ConvertJObject(jObject, itemType) : ConvertJToken(x, itemType)).ToArray();
		}

		private static object ConvertJObject(JObject value, Type destinationType)
		{
			if (destinationType.IsEnum)
			{
				return ConvertChoiceJObjectToEnum(value, destinationType);
			}
			else if (destinationType == typeof(string))
			{
				return ConvertChoiceJObjectToString(value);
			}
			else if (typeof(NamedArtifact).IsAssignableFrom(destinationType))
			{
				return ConvertJObjectToNamedArtifact(value, destinationType);
			}
			else if (typeof(Artifact).IsAssignableFrom(destinationType))
			{
				return ConvertJObjectToArtifact(value, destinationType);
			}
			else
			{
				return ConvertJToken(value, destinationType);
			}
		}

		private static object ConvertJToken(JToken value, Type destinationType)
		{
			return value.Type == JTokenType.Null
				? null
				: value.ToObject(destinationType);
		}

		private static object ConvertChoiceJObjectToString(JObject value)
		{
			string choiceName = RetrieveChoiceNamePropertyValue(value);

			if (string.IsNullOrWhiteSpace(choiceName))
			{
				throw new ArgumentException($"Value doesn't contain Name property");
			}

			return choiceName;
		}

		private static object ConvertChoiceJObjectToEnum(JObject value, Type destinationType)
		{
			string choiceName = RetrieveChoiceNamePropertyValue(value);
			return ConvertToEnum(destinationType, choiceName);
		}

		private static object ConvertJObjectToNamedArtifact(JObject value, Type destinationType)
		{
			NamedArtifact artifact = (NamedArtifact)ConvertJObjectToArtifact(value, destinationType);

			string name = value.Value<string>(nameof(NamedArtifact.Name));

			if (!string.IsNullOrWhiteSpace(name))
			{
				artifact.Name = name;
			}

			return artifact;
		}

		private static object ConvertJObjectToArtifact(JObject value, Type destinationType)
		{
			Artifact artifact = (Artifact)Activator.CreateInstance(destinationType);

			artifact.ArtifactID = RetrieveArtifactIDPropertyValue(value);

			return artifact;
		}

		private static int RetrieveArtifactIDPropertyValue(JToken token)
		{
			return _artifactIDFieldNames.Select(name => token.Value<int>(name)).FirstOrDefault(id => id > 0);
		}

		private static string RetrieveChoiceNamePropertyValue(JToken token)
		{
			return token.Value<string>("Name");
		}

		private static object ConvertToEnum(Type enumType, object value)
		{
			return value is string stringValue
				? ConvertToEnum(enumType, stringValue)
				: Enum.ToObject(enumType, value);
		}

		private static object ConvertToEnum(Type enumType, string value)
		{
			value = (value == "Fixed-Length Text") ? "Fixed Length" : value;
			value = (value == "Yes/No") ? "Yes No" : value;

			return ChoiceNameToEnumMapper.GetEnumValue(enumType, value);
		}

		private static TimeSpan ConvertToTimeSpan(object value)
		{
			return value is double || value is int || value is float
				? TimeSpan.FromSeconds(Convert.ToDouble(value))
				: TimeSpan.Parse(value.ToString());
		}

		private static decimal ConvertDoubleToDecimal(double value)
		{
			IFormatProvider formatProvider = CultureInfo.CurrentCulture;
			const NumberStyles numberStyles =
				NumberStyles.AllowDecimalPoint |
				NumberStyles.AllowExponent |
				NumberStyles.AllowLeadingSign;
			string doubleAsString = value.ToString("R", formatProvider);

			return decimal.Parse(doubleAsString, numberStyles, formatProvider);
		}
	}
}
