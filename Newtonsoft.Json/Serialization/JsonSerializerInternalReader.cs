using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		private JsonSerializerProxy _internalSerializer;

		private JsonFormatterConverter _formatterConverter;

		public JsonSerializerInternalReader(JsonSerializer serializer) : base(serializer)
		{
		}

		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue)
		{
			currentValue = null;
			useExistingValue = false;
			propertyContract = null;
			gottenCurrentValue = false;
			if (property.Ignored)
			{
				reader.Skip();
				return true;
			}
			ObjectCreationHandling valueOrDefault = property.ObjectCreationHandling.GetValueOrDefault(this.Serializer.ObjectCreationHandling);
			if ((valueOrDefault == ObjectCreationHandling.Auto || valueOrDefault == ObjectCreationHandling.Reuse) && (reader.TokenType == JsonToken.StartArray || reader.TokenType == JsonToken.StartObject) && property.Readable)
			{
				currentValue = property.ValueProvider.GetValue(target);
				gottenCurrentValue = true;
				useExistingValue = (currentValue == null || property.PropertyType.IsArray || ReflectionUtils.InheritsGenericDefinition(property.PropertyType, typeof(ReadOnlyCollection<>)) ? false : !property.PropertyType.IsValueType());
			}
			if (!property.Writable && !useExistingValue)
			{
				reader.Skip();
				return true;
			}
			if (property.NullValueHandling.GetValueOrDefault(this.Serializer.NullValueHandling) == NullValueHandling.Ignore && reader.TokenType == JsonToken.Null)
			{
				reader.Skip();
				return true;
			}
			if (this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer.DefaultValueHandling), DefaultValueHandling.Ignore) && JsonReader.IsPrimitiveToken(reader.TokenType) && MiscellaneousUtils.ValueEquals(reader.Value, property.DefaultValue))
			{
				reader.Skip();
				return true;
			}
			if (property.PropertyContract == null)
			{
				property.PropertyContract = this.GetContractSafe(property.PropertyType);
			}
			if (currentValue != null)
			{
				propertyContract = this.GetContractSafe(currentValue.GetType());
				if (propertyContract != property.PropertyContract)
				{
					propertyConverter = this.GetConverter(propertyContract, property.MemberConverter, containerContract, containerProperty);
				}
			}
			else
			{
				propertyContract = property.PropertyContract;
			}
			return false;
		}

		private void CheckedRead(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
			}
		}

		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id)
		{
			object obj;
			if (contract.UnderlyingType.IsInterface() || contract.UnderlyingType.IsAbstract())
			{
				throw JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantated.".FormatWith(CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			if (contract.DefaultCreator == null || contract.DefaultCreatorNonPublic && this.Serializer.ConstructorHandling != ConstructorHandling.AllowNonPublicDefaultConstructor)
			{
				throw JsonSerializationException.Create(reader, "Unable to find a default constructor to use for type {0}.".FormatWith(CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			IDynamicMetaObjectProvider defaultCreator = (IDynamicMetaObjectProvider)contract.DefaultCreator();
			if (id != null)
			{
				this.Serializer.ReferenceResolver.AddReference(this, id, defaultCreator);
			}
			contract.InvokeOnDeserializing(defaultCreator, this.Serializer.Context);
			int depth = reader.Depth;
			bool flag = false;
			do
			{
				JsonToken tokenType = reader.TokenType;
				if (tokenType == JsonToken.PropertyName)
				{
					string str = reader.Value.ToString();
					try
					{
						if (!reader.Read())
						{
							throw JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, str));
						}
						JsonProperty closestMatchProperty = contract.Properties.GetClosestMatchProperty(str);
						if (closestMatchProperty == null || !closestMatchProperty.Writable || closestMatchProperty.Ignored)
						{
							Type type = (JsonReader.IsPrimitiveToken(reader.TokenType) ? reader.ValueType : typeof(IDynamicMetaObjectProvider));
							JsonContract contractSafe = this.GetContractSafe(type);
							JsonConverter converter = this.GetConverter(contractSafe, null, null, member);
							obj = (converter == null || !converter.CanRead ? this.CreateValueInternal(reader, type, contractSafe, null, null, member, null) : converter.ReadJson(reader, type, null, this.GetInternalSerializer()));
							defaultCreator.TrySetMember(str, obj);
						}
						else
						{
							if (closestMatchProperty.PropertyContract == null)
							{
								closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
							}
							JsonConverter jsonConverter = this.GetConverter(closestMatchProperty.PropertyContract, closestMatchProperty.MemberConverter, null, null);
							this.SetPropertyValue(closestMatchProperty, jsonConverter, null, member, reader, defaultCreator);
						}
					}
					catch (Exception exception)
					{
						if (!base.IsErrorHandled(defaultCreator, contract, str, reader.Path, exception))
						{
							throw;
						}
						else
						{
							this.HandleError(reader, true, depth);
						}
					}
				}
				else
				{
					if (tokenType != JsonToken.EndObject)
					{
						throw JsonSerializationException.Create(reader, string.Concat("Unexpected token when deserializing object: ", reader.TokenType));
					}
					flag = true;
				}
			}
			while (!flag && reader.Read());
			contract.InvokeOnDeserialized(defaultCreator, this.Serializer.Context);
			return defaultCreator;
		}

		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, string id)
		{
			Type underlyingType = contract.UnderlyingType;
			if (!JsonTypeReflector.FullyTrusted)
			{
				throw JsonSerializationException.Create(reader, "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data.\r\nTo fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true.\r\n".FormatWith(CultureInfo.InvariantCulture, underlyingType));
			}
			SerializationInfo serializationInfo = new SerializationInfo(contract.UnderlyingType, this.GetFormatterConverter());
			bool flag = false;
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
					case JsonToken.PropertyName:
					{
						string str = reader.Value.ToString();
						if (!reader.Read())
						{
							throw JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, str));
						}
						serializationInfo.AddValue(str, JToken.ReadFrom(reader));
						continue;
					}
					case JsonToken.Comment:
					{
						continue;
					}
					default:
					{
						if (tokenType == JsonToken.EndObject)
						{
							break;
						}
						else
						{
							throw JsonSerializationException.Create(reader, string.Concat("Unexpected token when deserializing object: ", reader.TokenType));
						}
					}
				}
				flag = true;
			}
			while (!flag && reader.Read());
			if (contract.ISerializableCreator == null)
			{
				throw JsonSerializationException.Create(reader, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".FormatWith(CultureInfo.InvariantCulture, underlyingType));
			}
			ObjectConstructor<object> serializableCreator = contract.ISerializableCreator;
			object[] context = new object[] { serializationInfo, this.Serializer.Context };
			object obj = serializableCreator(context);
			if (id != null)
			{
				this.Serializer.ReferenceResolver.AddReference(this, id, obj);
			}
			contract.InvokeOnDeserializing(obj, this.Serializer.Context);
			contract.InvokeOnDeserialized(obj, this.Serializer.Context);
			return obj;
		}

		private JToken CreateJObject(JsonReader reader)
		{
			JToken token;
			ValidationUtils.ArgumentNotNull(reader, "reader");
			using (JTokenWriter jTokenWriter = new JTokenWriter())
			{
				jTokenWriter.WriteStartObject();
				if (reader.TokenType != JsonToken.PropertyName)
				{
					jTokenWriter.WriteEndObject();
				}
				else
				{
					jTokenWriter.WriteToken(reader, reader.Depth - 1);
				}
				token = jTokenWriter.Token;
			}
			return token;
		}

		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			JToken token;
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (contract != null && contract.UnderlyingType == typeof(JRaw))
			{
				return JRaw.Create(reader);
			}
			using (JTokenWriter jTokenWriter = new JTokenWriter())
			{
				jTokenWriter.WriteToken(reader);
				token = jTokenWriter.Token;
			}
			return token;
		}

		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			object obj;
			bool flag;
			if (!this.HasDefinedType(objectType))
			{
				obj = this.CreateJToken(reader, contract);
			}
			else
			{
				JsonArrayContract jsonArrayContract = this.EnsureArrayContract(reader, objectType, contract);
				if (existingValue != null)
				{
					obj = this.PopulateList(jsonArrayContract.CreateWrapper(existingValue), reader, jsonArrayContract, member, id);
				}
				else
				{
					IList array = CollectionUtils.CreateList(contract.CreatedType, out flag);
					if (id != null && flag)
					{
						throw JsonSerializationException.Create(reader, "Cannot preserve reference to array or readonly list: {0}.".FormatWith(CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (contract.OnSerializing != null && flag)
					{
						throw JsonSerializationException.Create(reader, "Cannot call OnSerializing on an array or readonly list: {0}.".FormatWith(CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (contract.OnError != null && flag)
					{
						throw JsonSerializationException.Create(reader, "Cannot call OnError on an array or readonly list: {0}.".FormatWith(CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					this.PopulateList(jsonArrayContract.CreateWrapper(array), reader, jsonArrayContract, member, id);
					if (!flag)
					{
						if (array is IWrappedCollection)
						{
							return ((IWrappedCollection)array).UnderlyingCollection;
						}
					}
					else if (contract.CreatedType.IsArray)
					{
						array = CollectionUtils.ToArray(((List<object>)array).ToArray(), ReflectionUtils.GetCollectionItemType(contract.CreatedType));
					}
					else if (ReflectionUtils.InheritsGenericDefinition(contract.CreatedType, typeof(ReadOnlyCollection<>)))
					{
						Type createdType = contract.CreatedType;
						object[] objArray = new object[] { array };
						array = (IList)ReflectionUtils.CreateInstance(createdType, objArray);
					}
					obj = array;
				}
			}
			return obj;
		}

		public object CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract)
		{
			if (contract.DefaultCreator == null || contract.DefaultCreatorNonPublic && this.Serializer.ConstructorHandling != ConstructorHandling.AllowNonPublicDefaultConstructor)
			{
				throw JsonSerializationException.Create(reader, "Unable to find a default constructor to use for type {0}.".FormatWith(CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			return contract.DefaultCreator();
		}

		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultConstructor)
		{
			object defaultCreator = null;
			if (objectContract.UnderlyingType.IsInterface() || objectContract.UnderlyingType.IsAbstract())
			{
				throw JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantated.".FormatWith(CultureInfo.InvariantCulture, objectContract.UnderlyingType));
			}
			if (objectContract.OverrideConstructor != null)
			{
				if ((int)objectContract.OverrideConstructor.GetParameters().Length > 0)
				{
					createdFromNonDefaultConstructor = true;
					return this.CreateObjectFromNonDefaultConstructor(reader, objectContract, containerMember, objectContract.OverrideConstructor, id);
				}
				defaultCreator = objectContract.OverrideConstructor.Invoke(null);
			}
			else if (objectContract.DefaultCreator != null && (!objectContract.DefaultCreatorNonPublic || this.Serializer.ConstructorHandling == ConstructorHandling.AllowNonPublicDefaultConstructor || objectContract.ParametrizedConstructor == null))
			{
				defaultCreator = objectContract.DefaultCreator();
			}
			else if (objectContract.ParametrizedConstructor != null)
			{
				createdFromNonDefaultConstructor = true;
				return this.CreateObjectFromNonDefaultConstructor(reader, objectContract, containerMember, objectContract.ParametrizedConstructor, id);
			}
			if (defaultCreator == null)
			{
				throw JsonSerializationException.Create(reader, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".FormatWith(CultureInfo.InvariantCulture, objectContract.UnderlyingType));
			}
			createdFromNonDefaultConstructor = false;
			return defaultCreator;
		}

		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			string str;
			object obj;
			object obj1;
			object obj2;
			this.CheckedRead(reader);
			if (this.ReadSpecialProperties(reader, ref objectType, ref contract, member, containerContract, containerMember, existingValue, out obj, out str))
			{
				return obj;
			}
			if (!this.HasDefinedType(objectType))
			{
				return this.CreateJObject(reader);
			}
			if (contract == null)
			{
				throw JsonSerializationException.Create(reader, "Could not resolve type '{0}' to a JsonContract.".FormatWith(CultureInfo.InvariantCulture, objectType));
			}
			switch (contract.ContractType)
			{
				case JsonContractType.Object:
				{
					bool flag = false;
					JsonObjectContract jsonObjectContract = (JsonObjectContract)contract;
					obj1 = (existingValue == null ? this.CreateNewObject(reader, jsonObjectContract, member, containerMember, str, out flag) : existingValue);
					if (flag)
					{
						return obj1;
					}
					return this.PopulateObject(obj1, reader, jsonObjectContract, member, str);
				}
				case JsonContractType.Array:
				case JsonContractType.String:
				{
					throw JsonSerializationException.Create(reader, "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly.\r\nTo fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.\r\n".FormatWith(CultureInfo.InvariantCulture, objectType, this.GetExpectedDescription(contract)));
				}
				case JsonContractType.Primitive:
				{
					JsonPrimitiveContract jsonPrimitiveContract = (JsonPrimitiveContract)contract;
					if (reader.TokenType != JsonToken.PropertyName || !string.Equals(reader.Value.ToString(), "$value", StringComparison.Ordinal))
					{
						throw JsonSerializationException.Create(reader, "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly.\r\nTo fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.\r\n".FormatWith(CultureInfo.InvariantCulture, objectType, this.GetExpectedDescription(contract)));
					}
					this.CheckedRead(reader);
					object obj3 = this.CreateValueInternal(reader, objectType, jsonPrimitiveContract, member, null, null, existingValue);
					this.CheckedRead(reader);
					return obj3;
				}
				case JsonContractType.Dictionary:
				{
					JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)contract;
					obj2 = (existingValue == null ? this.CreateNewDictionary(reader, jsonDictionaryContract) : existingValue);
					return this.PopulateDictionary(jsonDictionaryContract.CreateWrapper(obj2), reader, jsonDictionaryContract, member, str);
				}
				case JsonContractType.Dynamic:
				{
					return this.CreateDynamic(reader, (JsonDynamicContract)contract, member, str);
				}
				case JsonContractType.Serializable:
				{
					return this.CreateISerializable(reader, (JsonISerializableContract)contract, str);
				}
				default:
				{
					throw JsonSerializationException.Create(reader, "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly.\r\nTo fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.\r\n".FormatWith(CultureInfo.InvariantCulture, objectType, this.GetExpectedDescription(contract)));
				}
			}
		}

		private object CreateObjectFromNonDefaultConstructor(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ConstructorInfo constructorInfo, string id)
		{
			ValidationUtils.ArgumentNotNull(constructorInfo, "constructorInfo");
			Type underlyingType = contract.UnderlyingType;
			IDictionary<JsonProperty, object> jsonProperties = this.ResolvePropertyAndConstructorValues(contract, containerProperty, reader, underlyingType);
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			Func<ParameterInfo, ParameterInfo> func = (ParameterInfo p) => p;
			IDictionary<ParameterInfo, object> dictionary = ((IEnumerable<ParameterInfo>)parameters).ToDictionary<ParameterInfo, ParameterInfo, object>(func, (ParameterInfo p) => null);
			IDictionary<JsonProperty, object> jsonProperties1 = new Dictionary<JsonProperty, object>();
			foreach (KeyValuePair<JsonProperty, object> keyValuePair in jsonProperties)
			{
				KeyValuePair<ParameterInfo, object> keyValuePair1 = dictionary.ForgivingCaseSensitiveFind<KeyValuePair<ParameterInfo, object>>((KeyValuePair<ParameterInfo, object> kv) => kv.Key.Name, keyValuePair.Key.UnderlyingName);
				ParameterInfo key = keyValuePair1.Key;
				if (key == null)
				{
					jsonProperties1.Add(keyValuePair);
				}
				else
				{
					dictionary[key] = keyValuePair.Value;
				}
			}
			object obj = constructorInfo.Invoke(dictionary.Values.ToArray<object>());
			if (id != null)
			{
				this.Serializer.ReferenceResolver.AddReference(this, id, obj);
			}
			contract.InvokeOnDeserializing(obj, this.Serializer.Context);
			foreach (KeyValuePair<JsonProperty, object> jsonProperty in jsonProperties1)
			{
				JsonProperty key1 = jsonProperty.Key;
				object value = jsonProperty.Value;
				if (!this.ShouldSetPropertyValue(jsonProperty.Key, jsonProperty.Value))
				{
					if (key1.Writable || value == null)
					{
						continue;
					}
					JsonContract jsonContract = this.Serializer.ContractResolver.ResolveContract(key1.PropertyType);
					if (jsonContract.ContractType != JsonContractType.Array)
					{
						if (jsonContract.ContractType != JsonContractType.Dictionary)
						{
							continue;
						}
						JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
						object value1 = key1.ValueProvider.GetValue(obj);
						if (value1 == null)
						{
							continue;
						}
						IWrappedDictionary wrappedDictionaries = jsonDictionaryContract.CreateWrapper(value1);
						foreach (DictionaryEntry dictionaryEntry in jsonDictionaryContract.CreateWrapper(value))
						{
							wrappedDictionaries.Add(dictionaryEntry.Key, dictionaryEntry.Value);
						}
					}
					else
					{
						JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
						object obj1 = key1.ValueProvider.GetValue(obj);
						if (obj1 == null)
						{
							continue;
						}
						IWrappedCollection wrappedCollections = jsonArrayContract.CreateWrapper(obj1);
						foreach (object obj2 in jsonArrayContract.CreateWrapper(value))
						{
							wrappedCollections.Add(obj2);
						}
					}
				}
				else
				{
					key1.ValueProvider.SetValue(obj, value);
				}
			}
			contract.InvokeOnDeserialized(obj, this.Serializer.Context);
			return obj;
		}

		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			if (contract != null && contract.ContractType == JsonContractType.Linq)
			{
				return this.CreateJToken(reader, contract);
			}
			do
			{
				switch (reader.TokenType)
				{
					case JsonToken.StartObject:
					{
						return this.CreateObject(reader, objectType, contract, member, containerContract, containerMember, existingValue);
					}
					case JsonToken.StartArray:
					{
						return this.CreateList(reader, objectType, contract, member, existingValue, null);
					}
					case JsonToken.StartConstructor:
					{
						string str = reader.Value.ToString();
						return this.EnsureType(reader, str, CultureInfo.InvariantCulture, contract, objectType);
					}
					case JsonToken.PropertyName:
					case JsonToken.EndObject:
					case JsonToken.EndArray:
					case JsonToken.EndConstructor:
					{
						throw JsonSerializationException.Create(reader, string.Concat("Unexpected token while deserializing object: ", reader.TokenType));
					}
					case JsonToken.Comment:
					{
						continue;
					}
					case JsonToken.Raw:
					{
						return new JRaw((string)reader.Value);
					}
					case JsonToken.Integer:
					case JsonToken.Float:
					case JsonToken.Boolean:
					case JsonToken.Date:
					case JsonToken.Bytes:
					{
						return this.EnsureType(reader, reader.Value, CultureInfo.InvariantCulture, contract, objectType);
					}
					case JsonToken.String:
					{
						if (string.IsNullOrEmpty((string)reader.Value) && objectType != typeof(string) && objectType != typeof(object) && contract != null && contract.IsNullable)
						{
							return null;
						}
						if (objectType == typeof(byte[]))
						{
							return Convert.FromBase64String((string)reader.Value);
						}
						return this.EnsureType(reader, reader.Value, CultureInfo.InvariantCulture, contract, objectType);
					}
					case JsonToken.Null:
					case JsonToken.Undefined:
					{
						if (objectType == typeof(DBNull))
						{
							return DBNull.Value;
						}
						return this.EnsureType(reader, reader.Value, CultureInfo.InvariantCulture, contract, objectType);
					}
					default:
					{
						throw JsonSerializationException.Create(reader, string.Concat("Unexpected token while deserializing object: ", reader.TokenType));
					}
				}
			}
			while (reader.Read());
			throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
		}

		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			object obj;
			object obj1;
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			JsonContract contractSafe = this.GetContractSafe(objectType);
			try
			{
				JsonConverter converter = this.GetConverter(contractSafe, null, null, null);
				if (reader.TokenType != JsonToken.None || this.ReadForType(reader, contractSafe, converter != null))
				{
					obj = (converter == null || !converter.CanRead ? this.CreateValueInternal(reader, objectType, contractSafe, null, null, null, null) : converter.ReadJson(reader, objectType, null, this.GetInternalSerializer()));
					if (checkAdditionalContent && reader.Read() && reader.TokenType != JsonToken.Comment)
					{
						throw new JsonSerializationException("Additional text found in JSON string after finishing deserializing object.");
					}
					obj1 = obj;
				}
				else
				{
					if (contractSafe != null && !contractSafe.IsNullable)
					{
						throw JsonSerializationException.Create(reader, "No JSON content found and type '{0}' is not nullable.".FormatWith(CultureInfo.InvariantCulture, contractSafe.UnderlyingType));
					}
					obj1 = null;
				}
			}
			catch (Exception exception)
			{
				if (!base.IsErrorHandled(null, contractSafe, null, reader.Path, exception))
				{
					throw;
				}
				else
				{
					this.HandleError(reader, false, 0);
					obj1 = null;
				}
			}
			return obj1;
		}

		private void EndObject(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> propertiesPresence)
		{
			Required valueOrDefault;
			if (propertiesPresence != null)
			{
				foreach (KeyValuePair<JsonProperty, JsonSerializerInternalReader.PropertyPresence> keyValuePair in propertiesPresence)
				{
					JsonProperty key = keyValuePair.Key;
					JsonSerializerInternalReader.PropertyPresence value = keyValuePair.Value;
					if (value != JsonSerializerInternalReader.PropertyPresence.None && value != JsonSerializerInternalReader.PropertyPresence.Null)
					{
						continue;
					}
					try
					{
						Required? nullable = key._required;
						if (nullable.HasValue)
						{
							valueOrDefault = nullable.GetValueOrDefault();
						}
						else
						{
							Required? itemRequired = contract.ItemRequired;
							valueOrDefault = (itemRequired.HasValue ? itemRequired.GetValueOrDefault() : Required.Default);
						}
						Required required = valueOrDefault;
						switch (value)
						{
							case JsonSerializerInternalReader.PropertyPresence.None:
							{
								if (required == Required.AllowNull || required == Required.Always)
								{
									throw JsonSerializationException.Create(reader, "Required property '{0}' not found in JSON.".FormatWith(CultureInfo.InvariantCulture, key.PropertyName));
								}
								if (key.PropertyContract == null)
								{
									key.PropertyContract = this.GetContractSafe(key.PropertyType);
								}
								if (!this.HasFlag(key.DefaultValueHandling.GetValueOrDefault(this.Serializer.DefaultValueHandling), DefaultValueHandling.Populate) || !key.Writable)
								{
									break;
								}
								key.ValueProvider.SetValue(newObject, this.EnsureType(reader, key.DefaultValue, CultureInfo.InvariantCulture, key.PropertyContract, key.PropertyType));
								break;
							}
							case JsonSerializerInternalReader.PropertyPresence.Null:
							{
								if (required != Required.Always)
								{
									break;
								}
								throw JsonSerializationException.Create(reader, "Required property '{0}' expects a value but got null.".FormatWith(CultureInfo.InvariantCulture, key.PropertyName));
							}
						}
					}
					catch (Exception exception)
					{
						if (!base.IsErrorHandled(newObject, contract, key.PropertyName, reader.Path, exception))
						{
							throw;
						}
						else
						{
							this.HandleError(reader, true, initialDepth);
						}
					}
				}
			}
		}

		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			if (contract == null)
			{
				throw JsonSerializationException.Create(reader, "Could not resolve type '{0}' to a JsonContract.".FormatWith(CultureInfo.InvariantCulture, objectType));
			}
			JsonArrayContract jsonArrayContract = contract as JsonArrayContract;
			if (jsonArrayContract == null)
			{
				throw JsonSerializationException.Create(reader, "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly.\r\nTo fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array.\r\n".FormatWith(CultureInfo.InvariantCulture, objectType, this.GetExpectedDescription(contract)));
			}
			return jsonArrayContract;
		}

		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			object obj;
			if (targetType == null)
			{
				return value;
			}
			if (ReflectionUtils.GetObjectType(value) == targetType)
			{
				return value;
			}
			try
			{
				if (value == null && contract.IsNullable)
				{
					obj = null;
				}
				else if (!contract.IsConvertable)
				{
					obj = ConvertUtils.ConvertOrCast(value, culture, contract.NonNullableUnderlyingType);
				}
				else
				{
					if (contract.NonNullableUnderlyingType.IsEnum())
					{
						if (value is string)
						{
							obj = Enum.Parse(contract.NonNullableUnderlyingType, value.ToString(), true);
							return obj;
						}
						else if (ConvertUtils.IsInteger(value))
						{
							obj = Enum.ToObject(contract.NonNullableUnderlyingType, value);
							return obj;
						}
					}
					obj = Convert.ChangeType(value, contract.NonNullableUnderlyingType, culture);
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				throw JsonSerializationException.Create(reader, "Error converting value {0} to type '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.FormatValueForPrint(value), targetType), exception);
			}
			return obj;
		}

		private string FormatValueForPrint(object value)
		{
			if (value == null)
			{
				return "{null}";
			}
			if (!(value is string))
			{
				return value.ToString();
			}
			return string.Concat("\"", value, "\"");
		}

		private JsonContract GetContractSafe(Type type)
		{
			if (type == null)
			{
				return null;
			}
			return this.Serializer.ContractResolver.ResolveContract(type);
		}

		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			JsonConverter itemConverter = null;
			if (memberConverter != null)
			{
				itemConverter = memberConverter;
			}
			else if (containerProperty != null && containerProperty.ItemConverter != null)
			{
				itemConverter = containerProperty.ItemConverter;
			}
			else if (containerContract != null && containerContract.ItemConverter != null)
			{
				itemConverter = containerContract.ItemConverter;
			}
			else if (contract != null)
			{
				if (contract.Converter == null)
				{
					JsonConverter matchingConverter = this.Serializer.GetMatchingConverter(contract.UnderlyingType);
					JsonConverter jsonConverter = matchingConverter;
					if (matchingConverter != null)
					{
						itemConverter = jsonConverter;
					}
					else if (contract.InternalConverter != null)
					{
						itemConverter = contract.InternalConverter;
					}
				}
				else
				{
					itemConverter = contract.Converter;
				}
			}
			return itemConverter;
		}

		internal string GetExpectedDescription(JsonContract contract)
		{
			switch (contract.ContractType)
			{
				case JsonContractType.Object:
				case JsonContractType.Dictionary:
				case JsonContractType.Dynamic:
				case JsonContractType.Serializable:
				{
					return "JSON object (e.g. {\"name\":\"value\"})";
				}
				case JsonContractType.Array:
				{
					return "JSON array (e.g. [1,2,3])";
				}
				case JsonContractType.Primitive:
				{
					return "JSON primitive value (e.g. string, number, boolean, null)";
				}
				case JsonContractType.String:
				{
					return "JSON string value";
				}
			}
			throw new ArgumentOutOfRangeException();
		}

		private JsonFormatterConverter GetFormatterConverter()
		{
			if (this._formatterConverter == null)
			{
				this._formatterConverter = new JsonFormatterConverter(this.GetInternalSerializer());
			}
			return this._formatterConverter;
		}

		private JsonSerializerProxy GetInternalSerializer()
		{
			if (this._internalSerializer == null)
			{
				this._internalSerializer = new JsonSerializerProxy(this);
			}
			return this._internalSerializer;
		}

		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
			base.ClearErrorContext();
			if (readPastError)
			{
				reader.Skip();
				while (reader.Depth > initialDepth + 1)
				{
					reader.Read();
				}
			}
		}

		private bool HasDefinedType(Type type)
		{
			if (!(type != null) || !(type != typeof(object)) || typeof(JToken).IsSubclassOf(type))
			{
				return false;
			}
			return type != typeof(IDynamicMetaObjectProvider);
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		public void Populate(JsonReader reader, object target)
		{
			string str;
			ValidationUtils.ArgumentNotNull(target, "target");
			Type type = target.GetType();
			JsonContract jsonContract = this.Serializer.ContractResolver.ResolveContract(type);
			if (reader.TokenType == JsonToken.None)
			{
				reader.Read();
			}
			if (reader.TokenType == JsonToken.StartArray)
			{
				if (jsonContract.ContractType != JsonContractType.Array)
				{
					throw JsonSerializationException.Create(reader, "Cannot populate JSON array onto type '{0}'.".FormatWith(CultureInfo.InvariantCulture, type));
				}
				this.PopulateList(CollectionUtils.CreateCollectionWrapper(target), reader, (JsonArrayContract)jsonContract, null, null);
				return;
			}
			if (reader.TokenType != JsonToken.StartObject)
			{
				throw JsonSerializationException.Create(reader, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			this.CheckedRead(reader);
			string str1 = null;
			if (reader.TokenType == JsonToken.PropertyName && string.Equals(reader.Value.ToString(), "$id", StringComparison.Ordinal))
			{
				this.CheckedRead(reader);
				if (reader.Value != null)
				{
					str = reader.Value.ToString();
				}
				else
				{
					str = null;
				}
				str1 = str;
				this.CheckedRead(reader);
			}
			if (jsonContract.ContractType == JsonContractType.Dictionary)
			{
				this.PopulateDictionary(CollectionUtils.CreateDictionaryWrapper(target), reader, (JsonDictionaryContract)jsonContract, null, str1);
				return;
			}
			if (jsonContract.ContractType != JsonContractType.Object)
			{
				throw JsonSerializationException.Create(reader, "Cannot populate JSON object onto type '{0}'.".FormatWith(CultureInfo.InvariantCulture, type));
			}
			this.PopulateObject(target, reader, (JsonObjectContract)jsonContract, null, str1);
		}

		private object PopulateDictionary(IWrappedDictionary wrappedDictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			object obj;
			object underlyingDictionary = wrappedDictionary.UnderlyingDictionary;
			if (id != null)
			{
				this.Serializer.ReferenceResolver.AddReference(this, id, underlyingDictionary);
			}
			contract.InvokeOnDeserializing(underlyingDictionary, this.Serializer.Context);
			int depth = reader.Depth;
			if (contract.KeyContract == null)
			{
				contract.KeyContract = this.GetContractSafe(contract.DictionaryKeyType);
			}
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.GetContractSafe(contract.DictionaryValueType);
			}
			JsonConverter itemConverter = contract.ItemConverter ?? this.GetConverter(contract.ItemContract, null, contract, containerProperty);
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
					case JsonToken.PropertyName:
					{
						object value = reader.Value;
						try
						{
							try
							{
								value = this.EnsureType(reader, value, CultureInfo.InvariantCulture, contract.KeyContract, contract.DictionaryKeyType);
							}
							catch (Exception exception1)
							{
								Exception exception = exception1;
								throw JsonSerializationException.Create(reader, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".FormatWith(CultureInfo.InvariantCulture, reader.Value, contract.DictionaryKeyType), exception);
							}
							if (!this.ReadForType(reader, contract.ItemContract, itemConverter != null))
							{
								throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
							}
							obj = (itemConverter == null || !itemConverter.CanRead ? this.CreateValueInternal(reader, contract.DictionaryValueType, contract.ItemContract, null, contract, containerProperty, null) : itemConverter.ReadJson(reader, contract.DictionaryValueType, null, this.GetInternalSerializer()));
							wrappedDictionary[value] = obj;
							continue;
						}
						catch (Exception exception2)
						{
							if (!base.IsErrorHandled(underlyingDictionary, contract, value, reader.Path, exception2))
							{
								throw;
							}
							else
							{
								this.HandleError(reader, true, depth);
								continue;
							}
						}
						break;
					}
					case JsonToken.Comment:
					{
						continue;
					}
					default:
					{
						if (tokenType == JsonToken.EndObject)
						{
							break;
						}
						else
						{
							throw JsonSerializationException.Create(reader, string.Concat("Unexpected token when deserializing object: ", reader.TokenType));
						}
					}
				}
				contract.InvokeOnDeserialized(underlyingDictionary, this.Serializer.Context);
				return underlyingDictionary;
			}
			while (reader.Read());
			throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
		}

		private object PopulateList(IWrappedCollection wrappedList, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			object obj;
			object obj1;
			object underlyingCollection = wrappedList.UnderlyingCollection;
			if (id != null)
			{
				this.Serializer.ReferenceResolver.AddReference(this, id, underlyingCollection);
			}
			if (wrappedList.IsFixedSize)
			{
				reader.Skip();
				return underlyingCollection;
			}
			contract.InvokeOnDeserializing(underlyingCollection, this.Serializer.Context);
			int depth = reader.Depth;
			JsonContract contractSafe = this.GetContractSafe(contract.CollectionItemType);
			JsonConverter converter = this.GetConverter(contractSafe, null, contract, containerProperty);
			int? position = null;
			while (true)
			{
				try
				{
				Label1:
					while (this.ReadForType(reader, contractSafe, converter != null))
					{
						JsonToken tokenType = reader.TokenType;
						if (tokenType != JsonToken.Comment)
						{
							if (tokenType != JsonToken.EndArray)
							{
								obj = (converter == null || !converter.CanRead ? this.CreateValueInternal(reader, contract.CollectionItemType, contractSafe, null, contract, containerProperty, null) : converter.ReadJson(reader, contract.CollectionItemType, null, this.GetInternalSerializer()));
								wrappedList.Add(obj);
							}
							else
							{
								contract.InvokeOnDeserialized(underlyingCollection, this.Serializer.Context);
								obj1 = underlyingCollection;
								return obj1;
							}
						}
						goto Label1;
					}
					throw JsonSerializationException.Create(reader, "Unexpected end when deserializing array.");
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					JsonPosition jsonPosition = reader.GetPosition(depth);
					if (!base.IsErrorHandled(underlyingCollection, contract, jsonPosition.Position, reader.Path, exception))
					{
						throw;
					}
					else
					{
						this.HandleError(reader, true, depth);
						if (position.HasValue)
						{
							int? nullable = position;
							int? position1 = jsonPosition.Position;
							if ((nullable.GetValueOrDefault() != position1.GetValueOrDefault() ? false : nullable.HasValue == position1.HasValue))
							{
								throw JsonSerializationException.Create(reader, "Infinite loop detected from error handling.", exception);
							}
						}
						position = jsonPosition.Position;
					}
				}
			}
			return obj1;
		}

		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> dictionary;
			contract.InvokeOnDeserializing(newObject, this.Serializer.Context);
			if (contract.HasRequiredOrDefaultValueProperties || this.HasFlag(this.Serializer.DefaultValueHandling, DefaultValueHandling.Populate))
			{
				dictionary = contract.Properties.ToDictionary<JsonProperty, JsonProperty, JsonSerializerInternalReader.PropertyPresence>((JsonProperty m) => m, (JsonProperty m) => JsonSerializerInternalReader.PropertyPresence.None);
			}
			else
			{
				dictionary = null;
			}
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> jsonProperties = dictionary;
			if (id != null)
			{
				this.Serializer.ReferenceResolver.AddReference(this, id, newObject);
			}
			int depth = reader.Depth;
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
					case JsonToken.PropertyName:
					{
						string str = reader.Value.ToString();
						try
						{
							JsonProperty closestMatchProperty = contract.Properties.GetClosestMatchProperty(str);
							if (closestMatchProperty != null)
							{
								if (closestMatchProperty.PropertyContract == null)
								{
									closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
								}
								JsonConverter converter = this.GetConverter(closestMatchProperty.PropertyContract, closestMatchProperty.MemberConverter, contract, member);
								if (!this.ReadForType(reader, closestMatchProperty.PropertyContract, converter != null))
								{
									throw JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, str));
								}
								this.SetPropertyPresence(reader, closestMatchProperty, jsonProperties);
								this.SetPropertyValue(closestMatchProperty, converter, contract, member, reader, newObject);
								continue;
							}
							else
							{
								if (this.Serializer.MissingMemberHandling == MissingMemberHandling.Error)
								{
									throw JsonSerializationException.Create(reader, "Could not find member '{0}' on object of type '{1}'".FormatWith(CultureInfo.InvariantCulture, str, contract.UnderlyingType.Name));
								}
								reader.Skip();
								continue;
							}
						}
						catch (Exception exception)
						{
							if (!base.IsErrorHandled(newObject, contract, str, reader.Path, exception))
							{
								throw;
							}
							else
							{
								this.HandleError(reader, true, depth);
								continue;
							}
						}
						break;
					}
					case JsonToken.Comment:
					{
						continue;
					}
					default:
					{
						if (tokenType == JsonToken.EndObject)
						{
							break;
						}
						else
						{
							throw JsonSerializationException.Create(reader, string.Concat("Unexpected token when deserializing object: ", reader.TokenType));
						}
					}
				}
				this.EndObject(newObject, reader, contract, depth, jsonProperties);
				contract.InvokeOnDeserialized(newObject, this.Serializer.Context);
				return newObject;
			}
			while (reader.Read());
			throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
		}

		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter)
		{
			if (hasConverter)
			{
				return reader.Read();
			}
			switch ((contract != null ? contract.InternalReadType : ReadType.Read))
			{
				case ReadType.Read:
				{
					do
					{
						if (reader.Read())
						{
							continue;
						}
						return false;
					}
					while (reader.TokenType == JsonToken.Comment);
					return true;
				}
				case ReadType.ReadAsInt32:
				{
					reader.ReadAsInt32();
					break;
				}
				case ReadType.ReadAsBytes:
				{
					reader.ReadAsBytes();
					break;
				}
				case ReadType.ReadAsString:
				{
					reader.ReadAsString();
					break;
				}
				case ReadType.ReadAsDecimal:
				{
					reader.ReadAsDecimal();
					break;
				}
				case ReadType.ReadAsDateTime:
				{
					reader.ReadAsDateTime();
					break;
				}
				case ReadType.ReadAsDateTimeOffset:
				{
					reader.ReadAsDateTimeOffset();
					break;
				}
				default:
				{
					throw new ArgumentOutOfRangeException();
				}
			}
			return reader.TokenType != JsonToken.None;
		}

		private bool ReadSpecialProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			bool flag;
			string str;
			string str1;
			Type type;
			string str2;
			TypeNameHandling? typeNameHandling;
			TypeNameHandling valueOrDefault;
			TypeNameHandling? itemTypeNameHandling;
			TypeNameHandling? nullable;
			string str3;
			id = null;
			newValue = null;
			if (reader.TokenType == JsonToken.PropertyName)
			{
				string str4 = reader.Value.ToString();
				if (str4.Length > 0 && str4[0] == '$')
				{
					do
					{
						str4 = reader.Value.ToString();
						if (string.Equals(str4, "$ref", StringComparison.Ordinal))
						{
							this.CheckedRead(reader);
							if (reader.TokenType != JsonToken.String && reader.TokenType != JsonToken.Null)
							{
								throw JsonSerializationException.Create(reader, "JSON reference {0} property must have a string or null value.".FormatWith(CultureInfo.InvariantCulture, "$ref"));
							}
							if (reader.Value != null)
							{
								str3 = reader.Value.ToString();
							}
							else
							{
								str3 = null;
							}
							string str5 = str3;
							this.CheckedRead(reader);
							if (str5 != null)
							{
								if (reader.TokenType == JsonToken.PropertyName)
								{
									throw JsonSerializationException.Create(reader, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".FormatWith(CultureInfo.InvariantCulture, "$ref"));
								}
								newValue = this.Serializer.ReferenceResolver.ResolveReference(this, str5);
								return true;
							}
							flag = true;
						}
						else if (string.Equals(str4, "$type", StringComparison.Ordinal))
						{
							this.CheckedRead(reader);
							string str6 = reader.Value.ToString();
							if (member != null)
							{
								typeNameHandling = member.TypeNameHandling;
							}
							else
							{
								typeNameHandling = null;
							}
							TypeNameHandling? nullable1 = typeNameHandling;
							if (nullable1.HasValue)
							{
								valueOrDefault = nullable1.GetValueOrDefault();
							}
							else
							{
								if (containerContract != null)
								{
									itemTypeNameHandling = containerContract.ItemTypeNameHandling;
								}
								else
								{
									itemTypeNameHandling = null;
								}
								TypeNameHandling? nullable2 = itemTypeNameHandling;
								if (nullable2.HasValue)
								{
									valueOrDefault = nullable2.GetValueOrDefault();
								}
								else
								{
									if (containerMember != null)
									{
										nullable = containerMember.ItemTypeNameHandling;
									}
									else
									{
										nullable = null;
									}
									TypeNameHandling? nullable3 = nullable;
									valueOrDefault = (nullable3.HasValue ? nullable3.GetValueOrDefault() : this.Serializer.TypeNameHandling);
								}
							}
							if (valueOrDefault != TypeNameHandling.None)
							{
								ReflectionUtils.SplitFullyQualifiedTypeName(str6, out str, out str1);
								try
								{
									type = this.Serializer.Binder.BindToType(str1, str);
								}
								catch (Exception exception1)
								{
									Exception exception = exception1;
									throw JsonSerializationException.Create(reader, "Error resolving type specified in JSON '{0}'.".FormatWith(CultureInfo.InvariantCulture, str6), exception);
								}
								if (type == null)
								{
									throw JsonSerializationException.Create(reader, "Type specified in JSON '{0}' was not resolved.".FormatWith(CultureInfo.InvariantCulture, str6));
								}
								if (objectType != null && objectType != typeof(IDynamicMetaObjectProvider) && !objectType.IsAssignableFrom(type))
								{
									throw JsonSerializationException.Create(reader, "Type specified in JSON '{0}' is not compatible with '{1}'.".FormatWith(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, objectType.AssemblyQualifiedName));
								}
								objectType = type;
								contract = this.GetContractSafe(type);
							}
							this.CheckedRead(reader);
							flag = true;
						}
						else if (!string.Equals(str4, "$id", StringComparison.Ordinal))
						{
							if (string.Equals(str4, "$values", StringComparison.Ordinal))
							{
								this.CheckedRead(reader);
								object obj = this.CreateList(reader, objectType, contract, member, existingValue, id);
								this.CheckedRead(reader);
								newValue = obj;
								return true;
							}
							flag = false;
						}
						else
						{
							this.CheckedRead(reader);
							if (reader.Value != null)
							{
								str2 = reader.Value.ToString();
							}
							else
							{
								str2 = null;
							}
							id = str2;
							this.CheckedRead(reader);
							flag = true;
						}
					}
					while (flag && reader.TokenType == JsonToken.PropertyName);
				}
			}
			return false;
		}

		private IDictionary<JsonProperty, object> ResolvePropertyAndConstructorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			object obj;
			IDictionary<JsonProperty, object> jsonProperties = new Dictionary<JsonProperty, object>();
			bool flag = false;
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
					case JsonToken.PropertyName:
					{
						string str = reader.Value.ToString();
						JsonProperty closestMatchProperty = contract.ConstructorParameters.GetClosestMatchProperty(str) ?? contract.Properties.GetClosestMatchProperty(str);
						if (closestMatchProperty == null)
						{
							if (!reader.Read())
							{
								throw JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, str));
							}
							if (this.Serializer.MissingMemberHandling == MissingMemberHandling.Error)
							{
								throw JsonSerializationException.Create(reader, "Could not find member '{0}' on object of type '{1}'".FormatWith(CultureInfo.InvariantCulture, str, objectType.Name));
							}
							reader.Skip();
							continue;
						}
						else
						{
							if (closestMatchProperty.PropertyContract == null)
							{
								closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
							}
							JsonConverter converter = this.GetConverter(closestMatchProperty.PropertyContract, closestMatchProperty.MemberConverter, contract, containerProperty);
							if (!this.ReadForType(reader, closestMatchProperty.PropertyContract, converter != null))
							{
								throw JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(CultureInfo.InvariantCulture, str));
							}
							if (closestMatchProperty.Ignored)
							{
								reader.Skip();
								continue;
							}
							else
							{
								if (closestMatchProperty.PropertyContract == null)
								{
									closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
								}
								obj = (converter == null || !converter.CanRead ? this.CreateValueInternal(reader, closestMatchProperty.PropertyType, closestMatchProperty.PropertyContract, closestMatchProperty, contract, containerProperty, null) : converter.ReadJson(reader, closestMatchProperty.PropertyType, null, this.GetInternalSerializer()));
								jsonProperties[closestMatchProperty] = obj;
								continue;
							}
						}
					}
					case JsonToken.Comment:
					{
						continue;
					}
					default:
					{
						if (tokenType == JsonToken.EndObject)
						{
							break;
						}
						else
						{
							throw JsonSerializationException.Create(reader, string.Concat("Unexpected token when deserializing object: ", reader.TokenType));
						}
					}
				}
				flag = true;
			}
			while (!flag && reader.Read());
			return jsonProperties;
		}

		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			if (property != null && requiredProperties != null)
			{
				requiredProperties[property] = (reader.TokenType == JsonToken.Null || reader.TokenType == JsonToken.Undefined ? JsonSerializerInternalReader.PropertyPresence.Null : JsonSerializerInternalReader.PropertyPresence.Value);
			}
		}

		private void SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			object value;
			bool flag;
			JsonContract jsonContract;
			bool flag1;
			object obj;
			if (this.CalculatePropertyDetails(property, ref propertyConverter, containerContract, containerProperty, reader, target, out flag, out value, out jsonContract, out flag1))
			{
				return;
			}
			if (propertyConverter == null || !propertyConverter.CanRead)
			{
				obj = this.CreateValueInternal(reader, property.PropertyType, jsonContract, property, containerContract, containerProperty, (flag ? value : null));
			}
			else
			{
				if (!flag1 && target != null && property.Readable)
				{
					value = property.ValueProvider.GetValue(target);
				}
				obj = propertyConverter.ReadJson(reader, property.PropertyType, value, this.GetInternalSerializer());
			}
			if ((!flag || obj != value) && this.ShouldSetPropertyValue(property, obj))
			{
				property.ValueProvider.SetValue(target, obj);
				if (property.SetIsSpecified != null)
				{
					property.SetIsSpecified(target, true);
				}
			}
		}

		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			if (property.NullValueHandling.GetValueOrDefault(this.Serializer.NullValueHandling) == NullValueHandling.Ignore && value == null)
			{
				return false;
			}
			if (this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer.DefaultValueHandling), DefaultValueHandling.Ignore) && MiscellaneousUtils.ValueEquals(value, property.DefaultValue))
			{
				return false;
			}
			if (!property.Writable)
			{
				return false;
			}
			return true;
		}

		internal enum PropertyPresence
		{
			None,
			Null,
			Value
		}
	}
}