using System;
using System.Reflection;
using Relativity.Testing.Framework.Attributes;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for object type guid resolution.
	/// </summary>
	public static class ObjectTypeGuidResolver
	{
		/// <summary>
		/// Resolves the object type guid of <typeparamref name="T"/> type.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>The object type guid, or null if the attribute is not present.</returns>
		public static Guid Resolve<T>()
		{
			return Resolve(typeof(T));
		}

		/// <summary>
		/// Resolves the object type guid of <paramref name="type"/>.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <returns>The object type guid, or null if the attribute is not present.</returns>
		public static Guid Resolve(Type type)
		{
			return type.IsDefined(typeof(ObjectTypeGuidAttribute)) ?
			type.GetCustomAttribute<ObjectTypeGuidAttribute>().Id :
			Guid.Empty;
		}
	}
}
