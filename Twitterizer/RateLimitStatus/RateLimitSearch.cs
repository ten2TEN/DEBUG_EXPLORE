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
	public class RateLimitSearch : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/search/tweets")]
		public TwitterRateLimitResults Tweets
		{
			get;
			set;
		}

		public RateLimitSearch()
		{
		}
	}
}