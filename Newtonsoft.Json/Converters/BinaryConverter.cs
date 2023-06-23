using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	public class BinaryConverter : JsonConverter
	{
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		public BinaryConverter()
		{
		}

		public override bool CanConvert(Type objectType)
		{
			if (objectType.AssignableToTypeName("System.Data.Linq.Binary"))
			{
				return true;
			}
			if (!(objectType == typeof(SqlBinary)) && !(objectType == typeof(SqlBinary?)))
			{
				return false;
			}
			return true;
		}

		private byte[] GetByteArray(object value)
		{
			if (value.GetType().AssignableToTypeName("System.Data.Linq.Binary"))
			{
				return DynamicWrapper.CreateWrapper<IBinary>(value).ToArray();
			}
			if (!(value is SqlBinary))
			{
				throw new JsonSerializationException("Unexpected value type when writing binary: {0}".FormatWith(CultureInfo.InvariantCulture, value.GetType()));
			}
			return ((SqlBinary)value).Value;
		}

		private byte[] ReadByteArray(JsonReader reader)
		{
			List<byte> nums = new List<byte>();
			while (reader.Read())
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
					case JsonToken.Comment:
					{
						continue;
					}
					case JsonToken.Raw:
					{
						throw JsonSerializationException.Create(reader, "Unexpected token when reading bytes: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
					}
					case JsonToken.Integer:
					{
						nums.Add(Convert.ToByte(reader.Value, CultureInfo.InvariantCulture));
						continue;
					}
					default:
					{
						if (tokenType == JsonToken.EndArray)
						{
							return nums.ToArray();
						}
						throw JsonSerializationException.Create(reader, "Unexpected token when reading bytes: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
					}
				}
			}
			throw JsonSerializationException.Create(reader, "Unexpected end when reading bytes.");
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			byte[] numArray;
			Type type = (ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType);
			if (reader.TokenType == JsonToken.Null)
			{
				if (!ReflectionUtils.IsNullable(objectType))
				{
					throw JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			if (reader.TokenType != JsonToken.StartArray)
			{
				if (reader.TokenType != JsonToken.String)
				{
					throw JsonSerializationException.Create(reader, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
				}
				numArray = Convert.FromBase64String(reader.Value.ToString());
			}
			else
			{
				numArray = this.ReadByteArray(reader);
			}
			if (type.AssignableToTypeName("System.Data.Linq.Binary"))
			{
				return Activator.CreateInstance(type, new object[] { numArray });
			}
			if (type != typeof(SqlBinary))
			{
				throw JsonSerializationException.Create(reader, "Unexpected object type when writing binary: {0}".FormatWith(CultureInfo.InvariantCulture, objectType));
			}
			return new SqlBinary(numArray);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteValue(this.GetByteArray(value));
		}
	}
}