using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	internal static class CollectionUtils
	{
		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			return list.AddDistinct<T>(value, EqualityComparer<T>.Default);
		}

		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			if (list.ContainsValue<T>(value, comparer))
			{
				return false;
			}
			list.Add(value);
			return true;
		}

		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
			if (initial == null)
			{
				throw new ArgumentNullException("initial");
			}
			if (collection == null)
			{
				return;
			}
			foreach (T t in collection)
			{
				initial.Add(t);
			}
		}

		public static void AddRange(this IList initial, IEnumerable collection)
		{
			ValidationUtils.ArgumentNotNull(initial, "initial");
			(new ListWrapper<object>(initial)).AddRange<object>(collection.Cast<object>());
		}

		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			bool flag = true;
			foreach (T value in values)
			{
				if (list.AddDistinct<T>(value, comparer))
				{
					continue;
				}
				flag = false;
			}
			return flag;
		}

		public static IEnumerable<T> CastValid<T>(this IEnumerable enumerable)
		{
			ValidationUtils.ArgumentNotNull(enumerable, "enumerable");
			return (
				from object o in enumerable
				where o is T
				select o).Cast<T>();
		}

		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			bool flag;
			if (comparer == null)
			{
				comparer = EqualityComparer<TSource>.Default;
			}
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!comparer.Equals(enumerator.Current, value))
					{
						continue;
					}
					flag = true;
					return flag;
				}
				return false;
			}
			return flag;
		}

		public static IWrappedCollection CreateCollectionWrapper(object list)
		{
			Type type;
			ValidationUtils.ArgumentNotNull(list, "list");
			if (!ReflectionUtils.ImplementsGenericDefinition(list.GetType(), typeof(ICollection<>), out type))
			{
				if (!(list is IList))
				{
					throw new ArgumentException("Can not create ListWrapper for type {0}.".FormatWith(CultureInfo.InvariantCulture, list.GetType()), "list");
				}
				return new CollectionWrapper<object>((IList)list);
			}
			Type collectionItemType = ReflectionUtils.GetCollectionItemType(type);
			Func<Type, IList<object>, object> func = (Type t, IList<object> a) => t.GetConstructor(new Type[] { type }).Invoke(new object[] { list });
			Type type1 = typeof(CollectionWrapper<>);
			Type[] typeArray = new Type[] { collectionItemType };
			object[] objArray = new object[] { list };
			return (IWrappedCollection)ReflectionUtils.CreateGeneric(type1, typeArray, func, objArray);
		}

		public static IWrappedDictionary CreateDictionaryWrapper(object dictionary)
		{
			Type type;
			ValidationUtils.ArgumentNotNull(dictionary, "dictionary");
			if (!ReflectionUtils.ImplementsGenericDefinition(dictionary.GetType(), typeof(IDictionary<,>), out type))
			{
				if (!(dictionary is IDictionary))
				{
					throw new ArgumentException("Can not create DictionaryWrapper for type {0}.".FormatWith(CultureInfo.InvariantCulture, dictionary.GetType()), "dictionary");
				}
				return new DictionaryWrapper<object, object>((IDictionary)dictionary);
			}
			Type dictionaryKeyType = ReflectionUtils.GetDictionaryKeyType(type);
			Type dictionaryValueType = ReflectionUtils.GetDictionaryValueType(type);
			Func<Type, IList<object>, object> func = (Type t, IList<object> a) => t.GetConstructor(new Type[] { type }).Invoke(new object[] { dictionary });
			Type type1 = typeof(DictionaryWrapper<,>);
			Type[] typeArray = new Type[] { dictionaryKeyType, dictionaryValueType };
			object[] objArray = new object[] { dictionary };
			return (IWrappedDictionary)ReflectionUtils.CreateGeneric(type1, typeArray, func, objArray);
		}

		public static IList CreateGenericList(Type listType)
		{
			ValidationUtils.ArgumentNotNull(listType, "listType");
			return (IList)ReflectionUtils.CreateGeneric(typeof(List<>), listType, new object[0]);
		}

		public static IList CreateList(Type listType, out bool isReadOnlyOrFixedSize)
		{
			IList objs;
			Type type;
			ValidationUtils.ArgumentNotNull(listType, "listType");
			isReadOnlyOrFixedSize = false;
			if (listType.IsArray)
			{
				objs = new List<object>();
				isReadOnlyOrFixedSize = true;
			}
			else if (ReflectionUtils.InheritsGenericDefinition(listType, typeof(ReadOnlyCollection<>), out type))
			{
				Type genericArguments = type.GetGenericArguments()[0];
				Type type1 = typeof(IEnumerable<>);
				Type[] typeArray = new Type[] { genericArguments };
				Type type2 = ReflectionUtils.MakeGenericType(type1, typeArray);
				bool flag = false;
				ConstructorInfo[] constructors = listType.GetConstructors();
				int num = 0;
				while (num < (int)constructors.Length)
				{
					IList<ParameterInfo> parameters = constructors[num].GetParameters();
					if (parameters.Count != 1 || !type2.IsAssignableFrom(parameters[0].ParameterType))
					{
						num++;
					}
					else
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					throw new Exception("Read-only type {0} does not have a public constructor that takes a type that implements {1}.".FormatWith(CultureInfo.InvariantCulture, listType, type2));
				}
				objs = CollectionUtils.CreateGenericList(genericArguments);
				isReadOnlyOrFixedSize = true;
			}
			else if (typeof(IList).IsAssignableFrom(listType))
			{
				if (ReflectionUtils.IsInstantiatableType(listType))
				{
					objs = (IList)Activator.CreateInstance(listType);
				}
				else if (listType != typeof(IList))
				{
					objs = null;
				}
				else
				{
					objs = new List<object>();
				}
			}
			else if (!ReflectionUtils.ImplementsGenericDefinition(listType, typeof(ICollection<>)))
			{
				objs = null;
			}
			else if (!ReflectionUtils.IsInstantiatableType(listType))
			{
				objs = null;
			}
			else
			{
				objs = CollectionUtils.CreateCollectionWrapper(Activator.CreateInstance(listType));
			}
			if (objs == null)
			{
				throw new InvalidOperationException("Cannot create and populate list type {0}.".FormatWith(CultureInfo.InvariantCulture, listType));
			}
			return objs;
		}

		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			int num;
			int num1 = 0;
			using (IEnumerator<T> enumerator = collection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!predicate(enumerator.Current))
					{
						num1++;
					}
					else
					{
						num = num1;
						return num;
					}
				}
				return -1;
			}
			return num;
		}

		public static int IndexOf<TSource>(this IEnumerable<TSource> list, TSource value, IEqualityComparer<TSource> comparer)
		{
			int num;
			int num1 = 0;
			using (IEnumerator<TSource> enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!comparer.Equals(enumerator.Current, value))
					{
						num1++;
					}
					else
					{
						num = num1;
						return num;
					}
				}
				return -1;
			}
			return num;
		}

		public static bool IsDictionaryType(Type type)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				return true;
			}
			if (ReflectionUtils.ImplementsGenericDefinition(type, typeof(IDictionary<,>)))
			{
				return true;
			}
			return false;
		}

		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			if (collection == null)
			{
				return true;
			}
			return collection.Count == 0;
		}

		public static Array ToArray(Array initial, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			Array arrays = Array.CreateInstance(type, initial.Length);
			Array.Copy(initial, 0, arrays, 0, initial.Length);
			return arrays;
		}
	}
}