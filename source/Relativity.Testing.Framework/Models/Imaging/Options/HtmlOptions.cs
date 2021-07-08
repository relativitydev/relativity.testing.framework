namespace Relativity.Testing.Framework.Models.Imaging
{
	/// <summary>
	/// Represents the native imaging options set on an <see cref="ImagingProfile"/> instance used when imaging HTML content.
	/// </summary>
	public class HtmlOptions
	{
		/// <summary>
		/// Gets or sets a value indicating whether to remove rows of non-breaking spaces (NBSP) code.
		/// </summary>
		/// <remarks>It is the only HTML option.</remarks>
		public bool RemoveNonBreakingSpaceCodes { get; set; }
	}
}
