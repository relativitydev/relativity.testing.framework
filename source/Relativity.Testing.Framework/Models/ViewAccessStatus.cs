namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Gets or sets.
	/// </summary>
	public class ViewAccessStatus
	{
		/// <summary>
		/// Gets or sets a value indicating whether the view is used to display relational fields.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool Exists { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the view is used to display relational fields.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool CanView { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the view is used to display relational fields.
		/// The default value is <see langword="false"/>.
		/// </summary>
		public bool CanViewCriteriaFields { get; set; }
	}
}
