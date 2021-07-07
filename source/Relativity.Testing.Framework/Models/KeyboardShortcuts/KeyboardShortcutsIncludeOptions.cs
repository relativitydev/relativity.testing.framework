namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the include options for getting Keyboard Shortucts.
	/// </summary>
	public class KeyboardShortcutsIncludeOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether to retrieve System shortcuts. The default value is true.
		/// </summary>
		public bool IncludeSystemShortcuts { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether to retrieve Choice shortcuts. The default value is true.
		/// </summary>
		public bool IncludeChoiceShortcuts { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether to retrieve Field shortcuts. The default value is true.
		/// </summary>
		public bool IncludeFieldShortcuts { get; set; } = true;
	}
}
