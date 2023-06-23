using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		private readonly List<object> _serializeStack = new List<object>();

		private JsonSerializerProxy _internalSerializer;

		public JsonSerializerInternalWriter(JsonSerializer serializer) : base(serializer)
		{
		}

		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			if (value == null || contract.ContractType == JsonContractType.Primitive || contract.ContractType == JsonContractType.String)
			{
				return true;
			}
			ReferenceLoopHandling? referenceLoopHandling = null;
			if (property != null)
			{
				referenceLoopHandling = property.ReferenceLoopHandling;
			}
			if (!referenceLoopHandling.HasValue && containerProperty != null)
			{
				referenceLoopHandling = containerProperty.ItemReferenceLoopHandling;
			}
			if (!referenceLoopHandling.HasValue && containerContract != null)
			{
				referenceLoopHandling = containerContract.ItemReferenceLoopHandling;
			}
			if (this._serializeStack.IndexOf(value) == -1)
			{
				return true;
			}
			switch (referenceLoopHandling.GetValueOrDefault(this.Serializer.ReferenceLoopHandling))
			{
				case ReferenceLoopHandling.Error:
				{
					string str = "Self referencing loop detected";
					if (property != null)
					{
						str = string.Concat(str, " for property '{0}'".FormatWith(CultureInfo.InvariantCulture, property.PropertyName));
					}
					str = string.Concat(str, " with type '{0}'.".FormatWith(CultureInfo.InvariantCulture, value.GetType()));
					throw JsonSerializationException.Create(null, writer.ContainerPath, str, null);
				}
				case ReferenceLoopHandling.Ignore:
				{
					return false;
				}
				case ReferenceLoopHandling.Serialize:
				{
					return true;
				}
			}
			throw new InvalidOperationException("Unexpected ReferenceLoopHandling value: '{0}'".FormatWith(CultureInfo.InvariantCulture, this.Serializer.ReferenceLoopHandling));
		}

		private JsonContract GetContractSafe(object value)
		{
			if (value == null)
			{
				return null;
			}
			return this.Serializer.ContractResolver.ResolveContract(value.GetType());
		}

		private JsonSerializerProxy GetInternalSerializer()
		{
			if (this._internalSerializer == null)
			{
				this._internalSerializer = new JsonSerializerProxy(this);
			}
			return this._internalSerializer;
		}

		private string GetPropertyName(DictionaryEntry entry)
		{
			string str;
			if (ConvertUtils.IsConvertible(entry.Key))
			{
				return Convert.ToString(entry.Key, CultureInfo.InvariantCulture);
			}
			if (JsonSerializerInternalWriter.TryConvertToString(entry.Key, entry.Key.GetType(), out str))
			{
				return str;
			}
			return entry.Key.ToString();
		}

		private void HandleError(JsonWriter writer, int initialDepth)
		{
			base.ClearErrorContext();
			while (writer.Top > initialDepth)
			{
				writer.WriteEnd();
			}
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return (value & flag) == flag;
		}

		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return (value & flag) == flag;
		}

		private bool IsSpecified(JsonProperty property, object target)
		{
			if (property.GetIsSpecified == null)
			{
				return true;
			}
			return property.GetIsSpecified(target);
		}

		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			bool? isReference = null;
			if (property != null)
			{
				isReference = property.IsReference;
			}
			if (!isReference.HasValue && containerProperty != null)
			{
				isReference = containerProperty.ItemIsReference;
			}
			if (!isReference.HasValue && collectionContract != null)
			{
				isReference = collectionContract.ItemIsReference;
			}
			if (!isReference.HasValue)
			{
				isReference = contract.IsReference;
			}
			return isReference;
		}

		public void Serialize(JsonWriter jsonWriter, object value)
		{
			if (jsonWriter == null)
			{
				throw new ArgumentNullException("jsonWriter");
			}
			this.SerializeValue(jsonWriter, value, this.GetContractSafe(value), null, null, null);
		}

		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (this.ShouldWriteReference(value, null, contract, collectionContract, containerProperty))
			{
				this.WriteReference(writer, value);
				return;
			}
			if (!this.CheckForCircularReference(writer, value, null, contract, collectionContract, containerProperty))
			{
				return;
			}
			this._serializeStack.Add(value);
			converter.WriteJson(writer, value, this.GetInternalSerializer());
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
		}

		private void SerializeDictionary(JsonWriter writer, IWrappedDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			contract.InvokeOnSerializing(values.UnderlyingDictionary, this.Serializer.Context);
			this._serializeStack.Add(values.UnderlyingDictionary);
			this.WriteObjectStart(writer, values.UnderlyingDictionary, contract, member, collectionContract, containerProperty);
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.Serializer.ContractResolver.ResolveContract(contract.DictionaryValueType ?? typeof(object));
			}
			int top = writer.Top;
			foreach (DictionaryEntry value in values)
			{
				string propertyName = this.GetPropertyName(value);
				propertyName = (contract.PropertyNameResolver != null ? contract.PropertyNameResolver(propertyName) : propertyName);
				try
				{
					object obj = value.Value;
					JsonContract finalItemContract = contract.FinalItemContract ?? this.GetContractSafe(obj);
					if (this.ShouldWriteReference(obj, null, finalItemContract, contract, member))
					{
						writer.WritePropertyName(propertyName);
						this.WriteReference(writer, obj);
					}
					else if (this.CheckForCircularReference(writer, obj, null, finalItemContract, contract, member))
					{
						writer.WritePropertyName(propertyName);
						this.SerializeValue(writer, obj, finalItemContract, null, contract, member);
					}
					else
					{
						continue;
					}
				}
				catch (Exception exception)
				{
					if (!base.IsErrorHandled(values.UnderlyingDictionary, contract, propertyName, writer.ContainerPath, exception))
					{
						throw;
					}
					else
					{
						this.HandleError(writer, top);
					}
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			contract.InvokeOnSerialized(values.UnderlyingDictionary, this.Serializer.Context);
		}

		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			object obj;
			contract.InvokeOnSerializing(value, this.Serializer.Context);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			foreach (string dynamicMemberName in value.GetDynamicMemberNames())
			{
				if (!value.TryGetMember(dynamicMemberName, out obj))
				{
					continue;
				}
				writer.WritePropertyName((contract.PropertyNameResolver != null ? contract.PropertyNameResolver(dynamicMemberName) : dynamicMemberName));
				this.SerializeValue(writer, obj, this.GetContractSafe(obj), null, null, member);
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			contract.InvokeOnSerialized(value, this.Serializer.Context);
		}

		[SecuritySafeCritical]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (!JsonTypeReflector.FullyTrusted)
			{
				throw JsonSerializationException.Create(null, writer.ContainerPath, "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data.\r\nTo fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true.".FormatWith(CultureInfo.InvariantCulture, value.GetType()), null);
			}
			contract.InvokeOnSerializing(value, this.Serializer.Context);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			SerializationInfo serializationInfo = new SerializationInfo(contract.UnderlyingType, new FormatterConverter());
			value.GetObjectData(serializationInfo, this.Serializer.Context);
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				SerializationEntry current = enumerator.Current;
				writer.WritePropertyName(current.Name);
				this.SerializeValue(writer, current.Value, this.GetContractSafe(current.Value), null, null, member);
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			contract.InvokeOnSerialized(value, this.Serializer.Context);
		}

		private void SerializeList(JsonWriter writer, IWrappedCollection values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			contract.InvokeOnSerializing(values.UnderlyingCollection, this.Serializer.Context);
			this._serializeStack.Add(values.UnderlyingCollection);
			bool flag = this.WriteStartArray(writer, values, contract, member, collectionContract, containerProperty);
			writer.WriteStartArray();
			int top = writer.Top;
			int num = 0;
			foreach (object value in values)
			{
				try
				{
					try
					{
						JsonContract finalItemContract = contract.FinalItemContract ?? this.GetContractSafe(value);
						if (this.ShouldWriteReference(value, null, finalItemContract, contract, member))
						{
							this.WriteReference(writer, value);
						}
						else if (this.CheckForCircularReference(writer, value, null, finalItemContract, contract, member))
						{
							this.SerializeValue(writer, value, finalItemContract, null, contract, member);
						}
					}
					catch (Exception exception)
					{
						if (!base.IsErrorHandled(values.UnderlyingCollection, contract, num, writer.ContainerPath, exception))
						{
							throw;
						}
						else
						{
							this.HandleError(writer, top);
						}
					}
				}
				finally
				{
					num++;
				}
			}
			writer.WriteEndArray();
			if (flag)
			{
				writer.WriteEndObject();
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			contract.InvokeOnSerialized(values.UnderlyingCollection, this.Serializer.Context);
		}

		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			Required valueOrDefault;
			contract.InvokeOnSerializing(value, this.Serializer.Context);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			int top = writer.Top;
			foreach (JsonProperty property in contract.Properties)
			{
				try
				{
					if (!property.Ignored && property.Readable && this.ShouldSerialize(property, value) && this.IsSpecified(property, value))
					{
						if (property.PropertyContract == null)
						{
							property.PropertyContract = this.Serializer.ContractResolver.ResolveContract(property.PropertyType);
						}
						object obj = property.ValueProvider.GetValue(value);
						JsonContract jsonContract = (property.PropertyContract.UnderlyingType.IsSealed() ? property.PropertyContract : this.GetContractSafe(obj));
						if (this.ShouldWriteProperty(obj, property))
						{
							string propertyName = property.PropertyName;
							if (this.ShouldWriteReference(obj, property, jsonContract, contract, member))
							{
								writer.WritePropertyName(propertyName);
								this.WriteReference(writer, obj);
								continue;
							}
							else if (this.CheckForCircularReference(writer, obj, property, jsonContract, contract, member))
							{
								if (obj == null)
								{
									Required? nullable = property._required;
									if (nullable.HasValue)
									{
										valueOrDefault = nullable.GetValueOrDefault();
									}
									else
									{
										Required? itemRequired = contract.ItemRequired;
										valueOrDefault = (itemRequired.HasValue ? itemRequired.GetValueOrDefault() : Required.Default);
									}
									if (valueOrDefault == Required.Always)
									{
										throw JsonSerializationException.Create(null, writer.ContainerPath, "Cannot write a null value for property '{0}'. Property requires a value.".FormatWith(CultureInfo.InvariantCulture, property.PropertyName), null);
									}
								}
								writer.WritePropertyName(propertyName);
								this.SerializeValue(writer, obj, jsonContract, property, contract, member);
							}
							else
							{
								continue;
							}
						}
					}
				}
				catch (Exception exception)
				{
					if (!base.IsErrorHandled(value, contract, property.PropertyName, writer.ContainerPath, exception))
					{
						throw;
					}
					else
					{
						this.HandleError(writer, top);
					}
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			contract.InvokeOnSerialized(value, this.Serializer.Context);
		}

		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			if (!(contract.UnderlyingType == typeof(byte[])) || !this.ShouldWriteType(TypeNameHandling.Objects, contract, member, containerContract, containerProperty))
			{
				writer.WriteValue(value);
				return;
			}
			writer.WriteStartObject();
			this.WriteTypeProperty(writer, contract.CreatedType);
			writer.WritePropertyName("$value");
			writer.WriteValue(value);
			writer.WriteEndObject();
		}

		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
			string str;
			contract.InvokeOnSerializing(value, this.Serializer.Context);
			JsonSerializerInternalWriter.TryConvertToString(value, contract.UnderlyingType, out str);
			writer.WriteValue(str);
			contract.InvokeOnSerialized(value, this.Serializer.Context);
		}

		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			object converter;
			JsonConverter[] array;
			object itemConverter;
			object obj;
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			if (member != null)
			{
				converter = member.Converter;
			}
			else
			{
				converter = null;
			}
			JsonConverter jsonConverter = (JsonConverter)converter;
			if (converter == null)
			{
				if (containerProperty != null)
				{
					itemConverter = containerProperty.ItemConverter;
				}
				else
				{
					itemConverter = null;
				}
				jsonConverter = (JsonConverter)itemConverter;
				if (itemConverter == null)
				{
					if (containerContract != null)
					{
						obj = containerContract.ItemConverter;
					}
					else
					{
						obj = null;
					}
					jsonConverter = (JsonConverter)obj;
					if (obj == null)
					{
						JsonConverter converter1 = valueContract.Converter;
						jsonConverter = converter1;
						if (converter1 == null)
						{
							JsonConverter matchingConverter = this.Serializer.GetMatchingConverter(valueContract.UnderlyingType);
							jsonConverter = matchingConverter;
							if (matchingConverter == null)
							{
								JsonConverter internalConverter = valueContract.InternalConverter;
								jsonConverter = internalConverter;
								if (internalConverter == null)
								{
									goto Label0;
								}
							}
						}
					}
				}
			}
			if (jsonConverter.CanWrite)
			{
				this.SerializeConvertable(writer, jsonConverter, value, valueContract, containerContract, containerProperty);
				return;
			}
		Label0:
			switch (valueContract.ContractType)
			{
				case JsonContractType.Object:
				{
					this.SerializeObject(writer, value, (JsonObjectContract)valueContract, member, containerContract, containerProperty);
					return;
				}
				case JsonContractType.Array:
				{
					JsonArrayContract jsonArrayContract = (JsonArrayContract)valueContract;
					this.SerializeList(writer, jsonArrayContract.CreateWrapper(value), jsonArrayContract, member, containerContract, containerProperty);
					return;
				}
				case JsonContractType.Primitive:
				{
					this.SerializePrimitive(writer, value, (JsonPrimitiveContract)valueContract, member, containerContract, containerProperty);
					return;
				}
				case JsonContractType.String:
				{
					this.SerializeString(writer, value, (JsonStringContract)valueContract);
					return;
				}
				case JsonContractType.Dictionary:
				{
					JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)valueContract;
					this.SerializeDictionary(writer, jsonDictionaryContract.CreateWrapper(value), jsonDictionaryContract, member, containerContract, containerProperty);
					return;
				}
				case JsonContractType.Dynamic:
				{
					this.SerializeDynamic(writer, (IDynamicMetaObjectProvider)value, (JsonDynamicContract)valueContract, member, containerContract, containerProperty);
					return;
				}
				case JsonContractType.Serializable:
				{
					this.SerializeISerializable(writer, (ISerializable)value, (JsonISerializableContract)valueContract, member, containerContract, containerProperty);
					return;
				}
				case JsonContractType.Linq:
				{
					JToken jTokens = (JToken)value;
					JsonWriter jsonWriter = writer;
					if (this.Serializer.Converters != null)
					{
						array = this.Serializer.Converters.ToArray<JsonConverter>();
					}
					else
					{
						array = null;
					}
					jTokens.WriteTo(jsonWriter, array);
					return;
				}
				default:
				{
					return;
				}
			}
		}

		private bool ShouldSerialize(JsonProperty property, object target)
		{
			if (property.ShouldSerialize == null)
			{
				return true;
			}
			return property.ShouldSerialize(target);
		}

		private bool ShouldWriteProperty(object memberValue, JsonProperty property)
		{
			if (property.NullValueHandling.GetValueOrDefault(this.Serializer.NullValueHandling) == NullValueHandling.Ignore && memberValue == null)
			{
				return false;
			}
			if (this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer.DefaultValueHandling), DefaultValueHandling.Ignore) && MiscellaneousUtils.ValueEquals(memberValue, property.DefaultValue))
			{
				return false;
			}
			return true;
		}

		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (value == null)
			{
				return false;
			}
			if (valueContract.ContractType == JsonContractType.Primitive || valueContract.ContractType == JsonContractType.String)
			{
				return false;
			}
			bool? nullable = this.ResolveIsReference(valueContract, property, collectionContract, containerProperty);
			if (!nullable.HasValue)
			{
				nullable = (valueContract.ContractType != JsonContractType.Array ? new bool?(this.HasFlag(this.Serializer.PreserveReferencesHandling, PreserveReferencesHandling.Objects)) : new bool?(this.HasFlag(this.Serializer.PreserveReferencesHandling, PreserveReferencesHandling.Arrays)));
			}
			if (!nullable.Value)
			{
				return false;
			}
			return this.Serializer.ReferenceResolver.IsReferenced(this, value);
		}

		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			TypeNameHandling? typeNameHandling;
			TypeNameHandling valueOrDefault;
			TypeNameHandling? itemTypeNameHandling;
			TypeNameHandling? nullable;
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
				if (containerProperty != null)
				{
					itemTypeNameHandling = containerProperty.ItemTypeNameHandling;
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
					if (containerContract != null)
					{
						nullable = containerContract.ItemTypeNameHandling;
					}
					else
					{
						nullable = null;
					}
					TypeNameHandling? nullable3 = nullable;
					valueOrDefault = (nullable3.HasValue ? nullable3.GetValueOrDefault() : this.Serializer.TypeNameHandling);
				}
			}
			TypeNameHandling typeNameHandling1 = valueOrDefault;
			if (this.HasFlag(typeNameHandling1, typeNameHandlingFlag))
			{
				return true;
			}
			if (this.HasFlag(typeNameHandling1, TypeNameHandling.Auto))
			{
				if (member != null)
				{
					if (contract.UnderlyingType != member.PropertyContract.CreatedType)
					{
						return true;
					}
				}
				else if (containerContract != null && containerContract.ItemContract != null && contract.UnderlyingType != containerContract.ItemContract.CreatedType)
				{
					return true;
				}
			}
			return false;
		}

		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			TypeConverter converter = ConvertUtils.GetConverter(type);
			if (converter != null && !(converter is ComponentConverter) && converter.GetType() != typeof(TypeConverter) && converter.CanConvertTo(typeof(string)))
			{
				s = converter.ConvertToInvariantString(value);
				return true;
			}
			if (!(value is Type))
			{
				s = null;
				return false;
			}
			s = ((Type)value).AssemblyQualifiedName;
			return true;
		}

		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			writer.WriteStartObject();
			bool? nullable = this.ResolveIsReference(contract, member, collectionContract, containerProperty);
			if ((nullable.HasValue ? nullable.GetValueOrDefault() : this.HasFlag(this.Serializer.PreserveReferencesHandling, PreserveReferencesHandling.Objects)))
			{
				writer.WritePropertyName("$id");
				writer.WriteValue(this.Serializer.ReferenceResolver.GetReference(this, value));
			}
			if (this.ShouldWriteType(TypeNameHandling.Objects, contract, member, collectionContract, containerProperty))
			{
				this.WriteTypeProperty(writer, contract.UnderlyingType);
			}
		}

		private void WriteReference(JsonWriter writer, object value)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("$ref");
			writer.WriteValue(this.Serializer.ReferenceResolver.GetReference(this, value));
			writer.WriteEndObject();
		}

		private bool WriteStartArray(JsonWriter writer, IWrappedCollection values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			bool? nullable = this.ResolveIsReference(contract, member, containerContract, containerProperty);
			bool flag = (nullable.HasValue ? nullable.GetValueOrDefault() : this.HasFlag(this.Serializer.PreserveReferencesHandling, PreserveReferencesHandling.Arrays));
			bool flag1 = this.ShouldWriteType(TypeNameHandling.Arrays, contract, member, containerContract, containerProperty);
			bool flag2 = (flag ? true : flag1);
			if (flag2)
			{
				writer.WriteStartObject();
				if (flag)
				{
					writer.WritePropertyName("$id");
					writer.WriteValue(this.Serializer.ReferenceResolver.GetReference(this, values.UnderlyingCollection));
				}
				if (flag1)
				{
					this.WriteTypeProperty(writer, values.UnderlyingCollection.GetType());
				}
				writer.WritePropertyName("$values");
			}
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.Serializer.ContractResolver.ResolveContract(contract.CollectionItemType ?? typeof(object));
			}
			return flag2;
		}

		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
			writer.WritePropertyName("$type");
			writer.WriteValue(ReflectionUtils.GetTypeName(type, this.Serializer.TypeNameAssemblyFormat, this.Serializer.Binder));
		}
	}
}