using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	public class FixedLengthTextField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FixedLengthTextField"/> class.
		/// </summary>
		public FixedLengthTextField()
		{
			FieldType = FieldType.FixedLength;
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
		/// Gets or sets an integer value indicating the number of characters in this <see cref="Field"/>.
		/// </summary>
		public int Length { get; set; } = 255;

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
		/// Gets or sets a value indicating whether the <see cref="Field"/> is relational.
		/// </summary>
		public bool IsRelational { get; set; }

		/// <summary>
		///  Gets or sets a value indicating user-friendly name for the <see cref="Field"/> displayed in the Relativity UI.
		/// </summary>
		public string FriendlyName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets a value of the <see cref="Field"/> indicating how blank values are handled when running an import job through the Relativity Desktop Client.
		/// </summary>
		public FieldImportBehavior ImportBehavior { get; set; }

		/// <summary>
		/// Gets or sets a value of the <see cref="Field"/> indicating an icon displayed in the Related Items pane of the core reviewer interface.
		/// </summary>
		public FieldPaneIcon PaneIcon { get; set; }

		/// <summary>
		/// Gets or sets an integer value of the <see cref="Field"/> used to indicate the order for the pane icons at the bottom of the Related Items pane.
		/// </summary>
		public int Order { get; set; }
	}
}
