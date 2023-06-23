using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal class IncomingFriendshipsCommand : TwitterCommand<TwitterCursorPagedIdCollection>
	{
		public IncomingFriendshipsCommand(OAuthTokens tokens, IncomingFriendshipsOptions options) : base(HTTPVerb.GET, "friendships/incoming.json", tokens, options)
		{
			base.DeserializationHandler = new SerializationHelper<TwitterCursorPagedIdCollection>.DeserializationHandler(TwitterCursorPagedIdCollection.DeserializeWrapper);
		}

		public override void Init()
		{
			IncomingFriendshipsOptions optionalProperties = base.OptionalProperties as IncomingFriendshipsOptions;
			if ((optionalProperties == null ? false : optionalProperties.Cursor != (long)0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				long cursor = optionalProperties.Cursor;
				requestParameters.Add("Cursor", cursor.ToString(CultureInfo.CurrentCulture));
			}
			else
			{
				base.RequestParameters.Add("cursor", "-1");
			}
		}
	}
}