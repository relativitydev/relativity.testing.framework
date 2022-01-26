using System;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Tests.Versioning.TestVersionAttributeClasses
{
	[VersionRange(">=2.0.0")]
	internal class TestVersionAttributeStrategyV2 : ITestVersionAttributeStrategy
	{
		public void DoNothing()
		{
			throw new NotImplementedException();
		}
	}
}
