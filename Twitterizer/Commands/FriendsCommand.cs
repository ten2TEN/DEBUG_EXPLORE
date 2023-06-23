using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class FriendsCommand : TwitterCommand<TwitterUserCollection>
	{
		public FriendsCommand(OAuthTokens tokens, FriendsOptions options) : base(HTTPVerb.GET, "statuses/friends.json", tokens, options)
		{
			base.DeserializationHandler = new SerializationHelper<TwitterUserCollection>.DeserializationHandler(TwitterUserCollection.DeserializeWrapper);
		}

		public override void Init()
		{
			base.RequestParameters.Add("cursor", "-1");
			FriendsOptions optionalProperties = base.OptionalProperties as FriendsOptions;
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