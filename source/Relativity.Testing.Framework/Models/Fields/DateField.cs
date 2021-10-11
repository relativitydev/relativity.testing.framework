namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Date field object.
	/// </summary>
	public class DateField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DateField"/> class.
		/// </summary>
		public DateField()
		{
			FieldType = FieldType.Date;
		}

		/// <summary>
		/// Gets or sets a value indicates the format used to display date and whole number.
		/// </summary>
		public string Formatting { get; set; } = "Date";

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
