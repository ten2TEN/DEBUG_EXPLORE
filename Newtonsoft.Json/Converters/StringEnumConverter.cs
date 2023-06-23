using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Converters
{
	public class StringEnumConverter : JsonConverter
	{
		private readonly Dictionary<Type, BidirectionalDictionary<string, string>> _enumMemberNamesPerType = new Dictionary<Type, BidirectionalDictionary<string, string>>();

		public bool CamelCaseText
		{
			get;
			set;
		}

		public StringEnumConverter()
		{
		}

		public override bool CanConvert(Type objectType)
		{
			return ((ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType)).IsEnum();
		}

		private BidirectionalDictionary<string, string> GetEnumNameMap(Type t)
		{
			BidirectionalDictionary<string, string> bidirectionalDictionary;
			string str;
			BidirectionalDictionary<string, string> bidirectionalDictionary1;
			if (!this._enumMemberNamesPerType.TryGetValue(t, out bidirectionalDictionary))
			{
				lock (this._enumMemberNamesPerType)
				{
					if (!this._enumMemberNamesPerType.TryGetValue(t, out bidirectionalDictionary))
					{
						bidirectionalDictionary = new BidirectionalDictionary<string, string>(StringComparer.OrdinalIgnoreCase, StringComparer.OrdinalIgnoreCase);
						FieldInfo[] fields = t.GetFields();
						for (int i = 0; i < (int)fields.Length; i++)
						{
							FieldInfo fieldInfo = fields[i];
							string name = fieldInfo.Name;
							string str1 = (
								from EnumMemberAttribute a in fieldInfo.GetCustomAttributes(typeof(EnumMemberAttribute), true)
								select a.Value).SingleOrDefault<string>() ?? fieldInfo.Name;
							if (bidirectionalDictionary.TryGetBySecond(str1, out str))
							{
								throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".FormatWith(CultureInfo.InvariantCulture, str1, t.Name));
							}
							bidirectionalDictionary.Add(name, str1);
						}
						this._enumMemberNamesPerType[t] = bidirectionalDictionary;
						return bidirectionalDictionary;
					}
					else
					{
						bidirectionalDictionary1 = bidirectionalDictionary;
					}
				}
				return bidirectionalDictionary1;
			}
			return bidirectionalDictionary;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			string str;
			Type type = (ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType);
			if (reader.TokenType == JsonToken.Null)
			{
				if (!ReflectionUtils.IsNullableType(objectType))
				{
					throw JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			if (reader.TokenType != JsonToken.String)
			{
				if (reader.TokenType != JsonToken.Integer)
				{
					throw JsonSerializationException.Create(reader, "Unexpected token when parsing enum. Expected String or Integer, got {0}.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
				}
				return ConvertUtils.ConvertOrCast(reader.Value, CultureInfo.InvariantCulture, type);
			}
			BidirectionalDictionary<string, string> enumNameMap = this.GetEnumNameMap(type);
			enumNameMap.TryGetBySecond(reader.Value.ToString(), out str);
			str = str ?? reader.Value.ToString();
			return Enum.Parse(type, str, true);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			string str;
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			Enum @enum = (Enum)value;
			string str1 = @enum.ToString("G");
			if (char.IsNumber(str1[0]) || str1[0] == '-')
			{
				writer.WriteValue(value);
				return;
			}
			BidirectionalDictionary<string, string> enumNameMap = this.GetEnumNameMap(@enum.GetType());
			enumNameMap.TryGetByFirst(str1, out str);
			str = str ?? str1;
			if (this.CamelCaseText)
			{
				char[] chrArray = new char[] { ',' };
				string[] array = (
					from item in str.Split(chrArray)
					select StringUtils.ToCamelCase(item.Trim())).ToArray<string>();
				str = string.Join(", ", array);
			}
			writer.WriteValue(str);
		}
	}
}