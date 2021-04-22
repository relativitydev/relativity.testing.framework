using System;
using System.Runtime.Serialization;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Represents error of failed data mapping.
	/// </summary>
	[Serializable]
	public class MappingException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MappingException"/> class.
		/// </summary>
		public MappingException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MappingException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public MappingException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MappingException"/> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public MappingException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MappingException"/> class.
		/// </summary>
		/// <param name="type">The type that failed to map.</param>
		/// <param name="propertyName">Name of the property that failed to map.</param>
		/// <param name="reason">The reason of mapping failure.</param>
		/// <param name="innerException">The inner exception.</param>
		public MappingException(Type type, string propertyName, string reason, Exception innerException = null)
			: base($"Failed to map \"{propertyName}\" property for {type.FullName} type. {reason}", innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MappingException"/> class.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext" /> that contains contextual information about the source or destination.</param>
		protected MappingException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
