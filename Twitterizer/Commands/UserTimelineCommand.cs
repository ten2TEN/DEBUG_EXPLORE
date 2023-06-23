using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class UserTimelineCommand : PagedTimelineCommand
	{
		public UserTimelineCommand(OAuthTokens tokens, UserTimelineOptions options) : base(HTTPVerb.GET, "statuses/user_timeline.json", tokens, options)
		{
			if ((tokens != null ? false : options == null))
			{
				throw new ArgumentException("You must supply either OAuth tokens or identify a user in the TimelineOptions class.");
			}
			if ((options == null || tokens != null || !string.IsNullOrEmpty(options.ScreenName) ? false : options.UserId <= new decimal(0)))
			{
				throw new ArgumentException("You must specify a user's screen name or id for unauthorized requests.");
			}
		}

		public override void Init()
		{
			UserTimelineOptions optionalProperties = base.OptionalProperties as UserTimelineOptions;
			if (optionalProperties == null)
			{
				optionalProperties = new UserTimelineOptions();
			}
			TimelineOptions.Init<TwitterStatusCollection>(this, optionalProperties);
			if (optionalProperties.UserId > new decimal(0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				decimal userId = optionalProperties.UserId;
				requestParameters.Add("user_id", userId.ToString(CultureInfo.InvariantCulture.NumberFormat));
			}
			if (!string.IsNullOrEmpty(optionalProperties.ScreenName))
			{
				base.RequestParameters.Add("screen_name", optionalProperties.ScreenName);
			}
		}
	}
}