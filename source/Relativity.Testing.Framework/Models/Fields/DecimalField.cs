namespace Relativity.Testing.Framework.Models
{
	public class DecimalField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DecimalField"/> class.
		/// </summary>
		public DecimalField()
		{
			FieldType = FieldType.Decimal;
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
	}
}
