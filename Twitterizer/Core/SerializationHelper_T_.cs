using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace Twitterizer.Core
{
	public static class SerializationHelper<T>
	where T : ITwitterObject
	{
		public static T Deserialize(byte[] webResponseData, SerializationHelper<T>.DeserializationHandler deserializationHandler)
		{
			T t = SerializationHelper<T>.Deserialize(Encoding.UTF8.GetString(webResponseData, 0, (int)webResponseData.Length), deserializationHandler);
			return t;
		}

		public static T Deserialize(byte[] webResponseData)
		{
			T t = SerializationHelper<T>.Deserialize(Encoding.UTF8.GetString(webResponseData, 0, (int)webResponseData.Length), null);
			return t;
		}

		public static T Deserialize(string webResponseData, SerializationHelper<T>.DeserializationHandler deserializationHandler)
		{
			T t;
			t = (deserializationHandler != null ? deserializationHandler((JObject)JsonConvert.DeserializeObject(webResponseData)) : JsonConvert.DeserializeObject<T>(webResponseData));
			return t;
		}

		public static T Deserialize(string webResponseData)
		{
			return SerializationHelper<T>.Deserialize(webResponseData, null);
		}

		public delegate T DeserializationHandler(JObject value);
	}
}