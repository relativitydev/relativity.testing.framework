namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity client object.
	/// </summary>
	public class Client : NamedArtifact, IFillsRequiredProperties<Client>
	{
		/// <summary>
		/// Gets or sets the number.
		/// </summary>
		public string Number { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public NamedArtifact Status { get; set; } = new NamedArtifact { Name = ClientStatus.Active.ToString() };

		/// <summary>
		/// Gets or sets the keywords.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="Client"/> object instance.</returns>
		public Client FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
				Name = Randomizer.GetString("AT_");

			if (string.IsNullOrWhiteSpace(Number))
				Number = Randomizer.GetString();

			return this;
		}
	}
}
