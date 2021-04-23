using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Defines the different Servers that are available in Relativity.
	/// </summary>
	public enum ResourceServerType
	{
		[ChoiceName("Web:Forms Authentication")]
		WebFormsAuth,

		Other,

		Web,

		WebWindowsAuth,

		[ChoiceName("Analytics Server")]
		Analytics,

		[ChoiceName("Worker Manager Server")]
		WorkerManager,

		[ChoiceName("SQL - Primary")]
		SqlPrimary,

		[ChoiceName("SQL - Distributed")]
		SqlDistributed,

		[ChoiceName("Cache Location Server")]
		CacheLocation,

		Agent,

		Worker,

		WebApi,

		WebApiWindowsAuth,

		[ChoiceName("WebAPI:Forms Authentication")]
		WebApiFormsAuth,

		[ChoiceName("Web - Distributed")]
		WebDistributed,

		WebDistributedWindowsAuth,

		[ChoiceName("Web - Distributed:Forms Authentication")]
		WebDistributedFormsAuth,

		[ChoiceName("Web Background Processing")]
		WebBackgroundProcessing,

		Services,

		[ChoiceName("Fileshare")]
		FileShare,

		[ChoiceName("WebAPI:AD Authentication")]
		WebApiAuthentication,

		Unknown
	}
}
