using System;

namespace Relativity.Testing.Framework.Models
{
	/// <summary>
	/// Generic class that indicates whether or not the given value is secured from the current user.
	/// </summary>
	/// <typeparam name="T">The type of the value that may be secured. The type should be nullable.</typeparam>
	[Serializable]
	public class Securable<T>
	{
		public Securable()
		{
		}

		public Securable(T value)
		{
			Value = value;
		}

		/// <summary>
		/// Gets or sets a value indicating whether whether or not the current user has permission to view the given value.
		/// </summary>
		public bool Secured { get; set; }

		/// <summary>
		/// Gets or sets the value that may or may not be secured.
		/// </summary>
		/// <remarks>
		/// If the value is secured, Value will be null.
		/// </remarks>
		public T Value { get; set; }

		public static implicit operator Securable<T>(T value)
		{
			return new Securable<T>(value);
		}

		public static explicit operator T(Securable<T> value)
		{
			return value.Value;
		}
	}
}
