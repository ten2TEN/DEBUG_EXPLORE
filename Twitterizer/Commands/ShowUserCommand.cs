using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class ShowUserCommand : TwitterCommand<TwitterUser>
	{
		public decimal UserId
		{
			get;
			set;
		}

		public string Username
		{
			get;
			set;
		}

		public ShowUserCommand(OAuthTokens tokens, decimal userId, string username, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "users/show.json", tokens, options)
		{
			bool flag;
			if (!(userId <= new decimal(0)) || !string.IsNullOrEmpty(username))
			{
				flag = (userId <= new decimal(0) ? true : string.IsNullOrEmpty(username));
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new ArgumentException("Either userId or username must be supplied, but not both.");
			}
			this.UserId = userId;
			this.Username = username;
		}

		public override void Init()
		{
			if (this.UserId > new decimal(0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				decimal userId = this.UserId;
				requestParameters.Add("user_id", userId.ToString(CultureInfo.CurrentCulture));
			}
			if (!string.IsNullOrEmpty(this.Username))
			{
				base.RequestParameters.Add("screen_name", this.Username);
			}
		}
	}
}