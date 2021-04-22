namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents the strategy of workspace entity deletion.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public interface IDeleteWorkspaceEntityByIdStrategy<T>
	{
		/// <summary>
		/// Deletes the workspace entity by the specified IDs of workspace and entity.
		/// </summary>
		/// <param name="workspaceId">The workspace ID.</param>
		/// <param name="entityId">The entity ID.</param>
		void Delete(int workspaceId, int entityId);
	}
}
