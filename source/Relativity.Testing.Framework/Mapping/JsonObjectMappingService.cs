using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Relativity.Testing.Framework.Mapping
{
	internal class JsonObjectMappingService : IJsonObjectMappingService
	{
		private readonly IObjectMappingService _objectMappingService;

		public JsonObjectMappingService(IObjectMappingService objectMappingService)
		{
			_objectMappingService = objectMappingService;
		}

		public IEnumerable<TObject> MapTo<TObject>(IEnumerable<JObject> jObjects, JsonMappingOptions options = null)
		{
			return jObjects.Select(x => MapTo<TObject>(x, options));
		}

		public TObject MapTo<TObject>(JObject jObject, JsonMappingOptions options = null)
		{
			TObject destination = Activator.CreateInstance<TObject>();

			MapObject(jObject, destination, options ?? JsonMappingOptions.Default);

			return destination;
		}

		private void MapObject<TObject>(JObject jObject, TObject destination, JsonMappingOptions options)
		{
			Dictionary<string, object> propertiesMap = jObject.Properties().
				Select((x, index) => new
				{
					Name = SelectObjectPropertyName<TObject>(x.Name, options),
					Value = x.Value as object
				}).
				Where(x => x.Name != null).
				ToDictionary(x => x.Name, x => x.Value);

			_objectMappingService.Map(propertiesMap, destination, options);
		}

		private static string SelectObjectPropertyName<TObject>(string jsonPropertyName, JsonMappingOptions options)
		{
			return options.UseFieldToPropertyMapping
				? ObjectFieldMapping.GetPropertyNameOrNull<TObject>(jsonPropertyName)
				: ObjectFieldMapping.ContainsProperty<TObject>(jsonPropertyName) ? jsonPropertyName : null;
		}
	}
}
