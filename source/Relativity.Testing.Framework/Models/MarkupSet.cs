using Castle.Core.Internal;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represent a markup set model.
	/// </summary>
	public class MarkupSet : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the parent artifact.
		/// </summary>
		public Artifact ParentObject { get; set; }

		/// <summary>
		/// Gets or sets the order.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the redaction text.
		/// </summary>
		public string RedactionText { get; set; }

		/// <summary>
		/// Fill the required properties of markup set model.
		/// </summary>
		/// <returns>Returns markup set.</returns>
		public MarkupSet FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = Randomizer.GetString("AT_");
			}

			if (RedactionText.IsNullOrEmpty())
			{
				RedactionText = "Custom Redaction Text";
			}

			Order = 1;

			return this;
		}
	}
}
