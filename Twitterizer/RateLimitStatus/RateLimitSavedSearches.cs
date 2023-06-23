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
	public class RateLimitSavedSearches : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/saved_searches/destroy/:id")]
		public TwitterRateLimitResults Destroy
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/saved_searches/list")]
		public TwitterRateLimitResults List
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/saved_searches/show/:id")]
		public TwitterRateLimitResults Show
		{
			get;
			set;
		}

		public RateLimitSavedSearches()
		{
		}
	}
}