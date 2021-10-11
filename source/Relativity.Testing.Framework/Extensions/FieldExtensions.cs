﻿using System;
using System.Collections.Generic;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Extensions
{
	/// <summary>
	/// Extension of FieldTypes.
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
		/// Converts a Field into a CategoryField.
		/// </summary>
		/// <param name="field">A field object.</param>
		/// <returns>A converted CategoryField object.</returns>
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
