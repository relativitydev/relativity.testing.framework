using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the base field object.
	/// </summary>
	[ObjectTypeName("Field")]
	public class Field : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the type of the field, such as date, fixed-length text, long text, or others.
		/// </summary>
		public FieldType FieldType { get; set; }

		/// <summary>
		/// Gets or sets the artifact type name.
		/// </summary>
		public string ArtifactTypeName { get; set; } = "Field";

		/// <summary>
		/// Gets or sets the object type.
		/// </summary>
		public ObjectType ObjectType { get; set; }

		/// <summary>
		/// Gets or sets the parent artifact.
		/// </summary>
		public Artifact ParentArtifact { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether a pivot can be performed on this <see cref="Field"/>.
		/// </summary>
		public bool AllowPivot { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Field"/> is available for grouping in Pivot.
		/// </summary>
		public bool AllowGroupBy { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the user must set a value on this <see cref="Field"/>.
		/// </summary>
		public bool IsRequired { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether field is identifier.
		/// </summary>
		public bool IsIdentifier { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether a hyperlink for the field is available for this <see cref="Field"/>.
		/// </summary>
		[FieldName("IsLinked")]
		public bool Linked { get; set; }

		/// <summary>
		/// Gets or sets the number of pixels used for the column width of a field when it is displayed in the view.
		/// </summary>
		public virtual string Width { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the PropagateTo <see cref="Field"/>.
		/// </summary>
		public FieldPropagate PropagateTo { get; set; }
	}
}
