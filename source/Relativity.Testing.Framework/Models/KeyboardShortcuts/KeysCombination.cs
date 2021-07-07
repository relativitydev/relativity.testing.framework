namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represent the KeysCombination for <see cref="KeyboardShortcut"/>, indicates whether additional keys are used as part of the shortcut.
	/// </summary>
	public class KeysCombination
	{
		/// <summary>
		///  Gets or sets a value indicating whether the Shift key is used in the key combination.
		/// </summary>
		public bool Shift { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the Control key is used in the key combination.
		/// </summary>
		public bool Ctrl { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the Alt key is used in the key combination.
		/// </summary>
		public bool Alt { get; set; }

		/// <summary>
		/// Gets or sets a key used in a specific keyboard shortcut combination,
		/// see <see href="https://platform.relativity.com/RelativityOne/Content/BD_Review/Keyboard_Shortcuts_Manager_service.htm#_Retrieve_keyboard_shortcut">
		/// platform API documentation</see> for number -> key mappings list.
		/// </summary>
		public int Key { get; set; }
	}
}
