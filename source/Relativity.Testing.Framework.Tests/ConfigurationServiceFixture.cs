using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Relativity.Testing.Framework.Configuration;

namespace Relativity.Testing.Framework.Tests
{
	[TestFixture]
	public class ConfigurationServiceFixture
	{
		private ConfigurationService _sut;

		[SetUp]
		public void SetUp()
		{
			_sut = new ConfigurationService(new ConfigurationBuilder().Build());
		}

		[Test]
		public void GetValue_Missing()
		{
			string key = GenerateRandomKey();

			var exception = Assert.Throws<ConfigurationKeyNotFoundException>(() =>
				_sut.GetValue(key));

			exception.KeyName.Should().Be(key);
			exception.Message.Should().Contain(key);
		}

		[Test]
		public void GetValue_Class_Missing()
		{
			string key = GenerateRandomKey();

			var exception = Assert.Throws<ConfigurationKeyNotFoundException>(() =>
				 _sut.GetValue<TestClass>(key));

			exception.KeyName.Should().Be(key);
			exception.Message.Should().Contain(key);
		}

		[Test]
		public void GetValueOrDefault_Missing()
		{
			string key = GenerateRandomKey();

			string result = _sut.GetValueOrDefault(key);

			result.Should().BeNull();
		}

		[Test]
		public void GetValueOrDefault_IntNullable_Missing()
		{
			string key = GenerateRandomKey();

			int? result = _sut.GetValueOrDefault<int?>(key);

			result.Should().BeNull();
		}

		[Test]
		public void GetValueOrDefault_Class_Missing()
		{
			string key = GenerateRandomKey();

			TestClass result = _sut.GetValueOrDefault<TestClass>(key);

			result.Should().BeNull();
		}

		[Test]
		public void GetValueOrDefault_WithDefaultValue_Missing()
		{
			string key = GenerateRandomKey();

			string result = _sut.GetValueOrDefault(key, "def");

			result.Should().Be("def");
		}

		[Test]
		public void Get_Class()
		{
			ConfigureSutWith(new Dictionary<string, string>
			{
				[nameof(TestClass.IntProperty)] = "5",
				[nameof(TestClass.StringProperty)] = "abc"
			});

			TestClass result = _sut.Get<TestClass>();

			result.Should().BeEquivalentTo(new TestClass
			{
				IntProperty = 5,
				StringProperty = "abc"
			});
		}

		[Test]
		public void GetValue_Class()
		{
			string sectionName = "SomeSection";

			ConfigureSutWith(new Dictionary<string, string>
			{
				[$"{sectionName}:{nameof(TestClass.IntProperty)}"] = "255",
				[$"{sectionName}:{nameof(TestClass.StringProperty)}"] = "abc"
			});

			TestClass result = _sut.GetValue<TestClass>(sectionName);

			result.Should().BeEquivalentTo(new TestClass
			{
				IntProperty = 255,
				StringProperty = "abc"
			});
		}

		[Test]
		public void GetValue_String()
		{
			string key = "some:string:value";

			ConfigureSutWith(new Dictionary<string, string>
			{
				[key] = "xyz"
			});

			string result = _sut.GetValue(key);

			result.Should().Be("xyz");
		}

		[Test]
		public void GetValue_Int()
		{
			string key = "some:int:value";

			ConfigureSutWith(new Dictionary<string, string>
			{
				[key] = "1024"
			});

			int result = _sut.GetValue<int>(key);

			result.Should().Be(1024);
		}

		[Test]
		public void GetValueOrDefault_String()
		{
			string key = "some:string:value";

			ConfigureSutWith(new Dictionary<string, string>
			{
				[key] = "xyz"
			});

			string result = _sut.GetValueOrDefault(key);

			result.Should().Be("xyz");
		}

		private void ConfigureSutWith(IEnumerable<KeyValuePair<string, string>> values)
		{
			_sut = new ConfigurationService(new ConfigurationBuilder().AddInMemoryCollection(values).Build());
		}

		private string GenerateRandomKey()
		{
			return Guid.NewGuid().ToString();
		}

		private class TestClass
		{
			public int IntProperty { get; set; }

			public string StringProperty { get; set; }
		}
	}
}
