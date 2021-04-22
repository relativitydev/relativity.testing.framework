using System.Collections.Generic;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for object data mapping.
	/// </summary>
	public interface IObjectMappingService
	{
		/// <summary>
		/// Maps the specified <paramref name="propertiesMap"/> to <paramref name="destination"/> object using <paramref name="options"/> as mapping options.
		/// </summary>
		/// <param name="propertiesMap">The properties map.</param>
		/// <param name="destination">The destination object.</param>
		/// <param name="options">The mapping options.</param>
		void Map(Dictionary<string, object> propertiesMap, object destination, MappingOptions options = null);

		/// <summary>
		/// Maps the specified value into the property with specified name of <paramref name="destination"/> object using <paramref name="options"/> as mapping options.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="propertyValue">The property value.</param>
		/// <param name="destination">The destination object.</param>
		/// <param name="options">The mapping options.</param>
		void Map(string propertyName, object propertyValue, object destination, MappingOptions options = null);
	}
}
