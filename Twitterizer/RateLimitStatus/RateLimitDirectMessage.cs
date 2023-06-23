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
	public class RateLimitDirectMessage : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/direct_messages")]
		public TwitterRateLimitResults DirectMessages
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/direct_messages/sent")]
		public TwitterRateLimitResults Sent
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/direct_messages/sent_and_received")]
		public TwitterRateLimitResults SentAndReceived
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/direct_messages/show")]
		public TwitterRateLimitResults Show
		{
			get;
			set;
		}

		public RateLimitDirectMessage()
		{
		}
	}
}