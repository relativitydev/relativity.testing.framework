namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents values for batch set autobatching.
	/// </summary>
	public class AutoBatchSettings
	{
		/// <summary>
		/// Gets or sets minimum size for batch created by autobatching.
		/// </summary>
		public int MinimumBatchSize { get; set; }

		/// <summary>
		/// Gets or sets the interval on which batches are created.
		/// </summary>
		public int AutoCreateRateInMinutes { get; set; }
	}
}
