using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Core;

namespace Twitterizer
{
	[DataContract]
	[Serializable]
	public class TwitterUserCollection : TwitterCollection<TwitterUser>, ITwitterObject
	{
		[DataMember]
		public long NextCursor
		{
			get;
			internal set;
		}

		[DataMember]
		public long PreviousCursor
		{
			get;
			internal set;
		}

		[DataMember]
		public Twitterizer.RateLimiting RateLimiting
		{
			get;
			internal set;
		}

		public TwitterUserCollection()
		{
		}

		internal static TwitterUserCollection DeserializeWrapper(JObject value)
		{
			TwitterUserCollection twitterUserCollection;
			if ((value == null ? false : value.SelectToken("users") != null))
			{
				TwitterUserCollection twitterUserCollection1 = JsonConvert.DeserializeObject<TwitterUserCollection>(value.SelectToken("users").ToString());
				twitterUserCollection1.NextCursor = value.SelectToken("next_cursor_str").Value<long>();
				twitterUserCollection1.PreviousCursor = value.SelectToken("previous_cursor").Value<long>();
				twitterUserCollection = twitterUserCollection1;
			}
			else
			{
				twitterUserCollection = null;
			}
			return twitterUserCollection;
		}
	}
}