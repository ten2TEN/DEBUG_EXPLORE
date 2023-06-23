using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonConverter(typeof(TwitterTrendCollection.Converter))]
	[Serializable]
	public class TwitterTrendCollection : TwitterCollection<TwitterTrend>, ITwitterObject
	{
		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="as_of")]
		public DateTime AsOf
		{
			get;
			set;
		}

		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="created_at")]
		public DateTime CreatedAt
		{
			get;
			set;
		}

		public TwitterTrendLocationCollection Locations
		{
			get;
			set;
		}

		public TwitterTrendCollection()
		{
		}

		internal class Converter : JsonConverter
		{
			public Converter()
			{
			}

			public override bool CanConvert(Type objectType)
			{
				return objectType == typeof(TwitterTrendCollection);
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				string value;
				TwitterTrendCollection twitterTrendCollection = existingValue as TwitterTrendCollection;
				if (twitterTrendCollection == null)
				{
					twitterTrendCollection = new TwitterTrendCollection();
				}
				int depth = reader.Depth;
				while (true)
				{
					if ((!reader.Read() ? true : reader.Depth <= depth))
					{
						break;
					}
					if ((reader.TokenType != JsonToken.PropertyName ? false : reader.Depth == depth + 2))
					{
						value = (string)reader.Value;
						if (value != null)
						{
							if (value == "as_of")
							{
								reader.Read();
								TwitterizerDateConverter twitterizerDateConverter = new TwitterizerDateConverter();
								twitterTrendCollection.AsOf = (DateTime)twitterizerDateConverter.ReadJson(reader, typeof(DateTime), null, serializer);
								continue;
							}
							else if (value == "created_at")
							{
								reader.Read();
								TwitterizerDateConverter twitterizerDateConverter1 = new TwitterizerDateConverter();
								twitterTrendCollection.CreatedAt = (DateTime)twitterizerDateConverter1.ReadJson(reader, typeof(DateTime), null, serializer);
								continue;
							}
							else if (value == "locations")
							{
								reader.Read();
								TwitterTrendLocationCollection.Converter converter = new TwitterTrendLocationCollection.Converter();
								twitterTrendCollection.Locations = (TwitterTrendLocationCollection)converter.ReadJson(reader, typeof(TwitterTrendLocationCollection), null, serializer);
								continue;
							}
						}
					}
					if ((reader.TokenType != JsonToken.StartObject ? false : reader.Depth > depth + 1))
					{
						twitterTrendCollection.Add(new TwitterTrend());
					}
					if (reader.TokenType == JsonToken.PropertyName)
					{
						value = (string)reader.Value;
						if (value != null)
						{
							if (value == "query")
							{
								reader.Read();
								twitterTrendCollection[twitterTrendCollection.Count - 1].SearchQuery = (string)reader.Value;
								continue;
							}
							else if (value == "name")
							{
								reader.Read();
								twitterTrendCollection[twitterTrendCollection.Count - 1].Name = (string)reader.Value;
								continue;
							}
							else if (value == "url")
							{
								reader.Read();
								twitterTrendCollection[twitterTrendCollection.Count - 1].Address = (string)reader.Value;
								continue;
							}
							else if (value == "promoted_content")
							{
								reader.Read();
								twitterTrendCollection[twitterTrendCollection.Count - 1].PromotedContent = (string)reader.Value;
								continue;
							}
							else if (value == "events")
							{
								reader.Read();
								twitterTrendCollection[twitterTrendCollection.Count - 1].Events = (string)reader.Value;
								continue;
							}
						}
					}
				}
				return twitterTrendCollection;
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
			}
		}
	}
}