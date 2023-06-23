using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterRelationshipUser : TwitterObject
	{
		[JsonProperty(PropertyName="all_replies")]
		public bool? AllReplies
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="blocking")]
		public bool? Blocking
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="can_dm")]
		public bool CanDM
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="followed_by")]
		public bool FollowedBy
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="following")]
		public bool Following
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="id")]
		public decimal Id
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="marked_spam")]
		public bool? MarkedSpam
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="notifications_enabled")]
		public bool? NotificationsEnabled
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="screen_name")]
		public string ScreenName
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="want_retweets")]
		public bool? WantRetweets
		{
			get;
			set;
		}

		public TwitterRelationshipUser()
		{
		}
	}
}