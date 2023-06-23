using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonConverter(typeof(TwitterTrendDictionary.Converter))]
	[Serializable]
	public class TwitterTrendDictionary : TwitterDictionary<DateTime, TwitterTrendCollection>, ITwitterObject
	{
		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="as_of")]
		public DateTime AsOf
		{
			get;
			set;
		}

		public TwitterTrendDictionary()
		{
		}

		internal class Converter : JsonConverter
		{
			private readonly static string[] dateformats;

			static Converter()
			{
				TwitterTrendDictionary.Converter.dateformats = new string[] { "yyyy-MM-dd HH:mm", "yyyy-MM-dd" };
			}

			public Converter()
			{
			}

			public override bool CanConvert(Type objectType)
			{
				return objectType == typeof(TwitterTrendDictionary);
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				object obj;
				TwitterTrendDictionary twitterTrendDictionary = existingValue as TwitterTrendDictionary;
				if (twitterTrendDictionary == null)
				{
					twitterTrendDictionary = new TwitterTrendDictionary();
				}
				int depth = reader.Depth;
				if (reader.TokenType == JsonToken.StartArray)
				{
					reader.Read();
				}
				while (true)
				{
					if (!(!reader.Read() ? false : reader.Depth > depth))
					{
						obj = twitterTrendDictionary;
						break;
					}
					else if ((reader.TokenType != JsonToken.PropertyName ? false : reader.Depth == 1))
					{
						string value = (string)reader.Value;
						if (value != null)
						{
							if (value == "as_of")
							{
								reader.Read();
								TwitterizerDateConverter twitterizerDateConverter = new TwitterizerDateConverter();
								twitterTrendDictionary.AsOf = (DateTime)twitterizerDateConverter.ReadJson(reader, typeof(DateTime), null, serializer);
								continue;
							}
							else if (value == "trends")
							{
								reader.Read();
								while (true)
								{
									if ((!reader.Read() ? true : reader.Depth < 3))
									{
										break;
									}
									if ((reader.TokenType != JsonToken.PropertyName ? false : reader.Depth == 3))
									{
										try
										{
											DateTime dateTime = DateTime.ParseExact(reader.Value.ToString(), TwitterTrendDictionary.Converter.dateformats, CultureInfo.InvariantCulture, DateTimeStyles.None);
											twitterTrendDictionary.Add(dateTime, new TwitterTrendCollection());
											TwitterTrendCollection.Converter converter = new TwitterTrendCollection.Converter();
											twitterTrendDictionary[dateTime] = (TwitterTrendCollection)converter.ReadJson(reader, typeof(TwitterTrendCollection), null, serializer);
										}
										catch
										{
											obj = null;
											return obj;
										}
									}
								}
								continue;
							}
						}
					}
				}
				return obj;
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
			}
		}
	}
}