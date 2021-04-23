using System;
using System.Runtime.Serialization;
using Relativity.Testing.Framework.Mapping;

namespace Relativity.Testing.Framework
{
	/// <summary>
	/// Represents error of failed object finding.
	/// </summary>
	[Serializable]
	public class ObjectNotFoundException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> class.
		/// </summary>
		public ObjectNotFoundException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public ObjectNotFoundException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public ObjectNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectNotFoundException"/> class.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		protected ObjectNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		/// <summary>
		/// Creates <see cref="ObjectNotFoundException"/> instance for case when entity is not found by ID.
		/// </summary>
		/// <typeparam name="T">The type of entity.</typeparam>
		/// <param name="id">The entity ID.</param>
		/// <returns>An instance of <see cref="ObjectNotFoundException"/> with built error message.</returns>
		public static ObjectNotFoundException CreateForNotFoundById<T>(int id)
		{
			string objectTypeName = ObjectTypeNameResolver.Resolve<T>();
			return new ObjectNotFoundException($"Failed to find {objectTypeName} entity by {id} ID.");
		}

		/// <summary>
		/// Creates <see cref="ObjectNotFoundException"/> instance for case when entity is not found by name.
		/// </summary>
		/// <typeparam name="T">The type of entity.</typeparam>
		/// <param name="name">The entity name.</param>
		/// <returns>An instance of <see cref="ObjectNotFoundException"/> with built error message.</returns>
		public static ObjectNotFoundException CreateForNotFoundByName<T>(string name)
		{
			string objectTypeName = ObjectTypeNameResolver.Resolve<T>();
			return new ObjectNotFoundException($"Failed to find {objectTypeName} entity by '{name}' name.");
		}
	}
}
