using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// The enum defines valid values for Relativity production status.
	/// </summary>
	public enum ProductionStatus
	{
		/// <summary>
		/// The production set is set up, but no data sources are added.
		/// </summary>
		New,

		/// <summary>
		/// Relativity is staging the production.
		/// </summary>
		Staging,

		/// <summary>
		/// Staging is complete.
		/// </summary>
		Staged,

		/// <summary>
		/// Relativity experienced an error when building the list of documents for production.
		/// Make sure to correct the staging errors and re-stage the production before you run the production.
		/// </summary>
		[ChoiceName("Staging error")]
		StagingError,

		/// <summary>
		/// Obsolete - Use Queued for Staging or Queued for Production.
		/// </summary>
		Waiting,

		/// <summary>
		/// Relativity is assigning production numbers to the documents.
		/// </summary>
		Producing,

		/// <summary>
		/// Relativity is branding the images.
		/// </summary>
		Branding,

		/// <summary>
		/// The production is complete and ready for export.
		/// </summary>
		Produced,

		/// <summary>
		/// Relativity experienced an error while producing the documents.
		/// </summary>
		Error,

		/// <summary>
		/// Relativity produced the documents with errors.
		/// </summary>
		ProducedWithErrors,

		/// <summary>
		/// Relativity is creating slip sheets for the production.
		/// </summary>
		[ChoiceName("Creating Placeholder Images")]
		ProducingCreatingPlaceholderImages,

		/// <summary>
		/// Relativity is applying Bates numbers to the production.
		/// </summary>
		[ChoiceName("Creating and Applying Bates Numbers")]
		ProducingCreatingAndApplyingBatesNumbers,

		/// <summary>
		/// Relativity is creating records for the Branding queue.
		/// </summary>
		[ChoiceName("Creating Branding Queue Records")]
		ProducingCreatingBrandingQueueRecords,

		/// <summary>
		/// Relativity is running saved searches associated with the production data source.
		/// </summary>
		[ChoiceName("Running Saved Searches")]
		StagingRunningSavedSearches,

		/// <summary>
		/// Relativity pre-sorts the documents and deletes any Production Information objects that may already exist if the production is being re-staged.
		/// </summary>
		[ChoiceName("Cleaning Up Data")]
		StagingCleaningUpData,

		/// <summary>
		/// Relativity is creating the Production Information records associated with the production.
		/// </summary>
		[ChoiceName("Creating Production Information Records")]
		StagingCreatingProductionInformationRecords,

		/// <summary>
		/// Relativity is canceling the production process.
		/// </summary>
		Canceling,

		/// <summary>
		/// Relativity is cleaning up the existing files associated with the production.
		/// </summary>
		[ChoiceName("Cleaning Existing Files")]
		ProducingCleaningExistingFiles,

		/// <summary>
		/// Staging Job has been created in the queue but has not been picked up by an agent.
		/// </summary>
		[ChoiceName("Queued for Staging")]
		QueuedForStaging,

		/// <summary>
		///  Run Production Job has been created in the queue but has not been picked up by an agent.
		/// </summary>
		[ChoiceName("Queued for Production")]
		QueuedForProduction,

		/// <summary>
		///  Run Production Job has been created in the queue after the producing steps. Waiting for branding agents to begin work.
		/// </summary>
		[ChoiceName("Queued for Branding")]
		QueuedForBranding,

		/// <summary>
		///  Status entered when automatically running a production, after Staged but before Producing.
		/// </summary>
		StartingProduction,

		/// <summary>
		///  Status entered when the StartingProduction status has error.
		/// </summary>
		ErrorStartingProduction,

		/// <summary>
		/// Someone made a different choice in the environment, and we're not able to map it back to an enum.
		/// </summary>
		Unknown
	}
}
