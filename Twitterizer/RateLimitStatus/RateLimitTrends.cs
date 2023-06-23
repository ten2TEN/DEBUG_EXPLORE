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
	public class RateLimitTrends : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/trends/available")]
		public TwitterRateLimitResults Available
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/trends/closest")]
		public TwitterRateLimitResults Closest
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/trends/place")]
		public TwitterRateLimitResults Place
		{
			get;
			set;
		}

		public RateLimitTrends()
		{
		}
	}
}