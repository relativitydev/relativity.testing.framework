using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Relativity.Testing.Framework.Configuration
{
	/// <summary>
	/// <see cref="IConfigurationBuilder"/> extensions for NUnit.
	/// </summary>
	public static class NUnitConfigurationBuilderExtensions
	{
		/// <summary>
		/// Adds the NUnit parameters to <paramref name="configurationBuilder"/>.
		/// </summary>
		/// <param name="configurationBuilder">The <see cref="IConfigurationBuilder"/> to add to.</param>
		/// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
		public static IConfigurationBuilder AddNUnitParameters(this IConfigurationBuilder configurationBuilder)
		{
			return configurationBuilder.AddInMemoryCollection(GetNUnitTestParameters());
		}

		private static IEnumerable<KeyValuePair<string, string>> GetNUnitTestParameters()
		{
			return TestContext.Parameters.Names.ToDictionary(x => x, x => TestContext.Parameters[x]);
		}
	}
}
