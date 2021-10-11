using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the LongText field object.
	/// </summary>
	public class LongTextField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LongTextField"/> class.
		/// </summary>
		public LongTextField()
		{
			FieldType = FieldType.LongText;
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
		/// Gets or sets a value indicating whether this <see cref="Field"/> values are added to the SQL text index for the workspace,
		/// making the field searchable via keyword search.
		/// </summary>
		public bool IncludeInTextIndex { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> can be used Unicode characters.
		/// </summary>
		[FieldName("HasUnicode")]
		public bool Unicode { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether HTML formatted text can be displayed in this <see cref="Field"/>.
		/// </summary>
		public bool AllowHTML { get; set; } = true;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> appears in the viewer.
		/// </summary>
		public bool AvailableInViewer { get; set; } = true;

		/// <summary>
		/// Gets or sets the number of pixels used for the column width of a field when it is displayed in the view.
		/// </summary>
		public override string Width { get; set; } = "255";
	}
}
