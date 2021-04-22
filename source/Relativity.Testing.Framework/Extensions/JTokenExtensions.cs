using Newtonsoft.Json.Linq;

namespace Relativity.Testing.Framework.Extensions
{
	/// <summary>
	/// Provides a set of extension methods for <see cref="JToken"/>.
	/// </summary>
	public static class JTokenExtensions
	{
		/// <summary>
		/// Remove null and empty properties for <see cref="JTokenType.Object"/> and <see cref="JTokenType.Array"/>.
		/// </summary>
		/// <param name="token">The token.</param>
		/// <returns>Json token.</returns>
		public static JToken RemoveNullAndEmptyProperties(this JToken token)
		{
			if (token.Type == JTokenType.Object)
			{
				JObject copy = new JObject();
				foreach (JProperty prop in token.Children<JProperty>())
				{
					JToken child = prop.Value;
					if (child.HasValues)
					{
						child = RemoveNullAndEmptyProperties(child);
					}

					if (!IsEmpty(child))
					{
						copy.Add(prop.Name, child);
					}
				}

				return copy;
			}
			else if (token.Type == JTokenType.Array)
			{
				JArray copy = new JArray();
				foreach (JToken item in token.Children())
				{
					JToken child = item;
					if (child.HasValues)
					{
						child = RemoveNullAndEmptyProperties(child);
					}

					if (!IsEmpty(child))
					{
						copy.Add(child);
					}
				}

				return copy;
			}

			return token;
		}

		public static bool IsEmpty(JToken token)
		{
			return token.Type == JTokenType.Null;
		}
	}
}
