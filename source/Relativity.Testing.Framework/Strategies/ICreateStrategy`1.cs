namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents the strategy of entity creation.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public interface ICreateStrategy<T>
	{
		/// <summary>
		/// Creates the specified entity.
		/// </summary>
		/// <param name="entity">The entity to create.</param>
		/// <returns>The created entity.</returns>
		T Create(T entity);
	}
}
