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
	internal sealed class CreateFriendshipCommand : TwitterCommand<TwitterUser>
	{
		private const string Path = "friendships/create.json";

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

		public CreateFriendshipCommand(OAuthTokens tokens, decimal userId, CreateFriendshipOptions optionalProperties) : base(HTTPVerb.POST, "friendships/create.json", tokens, optionalProperties)
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

		public CreateFriendshipCommand(OAuthTokens tokens, string userName, CreateFriendshipOptions optionalProperties) : base(HTTPVerb.POST, "friendships/create.json", tokens, optionalProperties)
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
			CreateFriendshipOptions optionalProperties = base.OptionalProperties as CreateFriendshipOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.Follow)
				{
					base.RequestParameters.Add("follow", "true");
				}
			}
		}
	}
}