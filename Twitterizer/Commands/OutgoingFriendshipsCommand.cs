using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal sealed class OutgoingFriendshipsCommand : TwitterCommand<TwitterCursorPagedIdCollection>
	{
		public OutgoingFriendshipsCommand(OAuthTokens tokens, OutgoingFriendshipsOptions options) : base(HTTPVerb.GET, "friendships/outgoing.json", tokens, options)
		{
			base.DeserializationHandler = new SerializationHelper<TwitterCursorPagedIdCollection>.DeserializationHandler(TwitterCursorPagedIdCollection.DeserializeWrapper);
		}

		public override void Init()
		{
			OutgoingFriendshipsOptions optionalProperties = base.OptionalProperties as OutgoingFriendshipsOptions;
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