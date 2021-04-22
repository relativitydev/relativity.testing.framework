using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a search provider.
	/// </summary>
	[ObjectTypeName("Search Index")]
	public class SearchProvider : NamedArtifact
	{
		/// <summary>
		/// Gets or sets a value indicating whether the Search Provider object is active.
		/// </summary>
		public bool Active { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the Search Provider object is available for searching.
		/// </summary>
		public bool AvailableForSearching { get; set; }

		/// <summary>
		/// Gets or sets the current search provider ranking multiplier for the given search provider.
		/// </summary>
		public int RankCacheMultiplier { get; set; }

		/// <summary>
		/// Gets or sets the minimum rank returned for the given search provider.
		/// </summary>
		public int MinRank { get; set; }

		/// <summary>
		/// Gets or sets the minimum rank returned for the given search provider.
		/// </summary>
		public int MaxRank { get; set; }

		/// <summary>
		/// Gets or sets the order for the given search provider.
		/// </summary>
		public int Order { get; set; }

		/// <summary>
		/// Gets or sets the dll name for the given search provider.
		/// </summary>
		public string DLL { get; set; }

		/// <summary>
		/// Gets or sets the parameters for the given search provider.
		/// </summary>
		public string Parameters { get; set; }

		/// <summary>
		/// Fills the required properties.
		/// </summary>
		/// <returns>The same <see cref="SearchProvider"/> object instance.</returns>
		public SearchProvider FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
				Name = Randomizer.GetString("AT_");

			if (string.IsNullOrWhiteSpace(DLL))
				DLL = "kCura.EDDS.dtSearchProvider.dll";

			if (string.IsNullOrWhiteSpace(Parameters))
				Parameters = string.Empty;

			return this;
		}
	}
}
