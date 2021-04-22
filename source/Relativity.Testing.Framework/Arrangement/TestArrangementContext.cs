using System;
using Relativity.Testing.Framework.Session;

namespace Relativity.Testing.Framework.Arrangement
{
	/// <summary>
	/// Represents the context of test arrangement.
	/// </summary>
	public class TestArrangementContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TestArrangementContext" /> class.
		/// </summary>
		/// <param name="facade">The facade.</param>
		/// <param name="session">The session.</param>
		/// <param name="entityCreator">The generic entity creator.</param>
		public TestArrangementContext(IRelativityFacade facade, TestSession session, IGenericEntityCreator entityCreator)
		{
			Facade = facade ?? throw new ArgumentNullException(nameof(facade));
			Session = session ?? throw new ArgumentNullException(nameof(session));
			EntityCreator = entityCreator ?? throw new ArgumentNullException(nameof(entityCreator));
		}

		/// <summary>
		/// Gets the facade.
		/// </summary>
		public IRelativityFacade Facade { get; }

		/// <summary>
		/// Gets the session.
		/// </summary>
		public TestSession Session { get; }

		/// <summary>
		/// Gets the generic entity creator.
		/// </summary>
		public IGenericEntityCreator EntityCreator { get; }
	}
}
