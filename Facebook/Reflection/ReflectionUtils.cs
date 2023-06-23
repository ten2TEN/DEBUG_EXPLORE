using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Facebook.Reflection
{
	[GeneratedCode("reflection-utils", "1.0.0")]
	internal class ReflectionUtils
	{
		private readonly static object[] EmptyObjects;

		static ReflectionUtils()
		{
			ReflectionUtils.EmptyObjects = new object[0];
		}

		public ReflectionUtils()
		{
		}

		public static BinaryExpression Assign(Expression left, Expression right)
		{
			Type type = typeof(ReflectionUtils.Assigner<>);
			Type[] typeArray = new Type[] { left.Type };
			MethodInfo method = type.MakeGenericType(typeArray).GetMethod("Assign");
			return Expression.Add(left, right, method);
		}

		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			if (info == null || type == null || !Attribute.IsDefined(info, type))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(info, type);
		}

		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			if (objectType == null || attributeType == null || !Attribute.IsDefined(objectType, attributeType))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(objectType, attributeType);
		}

		public static ReflectionUtils.ConstructorDelegate GetConstructorByExpression(ConstructorInfo constructorInfo)
		{
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
			Expression[] expressionArray = new Expression[(int)parameters.Length];
			for (int i = 0; i < (int)parameters.Length; i++)
			{
				Expression expression = Expression.Constant(i);
				Type parameterType = parameters[i].ParameterType;
				Expression expression1 = Expression.ArrayIndex(parameterExpression, expression);
				expressionArray[i] = Expression.Convert(expression1, parameterType);
			}
			NewExpression newExpression = Expression.New(constructorInfo, expressionArray);
			ParameterExpression[] parameterExpressionArray = new ParameterExpression[] { parameterExpression };
			Func<object[], object> func = Expression.Lambda<Func<object[], object>>(newExpression, parameterExpressionArray).Compile();
			return (object[] args) => func(args);
		}

		public static ReflectionUtils.ConstructorDelegate GetConstructorByExpression(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = ReflectionUtils.GetConstructorInfo(type, argsType);
			if (constructorInfo == null)
			{
				return null;
			}
			return ReflectionUtils.GetConstructorByExpression(constructorInfo);
		}

		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return (object[] args) => constructorInfo.Invoke(args);
		}

		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = ReflectionUtils.GetConstructorInfo(type, argsType);
			if (constructorInfo == null)
			{
				return null;
			}
			return ReflectionUtils.GetConstructorByReflection(constructorInfo);
		}

		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo;
			using (IEnumerator<ConstructorInfo> enumerator = ReflectionUtils.GetConstructors(type).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ConstructorInfo current = enumerator.Current;
					ParameterInfo[] parameters = current.GetParameters();
					if ((int)argsType.Length != (int)parameters.Length)
					{
						continue;
					}
					int num = 0;
					bool flag = true;
					ParameterInfo[] parameterInfoArray = current.GetParameters();
					int num1 = 0;
					while (num1 < (int)parameterInfoArray.Length)
					{
						if (parameterInfoArray[num1].ParameterType == argsType[num])
						{
							num1++;
						}
						else
						{
							flag = false;
							break;
						}
					}
					if (!flag)
					{
						continue;
					}
					constructorInfo = current;
					return constructorInfo;
				}
				return null;
			}
			return constructorInfo;
		}

		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return type.GetConstructors();
		}

		public static ReflectionUtils.ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return ReflectionUtils.GetConstructorByExpression(constructorInfo);
		}

		public static ReflectionUtils.ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return ReflectionUtils.GetConstructorByExpression(type, argsType);
		}

		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		public static Type GetGenericListElementType(Type type)
		{
			Type genericTypeArguments;
			using (IEnumerator<Type> enumerator = type.GetInterfaces().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Type current = enumerator.Current;
					if (!ReflectionUtils.IsTypeGeneric(current) || !(current.GetGenericTypeDefinition() == typeof(IList<>)))
					{
						continue;
					}
					genericTypeArguments = ReflectionUtils.GetGenericTypeArguments(current)[0];
					return genericTypeArguments;
				}
				return ReflectionUtils.GetGenericTypeArguments(type)[0];
			}
			return genericTypeArguments;
		}

		public static Type[] GetGenericTypeArguments(Type type)
		{
			return type.GetGenericArguments();
		}

		public static ReflectionUtils.GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetGetMethodByExpression(propertyInfo);
		}

		public static ReflectionUtils.GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetGetMethodByExpression(fieldInfo);
		}

		public static ReflectionUtils.GetDelegate GetGetMethodByExpression(PropertyInfo propertyInfo)
		{
			MethodInfo getterMethodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			UnaryExpression unaryExpression = (!ReflectionUtils.IsValueType(propertyInfo.DeclaringType) ? Expression.TypeAs(parameterExpression, propertyInfo.DeclaringType) : Expression.Convert(parameterExpression, propertyInfo.DeclaringType));
			UnaryExpression unaryExpression1 = Expression.TypeAs(Expression.Call(unaryExpression, getterMethodInfo), typeof(object));
			ParameterExpression[] parameterExpressionArray = new ParameterExpression[] { parameterExpression };
			Func<object, object> func = Expression.Lambda<Func<object, object>>(unaryExpression1, parameterExpressionArray).Compile();
			return (object source) => func(source);
		}

		public static ReflectionUtils.GetDelegate GetGetMethodByExpression(FieldInfo fieldInfo)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			MemberExpression memberExpression = Expression.Field(Expression.Convert(parameterExpression, fieldInfo.DeclaringType), fieldInfo);
			UnaryExpression unaryExpression = Expression.Convert(memberExpression, typeof(object));
			ParameterExpression[] parameterExpressionArray = new ParameterExpression[] { parameterExpression };
			ReflectionUtils.GetDelegate getDelegate = Expression.Lambda<ReflectionUtils.GetDelegate>(unaryExpression, parameterExpressionArray).Compile();
			return (object source) => getDelegate(source);
		}

		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo getterMethodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
			return (object source) => getterMethodInfo.Invoke(source, ReflectionUtils.EmptyObjects);
		}

		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return (object source) => fieldInfo.GetValue(source);
		}

		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetGetMethod(true);
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		public static ReflectionUtils.SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetSetMethodByExpression(propertyInfo);
		}

		public static ReflectionUtils.SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetSetMethodByExpression(fieldInfo);
		}

		public static ReflectionUtils.SetDelegate GetSetMethodByExpression(PropertyInfo propertyInfo)
		{
			MethodInfo setterMethodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			ParameterExpression parameterExpression1 = Expression.Parameter(typeof(object), "value");
			UnaryExpression unaryExpression = (!ReflectionUtils.IsValueType(propertyInfo.DeclaringType) ? Expression.TypeAs(parameterExpression, propertyInfo.DeclaringType) : Expression.Convert(parameterExpression, propertyInfo.DeclaringType));
			Expression[] expressionArray = new Expression[] { (!ReflectionUtils.IsValueType(propertyInfo.PropertyType) ? Expression.TypeAs(parameterExpression1, propertyInfo.PropertyType) : Expression.Convert(parameterExpression1, propertyInfo.PropertyType)) };
			MethodCallExpression methodCallExpression = Expression.Call(unaryExpression, setterMethodInfo, expressionArray);
			ParameterExpression[] parameterExpressionArray = new ParameterExpression[] { parameterExpression, parameterExpression1 };
			Action<object, object> action = Expression.Lambda<Action<object, object>>(methodCallExpression, parameterExpressionArray).Compile();
			return (object source, object val) => action(source, val);
		}

		public static ReflectionUtils.SetDelegate GetSetMethodByExpression(FieldInfo fieldInfo)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			ParameterExpression parameterExpression1 = Expression.Parameter(typeof(object), "value");
			BinaryExpression binaryExpression = ReflectionUtils.Assign(Expression.Field(Expression.Convert(parameterExpression, fieldInfo.DeclaringType), fieldInfo), Expression.Convert(parameterExpression1, fieldInfo.FieldType));
			ParameterExpression[] parameterExpressionArray = new ParameterExpression[] { parameterExpression, parameterExpression1 };
			Action<object, object> action = Expression.Lambda<Action<object, object>>(binaryExpression, parameterExpressionArray).Compile();
			return (object source, object val) => action(source, val);
		}

		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo setterMethodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
			return (object source, object value) => setterMethodInfo.Invoke(source, new object[] { value });
		}

		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return (object source, object value) => fieldInfo.SetValue(source, value);
		}

		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetSetMethod(true);
		}

		public static Type GetTypeInfo(Type type)
		{
			return type;
		}

		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return ReflectionUtils.GetTypeInfo(type1).IsAssignableFrom(ReflectionUtils.GetTypeInfo(type2));
		}

		public static bool IsNullableType(Type type)
		{
			if (!ReflectionUtils.GetTypeInfo(type).IsGenericType)
			{
				return false;
			}
			return type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		public static bool IsTypeDictionary(Type type)
		{
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				return true;
			}
			if (!ReflectionUtils.GetTypeInfo(type).IsGenericType)
			{
				return false;
			}
			return type.GetGenericTypeDefinition() == typeof(IDictionary<,>);
		}

		public static bool IsTypeGeneric(Type type)
		{
			return ReflectionUtils.GetTypeInfo(type).IsGenericType;
		}

		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			if (!ReflectionUtils.IsTypeGeneric(type))
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			if (genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>))
			{
				return true;
			}
			return genericTypeDefinition == typeof(IEnumerable<>);
		}

		public static bool IsValueType(Type type)
		{
			return ReflectionUtils.GetTypeInfo(type).IsValueType;
		}

		public static object ToNullableType(object obj, Type nullableType)
		{
			if (obj == null)
			{
				return null;
			}
			return Convert.ChangeType(obj, Nullable.GetUnderlyingType(nullableType), CultureInfo.InvariantCulture);
		}

		private static class Assigner<T>
		{
			public static T Assign(ref T left, T right)
			{
				T t = right;
				T t1 = t;
				left = t;
				return t1;
			}
		}

		public delegate object ConstructorDelegate(params object[] args);

		public delegate object GetDelegate(object source);

		public delegate void SetDelegate(object source, object value);

		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			private readonly object _lock;

			private readonly ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			private Dictionary<TKey, TValue> _dictionary;

			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			public bool IsReadOnly
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public TValue this[TKey key]
			{
				get
				{
					return this.Get(key);
				}
				set
				{
					throw new NotImplementedException();
				}
			}

			public ICollection<TKey> Keys
			{
				get
				{
					return this._dictionary.Keys;
				}
			}

			public ICollection<TValue> Values
			{
				get
				{
					return this._dictionary.Values;
				}
			}

			public ThreadSafeDictionary(ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
				this._valueFactory = valueFactory;
			}

			public void Add(TKey key, TValue value)
			{
				throw new NotImplementedException();
			}

			public void Add(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			private TValue AddValue(TKey key)
			{
				TValue tValue;
				TValue tValue1;
				TValue tValue2 = this._valueFactory(key);
				lock (this._lock)
				{
					if (this._dictionary == null)
					{
						this._dictionary = new Dictionary<TKey, TValue>();
						this._dictionary[key] = tValue2;
					}
					else if (!this._dictionary.TryGetValue(key, out tValue))
					{
						Dictionary<TKey, TValue> tKeys = new Dictionary<TKey, TValue>(this._dictionary);
						tKeys[key] = tValue2;
						this._dictionary = tKeys;
					}
					else
					{
						tValue1 = tValue;
						return tValue1;
					}
					return tValue2;
				}
				return tValue1;
			}

			public void Clear()
			{
				throw new NotImplementedException();
			}

			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			public bool ContainsKey(TKey key)
			{
				return this._dictionary.ContainsKey(key);
			}

			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			private TValue Get(TKey key)
			{
				TValue tValue;
				if (this._dictionary == null)
				{
					return this.AddValue(key);
				}
				if (this._dictionary.TryGetValue(key, out tValue))
				{
					return tValue;
				}
				return this.AddValue(key);
			}

			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			public bool Remove(TKey key)
			{
				throw new NotImplementedException();
			}

			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			public bool TryGetValue(TKey key, out TValue value)
			{
				value = this[key];
				return true;
			}
		}

		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);
	}
}