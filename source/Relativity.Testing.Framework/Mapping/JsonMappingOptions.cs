namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Represents the options of JSON data mapping.
	/// </summary>
	public class JsonMappingOptions : MappingOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether to use field to property mapping.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool UseFieldToPropertyMapping { get; set; }

		/// <summary>
		/// Gets the default mapping options.
		/// </summary>
		public static new JsonMappingOptions Default { get; } = new JsonMappingOptions();
	}
}
