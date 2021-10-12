using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The possible Resource types.
	/// </summary>
	public enum ResourceType
	{
		[ChoiceName("agent-worker-servers")]
		AgentWorkerServers,
		[ChoiceName("sql-servers")]
		SqlServers,
		[ChoiceName("file-repositories")]
		FileRepositories,
		[ChoiceName("cache-location-servers")]
		CacheLocationServers,
		[ChoiceName("analytics-servers")]
		AnalyticsServers,
		[ChoiceName("dt-search-index-locations")]
		DtSearchIndexLocations,
		[ChoiceName("worker-manager-servers")]
		WorkerManagerServers,
		[ChoiceName("processing-source-locations")]
		ProcessingSourceLocations,
		Unknown
	}
}
