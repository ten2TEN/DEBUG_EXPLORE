using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterRateLimitResults : TwitterObject
	{
		[JsonProperty(PropertyName="limit")]
		public int HourlyLimit
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="remaining")]
		public int RemainingHits
		{
			get;
			set;
		}

		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="reset")]
		public DateTime ResetTime
		{
			get;
			set;
		}

		public TwitterRateLimitResults()
		{
		}
	}
}