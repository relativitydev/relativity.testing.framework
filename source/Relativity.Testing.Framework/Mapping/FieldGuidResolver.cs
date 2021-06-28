using System;
using System.Reflection;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for field guid resolution.
	/// </summary>
	internal static class FieldGuidResolver
	{
		/// <summary>
		/// Resolves the field Guid of <paramref name="propertyInfo"/>.
		/// </summary>
		/// <param name="propertyInfo">The PropertyInfo of the field.</param>
		/// <returns>The field Guid, or Guid.Empty if the attribute is not present.</returns>
		public static Guid Resolve(PropertyInfo propertyInfo)
		{
			return propertyInfo.IsDefined(typeof(FieldGuidAttribute)) ?
				propertyInfo.GetCustomAttribute<FieldGuidAttribute>().Id :
				Guid.Empty;
		}
	}
}
