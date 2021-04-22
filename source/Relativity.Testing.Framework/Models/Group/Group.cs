namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity group object.
	/// </summary>
	public class Group : NamedArtifact, IFillsRequiredProperties<Group>
	{
		/// <summary>
		/// Gets or sets the client.
		/// </summary>
		public Client Client { get; set; }

		/// <summary>
		/// Gets the type.
		/// </summary>
		public GroupType Type { get; internal set; } = GroupType.SystemGroup;

		/// <summary>
		/// Gets or sets any keywords associated with the user group.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets optional words or phrase used to describe the user group.
		/// </summary>
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="Group"/> object instance.</returns>
		public Group FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
				Name = Randomizer.GetString("AT_");

			return this;
		}
	}
}
