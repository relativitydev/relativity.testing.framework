namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The CurrencyField representation.
	/// </summary>
	public class CurrencyField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CurrencyField"/> class.
		/// </summary>
		public CurrencyField()
		{
			FieldType = FieldType.Currency;
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> wraps in this field.
		/// </summary>
		public bool Wrapping { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the document list is sorted on this <see cref="Field"/>.
		/// </summary>
		public bool AllowSortTally { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> information can be displayed on an associated object field.
		/// </summary>
		public bool OpenToAssociations { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> appears in Field Tree browser in the workspace.
		/// </summary>
		public bool AvailableInFieldTree { get; set; }
	}
}
