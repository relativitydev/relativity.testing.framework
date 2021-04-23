using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Attributes;
using Relativity.Testing.Framework.Mapping;

namespace Relativity.Testing.Framework.Tests.Mapping
{
	[TestFixture]
	[TestOf(typeof(ObjectFieldMapping))]
	public static class ObjectFieldMappingFixture
	{
		private const string GUIDSTRING = "12345678-1234-1234-1234-1234567890ab";

		[Test]
		public static void GetPropertyNames_ReturnsNamesOfProperties()
		{
			var result = ObjectFieldMapping.GetPropertyNames<SomeObject>();
			result.Should().Contain(new List<string> { "ArtifactID", "Name" });
		}

		[Test]
		public static void GetFieldNames_ReturnsSanitizedFieldNames()
		{
			var result = ObjectFieldMapping.GetFieldNames<SomeObject>();
			result.Should().Contain(new List<string> { "Artifact ID", "Name" });
		}

		[Test]
		public static void Get_ReturnsFieldsAsKeys()
		{
			var result = ObjectFieldMapping.Get(typeof(SomeObject));
			result.Should().ContainKeys(new[] { "Artifact ID", "Name" });
		}

		[Test]
		public static void Get_ReturnsPropertiesAsValues()
		{
			var result = ObjectFieldMapping.Get(typeof(SomeObject));
			result.Should().ContainValues(new[] { "ArtifactID", "Name" });
		}

		[Test]
		public static void Get_UsesFieldNameAttributeToDesignateField()
		{
			var result = ObjectFieldMapping.Get(typeof(ObjectWithFieldNameAttribute));
			result.Should().ContainKeys(new[] { "AFieldName" });
			result.Should().ContainValues(new[] { "ArtifactID" });
		}

		[Test]
		public static void Get_UsesFieldGuidAttributeToDesignateField()
		{
			var result = ObjectFieldMapping.Get(typeof(ObjectWithFieldGuidAttribute));
			result.Should().ContainKeys(new[] { GUIDSTRING });
			result.Should().ContainValues(new[] { "ArtifactID" });
		}

		[Test]
		public static void Get_UsesFieldArtifactIdAttributeToDesignateField()
		{
			var result = ObjectFieldMapping.Get(typeof(ObjectWithFieldArtifactIdAttribute));
			result.Should().ContainKeys(new[] { "1234567" });
			result.Should().ContainValues(new[] { "ArtifactID" });
		}

		[Test]
		public static void Get_GuidTakesPrecedenceOverArtifactId()
		{
			var result = ObjectFieldMapping.Get(typeof(ObjectWithFieldGuidAndArtifactIdAttributes));
			result.Should().ContainKeys(new[] { GUIDSTRING });
			result.Should().ContainValues(new[] { "ArtifactID" });
		}

		[Test]
		public static void Get_ArtifactIdTakesPrecedenceOverName()
		{
			var result = ObjectFieldMapping.Get(typeof(ObjectWithFieldArtifactIdAndNameAttributes));
			result.Should().ContainKeys(new[] { "1234567" });
			result.Should().ContainValues(new[] { "ArtifactID" });
		}

#pragma warning disable CA1812
		internal class SomeObject
		{
			public int ArtifactID { get; set; }

			public string Name { get; set; }
		}

		internal class ObjectWithFieldNameAttribute
		{
			[FieldName("AFieldName")]
			public int ArtifactID { get; set; }
		}

		internal class ObjectWithFieldGuidAttribute
		{
			[FieldGuid(GUIDSTRING)]
			public int ArtifactID { get; set; }
		}

		internal class ObjectWithFieldArtifactIdAttribute
		{
			[FieldArtifactId(1234567)]
			public int ArtifactID { get; set; }
		}

		internal class ObjectWithFieldGuidAndArtifactIdAttributes
		{
			[FieldArtifactId(1234567)]
			[FieldGuid(GUIDSTRING)]
			public int ArtifactID { get; set; }
		}

		internal class ObjectWithFieldArtifactIdAndNameAttributes
		{
			[FieldArtifactId(1234567)]
			[FieldName("Should Not Be Me.")]
			public int ArtifactID { get; set; }
		}
	}
#pragma warning restore CA1812
}
