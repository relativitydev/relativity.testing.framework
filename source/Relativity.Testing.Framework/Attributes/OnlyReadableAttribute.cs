using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Indicates that property is only readable.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class OnlyReadableAttribute : Attribute
	{
	}
}
