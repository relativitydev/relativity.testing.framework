using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the object field guid of the property.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class FieldGuidAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FieldGuidAttribute"/> class.
		/// </summary>
		/// <param name="id">The guid of the field.</param>
		public FieldGuidAttribute(string id)
		{
			Id = Guid.Parse(id);
		}

		/// <summary>
		/// Gets the id.
		/// </summary>
		public Guid Id { get; }
	}
}
