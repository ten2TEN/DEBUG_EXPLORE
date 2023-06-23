using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonConverter(typeof(TwitterPlaceCollection.Converter))]
	[JsonObject]
	[Serializable]
	public class TwitterPlaceCollection : TwitterCollection<TwitterPlace>, ITwitterObject
	{
		public TwitterPlaceCollection()
		{
		}

		internal class Converter : JsonConverter
		{
			public Converter()
			{
			}

			public override bool CanConvert(Type objectType)
			{
				return objectType == typeof(TwitterPlaceCollection);
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				TwitterPlaceCollection twitterPlaceCollection = new TwitterPlaceCollection();
				reader.Read();
				reader.Read();
				bool flag = false;
				while (reader.Read())
				{
					if ((reader.TokenType != JsonToken.PropertyName ? false : (string)reader.Value == "query"))
					{
						flag = true;
					}
					if (!flag)
					{
						if (reader.TokenType == JsonToken.StartObject)
						{
							twitterPlaceCollection.Add(serializer.Deserialize<TwitterPlace>(reader));
						}
					}
				}
				return twitterPlaceCollection;
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
			}
		}
	}
}