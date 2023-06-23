using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterBoundingBox : TwitterObject
	{
		[JsonConverter(typeof(Coordinate.Converter))]
		[JsonProperty(PropertyName="coordinates")]
		public Collection<Coordinate> Coordinates
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="type")]
		public string Type
		{
			get;
			set;
		}

		public TwitterBoundingBox()
		{
		}
	}
}