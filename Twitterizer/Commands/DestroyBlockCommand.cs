using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal class DestroyBlockCommand : TwitterCommand<TwitterUser>
	{
		public string ScreenName
		{
			get;
			set;
		}

		public decimal UserId
		{
			get;
			set;
		}

		public DestroyBlockCommand(OAuthTokens tokens, string screenName, decimal userId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "blocks/destroy.json", tokens, options)
		{
			if ((!string.IsNullOrEmpty(screenName) ? false : userId <= new decimal(0)))
			{
				throw new ArgumentException("A screen name or user id is required.");
			}
			this.ScreenName = screenName;
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
			else if (!string.IsNullOrEmpty(this.ScreenName))
			{
				base.RequestParameters.Add("screen_name", this.ScreenName);
			}
			base.RequestParameters.Add("include_entities", "true");
		}
	}
}