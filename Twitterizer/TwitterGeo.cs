using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class TwitterGeo
	{
		[JsonConverter(typeof(Coordinate.Converter))]
		[JsonProperty(PropertyName="coordinates")]
		public Collection<Coordinate> Coordinates
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="type")]
		public TwitterGeoShapeType ShapeType
		{
			get;
			set;
		}

		public TwitterGeo()
		{
		}
	}
}