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
	public class RateLimitFollowers : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/followers/ids")]
		public TwitterRateLimitResults Ids
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/followers/list")]
		public TwitterRateLimitResults List
		{
			get;
			set;
		}

		public RateLimitFollowers()
		{
		}
	}
}