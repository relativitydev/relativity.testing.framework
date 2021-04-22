namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents an object dependent on another object selected for deletion.
	/// </summary>
	public class Dependency
	{
		/// <summary>
		/// Gets or sets a string indicating the type of the Relativity object dependent on the object selected for deletion.
		/// </summary>
		public Securable<string> ObjectType { get; set; }

		/// <summary>
		/// Gets or sets a string indicating whether a dependent object is deleted or unlinked when a specific object is deleted.
		/// </summary>
		/// <remarks>
		/// For example, this will have a value of "Delete" if the dependent object will be be deleted, or "Unlink" if the dependent object will be modified.
		/// </remarks>
		public string Action { get; set; }

		/// <summary>
		/// Gets or sets the number of objects with a dependency on a specific object selected for deletion.
		/// </summary>
		public Securable<int?> Count { get; set; }

		/// <summary>
		/// Gets or sets a string indicating whether the object for deletion is a parent, or a field on a single or multiple object field.
		/// </summary>
		/// <remarks>
		/// For example, the Connection property has a value of Parent when the dependent object is a child, and a value of
		/// Field: {field name} when the dependent object is a field on a single or multiple object field.
		/// </remarks>
		public Securable<string> Connection { get; set; }

		/// <summary>
		/// Gets or sets the degree of dependency between object types.
		/// </summary>
		/// <remarks>
		/// The hierarchical level helps to differentiate between the fields and views associated with a child object type and those directly
		/// associated with the object for deletion. For example, an object type selected for deletion has a child object type. The fields
		/// and views associated with the child object type have a dependency with a hierarchical level of 1. The fields and views directly
		/// associated with this object for deletion have a hierarchical level of 0.
		/// </remarks>
		public int HierarchicLevel { get; set; }
	}
}
