using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	internal static class TypeExtensions
	{
		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match)
		{
			for (Type i = type; i != null; i = i.BaseType())
			{
				if (string.Equals(i.FullName, fullTypeName, StringComparison.Ordinal))
				{
					match = i;
					return true;
				}
			}
			Type[] interfaces = type.GetInterfaces();
			for (int j = 0; j < (int)interfaces.Length; j++)
			{
				if (string.Equals(interfaces[j].Name, fullTypeName, StringComparison.Ordinal))
				{
					match = type;
					return true;
				}
			}
			match = null;
			return false;
		}

		public static bool AssignableToTypeName(this Type type, string fullTypeName)
		{
			Type type1;
			return type.AssignableToTypeName(fullTypeName, out type1);
		}

		public static Type BaseType(this Type type)
		{
			return type.BaseType;
		}

		public static bool ContainsGenericParameters(this Type type)
		{
			return type.ContainsGenericParameters;
		}

		public static IEnumerable<Type> GetAllInterfaces(this Type target)
		{
			Type[] interfaces = target.GetInterfaces();
			for (int num = 0; num < (int)interfaces.Length; num++)
			{
				Type type = interfaces[num];
				yield return type;
				Type[] typeArray = type.GetInterfaces();
				for (int j = 0; j < (int)typeArray.Length; j++)
				{
					yield return typeArray[j];
				}
			}
		}

		public static IEnumerable<MethodInfo> GetAllMethods(this Type target)
		{
			List<Type> list = target.GetAllInterfaces().ToList<Type>();
			list.Add(target);
			return 
				from type in list
				from method in type.GetMethods()
				select method;
		}

		public static MethodInfo GetGenericMethod(this Type type, string name, params Type[] parameterTypes)
		{
			MethodInfo methodInfo;
			IEnumerable<MethodInfo> methods = 
				from method in type.GetMethods()
				where method.Name == name
				select method;
			using (IEnumerator<MethodInfo> enumerator = methods.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MethodInfo current = enumerator.Current;
					if (!current.HasParameters(parameterTypes))
					{
						continue;
					}
					methodInfo = current;
					return methodInfo;
				}
				return null;
			}
			return methodInfo;
		}

		public static bool HasParameters(this MethodInfo method, params Type[] parameterTypes)
		{
			Type[] array = (
				from parameter in (IEnumerable<ParameterInfo>)method.GetParameters()
				select parameter.ParameterType).ToArray<Type>();
			if ((int)array.Length != (int)parameterTypes.Length)
			{
				return false;
			}
			for (int i = 0; i < (int)array.Length; i++)
			{
				if (array[i].ToString() != parameterTypes[i].ToString())
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsAbstract(this Type type)
		{
			return type.IsAbstract;
		}

		public static bool IsClass(this Type type)
		{
			return type.IsClass;
		}

		public static bool IsEnum(this Type type)
		{
			return type.IsEnum;
		}

		public static bool IsGenericType(this Type type)
		{
			return type.IsGenericType;
		}

		public static bool IsGenericTypeDefinition(this Type type)
		{
			return type.IsGenericTypeDefinition;
		}

		public static bool IsInterface(this Type type)
		{
			return type.IsInterface;
		}

		public static bool IsSealed(this Type type)
		{
			return type.IsSealed;
		}

		public static bool IsValueType(this Type type)
		{
			return type.IsValueType;
		}

		public static bool IsVisible(this Type type)
		{
			return type.IsVisible;
		}

		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			return memberInfo.MemberType;
		}
	}
}