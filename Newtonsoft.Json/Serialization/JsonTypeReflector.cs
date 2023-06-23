using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace Newtonsoft.Json.Serialization
{
	internal static class JsonTypeReflector
	{
		public const string IdPropertyName = "$id";

		public const string RefPropertyName = "$ref";

		public const string TypePropertyName = "$type";

		public const string ValuePropertyName = "$value";

		public const string ArrayValuesPropertyName = "$values";

		public const string ShouldSerializePrefix = "ShouldSerialize";

		public const string SpecifiedPostfix = "Specified";

		private const string MetadataTypeAttributeTypeName = "System.ComponentModel.DataAnnotations.MetadataTypeAttribute, System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

		private readonly static ThreadSafeStore<ICustomAttributeProvider, Type> JsonConverterTypeCache;

		private readonly static ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		private static Type _cachedMetadataTypeAttributeType;

		private static bool? _dynamicCodeGeneration;

		private static bool? _fullyTrusted;

		public static bool DynamicCodeGeneration
		{
			get
			{
				if (!JsonTypeReflector._dynamicCodeGeneration.HasValue)
				{
					try
					{
						(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess)).Demand();
						(new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess)).Demand();
						(new SecurityPermission(SecurityPermissionFlag.SkipVerification)).Demand();
						(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Demand();
						(new SecurityPermission(PermissionState.Unrestricted)).Demand();
						JsonTypeReflector._dynamicCodeGeneration = new bool?(true);
					}
					catch (Exception exception)
					{
						JsonTypeReflector._dynamicCodeGeneration = new bool?(false);
					}
				}
				return JsonTypeReflector._dynamicCodeGeneration.Value;
			}
		}

		public static bool FullyTrusted
		{
			get
			{
				if (!JsonTypeReflector._fullyTrusted.HasValue)
				{
					AppDomain currentDomain = AppDomain.CurrentDomain;
					JsonTypeReflector._fullyTrusted = new bool?((!currentDomain.IsHomogenous ? false : currentDomain.IsFullyTrusted));
				}
				return JsonTypeReflector._fullyTrusted.Value;
			}
		}

		public static Newtonsoft.Json.Utilities.ReflectionDelegateFactory ReflectionDelegateFactory
		{
			get
			{
				if (JsonTypeReflector.DynamicCodeGeneration)
				{
					return DynamicReflectionDelegateFactory.Instance;
				}
				return LateBoundReflectionDelegateFactory.Instance;
			}
		}

		static JsonTypeReflector()
		{
			JsonTypeReflector.JsonConverterTypeCache = new ThreadSafeStore<ICustomAttributeProvider, Type>(new Func<ICustomAttributeProvider, Type>(JsonTypeReflector.GetJsonConverterTypeFromAttribute));
			JsonTypeReflector.AssociatedMetadataTypesCache = new ThreadSafeStore<Type, Type>(new Func<Type, Type>(JsonTypeReflector.GetAssociateMetadataTypeFromAttribute));
		}

		private static Type GetAssociatedMetadataType(Type type)
		{
			return JsonTypeReflector.AssociatedMetadataTypesCache.Get(type);
		}

		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			IMetadataTypeAttribute lateBoundMetadataTypeAttribute;
			Type metadataTypeAttributeType = JsonTypeReflector.GetMetadataTypeAttributeType();
			if (metadataTypeAttributeType == null)
			{
				return null;
			}
			object obj = type.GetCustomAttributes(metadataTypeAttributeType, true).SingleOrDefault<object>();
			if (obj == null)
			{
				return null;
			}
			if (JsonTypeReflector.DynamicCodeGeneration)
			{
				lateBoundMetadataTypeAttribute = DynamicWrapper.CreateWrapper<IMetadataTypeAttribute>(obj);
			}
			else
			{
				lateBoundMetadataTypeAttribute = new LateBoundMetadataTypeAttribute(obj);
			}
			return lateBoundMetadataTypeAttribute.MetadataClassType;
		}

		private static T GetAttribute<T>(Type type)
		where T : Attribute
		{
			T attribute;
			Type associatedMetadataType = JsonTypeReflector.GetAssociatedMetadataType(type);
			if (associatedMetadataType != null)
			{
				attribute = ReflectionUtils.GetAttribute<T>(associatedMetadataType, true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			attribute = ReflectionUtils.GetAttribute<T>(type.GetCustomAttributeProvider(), true);
			if (attribute != null)
			{
				return attribute;
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < (int)interfaces.Length; i++)
			{
				Type type1 = interfaces[i];
				attribute = ReflectionUtils.GetAttribute<T>(type1.GetCustomAttributeProvider(), true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			return default(T);
		}

		private static T GetAttribute<T>(MemberInfo memberInfo)
		where T : Attribute
		{
			T attribute;
			Type associatedMetadataType = JsonTypeReflector.GetAssociatedMetadataType(memberInfo.DeclaringType);
			if (associatedMetadataType != null)
			{
				MemberInfo memberInfoFromType = ReflectionUtils.GetMemberInfoFromType(associatedMetadataType, memberInfo);
				if (memberInfoFromType != null)
				{
					attribute = ReflectionUtils.GetAttribute<T>(memberInfoFromType, true);
					if (attribute != null)
					{
						return attribute;
					}
				}
			}
			attribute = ReflectionUtils.GetAttribute<T>(memberInfo.GetCustomAttributeProvider(), true);
			if (attribute != null)
			{
				return attribute;
			}
			if (memberInfo.DeclaringType != null)
			{
				Type[] interfaces = memberInfo.DeclaringType.GetInterfaces();
				for (int i = 0; i < (int)interfaces.Length; i++)
				{
					MemberInfo memberInfoFromType1 = ReflectionUtils.GetMemberInfoFromType(interfaces[i], memberInfo);
					if (memberInfoFromType1 != null)
					{
						attribute = ReflectionUtils.GetAttribute<T>(memberInfoFromType1.GetCustomAttributeProvider(), true);
						if (attribute != null)
						{
							return attribute;
						}
					}
				}
			}
			return default(T);
		}

		public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider)
		where T : Attribute
		{
			object obj = null;
			obj = attributeProvider;
			Type type = obj as Type;
			if (type != null)
			{
				return JsonTypeReflector.GetAttribute<T>(type);
			}
			MemberInfo memberInfo = obj as MemberInfo;
			if (memberInfo != null)
			{
				return JsonTypeReflector.GetAttribute<T>(memberInfo);
			}
			return ReflectionUtils.GetAttribute<T>(attributeProvider, true);
		}

		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			for (Type i = type; i != null; i = i.BaseType())
			{
				DataContractAttribute attribute = CachedAttributeGetter<DataContractAttribute>.GetAttribute(i.GetCustomAttributeProvider());
				if (attribute != null)
				{
					return attribute;
				}
			}
			return null;
		}

		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			if (memberInfo.MemberType() == MemberTypes.Field)
			{
				return CachedAttributeGetter<DataMemberAttribute>.GetAttribute(memberInfo.GetCustomAttributeProvider());
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
			DataMemberAttribute attribute = CachedAttributeGetter<DataMemberAttribute>.GetAttribute(propertyInfo.GetCustomAttributeProvider());
			if (attribute == null && propertyInfo.IsVirtual())
			{
				for (Type i = propertyInfo.DeclaringType; attribute == null && i != null; i = i.BaseType())
				{
					PropertyInfo memberInfoFromType = (PropertyInfo)ReflectionUtils.GetMemberInfoFromType(i, propertyInfo);
					if (memberInfoFromType != null && memberInfoFromType.IsVirtual())
					{
						attribute = CachedAttributeGetter<DataMemberAttribute>.GetAttribute(memberInfoFromType.GetCustomAttributeProvider());
					}
				}
			}
			return attribute;
		}

		public static JsonArrayAttribute GetJsonArrayAttribute(Type type)
		{
			return JsonTypeReflector.GetJsonContainerAttribute(type) as JsonArrayAttribute;
		}

		public static JsonContainerAttribute GetJsonContainerAttribute(Type type)
		{
			return CachedAttributeGetter<JsonContainerAttribute>.GetAttribute(type.GetCustomAttributeProvider());
		}

		public static JsonConverter GetJsonConverter(ICustomAttributeProvider attributeProvider, Type targetConvertedType)
		{
			Type jsonConverterType = JsonTypeReflector.GetJsonConverterType(attributeProvider);
			if (jsonConverterType == null)
			{
				return null;
			}
			return JsonConverterAttribute.CreateJsonConverterInstance(jsonConverterType);
		}

		private static Type GetJsonConverterType(ICustomAttributeProvider attributeProvider)
		{
			return JsonTypeReflector.JsonConverterTypeCache.Get(attributeProvider);
		}

		private static Type GetJsonConverterTypeFromAttribute(ICustomAttributeProvider attributeProvider)
		{
			JsonConverterAttribute attribute = JsonTypeReflector.GetAttribute<JsonConverterAttribute>(attributeProvider);
			if (attribute == null)
			{
				return null;
			}
			return attribute.ConverterType;
		}

		public static JsonDictionaryAttribute GetJsonDictionaryAttribute(Type type)
		{
			return JsonTypeReflector.GetJsonContainerAttribute(type) as JsonDictionaryAttribute;
		}

		public static JsonObjectAttribute GetJsonObjectAttribute(Type type)
		{
			return JsonTypeReflector.GetJsonContainerAttribute(type) as JsonObjectAttribute;
		}

		private static Type GetMetadataTypeAttributeType()
		{
			if (JsonTypeReflector._cachedMetadataTypeAttributeType == null)
			{
				Type type = Type.GetType("System.ComponentModel.DataAnnotations.MetadataTypeAttribute, System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
				if (type == null)
				{
					return null;
				}
				JsonTypeReflector._cachedMetadataTypeAttributeType = type;
			}
			return JsonTypeReflector._cachedMetadataTypeAttributeType;
		}

		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			JsonObjectAttribute jsonObjectAttribute = JsonTypeReflector.GetJsonObjectAttribute(objectType);
			if (jsonObjectAttribute != null)
			{
				return jsonObjectAttribute.MemberSerialization;
			}
			if (JsonTypeReflector.GetDataContractAttribute(objectType) != null)
			{
				return MemberSerialization.OptIn;
			}
			if (!ignoreSerializableAttribute && JsonTypeReflector.GetSerializableAttribute(objectType) != null)
			{
				return MemberSerialization.Fields;
			}
			return MemberSerialization.OptOut;
		}

		public static SerializableAttribute GetSerializableAttribute(Type type)
		{
			return CachedAttributeGetter<SerializableAttribute>.GetAttribute(type.GetCustomAttributeProvider());
		}

		public static TypeConverter GetTypeConverter(Type type)
		{
			return TypeDescriptor.GetConverter(type);
		}
	}
}