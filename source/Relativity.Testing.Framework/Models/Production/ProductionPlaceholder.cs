using System.Diagnostics;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a production placeholder model.
	/// </summary>
	[DebuggerDisplay("{ArtifactID} {Name}")]
	public class ProductionPlaceholder : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the type of the placeholder. Valid values are defiend by the PlaceholderType enum.
		/// </summary>
		public PlaceholderType PlaceholderType { get; set; } = PlaceholderType.Custom;

		/// <summary>
		/// Gets or sets the custom HTML text of the placeholder.
		/// </summary>
		public string CustomText { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets a value of the indicating the name of the placeholder file.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Gets or sets a value of the indicating the string representing the Base64 encoding of the image.
		/// </summary>
		public string FileData { get; set; }

		/// <summary>
		/// Fills the Name and the CustomText if the PlaceholderType is set to custom and is null.
		/// </summary>
		/// <returns>A filled <see cref="ProductionPlaceholder"/>.</returns>
		public ProductionPlaceholder FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = Randomizer.GetString("AT_");
			}

			if (PlaceholderType == PlaceholderType.Custom && string.IsNullOrWhiteSpace(CustomText))
			{
				CustomText = "Custom Placeholder Text";
			}

			return this;
		}
	}
}
