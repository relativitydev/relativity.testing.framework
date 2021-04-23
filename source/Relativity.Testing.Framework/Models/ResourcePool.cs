using System.Collections.Generic;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// A representation of a Relativity Resource Pool used for data transfer.
	/// </summary>
	public class ResourcePool : NamedArtifact
	{
		/// <summary>
		/// Gets or sets the client.
		/// </summary>
		[FieldName("Client Name")]
		public NamedArtifact Client { get; set; }

		/// <summary>
		/// Gets or sets the agent and worker servers.
		/// </summary>
		public List<NamedArtifact> AgentAndWorkerServers { get; set; }

		/// <summary>
		/// Gets or sets the SQL servers.
		/// </summary>
		public List<NamedArtifact> SqlServers { get; set; }

		/// <summary>
		/// Gets or sets the file repositories.
		/// </summary>
		public List<NamedArtifact> FileRepositories { get; set; }

		/// <summary>
		/// Gets or sets the cache location servers.
		/// </summary>
		public List<NamedArtifact> CacheLocationServers { get; set; }

		/// <summary>
		/// Gets or sets the analytics servers.
		/// </summary>
		public List<NamedArtifact> AnalyticsServers { get; set; }

		/// <summary>
		/// Gets or sets the DT search index share locations.
		/// </summary>
		public List<NamedArtifact> DtSearchIndexShareLocations { get; set; }

		/// <summary>
		/// Gets or sets the workspace manager servers.
		/// </summary>
		public List<NamedArtifact> WorkspaceManagerServers { get; set; }

		/// <summary>
		/// Gets or sets the processing source locations.
		/// </summary>
		public List<Choice> ProcessingSourceLocations { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether resource pool should be available for selection in workspace creation workflow.
		/// </summary>
		public bool IsVisible { get; set; }

		/// <summary>
		/// Gets or sets any keywords associated with the resource pool.
		/// </summary>
		public string Keywords { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets an optional description or other information about the resource pool.
		/// </summary>
		public string Notes { get; set; } = string.Empty;
	}
}
