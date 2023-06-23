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
	public class RateLimitFriendShips : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/friendships/incoming")]
		public TwitterRateLimitResults Incoming
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/friendships/lookup")]
		public TwitterRateLimitResults Lookup
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/friendships/no_retweets/ids")]
		public TwitterRateLimitResults NoRetweetsIds
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/friendships/outgoing")]
		public TwitterRateLimitResults Outgoing
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/friendships/show")]
		public TwitterRateLimitResults Show
		{
			get;
			set;
		}

		public RateLimitFriendShips()
		{
		}
	}
}