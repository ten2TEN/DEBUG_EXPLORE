using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class UserIdCollection : TwitterIdCollection
	{
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

		public Twitterizer.RateLimiting RateLimiting
		{
			get;
			set;
		}

		public UserIdCollection()
		{
		}

		internal static UserIdCollection DeserializeWrapper(JObject value)
		{
			UserIdCollection userIdCollection;
			if ((value == null ? false : value.SelectToken("ids") != null))
			{
				decimal[] numArray = JsonConvert.DeserializeObject<decimal[]>(value.SelectToken("ids").ToString());
				UserIdCollection userIdCollection1 = new UserIdCollection()
				{
					NextCursor = value.SelectToken("next_cursor_str").Value<long>(),
					PreviousCursor = value.SelectToken("previous_cursor").Value<long>()
				};
				UserIdCollection userIdCollection2 = userIdCollection1;
				decimal[] numArray1 = numArray;
				for (int i = 0; i < (int)numArray1.Length; i++)
				{
					userIdCollection2.Add(numArray1[i]);
				}
				userIdCollection = userIdCollection2;
			}
			else
			{
				userIdCollection = null;
			}
			return userIdCollection;
		}
	}
}