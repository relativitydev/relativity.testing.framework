using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents the Relativity group object.
	/// </summary>
	public class Group : TimeStampedNamedArtifact, IFillsRequiredProperties<Group>, IHaveGuids
	{
		/// <inheritdoc/>
		public List<Guid> Guids { get; set; }

		/// <summary>
		/// Gets or sets the client.
		/// </summary>
		public Client Client { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		public GroupType Type { get; set; } = GroupType.SystemGroup;

		/// <summary>
		/// Gets or sets the list of available actions for group.
		/// </summary>
		public List<HttpAction> Actions { get; set; }

		/// <summary>
		/// Gets or sets the metadata.
		/// </summary>
		public Meta Meta { get; set; }

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
