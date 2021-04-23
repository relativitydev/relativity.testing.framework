using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Relativity.Testing.Framework.Models;
using Relativity.Testing.Framework.Strategies;

namespace Relativity.Testing.Framework.Session
{
	/// <summary>
	/// Represents the test session.
	/// Test session scope can be global, fixture or test.
	/// </summary>
	public sealed class TestSession : IDisposable
	{
		private static readonly AsyncLocal<TestSession> _current = new AsyncLocal<TestSession>();

		private readonly List<TestSession> _children = new List<TestSession>();

		private readonly List<TestSessionEntityItem> _entityItems = new List<TestSessionEntityItem>();

		private bool _isDisposed;

		private IRelativityFacade _facade;

		private TestSession()
		{
		}

		/// <summary>
		/// Gets or sets the current session that can be unique for each parallel thread/test (using <see cref="AsyncLocal{T}"/>).
		/// </summary>
		public static TestSession Current
		{
			get => _current.Value ?? Global;
			set => _current.Value = value;
		}

		/// <summary>
		/// Gets the global session that is the common and root session for tests run.
		/// </summary>
		public static TestSession Global { get; } = new TestSession();

		/// <summary>
		/// Gets the parent session or <see langword="null"/> for <see cref="Global"/>.
		/// </summary>
		public TestSession Parent { get; private set; }

		/// <summary>
		/// Gets the collection of child sessions.
		/// </summary>
		public IEnumerable<TestSession> Children => _children.AsReadOnly();

		/// <summary>
		/// Gets the combined collection of all entity items of parent sessions with this session.
		/// </summary>
		public IEnumerable<TestSessionEntityItem> EntityItems =>
			Parent == null ? _entityItems.AsReadOnly() : Parent.EntityItems.Concat(_entityItems);

		/// <summary>
		/// Gets the combined collection of all entities of parent sessions with this session.
		/// </summary>
		public IEnumerable<object> Entities
		{
			get
			{
				var entities = _entityItems.Select(x => x.Entity);

				return Parent == null ? entities : Parent.Entities.Concat(entities);
			}
		}

		private Dictionary<Type, object> WorkingEntities { get; } = new Dictionary<Type, object>();

		internal IRelativityFacade Facade
		{
			get => _facade ?? Parent?.Facade ?? RelativityFacade.Instance;
			set => _facade = value;
		}

		/// <summary>
		/// Gets the name of the current test fixture.
		/// </summary>
		public static string TestFixtureName
		{
			get
			{
				ITest testItem = TestExecutionContext.CurrentContext.CurrentTest;

				if (testItem is SetUpFixture)
				{
					return testItem.Fixture != null ? testItem.Fixture.GetType().Name : testItem.FullName;
				}

				do
				{
					if (testItem is TestFixture)
					{
						return testItem.Name;
					}

					testItem = testItem.Parent;
				}
				while (testItem != null);

				return null;
			}
		}

		/// <summary>
		/// Gets the name of the current test.
		/// </summary>
		public static string TestName
		{
			get
			{
				ITest testItem = TestExecutionContext.CurrentContext.CurrentTest;

				if (testItem is SetUpFixture)
				{
					return testItem.Fixture != null ? testItem.Fixture.GetType().Name : testItem.FullName;
				}

				return TestExecutionContext.CurrentContext.CurrentTest.Name;
			}
		}

		/// <summary>
		/// Get all the entities of particular type in session hierarchy.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <returns>The collection of<typeparamref name="TEntity"/>.</returns>
		public IEnumerable<TEntity> All<TEntity>()
		{
			return Entities.OfType<TEntity>();
		}

		/// <summary>
		/// Gets the first entity of specified type from session hierarchy.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <returns>The entity found.</returns>
		public TEntity First<TEntity>()
		{
			TEntity entity = All<TEntity>().FirstOrDefault();

			if (entity != null)
			{
				return entity;
			}
			else
			{
				throw CreateEntityNotFoundException<TEntity>();
			}
		}

		/// <summary>
		/// Gets the last entity of specified type from session hierarchy.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <returns>The entity found.</returns>
		public TEntity Last<TEntity>()
		{
			TEntity entity = All<TEntity>().LastOrDefault();

			if (entity != null)
			{
				return entity;
			}
			else
			{
				throw CreateEntityNotFoundException<TEntity>();
			}
		}

		private static Exception CreateEntityNotFoundException<TEntity>()
		{
			return new ObjectNotFoundException($"Test session doesn't contain any {typeof(TEntity).Name} object.");
		}

		/// <summary>
		/// Gets the current working entity of specified type from session hierarchy.
		/// If there is no entity previously set using <see cref="SetWorking"/> method,
		/// returns last entity of specified type added to session hierarchy.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <returns>The entity found.</returns>
		public TEntity Working<TEntity>()
		{
			object workingEntity = FindWorking(typeof(TEntity));

			return workingEntity != null ? (TEntity)workingEntity : Last<TEntity>();
		}

