using System;
using Relativity.Testing.Framework.Models;
using Relativity.Testing.Framework.Session;

namespace Relativity.Testing.Framework.Strategies
{
	/// <summary>
	/// Represents base strategy of entity creation.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	public abstract class CreateStrategy<T> : ICreateStrategy<T>
		where T : Artifact
	{
		/// <summary>
		/// Creates the specified entity.
		/// Before the creation ensures that <paramref name="entity"/> is not null
		/// and fills required properties of entity if it implements <see cref="IFillsRequiredProperties{T}"/>.
		/// After the creation adds created entity to the current session.
		/// </summary>
		/// <param name="entity">The entity to create.</param>
		/// <returns>The created entity.</returns>
		public T Create(T entity)
		{
			if (entity is null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			(entity as IFillsRequiredProperties<T>)?.FillRequiredProperties();

			T createdEntity = DoCreate(entity);

			TestSession.Current?.Add(createdEntity);

			return createdEntity;
		}

		/// <summary>
		/// Does create the specified entity.
		/// </summary>
		/// <param name="entity">The entity to create.</param>
		/// <returns>The created entity.</returns>
		protected abstract T DoCreate(T entity);
	}
}
