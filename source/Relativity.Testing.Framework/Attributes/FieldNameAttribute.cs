using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the object field name of the property.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class FieldNameAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FieldNameAttribute"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		public FieldNameAttribute(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		public string Name { get; }
	}
}
