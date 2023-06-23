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
	public class RateLimitUsers : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/users/contributees")]
		public TwitterRateLimitResults Contributees
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/contributors")]
		public TwitterRateLimitResults Contributors
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/lookup")]
		public TwitterRateLimitResults Lookup
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/profile_banner")]
		public TwitterRateLimitResults ProfileBanner
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/search")]
		public TwitterRateLimitResults Search
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/show/:id")]
		public TwitterRateLimitResults Show
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/suggestions")]
		public TwitterRateLimitResults Suggestions
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/suggestions/:slug")]
		public TwitterRateLimitResults SuggestionsSlug
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/users/suggestions/:slug/members")]
		public TwitterRateLimitResults SuggestionsSlugMembers
		{
			get;
			set;
		}

		public RateLimitUsers()
		{
		}
	}
}