using System.Threading.Tasks;
using Relativity.Testing.Framework.Models;
using Relativity.Testing.Framework.Session;

namespace Relativity.Testing.Framework.Strategies
{
	public abstract class CreateStrategyWithAsync<T> : CreateStrategy<T>, ICreateStrategyWithAsync<T>
		where T : Artifact
	{
		/// <summary>
		/// Asynchronously creates the specified entity.
		/// Before the creation ensures that <paramref name="entity"/> is not null
		/// and fills required properties of entity if it implements <see cref="IFillsRequiredProperties{T}"/>.
		/// After the creation adds created entity to the current session.
		/// </summary>
		/// <param name="entity">The entity to create.</param>
		/// <returns>The task representing asynchronous operation of entity creation.</returns>
		public async Task<T> CreateAsync(T entity)
		{
			ValidateEntity(entity);

			T createdEntity = await DoCreateAsync(entity).ConfigureAwait(false);

			TestSession.Current?.Add(createdEntity);

			return createdEntity;
		}

		/// <summary>
		/// Asynchronously does create the specified entity.
		/// </summary>
		/// <param name="entity">The entity to create.</param>
		/// <returns>The task representing asynchronous operation of entity creation.</returns>
		protected abstract Task<T> DoCreateAsync(T entity);
	}
}
