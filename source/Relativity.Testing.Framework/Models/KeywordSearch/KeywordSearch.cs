using System;
using System.Collections.Generic;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents an instance of keyword search. Keyword search (or SQL index search) is Relativity's default search engine.
	/// </summary>
	public class KeywordSearch : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the Artifact Type ID of the object for the search (currently only Document is supported).
		/// </summary>
		public int ArtifactTypeID { get; set; } = 10;

		/// <summary>
		/// Gets or sets the fields to be included in the search result set specified as a collection of Field objects.
		/// </summary>
		public NamedArtifact[] Fields { get; set; } = new[] { new NamedArtifact { Name = "Edit" }, new NamedArtifact { Name = "File Icon" }, new NamedArtifact { Name = "Control Number" }, new NamedArtifact { Name = "Extracted Text" } };

		/// <summary>
		/// Gets or sets user(s) who can access the saved search. Setting the ArtifactID value to 0 enables all users with permissions to the saved search are able to see it.
		/// </summary>
		public NamedArtifact Owner { get; set; }

		/// <summary>
		/// Gets or sets searchIndex of the keyword index used by the search.
		/// </summary>
		public NamedArtifact SearchIndex { get; set; }

		/// <summary>
		/// Gets or sets field identifying documents related to the documents matching the search criteria. The related documents will be included in the result set alongside with the documents that match the search criteria.
		/// </summary>
		public NamedArtifact Includes { get; set; }

		/// <summary>
		///  Gets or sets the scope of the search specified as a ScopeType enumeration.
		/// </summary>
		public ScopeType Scope { get; set; }

		/// <summary>
		/// Gets or sets if folders or subfolders are specified as the KeywordSearch.
		/// </summary>
		public List<NamedArtifact> SearchFolders { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether requires users to rerun a saved search when they return to it to ensure up-to-date results.
		/// </summary>
		public bool RequiresManualRun { get; set; }

		/// <summary>
		/// Gets or sets search Criteria specified as a CriteriaCollection object.
		/// </summary>
		public CriteriaCollection SearchCriteria { get; set; }

		/// <summary>
		/// Gets or sets sort order for search results specified as a Sorts object.
		/// </summary>
		public List<Sort> Sorts { get; set; }

		/// <summary>
		/// Gets or sets string parameter used to optimize views. Only use the query hint if instructed by the kCura Client Services team. Currently, you can use Hashjoin:(true/false) or Maxdrop:(x) to populate the field.
		/// </summary>
		public string QueryHint { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether indicates that the search results must be sort by relevance rank.
		/// </summary>
		public bool SortByRank { get; set; }

		/// <summary>
		/// Gets or sets search terms.
		/// </summary>
		public string SearchText { get; set; }

		/// <summary>
		/// Gets or sets optional field for recording additional information associated with the search as keywords.
		/// </summary>
		public string Keywords { get; set; }

		/// <summary>
		/// Gets or sets detailed description of the saved search.
		/// </summary>
		public string Notes { get; set; }

		/// <summary>
		/// Gets or sets relativityApplications associated with this saved search.
		/// </summary>
		public List<NamedArtifact> RelativityApplications { get; set; }

		/// <summary>
		/// Gets or sets artifactID of the user who created the saved search.
		/// </summary>
		public NamedArtifact SystemCreatedBy { get; set; }

		/// <summary>
		/// Gets or sets date and time in UTC when the saved search was created.
		/// </summary>
		public DateTime? SystemCreatedOn { get; set; }

		/// <summary>
		/// Gets or sets artifactID of the user who last modified the saved search.
		/// </summary>
		public NamedArtifact SystemLastModifiedBy { get; set; }

		/// <summary>
		/// Gets or sets date and time in UTC when the search was last modified.
		/// </summary>
		public DateTime? SystemLastModifiedOn { get; set; }

		/// <summary>
		/// Gets or sets dashboard associated with the saved search.
		/// </summary>
		public NamedArtifact Dashboard { get; set; }

		public KeywordSearch FillRequiredProperties()
		{
			if (string.IsNullOrWhiteSpace(Name))
				Name = Randomizer.GetString("AT_");

			return this;
		}
	}
}
