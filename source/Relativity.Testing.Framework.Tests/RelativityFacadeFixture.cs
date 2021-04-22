using System;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Strategies;

namespace Relativity.Testing.Framework.Tests
{
	[TestFixture]
	[TestOf(typeof(RelativityFacade))]
	public class RelativityFacadeFixture
	{
		private IRelativityFacade _sut;

		[SetUp]
		public void SetUp()
		{
			_sut = new RelativityFacade();
		}

		[TearDown]
		public void TearDown()
		{
			_sut.Dispose();
		}

		[Test]
		public void GetComponent_Missing()
		{
			Assert.Throws<ComponentNotFoundException>(() =>
				_sut.GetComponent<StubComponent>());
		}

		[Test]
		public void GetComponent()
		{
			_sut.RelyOn<StubComponent>();

			_sut.GetComponent<StubComponent>().
				Should().BeOfType<StubComponent>();
		}

		[Test]
		public void Resolve_Missing()
		{
			var exception = Assert.Throws<ComponentNotFoundException>(() =>
				_sut.Resolve<IStubService>());

			exception.Message.Should().Contain(typeof(IStubService).FullName);
		}

		[Test]
		public void Resolve_Strategy_Missing()
		{
			var exception = Assert.Throws<ComponentNotFoundException>(() =>
				_sut.Resolve<ICreateStrategy<DateTime>>());

			exception.Message.Should().Contain(typeof(ICreateStrategy<DateTime>).FullName);
		}

		[Test]
		public void Resolve()
		{
			_sut.RelyOn<StubComponent>();

			_sut.Resolve<IStubService>().
				Should().BeOfType<StubService>();
		}

		[Test]
		public void RelyOn_InvokesComponentEnsure()
		{
			_sut.RelyOn<StubComponent>();

			_sut.GetComponent<StubComponent>().
				IsEnsureInvoked.Should().BeTrue();
		}

		[Test]
		public void RelyOn_SameComponent()
		{
			_sut.RelyOn<StubComponent>();

			_sut.RelyOn<StubComponent>();

			_sut.Resolve<IStubService>().
				Should().BeOfType<StubService>();
		}

		[Test]
		public void RelyOn_SameComponentButDifferentInstance()
		{
			_sut.RelyOn(new StubComponent());

			_sut.RelyOn(new StubComponent());

			_sut.Resolve<IStubService>().
				Should().BeOfType<StubService>();
		}

		[Test]
		public void ResetFacade_RemovesComponents()
		{
			_sut.RelyOn<StubComponent>();
			_sut.ResetFacade();

			var exception = Assert.Throws<ComponentNotFoundException>(() =>
				_sut.Resolve<IStubService>());

			exception.Message.Should().Contain(typeof(IStubService).FullName);
		}

		[Test]
		public void ResetFacade_ComponentsCanBeReregisteredAfterReset()
		{
			_sut.RelyOn<StubComponent>();
			_sut.ResetFacade();
			_sut.RelyOn<StubComponent>();

			_sut.GetComponent<StubComponent>().
				Should().BeOfType<StubComponent>();
		}

#pragma warning disable SA1201, CA1812

		private class StubComponent : IRelativityComponent
		{
			public bool IsEnsureInvoked { get; private set; }

			public void Ensure(IWindsorContainer container)
			{
				IsEnsureInvoked = true;
			}

			public void Initialize(IWindsorContainer container)
			{
				container.Register(
					Component.For<IStubService>().
					ImplementedBy<StubService>().
					LifestyleSingleton());
			}
		}

		private interface IStubService
		{
		}

		private class StubService : IStubService
		{
		}

#pragma warning restore SA1201, CA1812
	}
}
