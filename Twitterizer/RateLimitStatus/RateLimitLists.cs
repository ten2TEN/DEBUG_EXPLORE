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
	public class RateLimitLists : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/lists/list")]
		public TwitterRateLimitResults List
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/members")]
		public TwitterRateLimitResults Members
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/memberships")]
		public TwitterRateLimitResults MemberShips
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/members/show")]
		public TwitterRateLimitResults MembersShow
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/ownerships")]
		public TwitterRateLimitResults OwnerShips
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/show")]
		public TwitterRateLimitResults Show
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/statuses")]
		public TwitterRateLimitResults Statuses
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/subscribers")]
		public TwitterRateLimitResults Subscribers
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/subscribers/show")]
		public TwitterRateLimitResults SubscribersShow
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/lists/subscriptions")]
		public TwitterRateLimitResults Subscriptions
		{
			get;
			set;
		}

		public RateLimitLists()
		{
		}
	}
}