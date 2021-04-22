using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents an Element in a <see cref="CategoryElement"/> of a category.
	/// This is normally a field, but might also be other things.
	/// </summary>
	public class Element
	{
		/// <summary>
		/// Gets or sets a value indicating whether to allow copy from previous.
		/// </summary>
		public bool AllowCopyFromPrevious { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to allow HTML.
		/// </summary>
		public bool AllowHTML { get; set; }

		/// <summary>
		/// Gets or sets the colspan.
		/// </summary>
		public int Colspan { get; set; } = 1;

		/// <summary>
		/// Gets or sets the column.
		/// </summary>
		public int Column { get; set; }

		/// <summary>
		/// Gets or sets the DisplayName.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to enable datagrid.
		/// </summary>
		public bool EnableDataGrid { get; set; }

		/// <summary>
		/// Gets or sets the artifactid of the FieldCategory.
		/// </summary>
		public int FieldCategoryID { get; set; }

		/// <summary>
		/// Gets or sets the artifactid of the Field.
		/// </summary>
		public int FieldId { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="FieldType"/>.
		/// </summary>
		public FieldType FieldType { get; set; }

		/// <summary>
		/// Gets or sets the guids associated with the field.
		/// </summary>
		public List<Guid> Guids { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the field is read only.
		/// </summary>
		public bool IsReadOnly { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the field is required.
		/// </summary>
		public bool IsRequired { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the field is a system field.
		/// </summary>
		public bool IsSystem { get; set; }

		/// <summary>
		/// Gets or sets the max length for text values.
		/// </summary>
		public int MaxLength { get; set; }

		/// <summary>
		/// Gets or sets the row.
		/// </summary>
		public int Row { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to show the column name.
		/// </summary>
		public bool ShowNameColumn { get; set; }
	}
}
