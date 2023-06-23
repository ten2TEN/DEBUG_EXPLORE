using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonConverter(typeof(TwitterTrendLocationCollection.Converter))]
	[Serializable]
	public class TwitterTrendLocationCollection : TwitterCollection<TwitterTrendLocation>, ITwitterObject
	{
		public TwitterTrendLocationCollection()
		{
		}

		internal class Converter : JsonConverter
		{
			public Converter()
			{
			}

			public override bool CanConvert(Type objectType)
			{
				return objectType == typeof(TwitterTrendLocationCollection);
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				TwitterTrendLocationCollection twitterTrendLocationCollection = existingValue as TwitterTrendLocationCollection;
				if (twitterTrendLocationCollection == null)
				{
					twitterTrendLocationCollection = new TwitterTrendLocationCollection();
				}
				int depth = reader.Depth;
				while (true)
				{
					if ((!reader.Read() ? true : reader.Depth <= depth))
					{
						break;
					}
					if ((reader.TokenType != JsonToken.StartObject ? false : reader.Depth >= 1))
					{
						twitterTrendLocationCollection.Add(new TwitterTrendLocation());
					}
					if (reader.TokenType == JsonToken.PropertyName)
					{
						string value = (string)reader.Value;
						if (value != null)
						{
							if (value == "name")
							{
								reader.Read();
								twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].Name = (string)reader.Value;
								continue;
							}
							else if (value == "woeid")
							{
								reader.Read();
								twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].WOEID = int.Parse(reader.Value.ToString());
								continue;
							}
							else if (value == "placeType")
							{
								int num = reader.Depth;
								while (true)
								{
									if ((!reader.Read() ? true : reader.Depth <= num))
									{
										break;
									}
									if ((reader.TokenType != JsonToken.StartObject ? false : reader.Depth >= 2))
									{
										twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].PlaceType = new TwitterTrendLocationPlaceType();
									}
									if (reader.TokenType == JsonToken.PropertyName)
									{
										value = (string)reader.Value;
										if (value != null)
										{
											if (value == "name")
											{
												reader.Read();
												twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].PlaceType.Name = (string)reader.Value;
												continue;
											}
											else if (value == "code")
											{
												reader.Read();
												twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].PlaceType.Code = int.Parse(reader.Value.ToString());
												continue;
											}
										}
									}
								}
								continue;
							}
							else if (value == "country")
							{
								reader.Read();
								twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].Country = (string)reader.Value;
								continue;
							}
							else if (value == "url")
							{
								reader.Read();
								twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].URL = (string)reader.Value;
								continue;
							}
							else if (value == "countryCode")
							{
								reader.Read();
								twitterTrendLocationCollection[twitterTrendLocationCollection.Count - 1].CountryCode = (string)reader.Value;
								continue;
							}
						}
					}
				}
				return twitterTrendLocationCollection;
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
			}
		}
	}
}