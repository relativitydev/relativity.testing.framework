using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Represents a default object field value.
	/// </summary>
	/// <typeparam name="T">Value type for field.</typeparam>
	public class DefaultFieldValue<T> : Artifact
	    where T : NamedArtifact
	{
#pragma warning disable CA1720 // Identifier contains type name
		/// <summary>
		/// Gets or sets Artifact GUID of field.
		/// </summary>
		public Guid Guid { get; set; }
#pragma warning restore CA1720 // Identifier contains type name

		/// <summary>
		/// Gets or sets default value for field.
		/// </summary>
		public T DefaultValue { get; set; }
	}
}
