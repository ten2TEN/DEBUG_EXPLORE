using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterCursorPagedIdCollection : Collection<decimal>, ITwitterObject
	{
		public Dictionary<string, string> Annotations
		{
			get;
			set;
		}

		public long NextCursor
		{
			get;
			set;
		}

		public long PreviousCursor
		{
			get;
			set;
		}

		public TwitterCursorPagedIdCollection()
		{
		}

		internal static TwitterCursorPagedIdCollection DeserializeWrapper(JObject value)
		{
			TwitterCursorPagedIdCollection twitterCursorPagedIdCollection;
			if ((value == null ? false : value.SelectToken("ids") != null))
			{
				TwitterCursorPagedIdCollection twitterCursorPagedIdCollection1 = JsonConvert.DeserializeObject<TwitterCursorPagedIdCollection>(value.SelectToken("ids").ToString());
				twitterCursorPagedIdCollection1.NextCursor = value.SelectToken("next_cursor_str").Value<long>();
				twitterCursorPagedIdCollection1.PreviousCursor = value.SelectToken("previous_cursor").Value<long>();
				twitterCursorPagedIdCollection = twitterCursorPagedIdCollection1;
			}
			else
			{
				twitterCursorPagedIdCollection = null;
			}
			return twitterCursorPagedIdCollection;
		}
	}
}