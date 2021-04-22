using System;
using Relativity.Testing.Framework.Mapping;

namespace Relativity.Testing.Framework.Attributes
{
	/// <summary>
	/// Specifies the choice type associated with the enum.
	/// </summary>
	[AttributeUsage(AttributeTargets.Enum)]
	public class ChoiceTypeAttribute : Attribute
	{
		public ChoiceTypeAttribute(int choiceTypeId)
		{
			ChoiceTypeId = choiceTypeId;
		}

		public ChoiceTypeAttribute(Type objectType, string objectFieldName)
			: this(ObjectTypeNameResolver.Resolve(objectType), objectFieldName)
		{
		}

		public ChoiceTypeAttribute(string objectTypeName, string objectFieldName)
		{
			ObjectTypeName = objectTypeName;
			ObjectFieldName = objectFieldName;
		}

		public int? ChoiceTypeId { get; }

		public string ObjectTypeName { get; }

		public string ObjectFieldName { get; }
	}
}
