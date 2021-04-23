using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity choice object.
	/// </summary>
	[ObjectTypeName("Code")]
	public class Choice : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the order.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the object type.
		/// </summary>
		[FieldName("Object Type")]
		public NamedArtifact ObjectType { get; set; }

		/// <summary>
		/// Gets or sets the object type.
		/// </summary>
		[FieldName("Highlight Color")]
		public ChoiceColor Color { get; set; }

		/// <summary>
		/// Gets or sets the field.
		/// </summary>
		[FieldName("Field")]
		public NamedArtifact Field { get; set; }

		/// <summary>
		/// Gets or sets the parent.
		/// </summary>
		public Artifact Parent { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Choice"/> is active.
		/// </summary>
		public bool Active { get; set; }

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="Choice"/> object instance.</returns>
		public Choice FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
				Name = Randomizer.GetString("AT_");

			if (Color == ChoiceColor.Default)
				Color = ChoiceColor.Green;

			return this;
		}
	}
}
