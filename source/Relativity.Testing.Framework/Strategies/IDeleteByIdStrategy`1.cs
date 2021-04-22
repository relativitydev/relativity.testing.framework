namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents the strategy of entity deletion.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public interface IDeleteByIdStrategy<T>
	{
		/// <summary>
		/// Deletes the entity by ID.
		/// </summary>
		/// <param name="id">The artifact ID of the entity.</param>
		void Delete(int id);
	}
}
