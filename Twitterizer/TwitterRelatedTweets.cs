using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[DebuggerDisplay("{GroupName}/{ResultType}")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterRelatedTweets : TwitterObject
	{
		[JsonProperty(PropertyName="groupName")]
		public string GroupName
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="results")]
		public TwitterStatusCollection Results
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="resultType")]
		public string ResultType
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="score")]
		public decimal Score
		{
			get;
			set;
		}

		public TwitterRelatedTweets()
		{
		}
	}
}