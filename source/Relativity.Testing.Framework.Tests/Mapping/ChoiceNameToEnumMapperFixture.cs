using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Logging;
using Relativity.Testing.Framework.Mapping;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Tests.Mapping
{
	[TestFixture]
	[TestOf(typeof(ChoiceNameToEnumMapper))]
	public class ChoiceNameToEnumMapperFixture
	{
		private readonly List<Type> _unknownEnumExclusionList = new List<Type>
		{
			typeof(ObjectPermissionKinds),
			typeof(LogLevel),
			typeof(SqlFullTextLanguage)
		};

		[Test]
		public void GetEnumValue_ReturnsUnknownWhenGivenAValueOutsideOfTheEnums()
		{
			var result = (ResourceServerType)ChoiceNameToEnumMapper.GetEnumValue(typeof(ResourceServerType), Randomizer.GetString());

			result.Should().Be(ResourceServerType.Unknown);
		}

		[Test]
		public void GetEnumValue_HandlesUnknownForAllEnums()
		{
			Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().First(x => x.GetName().Name == "Relativity.Testing.Framework");
			var types = assembly.GetTypes().Where(t => t.IsEnum && t.IsPublic && !_unknownEnumExclusionList.Contains(t));

			foreach (Type t in types)
			{
				Assert.DoesNotThrow(() => ChoiceNameToEnumMapper.GetEnumValue(t, Randomizer.GetString()));
			}
		}
	}
}
