using System;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the choice name of the enum value.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	public class ChoiceNameAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChoiceNameAttribute"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		public ChoiceNameAttribute(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		public string Name { get; }
	}
}
