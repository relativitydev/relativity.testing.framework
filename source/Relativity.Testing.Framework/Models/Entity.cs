using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity entity object.
	/// </summary>
	public class Entity : Artifact
	{
		/// <summary>
		/// Gets or sets document numbering prefix for an entity.
		/// </summary>
		public string DocumentNumberingPrefix { get; set; }

		/// <summary>
		/// Gets or sets first name for an entity.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets last name for an entity.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets full name for an entity.
		/// </summary>
		public string FullName { get; set; }

		/// <summary>
		/// Gets or sets entity type.
		/// </summary>
		public NamedArtifact Type { get; set; } = new NamedArtifact { Name = "Person" };

		/// <summary>
		/// Gets or sets entity classification.
		/// </summary>
		public List<NamedArtifact> Classification { get; set; }

		/// <summary>
		/// Gets or sets Notes.
		/// </summary>
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Fills the FirstName on the Entity if missing.
		/// </summary>
		/// <returns>A filled <see cref="Entity"/>.</returns>
		public Entity FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(FirstName))
			{
				FirstName = Randomizer.GetString("FN_");
			}

			if (string.IsNullOrWhiteSpace(LastName))
			{
				LastName = Randomizer.GetString("LN_");
			}

			if (string.IsNullOrWhiteSpace(FullName))
			{
				FullName = $"{FirstName}, {LastName}";
			}

			return this;
		}
	}
}
