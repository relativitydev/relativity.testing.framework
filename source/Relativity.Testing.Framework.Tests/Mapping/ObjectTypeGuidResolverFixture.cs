using System;
using NUnit.Framework;
using Relativity.Testing.Framework.Attributes;
using Relativity.Testing.Framework.Mapping;

namespace Relativity.Testing.Framework.Tests.Mapping
{
	[TestFixture]
	[TestOf(typeof(ObjectTypeGuidResolver))]
	public static class ObjectTypeGuidResolverFixture
	{
		private const string GUIDSTRING = "12345678-1234-1234-1234-1234567890AB";

		[Test]
		public static void ResolveByGeneric_ReturnsGuid()
		{
			Guid expectedValue = new Guid(GUIDSTRING);
			Guid actualValue = ObjectTypeGuidResolver.Resolve<SomeObject>();
			Assert.AreEqual(actualValue, expectedValue);
		}

		[Test]
		public static void ResolveByType_ReturnsGuid()
		{
			Guid expectedValue = new Guid(GUIDSTRING);
			Guid actualValue = ObjectTypeGuidResolver.Resolve(typeof(SomeObject));
			Assert.AreEqual(actualValue, expectedValue);
		}

		[Test]
		public static void ResolveGenericWithNoGuid_ReturnsEmptyGuid()
		{
			Guid expectedValue = Guid.Empty;
			Guid actualValue = ObjectTypeGuidResolver.Resolve<NoGuidObject>();
			Assert.AreEqual(actualValue, expectedValue);
		}

		[Test]
		public static void ResolveTypeWithNoGuid_ReturnsEmptyGuid()
		{
			Guid expectedValue = Guid.Empty;
			Guid actualValue = ObjectTypeGuidResolver.Resolve(typeof(NoGuidObject));
			Assert.AreEqual(actualValue, expectedValue);
		}

		[Test]
		public static void ResolveGenericWithBadGuid_ThrowsFormatException()
		{
			Assert.Throws<FormatException>(() => ObjectTypeGuidResolver.Resolve<BadGuidObject>());
		}

		[Test]
		public static void ResolveTypeWithBadGuid_ThrowsFormatException()
		{
			Assert.Throws<FormatException>(() => ObjectTypeGuidResolver.Resolve(typeof(BadGuidObject)));
		}

		[ObjectTypeGuid(GUIDSTRING)]
#pragma warning disable CA1812
		internal class SomeObject
		{
			public int ArtifactID { get; set; }

			public string Name { get; set; }
		}

		internal class NoGuidObject
		{
			public int ArtifactID { get; set; }

			public string Name { get; set; }
		}

		[ObjectTypeGuid("I'm-Not-A-Guid")]
		internal class BadGuidObject
		{
			public int ArtifactID { get; set; }

			public string Name { get; set; }
		}
	}
#pragma warning restore CA1812
}
