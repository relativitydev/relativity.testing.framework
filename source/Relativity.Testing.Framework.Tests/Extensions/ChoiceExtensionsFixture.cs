using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Extensions;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Extensions
{
	[TestFixture]
	[TestOf(typeof(ChoiceExtensions))]
	public class ChoiceExtensionsFixture
	{
		[Test]
		public void ToChoiceRequest_CopiesPropertiesFromChoice()
		{
			NamedArtifact field = new NamedArtifact { ArtifactID = 45678 };
			NamedArtifact objectType = new NamedArtifact { ArtifactID = 23456 };
			NamedArtifact parent = new NamedArtifact { ArtifactID = 34567 };

			Choice choice = new Choice
			{
				Active = true,
				ArtifactID = 12345,
				Color = ChoiceColor.Gray,
				Field = field,
				Name = "AField",
				ObjectType = objectType,
				Order = 1,
				Parent = parent
			};

			ChoiceRequest choiceRequest = choice.ToChoiceRequest();

			choiceRequest.ArtifactID.Should().Be(12345);
			choiceRequest.Color.Should().Be(ChoiceColor.Gray);
			choiceRequest.Field.Should().Be(field);
			choiceRequest.Name.Should().Be("AField");
			choiceRequest.Order.Should().Be(1);
			choiceRequest.Parent.Should().Be(parent);
		}
	}
}
