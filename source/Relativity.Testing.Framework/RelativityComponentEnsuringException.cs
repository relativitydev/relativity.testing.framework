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
		/// <summary>
		/// Initializes a new instance of the <see cref="RelativityComponentEnsuringException"/> class.
		/// </summary>
		public RelativityComponentEnsuringException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RelativityComponentEnsuringException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public RelativityComponentEnsuringException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RelativityComponentEnsuringException"/> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public RelativityComponentEnsuringException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RelativityComponentEnsuringException"/> class.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext" /> that contains contextual information about the source or destination.</param>
		protected RelativityComponentEnsuringException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
