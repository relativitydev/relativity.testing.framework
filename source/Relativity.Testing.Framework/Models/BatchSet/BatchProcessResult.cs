namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents values That are retuurned after creating or purging batches.
	/// </summary>
	public class BatchProcessResult
	{
		/// <summary>
		/// Gets or sets count.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Gets or sets Action.
		/// </summary>
		public string Action { get; set; }
	}
}
