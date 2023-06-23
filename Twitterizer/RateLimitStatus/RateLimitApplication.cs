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
	public class RateLimitApplication : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/application/rate_limit_status")]
		public TwitterRateLimitResults RateLimitStatus
		{
			get;
			set;
		}

		public RateLimitApplication()
		{
		}
	}
}