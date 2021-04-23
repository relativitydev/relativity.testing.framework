using System;
using System.Runtime.Serialization;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents errors that occur during <see cref="IRelativityComponent.Ensure(Castle.Windsor.IWindsorContainer)"/> execution.
	/// </summary>
	[Serializable]
	public class RelativityComponentEnsuringException : Exception
	{
		public RelativityComponentEnsuringException()
		{
		}

		public RelativityComponentEnsuringException(string message)
			: base(message)
		{
		}

		public RelativityComponentEnsuringException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected RelativityComponentEnsuringException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
