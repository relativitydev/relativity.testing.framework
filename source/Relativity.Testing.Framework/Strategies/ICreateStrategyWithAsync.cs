using System.Threading.Tasks;

namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents the strategy of entity creation that supports asynchronous operations.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public interface ICreateStrategyWithAsync<T> : ICreateStrategy<T>
	{
		/// <summary>
		/// Asynchronously creates the specified entity.
		/// </summary>
		/// <param name="entity">The entity to create.</param>
		/// <returns>The task representing asynchronous operation of entity creation with created entity as result.</returns>
		Task<T> CreateAsync(T entity);
	}
}
