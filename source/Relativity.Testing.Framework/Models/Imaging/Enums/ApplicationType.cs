namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// ApplicationType specifies the source desktop application for a FieldCode mapping.
	/// </summary>
	public enum ApplicationType
	{
		/// <summary>
		/// Application is not set.
		/// </summary>
		NotSet = 0,

		/// <summary>
		/// The source is Microsoft Word.
		/// </summary>
		MicrosoftWord = 1,

		/// <summary>
		/// The source is Microsoft Excel.
		/// </summary>
		MicrosoftExcel = 2,

		/// <summary>
		/// The source is Microsoft PowerPoint.
		/// </summary>
		MicrosoftPowerpoint = 3,

		/// <summary>
		/// The source is Microsoft Visio.
		/// </summary>
		MicrosoftVisio = 4,

		/// <summary>
		/// Represents error during mapping.
		/// </summary>
		Unknown
	}
}
