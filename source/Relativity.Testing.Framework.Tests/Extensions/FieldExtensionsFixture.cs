using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Extensions;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Extensions
{
	[TestFixture]
	[TestOf(typeof(FieldExtensions))]
	public class FieldExtensionsFixture
	{
		[Test]
		public void ToCategoryField_CopiesPropertiesFromField()
		{
			Field field = new Field
			{
				Name = "A field",
				ArtifactID = 12345,
				FieldType = FieldType.Currency,
				IsRequired = true
			};

			CategoryField categoryField = field.ToCategoryField();

			categoryField.FieldArtifactID.Should().Be(field.ArtifactID);
			categoryField.DisplayName.Should().Be(field.Name);
			categoryField.FieldTypeID.Should().Be(field.FieldType);
			categoryField.IsRequired.Should().Be(field.IsRequired);
			categoryField.FieldDisplayType.Should().Be(FieldDisplayType.Currency);
		}
	}
}
