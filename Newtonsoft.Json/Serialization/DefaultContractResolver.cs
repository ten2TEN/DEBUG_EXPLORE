using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	public class DefaultContractResolver : IContractResolver
	{
		private readonly static IContractResolver _instance;

		private readonly static IList<JsonConverter> BuiltInConverters;

		private static Dictionary<ResolverContractKey, JsonContract> _sharedContractCache;

		private readonly static object _typeContractCacheLock;

		private Dictionary<ResolverContractKey, JsonContract> _instanceContractCache;

		private readonly bool _sharedCache;

		public BindingFlags DefaultMembersSearchFlags
		{
			get;
			set;
		}

		public bool DynamicCodeGeneration
		{
			get
			{
				return JsonTypeReflector.DynamicCodeGeneration;
			}
		}

		public bool IgnoreSerializableAttribute
		{
			get;
			set;
		}

		public bool IgnoreSerializableInterface
		{
			get;
			set;
		}

		internal static IContractResolver Instance
		{
			get
			{
				return DefaultContractResolver._instance;
			}
		}

		public bool SerializeCompilerGeneratedMembers
		{
			get;
			set;
		}

		static DefaultContractResolver()
		{
			DefaultContractResolver._instance = new DefaultContractResolver(true);
			List<JsonConverter> jsonConverters = new List<JsonConverter>()
			{
				new EntityKeyMemberConverter(),
				new ExpandoObjectConverter(),
				new XmlNodeConverter(),
				new BinaryConverter(),
				new DataSetConverter(),
				new DataTableConverter(),
				new KeyValuePairConverter(),
				new BsonObjectIdConverter()
			};
			DefaultContractResolver.BuiltInConverters = jsonConverters;
			DefaultContractResolver._typeContractCacheLock = new object();
		}

		public DefaultContractResolver() : this(false)
		{
		}

		public DefaultContractResolver(bool shareCache)
		{
			this.DefaultMembersSearchFlags = BindingFlags.Instance | BindingFlags.Public;
			this.IgnoreSerializableAttribute = true;
			this._sharedCache = shareCache;
		}

		internal static bool CanConvertToString(Type type)
		{
			TypeConverter converter = ConvertUtils.GetConverter(type);
			if (converter != null && !(converter is ComponentConverter) && !(converter is ReferenceConverter) && converter.GetType() != typeof(TypeConverter) && converter.CanConvertTo(typeof(string)))
			{
				return true;
			}
			if (!(type == typeof(Type)) && !type.IsSubclassOf(typeof(Type)))
			{
				return false;
			}
			return true;
		}

		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			JsonArrayContract jsonArrayContract = new JsonArrayContract(objectType);
			this.InitializeContract(jsonArrayContract);
			return jsonArrayContract;
		}

		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			ParameterInfo[] parameters = constructor.GetParameters();
			JsonPropertyCollection jsonPropertyCollection = new JsonPropertyCollection(constructor.DeclaringType);
			ParameterInfo[] parameterInfoArray = parameters;
			for (int i = 0; i < (int)parameterInfoArray.Length; i++)
			{
				ParameterInfo parameterInfo = parameterInfoArray[i];
				JsonProperty closestMatchProperty = memberProperties.GetClosestMatchProperty(parameterInfo.Name);
				if (closestMatchProperty != null && closestMatchProperty.PropertyType != parameterInfo.ParameterType)
				{
					closestMatchProperty = null;
				}
				JsonProperty jsonProperty = this.CreatePropertyFromConstructorParameter(closestMatchProperty, parameterInfo);
				if (jsonProperty != null)
				{
					jsonPropertyCollection.AddProperty(jsonProperty);
				}
			}
			return jsonPropertyCollection;
		}

		protected virtual JsonContract CreateContract(Type objectType)
		{
			Type type = ReflectionUtils.EnsureNotNullableType(objectType);
			if (JsonConvert.IsJsonPrimitiveType(type))
			{
				return this.CreatePrimitiveContract(objectType);
			}
			if (JsonTypeReflector.GetJsonObjectAttribute(type) != null)
			{
				return this.CreateObjectContract(objectType);
			}
			if (JsonTypeReflector.GetJsonArrayAttribute(type) != null)
			{
				return this.CreateArrayContract(objectType);
			}
			if (JsonTypeReflector.GetJsonDictionaryAttribute(type) != null)
			{
				return this.CreateDictionaryContract(objectType);
			}
			if (type == typeof(JToken) || type.IsSubclassOf(typeof(JToken)))
			{
				return this.CreateLinqContract(objectType);
			}
			if (CollectionUtils.IsDictionaryType(type))
			{
				return this.CreateDictionaryContract(objectType);
			}
			if (typeof(IEnumerable).IsAssignableFrom(type))
			{
				return this.CreateArrayContract(objectType);
			}
			if (DefaultContractResolver.CanConvertToString(type))
			{
				return this.CreateStringContract(objectType);
			}
			if (!this.IgnoreSerializableInterface && typeof(ISerializable).IsAssignableFrom(type))
			{
				return this.CreateISerializableContract(objectType);
			}
			if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type))
			{
				return this.CreateDynamicContract(objectType);
			}
			return this.CreateObjectContract(objectType);
		}

		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			JsonDictionaryContract jsonDictionaryContract = new JsonDictionaryContract(objectType);
			this.InitializeContract(jsonDictionaryContract);
			DefaultContractResolver defaultContractResolver = this;
			jsonDictionaryContract.PropertyNameResolver = new Func<string, string>(defaultContractResolver.ResolvePropertyName);
			return jsonDictionaryContract;
		}

		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			JsonDynamicContract jsonDynamicContract = new JsonDynamicContract(objectType);
			this.InitializeContract(jsonDynamicContract);
			DefaultContractResolver defaultContractResolver = this;
			jsonDynamicContract.PropertyNameResolver = new Func<string, string>(defaultContractResolver.ResolvePropertyName);
			jsonDynamicContract.Properties.AddRange<JsonProperty>(this.CreateProperties(objectType, MemberSerialization.OptOut));
			return jsonDynamicContract;
		}

		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			JsonISerializableContract jsonISerializableContract = new JsonISerializableContract(objectType);
			this.InitializeContract(jsonISerializableContract);
			Type nonNullableUnderlyingType = jsonISerializableContract.NonNullableUnderlyingType;
			Type[] typeArray = new Type[] { typeof(SerializationInfo), typeof(StreamingContext) };
			ConstructorInfo constructor = nonNullableUnderlyingType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, typeArray, null);
			if (constructor != null)
			{
				MethodCall<object, object> methodCall = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(constructor);
				jsonISerializableContract.ISerializableCreator = (object[] args) => methodCall(null, args);
			}
			return jsonISerializableContract;
		}

		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			JsonLinqContract jsonLinqContract = new JsonLinqContract(objectType);
			this.InitializeContract(jsonLinqContract);
			return jsonLinqContract;
		}

		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			IValueProvider reflectionValueProvider;
			if (!this.DynamicCodeGeneration)
			{
				reflectionValueProvider = new ReflectionValueProvider(member);
			}
			else
			{
				reflectionValueProvider = new DynamicValueProvider(member);
			}
			return reflectionValueProvider;
		}

		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			JsonObjectContract jsonObjectContract = new JsonObjectContract(objectType);
			this.InitializeContract(jsonObjectContract);
			bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
			jsonObjectContract.MemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(jsonObjectContract.NonNullableUnderlyingType, ignoreSerializableAttribute);
			jsonObjectContract.Properties.AddRange<JsonProperty>(this.CreateProperties(jsonObjectContract.NonNullableUnderlyingType, jsonObjectContract.MemberSerialization));
			JsonObjectAttribute jsonObjectAttribute = JsonTypeReflector.GetJsonObjectAttribute(jsonObjectContract.NonNullableUnderlyingType);
			if (jsonObjectAttribute != null)
			{
				jsonObjectContract.ItemRequired = jsonObjectAttribute._itemRequired;
			}
			if (((IEnumerable<ConstructorInfo>)jsonObjectContract.NonNullableUnderlyingType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)).Any<ConstructorInfo>((ConstructorInfo c) => c.IsDefined(typeof(JsonConstructorAttribute), true)))
			{
				ConstructorInfo attributeConstructor = this.GetAttributeConstructor(jsonObjectContract.NonNullableUnderlyingType);
				if (attributeConstructor != null)
				{
					jsonObjectContract.OverrideConstructor = attributeConstructor;
					jsonObjectContract.ConstructorParameters.AddRange<JsonProperty>(this.CreateConstructorParameters(attributeConstructor, jsonObjectContract.Properties));
				}
			}
			else if (jsonObjectContract.DefaultCreator == null || jsonObjectContract.DefaultCreatorNonPublic)
			{
				ConstructorInfo parametrizedConstructor = this.GetParametrizedConstructor(jsonObjectContract.NonNullableUnderlyingType);
				if (parametrizedConstructor != null)
				{
					jsonObjectContract.ParametrizedConstructor = parametrizedConstructor;
					jsonObjectContract.ConstructorParameters.AddRange<JsonProperty>(this.CreateConstructorParameters(parametrizedConstructor, jsonObjectContract.Properties));
				}
			}
			return jsonObjectContract;
		}

		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			JsonPrimitiveContract jsonPrimitiveContract = new JsonPrimitiveContract(objectType);
			this.InitializeContract(jsonPrimitiveContract);
			return jsonPrimitiveContract;
		}

		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			List<MemberInfo> serializableMembers = this.GetSerializableMembers(type);
			if (serializableMembers == null)
			{
				throw new JsonSerializationException("Null collection of seralizable members returned.");
			}
			JsonPropertyCollection jsonPropertyCollection = new JsonPropertyCollection(type);
			foreach (MemberInfo serializableMember in serializableMembers)
			{
				JsonProperty jsonProperty = this.CreateProperty(serializableMember, memberSerialization);
				if (jsonProperty == null)
				{
					continue;
				}
				jsonPropertyCollection.AddProperty(jsonProperty);
			}
			return jsonPropertyCollection.OrderBy<JsonProperty, int>((JsonProperty p) => {
				int? order = p.Order;
				if (!order.HasValue)
				{
					return -1;
				}
				return order.GetValueOrDefault();
			}).ToList<JsonProperty>();
		}

		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			bool flag;
			bool flag1;
			JsonProperty jsonProperty = new JsonProperty()
			{
				PropertyType = ReflectionUtils.GetMemberUnderlyingType(member),
				DeclaringType = member.DeclaringType,
				ValueProvider = this.CreateMemberValueProvider(member)
			};
			this.SetPropertySettingsFromAttributes(jsonProperty, member.GetCustomAttributeProvider(), member.Name, member.DeclaringType, memberSerialization, out flag, out flag1);
			jsonProperty.Readable = ReflectionUtils.CanReadMemberValue(member, flag);
			jsonProperty.Writable = ReflectionUtils.CanSetMemberValue(member, flag, flag1);
			jsonProperty.ShouldSerialize = this.CreateShouldSerializeTest(member);
			this.SetIsSpecifiedActions(jsonProperty, member, flag);
			return jsonProperty;
		}

		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			bool flag;
			bool flag1;
			JsonProperty jsonProperty = new JsonProperty()
			{
				PropertyType = parameterInfo.ParameterType
			};
			this.SetPropertySettingsFromAttributes(jsonProperty, parameterInfo.GetCustomAttributeProvider(), parameterInfo.Name, parameterInfo.Member.DeclaringType, MemberSerialization.OptOut, out flag, out flag1);
			jsonProperty.Readable = false;
			jsonProperty.Writable = true;
			if (matchingMemberProperty != null)
			{
				jsonProperty.PropertyName = (jsonProperty.PropertyName != parameterInfo.Name ? jsonProperty.PropertyName : matchingMemberProperty.PropertyName);
				jsonProperty.Converter = jsonProperty.Converter ?? matchingMemberProperty.Converter;
				jsonProperty.MemberConverter = jsonProperty.MemberConverter ?? matchingMemberProperty.MemberConverter;
				jsonProperty.DefaultValue = jsonProperty.DefaultValue ?? matchingMemberProperty.DefaultValue;
				JsonProperty jsonProperty1 = jsonProperty;
				Required? nullable = jsonProperty._required;
				jsonProperty1._required = (nullable.HasValue ? new Required?(nullable.GetValueOrDefault()) : matchingMemberProperty._required);
				JsonProperty jsonProperty2 = jsonProperty;
				bool? isReference = jsonProperty.IsReference;
				jsonProperty2.IsReference = (isReference.HasValue ? new bool?(isReference.GetValueOrDefault()) : matchingMemberProperty.IsReference);
				JsonProperty jsonProperty3 = jsonProperty;
				NullValueHandling? nullValueHandling = jsonProperty.NullValueHandling;
				jsonProperty3.NullValueHandling = (nullValueHandling.HasValue ? new NullValueHandling?(nullValueHandling.GetValueOrDefault()) : matchingMemberProperty.NullValueHandling);
				JsonProperty jsonProperty4 = jsonProperty;
				DefaultValueHandling? defaultValueHandling = jsonProperty.DefaultValueHandling;
				jsonProperty4.DefaultValueHandling = (defaultValueHandling.HasValue ? new DefaultValueHandling?(defaultValueHandling.GetValueOrDefault()) : matchingMemberProperty.DefaultValueHandling);
				JsonProperty jsonProperty5 = jsonProperty;
				ReferenceLoopHandling? referenceLoopHandling = jsonProperty.ReferenceLoopHandling;
				jsonProperty5.ReferenceLoopHandling = (referenceLoopHandling.HasValue ? new ReferenceLoopHandling?(referenceLoopHandling.GetValueOrDefault()) : matchingMemberProperty.ReferenceLoopHandling);
				JsonProperty jsonProperty6 = jsonProperty;
				ObjectCreationHandling? objectCreationHandling = jsonProperty.ObjectCreationHandling;
				jsonProperty6.ObjectCreationHandling = (objectCreationHandling.HasValue ? new ObjectCreationHandling?(objectCreationHandling.GetValueOrDefault()) : matchingMemberProperty.ObjectCreationHandling);
				JsonProperty jsonProperty7 = jsonProperty;
				TypeNameHandling? typeNameHandling = jsonProperty.TypeNameHandling;
				jsonProperty7.TypeNameHandling = (typeNameHandling.HasValue ? new TypeNameHandling?(typeNameHandling.GetValueOrDefault()) : matchingMemberProperty.TypeNameHandling);
			}
			return jsonProperty;
		}

		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			MethodInfo method = member.DeclaringType.GetMethod(string.Concat("ShouldSerialize", member.Name), ReflectionUtils.EmptyTypes);
			if (method == null || method.ReturnType != typeof(bool))
			{
				return null;
			}
			MethodCall<object, object> methodCall = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			return (object o) => (bool)methodCall(o, new object[0]);
		}

		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			JsonStringContract jsonStringContract = new JsonStringContract(objectType);
			this.InitializeContract(jsonStringContract);
			return jsonStringContract;
		}

		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			IList<ConstructorInfo> list = (
				from c in (IEnumerable<ConstructorInfo>)objectType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where c.IsDefined(typeof(JsonConstructorAttribute), true)
				select c).ToList<ConstructorInfo>();
			if (list.Count > 1)
			{
				throw new JsonException("Multiple constructors with the JsonConstructorAttribute.");
			}
			if (list.Count != 1)
			{
				return null;
			}
			return list[0];
		}

		private Dictionary<ResolverContractKey, JsonContract> GetCache()
		{
			if (this._sharedCache)
			{
				return DefaultContractResolver._sharedContractCache;
			}
			return this._instanceContractCache;
		}

		private void GetCallbackMethodsForType(Type type, out MethodInfo onSerializing, out MethodInfo onSerialized, out MethodInfo onDeserializing, out MethodInfo onDeserialized, out MethodInfo onError)
		{
			onSerializing = null;
			onSerialized = null;
			onDeserializing = null;
			onDeserialized = null;
			onError = null;
			MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < (int)methods.Length; i++)
			{
				MethodInfo methodInfo = methods[i];
				if (!methodInfo.ContainsGenericParameters)
				{
					Type type1 = null;
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnSerializingAttribute), onSerializing, ref type1))
					{
						onSerializing = methodInfo;
					}
					if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnSerializedAttribute), onSerialized, ref type1))
					{
						onSerialized = methodInfo;
					}
					if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnDeserializingAttribute), onDeserializing, ref type1))
					{
						onDeserializing = methodInfo;
					}
					if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnDeserializedAttribute), onDeserialized, ref type1))
					{
						onDeserialized = methodInfo;
					}
					if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnErrorAttribute), onError, ref type1))
					{
						onError = methodInfo;
					}
				}
			}
		}

		internal static string GetClrTypeFullName(Type type)
		{
			if (type.IsGenericTypeDefinition() || !type.ContainsGenericParameters())
			{
				return type.FullName;
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object[] @namespace = new object[] { type.Namespace, type.Name };
			return string.Format(invariantCulture, "{0}.{1}", @namespace);
		}

		private Func<object> GetDefaultCreator(Type createdType)
		{
			return JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(createdType);
		}

		private ConstructorInfo GetParametrizedConstructor(Type objectType)
		{
			IList<ConstructorInfo> list = objectType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).ToList<ConstructorInfo>();
			if (list.Count != 1)
			{
				return null;
			}
			return list[0];
		}

		public string GetResolvedPropertyName(string propertyName)
		{
			return this.ResolvePropertyName(propertyName);
		}

		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			Type type;
			MemberSerialization objectMemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(objectType, this.IgnoreSerializableAttribute);
			List<MemberInfo> list = (
				from m in ReflectionUtils.GetFieldsAndProperties(objectType, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
				where !ReflectionUtils.IsIndexedProperty(m)
				select m).ToList<MemberInfo>();
			List<MemberInfo> memberInfos = new List<MemberInfo>();
			if (objectMemberSerialization == MemberSerialization.Fields)
			{
				foreach (MemberInfo memberInfo in list)
				{
					if (memberInfo.MemberType() != MemberTypes.Field)
					{
						continue;
					}
					memberInfos.Add(memberInfo);
				}
			}
			else
			{
				DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(objectType);
				List<MemberInfo> list1 = (
					from m in ReflectionUtils.GetFieldsAndProperties(objectType, this.DefaultMembersSearchFlags)
					where !ReflectionUtils.IsIndexedProperty(m)
					select m).ToList<MemberInfo>();
				foreach (MemberInfo memberInfo1 in list)
				{
					if (!this.SerializeCompilerGeneratedMembers && memberInfo1.IsDefined(typeof(CompilerGeneratedAttribute), true))
					{
						continue;
					}
					if (list1.Contains(memberInfo1))
					{
						memberInfos.Add(memberInfo1);
					}
					else if (JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(memberInfo1.GetCustomAttributeProvider()) != null)
					{
						memberInfos.Add(memberInfo1);
					}
					else if (dataContractAttribute == null || JsonTypeReflector.GetAttribute<DataMemberAttribute>(memberInfo1.GetCustomAttributeProvider()) == null)
					{
						if (objectMemberSerialization != MemberSerialization.Fields || memberInfo1.MemberType() != MemberTypes.Field)
						{
							continue;
						}
						memberInfos.Add(memberInfo1);
					}
					else
					{
						memberInfos.Add(memberInfo1);
					}
				}
				if (objectType.AssignableToTypeName("System.Data.Objects.DataClasses.EntityObject", out type))
				{
					memberInfos = memberInfos.Where<MemberInfo>(new Func<MemberInfo, bool>(this.ShouldSerializeEntityMember)).ToList<MemberInfo>();
				}
			}
			return memberInfos;
		}

		private void InitializeContract(JsonContract contract)
		{
			JsonContainerAttribute jsonContainerAttribute = JsonTypeReflector.GetJsonContainerAttribute(contract.NonNullableUnderlyingType);
			if (jsonContainerAttribute == null)
			{
				DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(contract.NonNullableUnderlyingType);
				if (dataContractAttribute != null && dataContractAttribute.IsReference)
				{
					contract.IsReference = new bool?(true);
				}
			}
			else
			{
				contract.IsReference = jsonContainerAttribute._isReference;
			}
			contract.Converter = this.ResolveContractConverter(contract.NonNullableUnderlyingType);
			contract.InternalConverter = JsonSerializer.GetMatchingConverter(DefaultContractResolver.BuiltInConverters, contract.NonNullableUnderlyingType);
			if (ReflectionUtils.HasDefaultConstructor(contract.CreatedType, true) || contract.CreatedType.IsValueType())
			{
				contract.DefaultCreator = this.GetDefaultCreator(contract.CreatedType);
				contract.DefaultCreatorNonPublic = (contract.CreatedType.IsValueType() ? false : ReflectionUtils.GetDefaultConstructor(contract.CreatedType) == null);
			}
			this.ResolveCallbackMethods(contract, contract.NonNullableUnderlyingType);
		}

		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			if (!method.IsDefined(attributeType, false))
			{
				return false;
			}
			if (currentCallback != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object[] objArray = new object[] { method, currentCallback, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), attributeType };
				throw new JsonException("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".FormatWith(invariantCulture, objArray));
			}
			if (prevAttributeType != null)
			{
				CultureInfo cultureInfo = CultureInfo.InvariantCulture;
				object[] objArray1 = new object[] { prevAttributeType, attributeType, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method };
				throw new JsonException("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".FormatWith(cultureInfo, objArray1));
			}
			if (method.IsVirtual)
			{
				throw new JsonException("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".FormatWith(CultureInfo.InvariantCulture, method, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), attributeType));
			}
			if (method.ReturnType != typeof(void))
			{
				throw new JsonException("Serialization Callback '{1}' in type '{0}' must return void.".FormatWith(CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method));
			}
			if (attributeType == typeof(OnErrorAttribute))
			{
				if (parameters == null || (int)parameters.Length != 2 || parameters[0].ParameterType != typeof(StreamingContext) || parameters[1].ParameterType != typeof(ErrorContext))
				{
					CultureInfo invariantCulture1 = CultureInfo.InvariantCulture;
					object[] clrTypeFullName = new object[] { DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method, typeof(StreamingContext), typeof(ErrorContext) };
					throw new JsonException("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".FormatWith(invariantCulture1, clrTypeFullName));
				}
			}
			else if (parameters == null || (int)parameters.Length != 1 || parameters[0].ParameterType != typeof(StreamingContext))
			{
				throw new JsonException("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".FormatWith(CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method, typeof(StreamingContext)));
			}
			prevAttributeType = attributeType;
			return true;
		}

		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
			MethodInfo methodInfo;
			MethodInfo methodInfo1;
			MethodInfo methodInfo2;
			MethodInfo methodInfo3;
			MethodInfo methodInfo4;
			if (t.BaseType() != null)
			{
				this.ResolveCallbackMethods(contract, t.BaseType());
			}
			this.GetCallbackMethodsForType(t, out methodInfo, out methodInfo1, out methodInfo2, out methodInfo3, out methodInfo4);
			if (methodInfo != null)
			{
				contract.OnSerializing = methodInfo;
			}
			if (methodInfo1 != null)
			{
				contract.OnSerialized = methodInfo1;
			}
			if (methodInfo2 != null)
			{
				contract.OnDeserializing = methodInfo2;
			}
			if (methodInfo3 != null && (!t.IsGenericType() || t.GetGenericTypeDefinition() != typeof(ConcurrentDictionary<,>)))
			{
				contract.OnDeserialized = methodInfo3;
			}
			if (methodInfo4 != null)
			{
				contract.OnError = methodInfo4;
			}
		}

		public virtual JsonContract ResolveContract(Type type)
		{
			JsonContract jsonContract;
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			ResolverContractKey resolverContractKey = new ResolverContractKey(this.GetType(), type);
			Dictionary<ResolverContractKey, JsonContract> cache = this.GetCache();
			if (cache == null || !cache.TryGetValue(resolverContractKey, out jsonContract))
			{
				jsonContract = this.CreateContract(type);
				lock (DefaultContractResolver._typeContractCacheLock)
				{
					cache = this.GetCache();
					Dictionary<ResolverContractKey, JsonContract> resolverContractKeys = (cache != null ? new Dictionary<ResolverContractKey, JsonContract>(cache) : new Dictionary<ResolverContractKey, JsonContract>());
					resolverContractKeys[resolverContractKey] = jsonContract;
					this.UpdateCache(resolverContractKeys);
				}
			}
			return jsonContract;
		}

		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return JsonTypeReflector.GetJsonConverter(objectType.GetCustomAttributeProvider(), objectType);
		}

		protected internal virtual string ResolvePropertyName(string propertyName)
		{
			return propertyName;
		}

		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
			MemberInfo field = member.DeclaringType.GetProperty(string.Concat(member.Name, "Specified"));
			if (field == null)
			{
				field = member.DeclaringType.GetField(string.Concat(member.Name, "Specified"));
			}
			if (field == null || ReflectionUtils.GetMemberUnderlyingType(field) != typeof(bool))
			{
				return;
			}
			Func<object, object> func = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(field);
			property.GetIsSpecified = (object o) => (bool)func(o);
			if (ReflectionUtils.CanSetMemberValue(field, allowNonPublicAccess, false))
			{
				property.SetIsSpecified = JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(field);
			}
		}

		private void SetPropertySettingsFromAttributes(JsonProperty property, ICustomAttributeProvider attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess, out bool hasExplicitAttribute)
		{
			DataMemberAttribute dataMemberAttribute;
			string propertyName;
			NullValueHandling? nullable;
			DefaultValueHandling? nullable1;
			ReferenceLoopHandling? nullable2;
			ObjectCreationHandling? nullable3;
			TypeNameHandling? nullable4;
			bool? nullable5;
			bool? nullable6;
			JsonConverter jsonConverter;
			ReferenceLoopHandling? nullable7;
			TypeNameHandling? nullable8;
			int? nullable9;
			hasExplicitAttribute = false;
			DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(declaringType);
			MemberInfo memberInfo = null;
			memberInfo = attributeProvider as MemberInfo;
			if (dataContractAttribute == null || !(memberInfo != null))
			{
				dataMemberAttribute = null;
			}
			else
			{
				dataMemberAttribute = JsonTypeReflector.GetDataMemberAttribute(memberInfo);
			}
			JsonPropertyAttribute attribute = JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(attributeProvider);
			if (attribute != null)
			{
				hasExplicitAttribute = true;
			}
			if (attribute == null || attribute.PropertyName == null)
			{
				propertyName = (dataMemberAttribute == null || dataMemberAttribute.Name == null ? name : dataMemberAttribute.Name);
			}
			else
			{
				propertyName = attribute.PropertyName;
			}
			property.PropertyName = this.ResolvePropertyName(propertyName);
			property.UnderlyingName = name;
			bool flag = false;
			if (attribute != null)
			{
				property._required = attribute._required;
				property.Order = attribute._order;
				flag = true;
			}
			else if (dataMemberAttribute != null)
			{
				property._required = new Required?((dataMemberAttribute.IsRequired ? Required.AllowNull : Required.Default));
				JsonProperty jsonProperty = property;
				if (dataMemberAttribute.Order != -1)
				{
					nullable9 = new int?(dataMemberAttribute.Order);
				}
				else
				{
					nullable9 = null;
				}
				jsonProperty.Order = nullable9;
				flag = true;
			}
			bool flag1 = (JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>(attributeProvider) != null ? true : JsonTypeReflector.GetAttribute<NonSerializedAttribute>(attributeProvider) != null);
			if (memberSerialization == MemberSerialization.OptIn)
			{
				property.Ignored = (flag1 ? true : !flag);
			}
			else
			{
				bool attribute1 = false;
				attribute1 = JsonTypeReflector.GetAttribute<IgnoreDataMemberAttribute>(attributeProvider) != null;
				property.Ignored = (flag1 ? true : attribute1);
			}
			property.Converter = JsonTypeReflector.GetJsonConverter(attributeProvider, property.PropertyType);
			property.MemberConverter = JsonTypeReflector.GetJsonConverter(attributeProvider, property.PropertyType);
			DefaultValueAttribute defaultValueAttribute = JsonTypeReflector.GetAttribute<DefaultValueAttribute>(attributeProvider);
			property.DefaultValue = (defaultValueAttribute != null ? defaultValueAttribute.Value : null);
			JsonProperty jsonProperty1 = property;
			if (attribute != null)
			{
				nullable = attribute._nullValueHandling;
			}
			else
			{
				nullable = null;
			}
			jsonProperty1.NullValueHandling = nullable;
			JsonProperty jsonProperty2 = property;
			if (attribute != null)
			{
				nullable1 = attribute._defaultValueHandling;
			}
			else
			{
				nullable1 = null;
			}
			jsonProperty2.DefaultValueHandling = nullable1;
			JsonProperty jsonProperty3 = property;
			if (attribute != null)
			{
				nullable2 = attribute._referenceLoopHandling;
			}
			else
			{
				nullable2 = null;
			}
			jsonProperty3.ReferenceLoopHandling = nullable2;
			JsonProperty jsonProperty4 = property;
			if (attribute != null)
			{
				nullable3 = attribute._objectCreationHandling;
			}
			else
			{
				nullable3 = null;
			}
			jsonProperty4.ObjectCreationHandling = nullable3;
			JsonProperty jsonProperty5 = property;
			if (attribute != null)
			{
				nullable4 = attribute._typeNameHandling;
			}
			else
			{
				nullable4 = null;
			}
			jsonProperty5.TypeNameHandling = nullable4;
			JsonProperty jsonProperty6 = property;
			if (attribute != null)
			{
				nullable5 = attribute._isReference;
			}
			else
			{
				nullable5 = null;
			}
			jsonProperty6.IsReference = nullable5;
			JsonProperty jsonProperty7 = property;
			if (attribute != null)
			{
				nullable6 = attribute._itemIsReference;
			}
			else
			{
				nullable6 = null;
			}
			jsonProperty7.ItemIsReference = nullable6;
			JsonProperty jsonProperty8 = property;
			if (attribute == null || !(attribute.ItemConverterType != null))
			{
				jsonConverter = null;
			}
			else
			{
				jsonConverter = JsonConverterAttribute.CreateJsonConverterInstance(attribute.ItemConverterType);
			}
			jsonProperty8.ItemConverter = jsonConverter;
			JsonProperty jsonProperty9 = property;
			if (attribute != null)
			{
				nullable7 = attribute._itemReferenceLoopHandling;
			}
			else
			{
				nullable7 = null;
			}
			jsonProperty9.ItemReferenceLoopHandling = nullable7;
			JsonProperty jsonProperty10 = property;
			if (attribute != null)
			{
				nullable8 = attribute._itemTypeNameHandling;
			}
			else
			{
				nullable8 = null;
			}
			jsonProperty10.ItemTypeNameHandling = nullable8;
			allowNonPublicAccess = false;
			if ((this.DefaultMembersSearchFlags & BindingFlags.NonPublic) == BindingFlags.NonPublic)
			{
				allowNonPublicAccess = true;
			}
			if (attribute != null)
			{
				allowNonPublicAccess = true;
			}
			if (memberSerialization == MemberSerialization.Fields)
			{
				allowNonPublicAccess = true;
			}
			if (dataMemberAttribute != null)
			{
				allowNonPublicAccess = true;
				hasExplicitAttribute = true;
			}
		}

		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo != null && propertyInfo.PropertyType.IsGenericType() && propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1")
			{
				return false;
			}
			return true;
		}

		private void UpdateCache(Dictionary<ResolverContractKey, JsonContract> cache)
		{
			if (this._sharedCache)
			{
				DefaultContractResolver._sharedContractCache = cache;
				return;
			}
			this._instanceContractCache = cache;
		}
	}
}