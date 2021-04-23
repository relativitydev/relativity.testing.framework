using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the guid for the object type.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class ObjectTypeGuidAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectTypeGuidAttribute"/> class.
		/// </summary>
		/// <param name="id">The id of the objecttype.</param>
		public ObjectTypeGuidAttribute(string id)
		{
			Id = Guid.Parse(id);
		}

		/// <summary>
		/// Gets the id.
		/// </summary>
		public Guid Id { get; }
	}
}
