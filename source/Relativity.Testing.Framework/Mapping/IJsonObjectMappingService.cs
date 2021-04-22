using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for JSON object data mapping.
	/// </summary>
	public interface IJsonObjectMappingService
	{
		/// <summary>
		/// Maps the collection of JSON objects to the collection of objects of <typeparamref name="TObject"/> type.
		/// </summary>
		/// <typeparam name="TObject">The type of the object to map to.</typeparam>
		/// <param name="jObjects">The JSON objects.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>The mapped collection of <typeparamref name="TObject"/> objects.</returns>
		IEnumerable<TObject> MapTo<TObject>(IEnumerable<JObject> jObjects, JsonMappingOptions options = null);

		/// <summary>
		/// Maps the JSON object to the object of <typeparamref name="TObject"/> type.
		/// </summary>
		/// <typeparam name="TObject">The type of the object to map to.</typeparam>
		/// <param name="jObject">The JSON object.</param>
		/// <param name="options">The mapping options.</param>
		/// <returns>The mapped <typeparamref name="TObject"/> object.</returns>
		TObject MapTo<TObject>(JObject jObject, JsonMappingOptions options = null);
	}
}
