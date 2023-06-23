using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	internal static class ReflectionUtils
	{
		public readonly static Type[] EmptyTypes;

		static ReflectionUtils()
		{
			ReflectionUtils.EmptyTypes = Type.EmptyTypes;
		}

		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			MemberTypes memberType = member.MemberType();
			if (memberType == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)member;
				if (nonPublic)
				{
					return true;
				}
				if (fieldInfo.IsPublic)
				{
					return true;
				}
				return false;
			}
			if (memberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)member;
			if (!propertyInfo.CanRead)
			{
				return false;
			}
			if (nonPublic)
			{
				return true;
			}
			return propertyInfo.GetGetMethod(nonPublic) != null;
		}

		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			MemberTypes memberType = member.MemberType();
			if (memberType == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)member;
				if (fieldInfo.IsInitOnly && !canSetReadOnly)
				{
					return false;
				}
				if (nonPublic)
				{
					return true;
				}
				if (fieldInfo.IsPublic)
				{
					return true;
				}
				return false;
			}
			if (memberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)member;
			if (!propertyInfo.CanWrite)
			{
				return false;
			}
			if (nonPublic)
			{
				return true;
			}
			return propertyInfo.GetSetMethod(nonPublic) != null;
		}

		public static object CreateGeneric(Type genericTypeDefinition, Type innerType, params object[] args)
		{
			Type[] typeArray = new Type[] { innerType };
			return ReflectionUtils.CreateGeneric(genericTypeDefinition, typeArray, args);
		}

		public static object CreateGeneric(Type genericTypeDefinition, IList<Type> innerTypes, params object[] args)
		{
			return ReflectionUtils.CreateGeneric(genericTypeDefinition, innerTypes, (Type t, IList<object> a) => ReflectionUtils.CreateInstance(t, a.ToArray<object>()), args);
		}

		public static object CreateGeneric(Type genericTypeDefinition, IList<Type> innerTypes, Func<Type, IList<object>, object> instanceCreator, params object[] args)
		{
			ValidationUtils.ArgumentNotNull(genericTypeDefinition, "genericTypeDefinition");
			ValidationUtils.ArgumentNotNullOrEmpty<Type>(innerTypes, "innerTypes");
			ValidationUtils.ArgumentNotNull(instanceCreator, "createInstance");
			Type type = ReflectionUtils.MakeGenericType(genericTypeDefinition, innerTypes.ToArray<Type>());
			return instanceCreator(type, args);
		}

		public static object CreateInstance(Type type, params object[] args)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			return Activator.CreateInstance(type, args);
		}

		public static Type EnsureNotNullableType(Type t)
		{
			if (!ReflectionUtils.IsNullableType(t))
			{
				return t;
			}
			return Nullable.GetUnderlyingType(t);
		}

		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			int num = 0;
			for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
			{
				char chr = fullyQualifiedTypeName[i];
				if (chr != ',')
				{
					switch (chr)
					{
						case '[':
						{
							num++;
							break;
						}
						case ']':
						{
							num--;
							break;
						}
					}
				}
				else if (num == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider)
		where T : Attribute
		{
			return ReflectionUtils.GetAttribute<T>(attributeProvider, true);
		}

		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider, bool inherit)
		where T : Attribute
		{
			return ReflectionUtils.GetAttributes<T>(attributeProvider, inherit).SingleOrDefault<T>();
		}

		public static T[] GetAttributes<T>(ICustomAttributeProvider attributeProvider, bool inherit)
		where T : Attribute
		{
			ValidationUtils.ArgumentNotNull(attributeProvider, "attributeProvider");
			object obj = attributeProvider;
			if (obj is Type)
			{
				return (T[])((Type)obj).GetCustomAttributes(typeof(T), inherit);
			}
			if (obj is Assembly)
			{
				return (T[])Attribute.GetCustomAttributes((Assembly)obj, typeof(T));
			}
			if (obj is MemberInfo)
			{
				return (T[])Attribute.GetCustomAttributes((MemberInfo)obj, typeof(T), inherit);
			}
			if (obj is Module)
			{
				return (T[])Attribute.GetCustomAttributes((Module)obj, typeof(T), inherit);
			}
			if (!(obj is ParameterInfo))
			{
				return (T[])attributeProvider.GetCustomAttributes(typeof(T), inherit);
			}
			return (T[])Attribute.GetCustomAttributes((ParameterInfo)obj, typeof(T), inherit);
		}

		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
			if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingFlag = bindingAttr.RemoveFlag(BindingFlags.Public);
				while (true)
				{
					Type type = targetType.BaseType();
					targetType = type;
					if (type == null)
					{
						break;
					}
					IEnumerable<MemberInfo> memberInfos = (
						from f in (IEnumerable<FieldInfo>)targetType.GetFields(bindingFlag)
						where f.IsPrivate
						select f).Cast<MemberInfo>();
					initialFields.AddRange<MemberInfo>(memberInfos);
				}
			}
		}

		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
			if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingFlag = bindingAttr.RemoveFlag(BindingFlags.Public);
			Label1:
				Type type = targetType.BaseType();
				targetType = type;
				if (type == null)
				{
					return;
				}
				PropertyInfo[] properties = targetType.GetProperties(bindingFlag);
				for (int i = 0; i < (int)properties.Length; i++)
				{
					PropertyInfo propertyInfo = properties[i];
					int num = initialProperties.IndexOf<PropertyInfo>((PropertyInfo p) => p.Name == propertyInfo.Name);
					if (num != -1)
					{
						initialProperties[num] = propertyInfo;
					}
					else
					{
						initialProperties.Add(propertyInfo);
					}
				}
				goto Label1;
			}
		}

		public static Type GetCollectionItemType(Type type)
		{
			Type type1;
			ValidationUtils.ArgumentNotNull(type, "type");
			if (type.IsArray)
			{
				return type.GetElementType();
			}
			if (!ReflectionUtils.ImplementsGenericDefinition(type, typeof(IEnumerable<>), out type1))
			{
				if (!typeof(IEnumerable).IsAssignableFrom(type))
				{
					throw new Exception("Type {0} is not a collection.".FormatWith(CultureInfo.InvariantCulture, type));
				}
				return null;
			}
			if (type1.IsGenericTypeDefinition())
			{
				throw new Exception("Type {0} is not a collection.".FormatWith(CultureInfo.InvariantCulture, type));
			}
			return type1.GetGenericArguments()[0];
		}

		public static ICustomAttributeProvider GetCustomAttributeProvider(this object o)
		{
			return (ICustomAttributeProvider)o;
		}

		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return ReflectionUtils.GetDefaultConstructor(t, false);
		}

		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			BindingFlags bindingFlag = BindingFlags.Instance | BindingFlags.Public;
			if (nonPublic)
			{
				bindingFlag |= BindingFlags.NonPublic;
			}
			return ((IEnumerable<ConstructorInfo>)t.GetConstructors(bindingFlag)).SingleOrDefault<ConstructorInfo>((ConstructorInfo c) => !c.GetParameters().Any<ParameterInfo>());
		}

		public static Type GetDictionaryKeyType(Type dictionaryType)
		{
			Type type;
			Type type1;
			ReflectionUtils.GetDictionaryKeyValueTypes(dictionaryType, out type, out type1);
			return type;
		}

		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			Type type;
			ValidationUtils.ArgumentNotNull(dictionaryType, "type");
			if (!ReflectionUtils.ImplementsGenericDefinition(dictionaryType, typeof(IDictionary<,>), out type))
			{
				if (!typeof(IDictionary).IsAssignableFrom(dictionaryType))
				{
					throw new Exception("Type {0} is not a dictionary.".FormatWith(CultureInfo.InvariantCulture, dictionaryType));
				}
				keyType = null;
				valueType = null;
				return;
			}
			if (type.IsGenericTypeDefinition())
			{
				throw new Exception("Type {0} is not a dictionary.".FormatWith(CultureInfo.InvariantCulture, dictionaryType));
			}
			Type[] genericArguments = type.GetGenericArguments();
			keyType = genericArguments[0];
			valueType = genericArguments[1];
		}

		public static Type GetDictionaryValueType(Type dictionaryType)
		{
			Type type;
			Type type1;
			ReflectionUtils.GetDictionaryKeyValueTypes(dictionaryType, out type, out type1);
			return type1;
		}

		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull(targetType, "targetType");
			List<MemberInfo> memberInfos = new List<MemberInfo>(targetType.GetFields(bindingAttr));
			ReflectionUtils.GetChildPrivateFields(memberInfos, targetType, bindingAttr);
			return memberInfos.Cast<FieldInfo>();
		}

		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			List<MemberInfo> memberInfos = new List<MemberInfo>();
			memberInfos.AddRange(ReflectionUtils.GetFields(type, bindingAttr));
			memberInfos.AddRange(ReflectionUtils.GetProperties(type, bindingAttr));
			List<MemberInfo> memberInfos1 = new List<MemberInfo>(memberInfos.Count);
			foreach (IGrouping<string, MemberInfo> strs in 
				from m in memberInfos
				group m by m.Name)
			{
				int num = strs.Count<MemberInfo>();
				IList<MemberInfo> list = strs.ToList<MemberInfo>();
				if (num != 1)
				{
					IEnumerable<MemberInfo> memberInfos2 = list.Where<MemberInfo>((MemberInfo m) => {
						if (!ReflectionUtils.IsOverridenGenericMember(m, bindingAttr))
						{
							return true;
						}
						return m.Name == "Item";
					});
					memberInfos1.AddRange(memberInfos2);
				}
				else
				{
					memberInfos1.Add(list.First<MemberInfo>());
				}
			}
			return memberInfos1;
		}

		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			if (memberInfo.MemberType() != MemberTypes.Property)
			{
				return targetType.GetMember(memberInfo.Name, memberInfo.MemberType(), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SingleOrDefault<MemberInfo>();
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
			Type[] array = (
				from p in (IEnumerable<ParameterInfo>)propertyInfo.GetIndexParameters()
				select p.ParameterType).ToArray<Type>();
			return targetType.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, array, null);
		}

		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			MemberTypes memberType = member.MemberType();
			switch (memberType)
			{
				case MemberTypes.Event:
				{
					return ((EventInfo)member).EventHandlerType;
				}
				case MemberTypes.Constructor | MemberTypes.Event:
				{
					throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo or EventInfo", "member");
				}
				case MemberTypes.Field:
				{
					return ((FieldInfo)member).FieldType;
				}
				default:
				{
					if (memberType == MemberTypes.Property)
					{
						return ((PropertyInfo)member).PropertyType;
					}
					throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo or EventInfo", "member");
				}
			}
		}

		public static object GetMemberValue(MemberInfo member, object target)
		{
			object value;
			ValidationUtils.ArgumentNotNull(member, "member");
			ValidationUtils.ArgumentNotNull(target, "target");
			MemberTypes memberType = member.MemberType();
			if (memberType == MemberTypes.Field)
			{
				return ((FieldInfo)member).GetValue(target);
			}
			if (memberType != MemberTypes.Property)
			{
				throw new ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".FormatWith(CultureInfo.InvariantCulture, CultureInfo.InvariantCulture, member.Name), "member");
			}
			try
			{
				value = ((PropertyInfo)member).GetValue(target, null);
			}
			catch (TargetParameterCountException targetParameterCountException1)
			{
				TargetParameterCountException targetParameterCountException = targetParameterCountException1;
				throw new ArgumentException("MemberInfo '{0}' has index parameters".FormatWith(CultureInfo.InvariantCulture, member.Name), targetParameterCountException);
			}
			return value;
		}

		public static Type GetObjectType(object v)
		{
			if (v == null)
			{
				return null;
			}
			return v.GetType();
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull(targetType, "targetType");
			List<PropertyInfo> propertyInfos = new List<PropertyInfo>(targetType.GetProperties(bindingAttr));
			ReflectionUtils.GetChildPrivateProperties(propertyInfos, targetType, bindingAttr);
			for (int i = 0; i < propertyInfos.Count; i++)
			{
				PropertyInfo item = propertyInfos[i];
				if (item.DeclaringType != targetType)
				{
					PropertyInfo memberInfoFromType = (PropertyInfo)ReflectionUtils.GetMemberInfoFromType(item.DeclaringType, item);
					propertyInfos[i] = memberInfoFromType;
				}
			}
			return propertyInfos;
		}

		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat)
		{
			return ReflectionUtils.GetTypeName(t, assemblyFormat, null);
		}

		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			string assemblyQualifiedName;
			string str;
			string str1;
			if (binder == null)
			{
				assemblyQualifiedName = t.AssemblyQualifiedName;
			}
			else
			{
				binder.BindToName(t, out str, out str1);
				assemblyQualifiedName = string.Concat(str1, (str == null ? "" : string.Concat(", ", str)));
			}
			switch (assemblyFormat)
			{
				case FormatterAssemblyStyle.Simple:
				{
					return ReflectionUtils.RemoveAssemblyDetails(assemblyQualifiedName);
				}
				case FormatterAssemblyStyle.Full:
				{
					return assemblyQualifiedName;
				}
			}
			throw new ArgumentOutOfRangeException();
		}

		public static bool HasDefaultConstructor(Type t)
		{
			return ReflectionUtils.HasDefaultConstructor(t, false);
		}

		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			if (t.IsValueType())
			{
				return true;
			}
			return ReflectionUtils.GetDefaultConstructor(t, nonPublic) != null;
		}

		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			Type type1;
			return ReflectionUtils.ImplementsGenericDefinition(type, genericInterfaceDefinition, out type1);
		}

		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			ValidationUtils.ArgumentNotNull(genericInterfaceDefinition, "genericInterfaceDefinition");
			if (!genericInterfaceDefinition.IsInterface() || !genericInterfaceDefinition.IsGenericTypeDefinition())
			{
				throw new ArgumentNullException("'{0}' is not a generic interface definition.".FormatWith(CultureInfo.InvariantCulture, genericInterfaceDefinition));
			}
			if (type.IsInterface() && type.IsGenericType() && genericInterfaceDefinition == type.GetGenericTypeDefinition())
			{
				implementingType = type;
				return true;
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < (int)interfaces.Length; i++)
			{
				Type type1 = interfaces[i];
				if (type1.IsGenericType() && genericInterfaceDefinition == type1.GetGenericTypeDefinition())
				{
					implementingType = type1;
					return true;
				}
			}
			implementingType = null;
			return false;
		}

		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			Type type1;
			return ReflectionUtils.InheritsGenericDefinition(type, genericClassDefinition, out type1);
		}

		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			ValidationUtils.ArgumentNotNull(genericClassDefinition, "genericClassDefinition");
			if (!genericClassDefinition.IsClass() || !genericClassDefinition.IsGenericTypeDefinition())
			{
				throw new ArgumentNullException("'{0}' is not a generic class definition.".FormatWith(CultureInfo.InvariantCulture, genericClassDefinition));
			}
			return ReflectionUtils.InheritsGenericDefinitionInternal(type, genericClassDefinition, out implementingType);
		}

		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			if (currentType.IsGenericType() && genericClassDefinition == currentType.GetGenericTypeDefinition())
			{
				implementingType = currentType;
				return true;
			}
			if (currentType.BaseType() == null)
			{
				implementingType = null;
				return false;
			}
			return ReflectionUtils.InheritsGenericDefinitionInternal(currentType.BaseType(), genericClassDefinition, out implementingType);
		}

		public static bool IsIndexedProperty(MemberInfo member)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			PropertyInfo propertyInfo = member as PropertyInfo;
			if (propertyInfo == null)
			{
				return false;
			}
			return ReflectionUtils.IsIndexedProperty(propertyInfo);
		}

		public static bool IsIndexedProperty(PropertyInfo property)
		{
			ValidationUtils.ArgumentNotNull(property, "property");
			return (int)property.GetIndexParameters().Length > 0;
		}

		public static bool IsInstantiatableType(Type t)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			if (t.IsAbstract() || t.IsInterface() || t.IsArray || t.IsGenericTypeDefinition() || t == typeof(void))
			{
				return false;
			}
			if (!ReflectionUtils.HasDefaultConstructor(t))
			{
				return false;
			}
			return true;
		}

		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			bool flag = currentType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Any<MethodInfo>((MethodInfo info) => {
				if (!(info.Name == method) || !(info.DeclaringType != methodDeclaringType))
				{
					return false;
				}
				return info.GetBaseDefinition().DeclaringType == methodDeclaringType;
			});
			return flag;
		}

		public static bool IsNullable(Type t)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			if (!t.IsValueType())
			{
				return true;
			}
			return ReflectionUtils.IsNullableType(t);
		}

		public static bool IsNullableType(Type t)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			if (!t.IsGenericType())
			{
				return false;
			}
			return t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			MemberTypes memberType = memberInfo.MemberType();
			if (memberType != MemberTypes.Field && memberType != MemberTypes.Property)
			{
				throw new ArgumentException("Member must be a field or property.");
			}
			Type declaringType = memberInfo.DeclaringType;
			if (!declaringType.IsGenericType())
			{
				return false;
			}
			Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			if (genericTypeDefinition == null)
			{
				return false;
			}
			MemberInfo[] member = genericTypeDefinition.GetMember(memberInfo.Name, bindingAttr);
			if ((int)member.Length == 0)
			{
				return false;
			}
			if (!ReflectionUtils.GetMemberUnderlyingType(member[0]).IsGenericParameter)
			{
				return false;
			}
			return true;
		}

		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			MethodInfo getMethod = propertyInfo.GetGetMethod();
			if (getMethod != null && getMethod.IsVirtual)
			{
				return true;
			}
			getMethod = propertyInfo.GetSetMethod();
			if (getMethod != null && getMethod.IsVirtual)
			{
				return true;
			}
			return false;
		}

		public static Type MakeGenericType(Type genericTypeDefinition, params Type[] innerTypes)
		{
			ValidationUtils.ArgumentNotNull(genericTypeDefinition, "genericTypeDefinition");
			ValidationUtils.ArgumentNotNullOrEmpty<Type>(innerTypes, "innerTypes");
			ValidationUtils.ArgumentConditionTrue(genericTypeDefinition.IsGenericTypeDefinition(), "genericTypeDefinition", "Type {0} is not a generic type definition.".FormatWith(CultureInfo.InvariantCulture, genericTypeDefinition));
			return genericTypeDefinition.MakeGenericType(innerTypes);
		}

		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			bool flag1 = false;
			for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
			{
				char chr = fullyQualifiedTypeName[i];
				char chr1 = chr;
				if (chr1 != ',')
				{
					switch (chr1)
					{
						case '[':
						{
							flag = false;
							flag1 = false;
							stringBuilder.Append(chr);
							break;
						}
						case '\\':
						{
							if (flag1)
							{
								break;
							}
							stringBuilder.Append(chr);
							break;
						}
						case ']':
						{
							flag = false;
							flag1 = false;
							stringBuilder.Append(chr);
							break;
						}
						default:
						{
							goto case '\\';
						}
					}
				}
				else if (flag)
				{
					flag1 = true;
				}
				else
				{
					flag = true;
					stringBuilder.Append(chr);
				}
			}
			return stringBuilder.ToString();
		}

		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			if ((bindingAttr & flag) != flag)
			{
				return bindingAttr;
			}
			return bindingAttr ^ flag;
		}

		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			ValidationUtils.ArgumentNotNull(target, "target");
			MemberTypes memberType = member.MemberType();
			if (memberType == MemberTypes.Field)
			{
				((FieldInfo)member).SetValue(target, value);
				return;
			}
			if (memberType != MemberTypes.Property)
			{
				throw new ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".FormatWith(CultureInfo.InvariantCulture, member.Name), "member");
			}
			((PropertyInfo)member).SetValue(target, value, null);
		}

		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			int? assemblyDelimiterIndex = ReflectionUtils.GetAssemblyDelimiterIndex(fullyQualifiedTypeName);
			if (!assemblyDelimiterIndex.HasValue)
			{
				typeName = fullyQualifiedTypeName;
				assemblyName = null;
				return;
			}
			typeName = fullyQualifiedTypeName.Substring(0, assemblyDelimiterIndex.Value).Trim();
			assemblyName = fullyQualifiedTypeName.Substring(assemblyDelimiterIndex.Value + 1, fullyQualifiedTypeName.Length - assemblyDelimiterIndex.Value - 1).Trim();
		}
	}
}