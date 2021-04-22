using Relativity.Testing.Framework.Session;

namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents base strategy of workspace entity deletion.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public abstract class DeleteWorkspaceEntityByIdStrategy<T> : IDeleteWorkspaceEntityByIdStrategy<T>
	{
		/// <summary>
		/// Deletes the workspace entity by the specified IDs of workspace and entity.
		/// </summary>
		/// <param name="workspaceId">The workspace ID.</param>
		/// <param name="entityId">The entity ID.</param>
		public void Delete(int workspaceId, int entityId)
		{
			DoDelete(workspaceId, entityId);

			TestSession.Current?.Remove(workspaceId, entityId);
		}

		/// <summary>
		/// Does delete the entity by IDs of workspace and entity.
		/// </summary>
		/// <param name="workspaceId">The workspace ID.</param>
		/// <param name="entityId">The entity ID.</param>
		protected abstract void DoDelete(int workspaceId, int entityId);
	}
}
