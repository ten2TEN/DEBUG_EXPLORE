using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterSearchResultCollection : TwitterCollection<TwitterSearchResult>, ITwitterObject
	{
		public double CompletedIn
		{
			get;
			internal set;
		}

		public long MaxId
		{
			get;
			internal set;
		}

		public string MaxIdStr
		{
			get;
			internal set;
		}

		public string Query
		{
			get;
			internal set;
		}

		public string RefreshUrl
		{
			get;
			internal set;
		}

		public TwitterSearchResultCollection()
		{
		}

		internal static TwitterSearchResultCollection Deserialize(JObject value)
		{
			TwitterSearchResultCollection twitterSearchResultCollection;
			if ((value == null ? false : value["statuses"] != null))
			{
				TwitterSearchResultCollection twitterSearchResultCollection1 = JsonConvert.DeserializeObject<TwitterSearchResultCollection>(value["statuses"].ToString());
				twitterSearchResultCollection1.CompletedIn = value.SelectToken("search_metadata.completed_in").Value<double>();
				twitterSearchResultCollection1.MaxId = value.SelectToken("search_metadata.max_id").Value<long>();
				twitterSearchResultCollection1.MaxIdStr = value.SelectToken("search_metadata.max_id_str").Value<string>();
				twitterSearchResultCollection1.Query = value.SelectToken("search_metadata.query").Value<string>();
				twitterSearchResultCollection = twitterSearchResultCollection1;
			}
			else
			{
				twitterSearchResultCollection = null;
			}
			return twitterSearchResultCollection;
		}
	}
}