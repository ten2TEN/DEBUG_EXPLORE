using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	public class EntityKeyMemberConverter : JsonConverter
	{
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		public EntityKeyMemberConverter()
		{
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType.AssignableToTypeName("System.Data.EntityKeyMember");
		}

		private static void ReadAndAssert(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw new JsonSerializationException("Unexpected end.");
			}
		}

		private static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
			EntityKeyMemberConverter.ReadAndAssert(reader);
			if (reader.TokenType != JsonToken.PropertyName || reader.Value.ToString() != propertyName)
			{
				throw new JsonSerializationException("Expected JSON property '{0}'.".FormatWith(CultureInfo.InvariantCulture, propertyName));
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			IEntityKeyMember str = DynamicWrapper.CreateWrapper<IEntityKeyMember>(Activator.CreateInstance(objectType));
			EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Key");
			EntityKeyMemberConverter.ReadAndAssert(reader);
			str.Key = reader.Value.ToString();
			EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Type");
			EntityKeyMemberConverter.ReadAndAssert(reader);
			Type type = Type.GetType(reader.Value.ToString());
			EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Value");
			EntityKeyMemberConverter.ReadAndAssert(reader);
			str.Value = serializer.Deserialize(reader, type);
			EntityKeyMemberConverter.ReadAndAssert(reader);
			return DynamicWrapper.GetUnderlyingObject(str);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			string str;
			Type type;
			string fullName;
			IEntityKeyMember entityKeyMember = DynamicWrapper.CreateWrapper<IEntityKeyMember>(value);
			if (entityKeyMember.Value != null)
			{
				type = entityKeyMember.Value.GetType();
			}
			else
			{
				type = null;
			}
			Type type1 = type;
			writer.WriteStartObject();
			writer.WritePropertyName("Key");
			writer.WriteValue(entityKeyMember.Key);
			writer.WritePropertyName("Type");
			JsonWriter jsonWriter = writer;
			if (type1 != null)
			{
				fullName = type1.FullName;
			}
			else
			{
				fullName = null;
			}
			jsonWriter.WriteValue(fullName);
			writer.WritePropertyName("Value");
			if (type1 == null)
			{
				writer.WriteNull();
			}
			else if (!JsonSerializerInternalWriter.TryConvertToString(entityKeyMember.Value, type1, out str))
			{
				writer.WriteValue(entityKeyMember.Value);
			}
			else
			{
				writer.WriteValue(str);
			}
			writer.WriteEndObject();
		}
	}
}