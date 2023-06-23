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
	public class RateLimitAccount : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/account/settings")]
		public TwitterRateLimitResults Settings
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/account/verify_credentials")]
		public TwitterRateLimitResults Verify
		{
			get;
			set;
		}

		public RateLimitAccount()
		{
		}
	}
}