namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The FieldPaneIcon representation.
	/// </summary>
	public class FieldPaneIcon
	{
		/// <summary>
		/// Gets or sets a value of the <see cref="Field"/> indicating the name of the icon file.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Gets or sets a value of the <see cref="Field"/> indicating the string representing the Base64 encoding of the image.
		/// </summary>
		public string ImageBase64 { get; set; }
	}
}
