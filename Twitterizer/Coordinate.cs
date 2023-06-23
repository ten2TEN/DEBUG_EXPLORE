using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Twitterizer
{
	[DataContract]
	[Serializable]
	public class Coordinate
	{
		public double Latitude
		{
			get;
			set;
		}

		public double Longitude
		{
			get;
			set;
		}

		public Coordinate()
		{
		}

		internal class Converter : JsonConverter
		{
			public Converter()
			{
			}

			public override bool CanConvert(Type objectType)
			{
				return objectType == typeof(Collection<Coordinate>);
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				object obj;
				try
				{
					Collection<Coordinate> coordinates = existingValue as Collection<Coordinate>;
					if (coordinates == null)
					{
						coordinates = new Collection<Coordinate>();
					}
					int depth = reader.Depth;
					if (reader.TokenType == JsonToken.StartArray)
					{
						if (reader.TokenType == JsonToken.StartArray)
						{
							reader.Read();
						}
						double num = 1;
						while (true)
						{
							if ((!reader.Read() ? true : reader.Depth <= depth))
							{
								break;
							}
							JsonToken[] jsonTokenArray = new JsonToken[] { JsonToken.StartArray, JsonToken.EndArray };
							if (!jsonTokenArray.Contains<JsonToken>(reader.TokenType))
							{
								int num1 = Convert.ToInt32(Math.Ceiling(num / 2) - 1);
								if (num % 2 <= 0)
								{
									coordinates[num1].Longitude = Convert.ToDouble(reader.Value);
								}
								else
								{
									coordinates.Add(new Coordinate());
									coordinates[num1].Latitude = Convert.ToDouble(reader.Value);
								}
								num += 1;
							}
						}
						obj = coordinates;
					}
					else
					{
						obj = null;
					}
				}
				catch
				{
					obj = null;
				}
				return obj;
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
				writer.WriteNull();
			}
		}
	}
}