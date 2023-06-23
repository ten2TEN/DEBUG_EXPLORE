using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace Twitterizer
{
	public class TwitterizerDateConverter : DateTimeConverterBase
	{
		protected const string DateFormat = "ddd MMM dd HH:mm:ss zz00 yyyy";

		public TwitterizerDateConverter()
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			DateTime dateTime;
			object obj;
			DateTime dateTime1;
			DateTime dateTime2;
			if ((reader.Value == null ? false : !(reader.Value.GetType() != typeof(string))))
			{
				if (DateTime.TryParseExact((string)reader.Value, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
				{
					dateTime2 = dateTime;
				}
				else
				{
					dateTime1 = new DateTime();
					dateTime2 = dateTime1;
				}
				obj = dateTime2;
			}
			else
			{
				dateTime1 = new DateTime();
				obj = dateTime1;
			}
			return obj;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value.GetType() != typeof(DateTime))
			{
				throw new ArgumentOutOfRangeException("value", "The value provided was not the expected data type.");
			}
			DateTime dateTime = (DateTime)value;
			writer.WriteValue(dateTime.ToString("ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture));
		}
	}
}