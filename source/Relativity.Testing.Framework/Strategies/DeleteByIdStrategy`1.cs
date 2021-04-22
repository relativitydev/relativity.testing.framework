using Relativity.Testing.Framework.Session;

namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents base strategy of entity deletion.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public abstract class DeleteByIdStrategy<T> : IDeleteByIdStrategy<T>
	{
		/// <summary>
		/// Deletes the entity by ID.
		/// After the deletion removes entity from the current session with specified ID.
		/// </summary>
		/// <param name="id">The artifact ID of the entity.</param>
		public void Delete(int id)
		{
			DoDelete(id);

			TestSession.Current?.Remove(id);
		}

		/// <summary>
		/// Does delete the entity by ID.
		/// </summary>
		/// <param name="id">The artifact ID of the entity.</param>
		protected abstract void DoDelete(int id);
	}
}
