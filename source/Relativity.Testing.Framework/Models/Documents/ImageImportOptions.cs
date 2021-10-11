namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Options to set on Image imports.
	/// </summary>
	public class ImageImportOptions : DocumentImportOptionsBase
	{
		/// <summary>
		/// Gets or sets the value wich defines a column name in the SourceData, which maps to a field used as a unique identifier.
		/// </summary>
		public string BatesNumberField { get; set; } = "Bates Number";

		/// <summary>
		/// Gets or sets the value wich indicates the column name in the SourceData that maps to the FileLocation field in Relativity.
		/// </summary>
		public string FileLocationField { get; set; } = "File Location";
	}
}
