using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Data;

namespace Newtonsoft.Json.Converters
{
	public class DataTableConverter : JsonConverter
	{
		public DataTableConverter()
		{
		}

		public override bool CanConvert(Type valueType)
		{
			return valueType == typeof(DataTable);
		}

		private static Type GetColumnDataType(JsonToken tokenType)
		{
			switch (tokenType)
			{
				case JsonToken.Integer:
				{
					return typeof(long);
				}
				case JsonToken.Float:
				{
					return typeof(double);
				}
				case JsonToken.String:
				case JsonToken.Null:
				case JsonToken.Undefined:
				{
					return typeof(string);
				}
				case JsonToken.Boolean:
				{
					return typeof(bool);
				}
				case JsonToken.EndObject:
				case JsonToken.EndArray:
				case JsonToken.EndConstructor:
				{
					throw new ArgumentOutOfRangeException();
				}
				case JsonToken.Date:
				{
					return typeof(DateTime);
				}
				default:
				{
					throw new ArgumentOutOfRangeException();
				}
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			DataTable dataTable;
			if (reader.TokenType != JsonToken.PropertyName)
			{
				dataTable = new DataTable();
			}
			else
			{
				dataTable = new DataTable((string)reader.Value);
				reader.Read();
			}
			reader.Read();
			while (reader.TokenType == JsonToken.StartObject)
			{
				DataRow dataRow = dataTable.NewRow();
				reader.Read();
				while (reader.TokenType == JsonToken.PropertyName)
				{
					string value = (string)reader.Value;
					reader.Read();
					if (!dataTable.Columns.Contains(value))
					{
						Type columnDataType = DataTableConverter.GetColumnDataType(reader.TokenType);
						dataTable.Columns.Add(new DataColumn(value, columnDataType));
					}
					DataRow dataRow1 = dataRow;
					string str = value;
					object obj = reader.Value;
					if (obj == null)
					{
						obj = DBNull.Value;
					}
					dataRow1[str] = obj;
					reader.Read();
				}
				dataRow.EndEdit();
				dataTable.Rows.Add(dataRow);
				reader.Read();
			}
			return dataTable;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			DataTable dataTable = (DataTable)value;
			DefaultContractResolver contractResolver = serializer.ContractResolver as DefaultContractResolver;
			writer.WriteStartArray();
			foreach (DataRow row in dataTable.Rows)
			{
				writer.WriteStartObject();
				foreach (DataColumn column in row.Table.Columns)
				{
					if (serializer.NullValueHandling == NullValueHandling.Ignore && (row[column] == null || row[column] == DBNull.Value))
					{
						continue;
					}
					writer.WritePropertyName((contractResolver != null ? contractResolver.GetResolvedPropertyName(column.ColumnName) : column.ColumnName));
					serializer.Serialize(writer, row[column]);
				}
				writer.WriteEndObject();
			}
			writer.WriteEndArray();
		}
	}
}