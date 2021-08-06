using System;
using Moq;
using NUnit.Framework;
using Relativity.Testing.Framework.Models;
using Relativity.Testing.Framework.Strategies;

namespace Relativity.Testing.Framework.Tests.Strategies
{
	[TestFixture]
	public class CreateStrategyWithAsyncFixture
	{
		private CreateStrategyWithAsync<Artifact> _sut;

		[SetUp]
		public void SetUp()
		{
			_sut = new Mock<CreateStrategyWithAsync<Artifact>>().Object;
		}

		[Test]
		public void CreateAsync_WithNullEntity_ThrowsArgumentNullException()
		{
			Assert.ThrowsAsync<ArgumentNullException>(() =>
				_sut.CreateAsync(null));
		}

		[Test]
		public void CreateAsync_WithNotNullEntity_DoesNotThrowException()
		{
			var artifact = new Artifact();

			Assert.DoesNotThrowAsync(() => _sut.CreateAsync(artifact));
		}
	}
}
