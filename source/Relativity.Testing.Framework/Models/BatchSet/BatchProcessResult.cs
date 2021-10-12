namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents values That are retuurned after creating or purging batches.
	/// </summary>
	public class BatchProcessResult
	{
		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Gets or sets the action.
		/// </summary>
		public string Action { get; set; }
	}
}
