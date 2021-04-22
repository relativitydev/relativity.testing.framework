namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Represents the options of data mapping.
	/// </summary>
	public class MappingOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether to skip missing property.
		/// The default value is <see langword="true"/>.
		/// </summary>
		public bool SkipMissingProperty { get; set; } = true;

		/// <summary>
		/// Gets the default mapping options.
		/// </summary>
		public static MappingOptions Default { get; } = new MappingOptions();
	}
}
