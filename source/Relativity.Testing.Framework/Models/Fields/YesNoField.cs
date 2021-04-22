using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	public class YesNoField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="YesNoField"/> class.
		/// </summary>
		public YesNoField()
		{
			FieldType = FieldType.YesNo;
		}

		/// <summary>
		/// Gets or sets the yes value.
		/// </summary>
		[FieldName("DisplayValueTrue")]
		public string YesValue { get; set; } = "Yes";

		/// <summary>
		/// Gets or sets the no value.
		/// </summary>
		[FieldName("DisplayValueFalse")]
		public string NoValue { get; set; } = "No";

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
