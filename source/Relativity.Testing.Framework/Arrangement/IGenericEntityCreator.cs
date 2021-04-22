namespace Relativity.Testing.Framework.Arrangement
{
	/// <summary>
	/// Represents the factory that can create generic entities.
	/// </summary>
	public interface IGenericEntityCreator
	{
		/// <summary>
		/// Creates the specified entity.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <param name="entity">The entity.</param>
		/// <returns>The created entity.</returns>
		TEntity Create<TEntity>(TEntity entity);
	}
}
