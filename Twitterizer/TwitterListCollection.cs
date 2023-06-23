using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterListCollection : TwitterCollection<TwitterList>, ITwitterObject
	{
		public int NextCursor
		{
			get;
			set;
		}

		public int PreviousCursor
		{
			get;
			set;
		}

		public Twitterizer.RateLimiting RateLimiting
		{
			get;
			set;
		}

		public TwitterListCollection()
		{
		}

		internal static TwitterListCollection Deserialize(JObject value)
		{
			TwitterListCollection twitterListCollection;
			if ((value == null || value.First == null ? false : value.First.First != null))
			{
				twitterListCollection = JsonConvert.DeserializeObject<TwitterListCollection>(value.First.First.ToString());
			}
			else
			{
				twitterListCollection = null;
			}
			return twitterListCollection;
		}
	}
}