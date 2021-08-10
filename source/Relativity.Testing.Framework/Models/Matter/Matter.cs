using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity matter object.
	/// </summary>
	public class Matter : TimeStampedNamedArtifact, IFillsRequiredProperties<Matter>
	{
		/// <summary>
		/// Gets or sets the number.
		/// </summary>
		public string Number { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public string Status { get; set; } = "Active";

		/// <summary>
		/// Gets or sets the client.
		/// </summary>
		public Client Client { get; set; }

		/// <summary>
		/// Gets or sets the keywords.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets a list of RESTful operations that a user has permissions to perform on the matter.
		/// </summary>
		public List<Action> Actions { get; set; }

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="Matter"/> object instance.</returns>
		public Matter FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
				Name = Randomizer.GetString("AT_");

			if (string.IsNullOrWhiteSpace(Number))
				Number = Randomizer.GetString();

			return this;
		}
	}
}
