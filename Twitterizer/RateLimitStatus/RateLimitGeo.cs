using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.RateLimitStatus
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class RateLimitGeo : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/geo/id/:place_id")]
		public TwitterRateLimitResults PlaceId
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/geo/reverse_geocode")]
		public TwitterRateLimitResults ReverseGeoCode
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/geo/search")]
		public TwitterRateLimitResults Search
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/geo/similar_places")]
		public TwitterRateLimitResults SimilarPlaces
		{
			get;
			set;
		}

		public RateLimitGeo()
		{
		}
	}
}