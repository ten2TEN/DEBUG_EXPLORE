using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Converters
{
	public class KeyValuePairConverter : JsonConverter
	{
		public KeyValuePairConverter()
		{
		}

		public override bool CanConvert(Type objectType)
		{
			Type type = (ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType);
			if (!type.IsValueType() || !type.IsGenericType())
			{
				return false;
			}
			return type.GetGenericTypeDefinition() == typeof(KeyValuePair<,>);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag = ReflectionUtils.IsNullableType(objectType);
			if (reader.TokenType == JsonToken.Null)
			{
				if (!flag)
				{
					throw JsonSerializationException.Create(reader, "Cannot convert null value to KeyValuePair.");
				}
				return null;
			}
			Type type = (flag ? Nullable.GetUnderlyingType(objectType) : objectType);
			IList<Type> genericArguments = type.GetGenericArguments();
			Type item = genericArguments[0];
			Type item1 = genericArguments[1];
			object obj = null;
			object obj1 = null;
			reader.Read();
			while (reader.TokenType == JsonToken.PropertyName)
			{
				string str = reader.Value.ToString();
				string str1 = str;
				if (str != null)
				{
					if (str1 == "Key")
					{
						reader.Read();
						obj = serializer.Deserialize(reader, item);
						goto Label0;
					}
					else
					{
						if (str1 != "Value")
						{
							goto Label2;
						}
						reader.Read();
						obj1 = serializer.Deserialize(reader, item1);
						goto Label0;
					}
				}
			Label2:
				reader.Skip();
			Label0:
				reader.Read();
			}
			object[] objArray = new object[] { obj, obj1 };
			return ReflectionUtils.CreateInstance(type, objArray);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Type type = value.GetType();
			PropertyInfo property = type.GetProperty("Key");
			PropertyInfo propertyInfo = type.GetProperty("Value");
			writer.WriteStartObject();
			writer.WritePropertyName("Key");
			serializer.Serialize(writer, ReflectionUtils.GetMemberValue(property, value));
			writer.WritePropertyName("Value");
			serializer.Serialize(writer, ReflectionUtils.GetMemberValue(propertyInfo, value));
			writer.WriteEndObject();
		}
	}
}