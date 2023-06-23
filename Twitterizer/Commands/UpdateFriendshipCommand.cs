using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class UpdateFriendshipCommand : TwitterCommand<TwitterRelationship>
	{
		private const string Path = "friendships/update.json";

		public decimal UserId
		{
			get;
			set;
		}

		public string UserName
		{
			get;
			set;
		}

		public UpdateFriendshipCommand(OAuthTokens tokens, decimal userId, UpdateFriendshipOptions optionalProperties) : base(HTTPVerb.POST, "friendships/update.json", tokens, optionalProperties)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (userId <= new decimal(0))
			{
				throw new ArgumentException("userId");
			}
			this.UserId = userId;
		}

		public UpdateFriendshipCommand(OAuthTokens tokens, string userName, UpdateFriendshipOptions optionalProperties) : base(HTTPVerb.POST, "friendships/update.json", tokens, optionalProperties)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (string.IsNullOrEmpty(userName))
			{
				throw new ArgumentNullException("userName");
			}
			this.UserName = userName;
		}

		public override void Init()
		{
			if (this.UserId > new decimal(0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				decimal userId = this.UserId;
				requestParameters.Add("user_id", userId.ToString(CultureInfo.InvariantCulture));
			}
			else if (!string.IsNullOrEmpty(this.UserName))
			{
				base.RequestParameters.Add("screen_name", this.UserName);
			}
			UpdateFriendshipOptions optionalProperties = base.OptionalProperties as UpdateFriendshipOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.DeviceNotifications.HasValue)
				{
					base.RequestParameters.Add("device", (optionalProperties.DeviceNotifications.Value ? "true" : "false"));
				}
				if (optionalProperties.ShowRetweets.HasValue)
				{
					base.RequestParameters.Add("retweets", (optionalProperties.ShowRetweets.Value ? "true" : "false"));
				}
			}
		}
	}
}