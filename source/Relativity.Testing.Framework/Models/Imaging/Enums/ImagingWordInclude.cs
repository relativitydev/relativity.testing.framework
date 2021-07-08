namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Specifies document attributes added by word processing software to include in the imaging output.
	/// </summary>
	public enum ImagingWordInclude
	{
		/// <summary>
		/// Includes comments added to the documents through the Review feature in Microsoft Word.
		/// </summary>
		Comments = 0,

		/// <summary>
		/// Includes the field codes added by Microsoft Word as placeholders for data.
		/// </summary>
		FieldCodes = 1,

		/// <summary>
		/// Includes comments or other information added to the documents through the Hidden Text feature in Microsoft Word.
		/// </summary>
		HiddenText = 2,

		/// <summary>
		/// Represends error during mapping.
		/// </summary>
		Unknown
	}
}
