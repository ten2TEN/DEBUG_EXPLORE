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
	public class RateLimitFavorites : TwitterObject
	{
		[DataMember]
		[JsonProperty(PropertyName="/favorites/list")]
		public TwitterRateLimitResults List
		{
			get;
			set;
		}

		public RateLimitFavorites()
		{
		}
	}
}