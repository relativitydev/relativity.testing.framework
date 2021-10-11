using System;
using System.Collections.Generic;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Extensions
{
	/// <summary>
	/// Field extension functions.
	/// </summary>
	public static class FieldExtensions
	{
		private static Dictionary<FieldType, FieldDisplayType> _fieldDisplayTypeMap = new Dictionary<FieldType, FieldDisplayType>
		{
			{ FieldType.FixedLength, FieldDisplayType.Text },
			{ FieldType.WholeNumber, FieldDisplayType.Integer },
			{ FieldType.Date, FieldDisplayType.Date },
			{ FieldType.YesNo, FieldDisplayType.BooleanRadioButton },
			{ FieldType.LongText, FieldDisplayType.MultilineText },
			{ FieldType.SingleChoice, FieldDisplayType.CodeRadioButtonList },
			{ FieldType.Decimal, FieldDisplayType.Decimal },
			{ FieldType.Currency, FieldDisplayType.Currency },
			{ FieldType.MultipleChoice, FieldDisplayType.MultiCodePicker },
			{ FieldType.File, FieldDisplayType.File },
			{ FieldType.SingleObject, FieldDisplayType.ObjectPicker },
			{ FieldType.User, FieldDisplayType.UserPicker },
			{ FieldType.MultipleObject, FieldDisplayType.ObjectsPicker },
		};

		/// <summary>
		/// Creates a category field based on a field.
		/// </summary>
		/// <param name="field">The requested field.</param>
		/// <returns>A <see cref="CategoryField"/>.</returns>
		public static CategoryField ToCategoryField(this Field field)
		{
			if (field == null)
			{
				throw new ArgumentNullException(nameof(field));
			}

			return new CategoryField
			{
				DisplayName = field.Name,
				FieldArtifactID = field.ArtifactID,
				FieldDisplayType = _fieldDisplayTypeMap[field.FieldType],
				FieldTypeID = field.FieldType,
				IsRequired = field.IsRequired
			};
		}
	}
}
