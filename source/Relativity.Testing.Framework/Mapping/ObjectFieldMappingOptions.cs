namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Represents the options of field data mapping.
	/// </summary>
	public class ObjectFieldMappingOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether use capitalized for property name presentation.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool UseCapitalized { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to skip the only readable fields.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool OnlyReadableSkip { get; set; }
	}
}
