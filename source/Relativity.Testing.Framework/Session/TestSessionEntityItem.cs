namespace Relativity.Testing.Framework.Session
{
	/// <summary>
	/// Represents the entity item tracked in <see cref="TestSession"/>.
	/// </summary>
	public class TestSessionEntityItem
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TestSessionEntityItem"/> class.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="workspaceId">The workspace ID.</param>
		public TestSessionEntityItem(object entity, int workspaceId = -1)
		{
			Entity = entity;
			WorkspaceId = workspaceId;
		}

		/// <summary>
		/// Gets the entity.
		/// </summary>
		public object Entity { get; }

		/// <summary>
		/// Gets the workspace ID.
		/// </summary>
		public int WorkspaceId { get; }

		/// <summary>
		/// Gets or sets a value indicating whether to delete this entity on cleanup of <see cref="TestSession"/>.
		/// </summary>
		public bool CleanUp { get; set; } = true;
	}
}
