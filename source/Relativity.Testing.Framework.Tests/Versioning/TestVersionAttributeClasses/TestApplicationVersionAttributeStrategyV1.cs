using System;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Tests.Versioning.TestVersionAttributeClasses
{
	[ApplicationVersionRange("227ee259-6ce6-4b9c-bbdd-fc3c0b78f275", "<2.0.0")]
	internal class TestApplicationVersionAttributeStrategyV1 : ITestApplicationVersionAttributeStrategy
	{
		public void DoNothing()
		{
			throw new NotImplementedException();
		}
	}
}
