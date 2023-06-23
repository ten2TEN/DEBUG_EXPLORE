using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[DataContract]
	[DebuggerDisplay("@{ScreenName}")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterUser : TwitterObject
	{
		[DataMember]
		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="created_at")]
		public DateTime? CreatedDate
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="description")]
		public string Description
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="notifications")]
		public bool? DoesReceiveNotifications
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="follow_request_sent")]
		public bool? FollowRequestSent
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="id")]
		public decimal Id
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="contributors_enabled")]
		public bool IsContributorsEnabled
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="followed_by")]
		public bool? IsFollowedBy
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="following")]
		public bool? IsFollowing
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="geo_enabled")]
		public bool? IsGeoEnabled
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_background_tile")]
		public bool? IsProfileBackgroundTiled
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="protected")]
		public bool IsProtected
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="lang")]
		public string Language
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="listed_count")]
		public int ListedCount
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="location")]
		public string Location
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="name")]
		public string Name
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="favourites_count")]
		public long NumberOfFavorites
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="followers_count")]
		public long? NumberOfFollowers
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="friends_count")]
		public long NumberOfFriends
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="statuses_count")]
		public long NumberOfStatuses
		{
			get;
			set;
		}

		[DataMember]
		public Color ProfileBackgroundColor
		{
			get
			{
				return ConversionUtility.FromTwitterString(this.ProfileBackgroundColorString);
			}
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_background_color")]
		public string ProfileBackgroundColorString
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_background_image_url")]
		public string ProfileBackgroundImageLocation
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_image_url")]
		public string ProfileImageLocation
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_image_url_https")]
		public string ProfileImageSecureLocation
		{
			get;
			set;
		}

		[DataMember]
		public Color ProfileLinkColor
		{
			get
			{
				return ConversionUtility.FromTwitterString(this.ProfileLinkColorString);
			}
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_link_color")]
		public string ProfileLinkColorString
		{
			get;
			set;
		}

		[DataMember]
		public Color ProfileSidebarBorderColor
		{
			get
			{
				return ConversionUtility.FromTwitterString(this.ProfileSidebarBorderColorString);
			}
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_sidebar_border_color")]
		public string ProfileSidebarBorderColorString
		{
			get;
			set;
		}

		[DataMember]
		public Color ProfileTextColor
		{
			get
			{
				return ConversionUtility.FromTwitterString(this.ProfileTextColorString);
			}
		}

		[DataMember]
		[JsonProperty(PropertyName="profile_text_color")]
		public string ProfileTextColorString
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="screen_name")]
		public string ScreenName
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="status")]
		public TwitterStatus Status
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="str_id")]
		public string StringId
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="time_zone")]
		public string TimeZone
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="utc_offset")]
		public double? TimeZoneOffset
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="verified")]
		public bool? Verified
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="url")]
		public string Website
		{
			get;
			set;
		}

		public TwitterUser()
		{
		}

		public static TwitterResponse<TwitterUserCollection> Lookup(OAuthTokens tokens, LookupUsersOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUserCollection>(new LookupUsersCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUserCollection> RetweetedBy(OAuthTokens tokens, decimal statusId, RetweetedByOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUserCollection>(new RetweetedByCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterUserCollection> RetweetedBy(OAuthTokens tokens, decimal statusId)
		{
			return TwitterUser.RetweetedBy(tokens, statusId, null);
		}

		public static TwitterResponse<UserIdCollection> RetweetedByIds(OAuthTokens tokens, decimal statusId, RetweetedByIdsOptions options)
		{
			return CommandPerformer.PerformAction<UserIdCollection>(new RetweetedByIdsCommand(tokens, statusId, options));
		}

		public static TwitterResponse<UserIdCollection> RetweetedByIds(OAuthTokens tokens, decimal statusId)
		{
			return TwitterUser.RetweetedByIds(tokens, statusId, null);
		}

		public static TwitterResponse<TwitterUserCollection> Search(OAuthTokens tokens, string query, UserSearchOptions options)
		{
			return CommandPerformer.PerformAction<TwitterUserCollection>(new UserSearchCommand(tokens, query, options));
		}

		public static TwitterResponse<TwitterUserCollection> Search(OAuthTokens tokens, string query)
		{
			return TwitterUser.Search(tokens, query, null);
		}

		public static TwitterResponse<TwitterUser> Show(OAuthTokens tokens, decimal id, OptionalProperties options)
		{
			ShowUserCommand showUserCommand = new ShowUserCommand(tokens, id, string.Empty, options);
			return CommandPerformer.PerformAction<TwitterUser>(showUserCommand);
		}

		public static TwitterResponse<TwitterUser> Show(decimal id, OptionalProperties options)
		{
			return TwitterUser.Show(null, id, options);
		}

		public static TwitterResponse<TwitterUser> Show(OAuthTokens tokens, decimal id)
		{
			return TwitterUser.Show(tokens, id, null);
		}

		public static TwitterResponse<TwitterUser> Show(decimal id)
		{
			return TwitterUser.Show(null, id, null);
		}

		public static TwitterResponse<TwitterUser> Show(OAuthTokens tokens, string username, OptionalProperties options)
		{
			ShowUserCommand showUserCommand = new ShowUserCommand(tokens, new decimal(0), username, options);
			return CommandPerformer.PerformAction<TwitterUser>(showUserCommand);
		}

		public static TwitterResponse<TwitterUser> Show(string username, OptionalProperties options)
		{
			return TwitterUser.Show(null, username, options);
		}

		public static TwitterResponse<TwitterUser> Show(OAuthTokens tokens, string username)
		{
			return TwitterUser.Show(tokens, username, null);
		}

		public static TwitterResponse<TwitterUser> Show(string username)
		{
			return TwitterUser.Show(null, username, null);
		}
	}
}