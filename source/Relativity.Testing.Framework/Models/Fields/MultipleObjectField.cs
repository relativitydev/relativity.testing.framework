namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the MultipleObject field object.
	/// </summary>
	public class MultipleObjectField : Field
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MultipleObjectField"/> class.
		/// </summary>
		public MultipleObjectField()
		{
			FieldType = FieldType.MultipleObject;
		}

		/// <summary>
		/// Gets or sets the object type associated with the field.
		/// </summary>
		public ObjectType AssociativeObjectType { get; set; }

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
