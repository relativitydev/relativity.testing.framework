namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a field in the <see cref="SaveFieldsAndCustomTextRequest"/>.
	/// </summary>
	public class CategoryField
	{
		/// <summary>
		///  Gets or sets the artifact id of the field.
		/// </summary>
		public int FieldArtifactID { get; set; }

		/// <summary>
		///  Gets or sets a value indicating whether the field is read only.
		/// </summary>
		public bool IsReadOnly { get; set; }

		/// <summary>
		///  Gets or sets the <see cref="FieldDisplayType"/> of the field.
		/// </summary>
		public FieldDisplayType FieldDisplayType { get; set; }

		/// <summary>
		///  Gets or sets the <see cref="FieldType"/> of the field.
		/// </summary>
		public FieldType FieldTypeID { get; set; }

		/// <summary>
		///  Gets or sets the number of rows.
		///  Defaults to 1.
		/// </summary>
		public int Rows { get; set; } = 1;

		/// <summary>
		///  Gets or sets a value indicating whether to show the name column.
		///  Defaults to true.
		/// </summary>
		public bool ShowNameColumn { get; set; } = true;

		/// <summary>
		///  Gets or sets a value indicating whether to allow copy from previous.
		/// </summary>
		public bool AllowCopyFromPrevious { get; set; }

		/// <summary>
		///  Gets or sets the repeat column.
		/// </summary>
		public int? RepeatColumn { get; set; } = 0;

		/// <summary>
		///  Gets or sets the artifactID of the PickerView.
		/// </summary>
		public int? PickerViewArtifactID { get; set; }

		/// <summary>
		///  Gets or sets the height of the full text field.
		/// </summary>
		public int? FullTextFieldHeight { get; set; }

		/// <summary>
		///  Gets or sets the default value.
		/// </summary>
		public string DefaultValue { get; set; }

		/// <summary>
		///  Gets or sets the name value.
		/// </summary>
		public string NameValue { get; set; }

		/// <summary>
		///  Gets or sets the display name of the field.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		///  Gets or sets a value indicating whether the field is required.
		/// </summary>
		public bool IsRequired { get; set; }

		/// <summary>
		///  Gets or sets the artifact id of the object type.
		/// </summary>
		public int? ObjectType { get; set; }

		/// <summary>
		///  Gets or sets the artifact id of the FieldCategory.
		/// </summary>
		public int FieldCategoryID { get; set; }

		/// <summary>
		///  Gets or sets a value indicating whether the artifact is a base field.
		/// </summary>
		public bool IsArtifactBaseField { get; set; }

		/// <summary>
		///  Gets or sets a value indicating whether to allow HTML.
		/// </summary>
		public bool AllowHtml { get; set; }

		/// <summary>
		///  Gets or sets the column to place the field in.
		///  Defaults to 1, the first column.
		/// </summary>
		public int Column { get; set; } = 1;

		/// <summary>
		///  Gets or sets the artifact id of the Category.
		/// </summary>
		public int CategoryID { get; set; }

		/// <summary>
		///  Gets or sets the colspan of the field.
		/// </summary>
		public int Colspan { get; set; }

		/// <summary>
		///  Gets or sets the row to place the field in.
		/// </summary>
		public int Row { get; set; }

		/// <summary>
		///  Gets or sets the artifact id of the Layout.
		/// </summary>
		public int LayoutArtifactID { get; set; }

		/// <summary>
		///  Gets or sets the order.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		///  Gets the <see cref="LayoutElementType"/>.
		/// </summary>
		public LayoutElementType ElementType { get; private set; }

		/// <summary>
		///  Gets or sets the TempID.
		/// </summary>
		public long TempID { get; set; }

		/// <summary>
		///  Gets or sets a value indicating whether this is edited.
		/// </summary>
		public bool IsEdited { get; set; }
	}
}
