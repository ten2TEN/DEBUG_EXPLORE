using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class FollowersCommand : TwitterCommand<TwitterUserCollection>
	{
		public FollowersCommand(OAuthTokens tokens, FollowersOptions options) : base(HTTPVerb.GET, "followers/list.json", tokens, options)
		{
			if ((tokens != null ? false : options == null))
			{
				throw new ArgumentException("You must provide an authorization token or specify a user.");
			}
			if ((tokens != null || options == null || !(options.UserId <= new decimal(0)) ? false : string.IsNullOrEmpty(options.ScreenName)))
			{
				throw new ArgumentException("Either a user id or screen name (but not both) must be supplied (using the options parameter) when called unauthorized.");
			}
			base.DeserializationHandler = new SerializationHelper<TwitterUserCollection>.DeserializationHandler(TwitterUserCollection.DeserializeWrapper);
		}

		public override void Init()
		{
			base.RequestParameters.Add("cursor", "-1");
			FollowersOptions optionalProperties = base.OptionalProperties as FollowersOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.UserId > new decimal(0))
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					decimal userId = optionalProperties.UserId;
					requestParameters.Add("user_id", userId.ToString(CultureInfo.CurrentCulture));
				}
				if (!string.IsNullOrEmpty(optionalProperties.ScreenName))
				{
					base.RequestParameters.Add("screen_name", optionalProperties.ScreenName);
				}
				if (optionalProperties.Cursor != (long)0)
				{
					Dictionary<string, object> str = base.RequestParameters;
					long cursor = optionalProperties.Cursor;
					str["cursor"] = cursor.ToString(CultureInfo.CurrentCulture);
				}
			}
		}
	}
}