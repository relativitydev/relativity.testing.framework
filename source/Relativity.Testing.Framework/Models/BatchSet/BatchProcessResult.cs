namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents values That are retuurned after creating or purging batches.
	/// </summary>
	public class BatchProcessResult
	{
		public int Count { get; set; }

		public string Action { get; set; }
	}
}
