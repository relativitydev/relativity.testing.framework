using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Extensions
{
	internal static class ChoiceExtensions
	{
		internal static ChoiceRequest ToChoiceRequest(this Choice choice)
		{
			ChoiceRequest choiceRequest = new ChoiceRequest
			{
				Order = choice.Order,
				ArtifactID = choice.ArtifactID,
				Color = choice.Color,
				Field = choice.Field,
				Name = choice.Name,
				Parent = choice.Parent
			};

			return choiceRequest;
		}
	}
}
