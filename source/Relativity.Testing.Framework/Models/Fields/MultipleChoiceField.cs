using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the MultipleChoice field object.
	/// </summary>
	public class MultipleChoiceField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MultipleChoiceField"/> class.
		/// </summary>
		public MultipleChoiceField()
		{
			FieldType = FieldType.MultipleChoice;
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
		/// Gets or sets a value indicating whether this <see cref="Field"/> can be used Unicode characters.
		/// </summary>
		[FieldName("HasUnicode")]
		public bool Unicode { get; set; } = true;

		/// <summary>
		/// Gets or sets the number of pixels used for the column width of a field when it is displayed in the view.
		/// </summary>
		public override string Width { get; set; } = "255";

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> appears in Field Tree browser in the workspace.
		/// </summary>
		public bool AvailableInFieldTree { get; set; }
	}
}
