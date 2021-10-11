namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the User field object.
	/// </summary>
	public class UserField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserField"/> class.
		/// </summary>
		public UserField()
		{
			FieldType = FieldType.User;
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
		/// Gets or sets the number of pixels used for the column width of a field when it is displayed in the view.
		/// </summary>
		public override string Width { get; set; } = "255";
	}
}
