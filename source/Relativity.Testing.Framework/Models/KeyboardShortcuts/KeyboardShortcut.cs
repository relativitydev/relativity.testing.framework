namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Keyboard Shortcut for the workspace.
	/// </summary>
	public class KeyboardShortcut : Artifact
	{
		/// <summary>
		/// Gets or sets a number used as the identifier for the keyboard shortcut.
		/// </summary>
		public int KeyboardShortcutID { get; set; }

		/// <summary>
		/// Gets or sets type of keyboard shortcut.
		/// </summary>
		public KeyboardShortcutType Type { get; set; }

		/// <summary>
		///  Gets or sets string representing action taken when a keyboard shortcut is triggered.
		/// </summary>
		public string Action { get; set; }

		/// <summary>
		///  Gets or sets keys combination that indicates whether additional keys are used as part of the shortcut.
		/// </summary>
		public KeysCombination KeysCombination { get; set; }
	}
}
