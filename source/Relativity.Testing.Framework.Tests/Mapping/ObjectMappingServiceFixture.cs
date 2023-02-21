using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Mapping;
using Relativity.Testing.Framework.Tests.Models.Mapping;

namespace Relativity.Testing.Framework.Tests.Mapping
{
	[TestFixture]
	[TestOf(typeof(ObjectMappingService))]
	public class ObjectMappingServiceFixture
	{
		[Test]
		public void Map_MapsDoubleValue_OntoDecimalProperty()
		{
			var sut = new ObjectMappingService();

			double testDoubleValue = 5.25;

			var testPropertiesMap = new Dictionary<string, object>();

			testPropertiesMap.Add("TestProperty", testDoubleValue);

			var testObject = new ObjectMappingServiceFixtureTestObject();

			sut.Map(testPropertiesMap, testObject, MappingOptions.Default);

			decimal expectedDecimalValue = new decimal(testDoubleValue);

			testObject.TestProperty.Should().Be(expectedDecimalValue);
		}
	}
}
