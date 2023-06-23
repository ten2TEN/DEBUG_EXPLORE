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
	public class RateLimitBlock : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/blocks/ids")]
		public TwitterRateLimitResults Ids
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="/blocks/list")]
		public TwitterRateLimitResults List
		{
			get;
			set;
		}

		public RateLimitBlock()
		{
		}
	}
}