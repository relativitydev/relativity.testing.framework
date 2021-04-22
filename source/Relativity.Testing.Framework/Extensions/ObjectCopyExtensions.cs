using System;
using System.Collections.Generic;
using System.Reflection;

namespace Relativity.Testing.Framework.Extensions
{
	/// <summary>
	/// Provides a set of Copy extension methods for object.
	/// </summary>
	public static class ObjectCopyExtensions
	{
		private static readonly MethodInfo _cloneMethod = typeof(object).GetMethod(nameof(MemberwiseClone), BindingFlags.NonPublic | BindingFlags.Instance);

		/// <summary>
		/// Copies the specified object instance.
		/// </summary>
		/// <typeparam name="T">The type of instance.</typeparam>
		/// <param name="instance">The object instance.</param>
		/// <returns>The copied object.</returns>
		public static T Copy<T>(this T instance)
			where T : class
		{
			return (T)Copy((object)instance);
		}

		/// <summary>
		/// Copies the specified object instance.
		/// </summary>
		/// <param name="instance">The object instance.</param>
		/// <returns>The copied object.</returns>
		public static object Copy(this object instance)
		{
			return DoCopy(instance, new Dictionary<object, object>(new ReferenceEqualityComparer()));
		}

		private static object DoCopy(object originalObject, IDictionary<object, object> visited)
		{
			if (originalObject == null)
				return null;

			var typeToReflect = originalObject.GetType();

			if (IsPrimitive(typeToReflect))
				return originalObject;

			if (visited.ContainsKey(originalObject))
				return visited[originalObject];

			if (typeof(Delegate).IsAssignableFrom(typeToReflect))
				return originalObject;

			object clonedObject = _cloneMethod.Invoke(originalObject, null);

			if (typeToReflect.IsArray)
			{
				var arrayType = typeToReflect.GetElementType();
				if (!IsPrimitive(arrayType))
				{
					Array clonedArray = (Array)clonedObject;
					ForEachArrayItem(clonedArray, (array, indices) => array.SetValue(DoCopy(clonedArray.GetValue(indices), visited), indices));
				}
			}

			visited.Add(originalObject, clonedObject);
			CopyFields(originalObject, visited, clonedObject, typeToReflect);
			RecursiveCopyBaseTypePrivateFields(originalObject, visited, clonedObject, typeToReflect);

			return clonedObject;
		}

		private static bool IsPrimitive(Type type)
		{
			return type == typeof(string) || (type.IsValueType & type.IsPrimitive);
		}

		private static void RecursiveCopyBaseTypePrivateFields(object originalObject, IDictionary<object, object> visited, object clonedObject, Type typeToReflect)
		{
			if (typeToReflect.BaseType != null)
			{
				RecursiveCopyBaseTypePrivateFields(originalObject, visited, clonedObject, typeToReflect.BaseType);
				CopyFields(originalObject, visited, clonedObject, typeToReflect.BaseType, BindingFlags.Instance | BindingFlags.NonPublic, info => info.IsPrivate);
			}
		}

		private static void CopyFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy, Func<System.Reflection.FieldInfo, bool> filter = null)
		{
			foreach (System.Reflection.FieldInfo fieldInfo in typeToReflect.GetFields(bindingFlags))
			{
				bool doesPassFilter = filter?.Invoke(fieldInfo) ?? true;

				if (doesPassFilter && !IsPrimitive(fieldInfo.FieldType))
				{
					object originalFieldValue = fieldInfo.GetValue(originalObject);
					object clonedFieldValue = DoCopy(originalFieldValue, visited);

					fieldInfo.SetValue(cloneObject, clonedFieldValue);
				}
			}
		}

		private static void ForEachArrayItem(Array array, Action<Array, int[]> action)
		{
			if (array.LongLength > 0)
			{
				ArrayTraverse walker = new ArrayTraverse(array);
				do
				{
					action(array, walker.Position);
				}
				while (walker.Step());
			}
		}

		private class ReferenceEqualityComparer : EqualityComparer<object>
		{
			public override bool Equals(object x, object y)
			{
				return ReferenceEquals(x, y);
			}

			public override int GetHashCode(object obj)
			{
				return obj?.GetHashCode() ?? 0;
			}
		}

		private class ArrayTraverse
		{
			private readonly int[] _maxLengths;

			public ArrayTraverse(Array array)
			{
				_maxLengths = new int[array.Rank];

				for (int i = 0; i < array.Rank; ++i)
					_maxLengths[i] = array.GetLength(i) - 1;

				Position = new int[array.Rank];
			}

			public int[] Position { get; }

			public bool Step()
			{
				for (int i = 0; i < Position.Length; ++i)
				{
					if (Position[i] < _maxLengths[i])
					{
						Position[i]++;

						for (int j = 0; j < i; j++)
							Position[j] = 0;

						return true;
					}
				}

				return false;
			}
		}
	}
}
