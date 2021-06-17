using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Representation of a choiceRequest.
	/// </summary>
	public class ChoiceRequest : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the field.
		/// </summary>
		[FieldName("Field")]
		public NamedArtifact Field { get; set; }

		/// <summary>
		/// Gets or sets the highlight color.
		/// Optional.
		/// </summary>
		[FieldName("Highlight Color")]
		public ChoiceColor Color { get; set; } = ChoiceColor.Green;

		/// <summary>
		/// Gets or sets the parent.
		/// Optional.
		/// </summary>
		public Artifact Parent { get; set; }

		/// <summary>
		/// Gets or sets the order.
		/// Optional.
		/// </summary>
		public int Order { get; set; }
	}
}
