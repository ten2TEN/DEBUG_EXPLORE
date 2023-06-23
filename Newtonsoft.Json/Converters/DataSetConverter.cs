using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Data;

namespace Newtonsoft.Json.Converters
{
	public class DataSetConverter : JsonConverter
	{
		public DataSetConverter()
		{
		}

		public override bool CanConvert(Type valueType)
		{
			return valueType == typeof(DataSet);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			DataSet dataSet = new DataSet();
			DataTableConverter dataTableConverter = new DataTableConverter();
			reader.Read();
			while (reader.TokenType == JsonToken.PropertyName)
			{
				DataTable dataTable = (DataTable)dataTableConverter.ReadJson(reader, typeof(DataTable), null, serializer);
				dataSet.Tables.Add(dataTable);
				reader.Read();
			}
			return dataSet;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			DataSet dataSet = (DataSet)value;
			DefaultContractResolver contractResolver = serializer.ContractResolver as DefaultContractResolver;
			DataTableConverter dataTableConverter = new DataTableConverter();
			writer.WriteStartObject();
			foreach (DataTable table in dataSet.Tables)
			{
				writer.WritePropertyName((contractResolver != null ? contractResolver.GetResolvedPropertyName(table.TableName) : table.TableName));
				dataTableConverter.WriteJson(writer, table, serializer);
			}
			writer.WriteEndObject();
		}
	}
}