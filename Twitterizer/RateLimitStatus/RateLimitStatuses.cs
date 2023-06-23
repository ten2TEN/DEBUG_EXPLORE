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
	public class RateLimitStatuses : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/statuses/home_timeline")]
		public TwitterRateLimitResults HomeTimeline
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/mentions_timeline")]
		public TwitterRateLimitResults Mentions
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/oembed")]
		public TwitterRateLimitResults Oembed
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/retweeters/ids")]
		public TwitterRateLimitResults RetweetersIds
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/retweets/:id")]
		public TwitterRateLimitResults Retweetes
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/retweets_of_me")]
		public TwitterRateLimitResults RetweetsOfMe
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/show/:id")]
		public TwitterRateLimitResults Show
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/statuses/user_timeline")]
		public TwitterRateLimitResults UserTimeline
		{
			get;
			set;
		}

		public RateLimitStatuses()
		{
		}
	}
}