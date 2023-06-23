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
	internal sealed class DeleteFriendshipCommand : TwitterCommand<TwitterUser>
	{
		private const string Path = "friendships/destroy.json";

		public decimal UserId
		{
			get;
			internal set;
		}

		public string UserName
		{
			get;
			internal set;
		}

		public DeleteFriendshipCommand(OAuthTokens tokens, decimal userId, string userName, Twitterizer.OptionalProperties optionalProperties) : base(HTTPVerb.POST, "friendships/destroy.json", tokens, optionalProperties)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if ((userId > new decimal(0) ? false : string.IsNullOrEmpty(userName)))
			{
				throw new ArgumentException("User ID or screen name is required.");
			}
			this.UserName = userName;
			this.UserId = userId;
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
		}
	}
}