		private object FindWorking(Type entityType)
		{
			if (WorkingEntities.TryGetValue(entityType, out object workingEntity))
			{
				return workingEntity;
			}
			else if (Parent != null)
			{
				return Parent.FindWorking(entityType);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Sets the entity as current working one of specified type.
		/// </summary>
		/// <typeparam name="TEntity">The type of the entity.</typeparam>
		/// <param name="entity">The entity.</param>
		public void SetWorking<TEntity>(TEntity entity)
		{
			WorkingEntities[typeof(TEntity)] = entity;
		}

		/// <summary>
		/// Adds the entity to the session.
		/// </summary>
		/// <param name="entity">The entity to add.</param>
		public void Add(Artifact entity)
		{
			_entityItems.Add(new TestSessionEntityItem(entity));
		}

		/// <summary>
		/// Adds the workspace entity to the session.
		/// </summary>
		/// <param name="workspaceId">The workspace ID.</param>
		/// <param name="entity">The entity to add.</param>
		public void Add(int workspaceId, Artifact entity)
		{
			_entityItems.Add(new TestSessionEntityItem(entity, workspaceId));
		}

		/// <summary>
		/// Removes an entity from the session by the specified ID.
		/// </summary>
		/// <param name="entityId">The entity ID.</param>
		public void Remove(int entityId)
		{
			if (Parent != null)
			{
				Parent.Remove(entityId);
			}

			_entityItems.RemoveAll(x => (x.Entity as Artifact)?.ArtifactID == entityId);
		}

		/// <summary>
		/// Removes an entity from the session by the specified IDs of workspace and entity.
		/// </summary>
		/// <param name="workspaceId">The workspace ID.</param>
		/// <param name="entityId">The entity ID.</param>
		public void Remove(int workspaceId, int entityId)
		{
			if (Parent != null)
			{
				Parent.Remove(workspaceId, entityId);
			}

			_entityItems.RemoveAll(x => x.WorkspaceId == workspaceId && (x.Entity as Artifact)?.ArtifactID == entityId);
		}

		/// <summary>
		/// Sets the value whether to delete the entity on cleanup.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="delete">Whether to delete.</param>
		public void SetCleanUp(object entity, bool delete)
		{
			var entityItem = EntityItems.FirstOrDefault(x => x.Entity.Equals(entity));

			if (entityItem != null)
			{
				entityItem.CleanUp = delete;
			}
		}

		/// <summary>
		/// Sets the value whether to delete the entities on cleanup.
		/// </summary>
		/// <param name="entities">The entities.</param>
		/// <param name="delete">Whether to delete.</param>
		public void SetCleanUp(IEnumerable<object> entities, bool delete)
		{
			var entityItems = EntityItems.Where(x => entities.Any(entity => entity.Equals(x.Entity)));

			foreach (var entityItem in entityItems)
			{
				entityItem.CleanUp = delete;
			}
		}

		/// <summary>
		/// Starts the child session.
		/// </summary>
		/// <returns>The newly created <see cref="TestSession"/> instance.</returns>
		public TestSession StartChildSession()
		{
			TestSession session = new TestSession { Parent = this };
			_children.Add(session);

			return session;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases unmanaged and optionally managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		private void Dispose(bool disposing)
		{
			if (!_isDisposed)
			{
				if (disposing)
				{
					ClearSessionTree();
					ClearState();
				}

				_isDisposed = true;
			}
		}

		private void ClearSessionTree()
		{
			if (Parent != null)
			{
				Parent._children.Remove(this);
			}

			foreach (TestSession child in Children.ToArray())
			{
				child.Dispose();
			}
		}

		private void ClearState()
		{
			foreach (TestSessionEntityItem entityItem in _entityItems.AsEnumerable().Reverse().ToArray())
			{
				Delete(entityItem);
			}

			_entityItems.Clear();
		}

		private void Delete(TestSessionEntityItem entityItem)
		{
			if (entityItem.CleanUp && entityItem.Entity is Artifact artifact)
			{
				if (entityItem.WorkspaceId > 0)
				{
					if (ShouldDeleteWorkspaceArtifact(entityItem.WorkspaceId))
					{
						DeleteWorkspaceArtifact(entityItem.WorkspaceId, artifact);
					}
				}
				else
				{
					DeleteArtifact(artifact);
				}
			}
		}

		private bool ShouldDeleteWorkspaceArtifact(int workspaceId)
		{
			var workspaceEntityItem = EntityItems.LastOrDefault(x => (x.Entity as Workspace)?.ArtifactID == workspaceId);

			return workspaceEntityItem == null || !workspaceEntityItem.CleanUp;
		}

		private void DeleteArtifact(Artifact artifact)
		{
			try
			{
				Type deleteStrategyType = typeof(IDeleteByIdStrategy<>).MakeGenericType(artifact.GetType());

				dynamic deleteStrategy = Facade.Resolve(deleteStrategyType);

				deleteStrategy.Delete(artifact.ArtifactID);
			}
			catch (Exception exception)
			{
				TestContext.WriteLine($"Session cleanup action failed when tried to delete {artifact.GetType().FullName} by ID {artifact.ArtifactID}: {exception}");
			}
		}

		private void DeleteWorkspaceArtifact(int workspaceId, Artifact artifact)
		{
			try
			{
				Type deleteStrategyType = typeof(IDeleteWorkspaceEntityByIdStrategy<>).MakeGenericType(artifact.GetType());

				dynamic deleteStrategy = Facade.Resolve(deleteStrategyType);

				deleteStrategy.Delete(workspaceId, artifact.ArtifactID);
			}
			catch (Exception exception)
			{
				TestContext.WriteLine($"Session cleanup action failed when tried to delete {artifact.GetType().FullName} by ID {artifact.ArtifactID}: {exception}");
			}
		}
	}
}
