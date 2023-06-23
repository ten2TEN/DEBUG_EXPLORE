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
	public class RateLimitFriends : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/friends/ids")]
		public TwitterRateLimitResults Ids
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/friends/list")]
		public TwitterRateLimitResults List
		{
			get;
			set;
		}

		public RateLimitFriends()
		{
		}
	}
}