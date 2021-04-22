using System.Reflection;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for field ArtifactId resolution.
	/// </summary>
	public static class FieldArtifactIdResolver
	{
		/// <summary>
		/// Resolves the field ArtifactId of <paramref name="propertyInfo"/>.
		/// </summary>
		/// <param name="propertyInfo">The PropertyInfo of the field.</param>
		/// <returns>The field ArtifactId, or 0 if the attribute is not present.</returns>
		public static int Resolve(PropertyInfo propertyInfo)
		{
			return propertyInfo.IsDefined(typeof(FieldArtifactIdAttribute)) ?
			propertyInfo.GetCustomAttribute<FieldArtifactIdAttribute>().ArtifactId :
			0;
		}
	}
}
