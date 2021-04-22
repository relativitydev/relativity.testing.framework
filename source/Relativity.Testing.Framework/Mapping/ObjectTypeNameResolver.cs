using System;
using System.Reflection;
using Relativity.Testing.Framework.Attributes;
using Relativity.Testing.Framework.Extensions;

namespace Relativity.Testing.Framework.Mapping
{
	/// <summary>
	/// Provides a set of methods for object type name resolve.
	/// </summary>
	public static class ObjectTypeNameResolver
	{
		/// <summary>
		/// Resolves the object type name of <typeparamref name="T"/> type.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>The object type name.</returns>
		public static string Resolve<T>()
		{
			return Resolve(typeof(T));
		}

		/// <summary>
		/// Resolves the object type name of <paramref name="type"/>.
		/// </summary>
		/// <param name="type">The type of the object.</param>
		/// <returns>The object type name.</returns>
		public static string Resolve(Type type)
		{
			return type.GetCustomAttribute<ObjectTypeNameAttribute>()?.Name
				?? type.Name.ToCapitalized();
		}
	}
}
