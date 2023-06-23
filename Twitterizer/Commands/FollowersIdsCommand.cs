using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal class FollowersIdsCommand : TwitterCommand<UserIdCollection>
	{
		public FollowersIdsCommand(OAuthTokens requestTokens, UsersIdsOptions options) : base(HTTPVerb.GET, string.Format(CultureInfo.CurrentCulture, "followers/ids.json", new object[0]), requestTokens, options)
		{
			if (requestTokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			base.DeserializationHandler = new SerializationHelper<UserIdCollection>.DeserializationHandler(UserIdCollection.DeserializeWrapper);
		}

		public override void Init()
		{
			UsersIdsOptions optionalProperties = base.OptionalProperties as UsersIdsOptions;
			if (optionalProperties != null)
			{
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
				base.RequestParameters.Add("cursor", (optionalProperties.Cursor > (long)0 ? optionalProperties.Cursor.ToString(CultureInfo.InvariantCulture) : "-1"));
			}
			else
			{
				base.RequestParameters.Add("cursor", "-1");
			}
		}
	}
}