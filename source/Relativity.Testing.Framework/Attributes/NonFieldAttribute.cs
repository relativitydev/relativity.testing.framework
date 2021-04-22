using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Indicates that property is non-field.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class NonFieldAttribute : Attribute
	{
	}
}
