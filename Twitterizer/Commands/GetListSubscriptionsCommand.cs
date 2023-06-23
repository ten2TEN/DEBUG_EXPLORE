using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal sealed class GetListSubscriptionsCommand : TwitterCommand<TwitterListCollection>
	{
		public GetListSubscriptionsCommand(OAuthTokens requestTokens, string userName, GetListSubscriptionsOptions options) : base(HTTPVerb.GET, string.Format("/lists/subscriptions.json", userName), requestTokens, options)
		{
			if (requestTokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			base.DeserializationHandler = new SerializationHelper<TwitterListCollection>.DeserializationHandler(TwitterListCollection.Deserialize);
		}

		public override void Init()
		{
			GetListSubscriptionsOptions optionalProperties = base.OptionalProperties as GetListSubscriptionsOptions;
			if ((optionalProperties == null ? false : optionalProperties.Cursor > (long)0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				long cursor = optionalProperties.Cursor;
				requestParameters.Add("cursor", cursor.ToString(CultureInfo.CurrentCulture));
			}
			else
			{
				base.RequestParameters.Add("cursor", "-1");
			}
		}
	}
}