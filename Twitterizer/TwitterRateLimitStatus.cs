using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Commands;
using Twitterizer.Core;
using Twitterizer.RateLimitStatus;

namespace Twitterizer
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterRateLimitStatus : TwitterObject
	{
		[JsonProperty(PropertyName="account")]
		public RateLimitAccount Account
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="application")]
		public RateLimitApplication Application
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="blocks")]
		public RateLimitBlock Blocks
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="direct_messages")]
		public RateLimitDirectMessage DirectMessages
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="favorites")]
		public RateLimitFavorites Favorites
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="followers")]
		public RateLimitFollowers Followers
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="friends")]
		public RateLimitFriends Friends
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="friendships")]
		public RateLimitFriendShips FriendShips
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="geo")]
		public RateLimitGeo Geo
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="lists")]
		public RateLimitLists Lists
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="saved_searches")]
		public RateLimitSavedSearches SavedSearches
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="search")]
		public RateLimitSearch Search
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="statuses")]
		public RateLimitStatuses Statuses
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="trends")]
		public RateLimitTrends Trends
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="users")]
		public RateLimitUsers Users
		{
			get;
			set;
		}

		public TwitterRateLimitStatus()
		{
		}

		internal static TwitterRateLimitStatus Deserialize(JObject value)
		{
			TwitterRateLimitStatus twitterRateLimitStatu;
			if ((value == null ? false : value["resources"] != null))
			{
				TwitterRateLimitStatus twitterRateLimitStatu1 = JsonConvert.DeserializeObject<TwitterRateLimitStatus>(value["resources"].ToString());
				twitterRateLimitStatu = twitterRateLimitStatu1;
			}
			else
			{
				twitterRateLimitStatu = null;
			}
			return twitterRateLimitStatu;
		}

		public static TwitterResponse<TwitterRateLimitStatus> GetStatus(OAuthTokens tokens, string resource, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterRateLimitStatus>(new RateLimitStatusCommand(tokens, resource, options));
		}

		public static TwitterResponse<TwitterRateLimitStatus> GetStatus(OAuthTokens tokens)
		{
			return TwitterRateLimitStatus.GetStatus(tokens, null, null);
		}
	}
}