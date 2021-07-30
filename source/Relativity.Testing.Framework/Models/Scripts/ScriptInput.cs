namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the input to a Relativity script.
	/// </summary>
	public class ScriptInput
	{
		/// <summary>
		/// Gets or sets the identifier of the input.
		/// </summary>
		public string ID { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public object Value { get; set; }
	}
}
