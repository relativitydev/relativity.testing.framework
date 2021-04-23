using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the object type name of the class.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class ObjectTypeNameAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectTypeNameAttribute"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		public ObjectTypeNameAttribute(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		public string Name { get; }
	}
}
