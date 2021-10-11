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
		/// <summary>
		/// Initializes a new instance of the <see cref="ChoiceTypeAttribute"/> class.
		/// </summary>
		/// <param name="choiceTypeId">ArtifactId for ChoiceType.</param>
		public ChoiceTypeAttribute(int choiceTypeId)
		{
			ChoiceTypeId = choiceTypeId;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ChoiceTypeAttribute"/> class.
		/// </summary>
		/// <param name="objectType">The object type.</param>
		/// <param name="objectFieldName">The field name.</param>
		public ChoiceTypeAttribute(Type objectType, string objectFieldName)
			: this(ObjectTypeNameResolver.Resolve(objectType), objectFieldName)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ChoiceTypeAttribute"/> class.
		/// </summary>
		/// <param name="objectTypeName">The object type name.</param>
		/// <param name="objectFieldName">The object field name.</param>
		public ChoiceTypeAttribute(string objectTypeName, string objectFieldName)
		{
			ObjectTypeName = objectTypeName;
			ObjectFieldName = objectFieldName;
		}

		/// <summary>
		/// Gets the ChoiceTypeId.
		/// </summary>
		public int? ChoiceTypeId { get; }

		/// <summary>
		/// Gets the ObjectTypeName.
		/// </summary>
		public string ObjectTypeName { get; }

		/// <summary>
		/// Gets the ObjectFieldName.
		/// </summary>
		public string ObjectFieldName { get; }
	}
}
