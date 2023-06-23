using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal sealed class ListMembershipsCommand : TwitterCommand<TwitterListCollection>
	{
		private readonly string screenname;

		private readonly decimal userid;

		public ListMembershipsCommand(OAuthTokens requestTokens, string screenname, ListMembershipsOptions options) : base(HTTPVerb.GET, "lists/memberships.json", requestTokens, options)
		{
			if (string.IsNullOrEmpty(screenname))
			{
				throw new ArgumentNullException("screenname");
			}
			if (base.Tokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			base.DeserializationHandler = new SerializationHelper<TwitterListCollection>.DeserializationHandler(TwitterListCollection.Deserialize);
			this.screenname = screenname;
		}

		public ListMembershipsCommand(OAuthTokens requestTokens, decimal userid, ListMembershipsOptions options) : base(HTTPVerb.GET, "lists/memberships.json", requestTokens, options)
		{
			if (userid <= new decimal(0))
			{
				throw new ArgumentNullException("userid");
			}
			if (base.Tokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			base.DeserializationHandler = new SerializationHelper<TwitterListCollection>.DeserializationHandler(TwitterListCollection.Deserialize);
			this.userid = userid;
		}

		public override void Init()
		{
			if (!string.IsNullOrEmpty(this.screenname))
			{
				base.RequestParameters.Add("screen_name", this.screenname);
			}
			if (this.userid > new decimal(0))
			{
				base.RequestParameters.Add("user_id", this.userid.ToString());
			}
			ListMembershipsOptions optionalProperties = base.OptionalProperties as ListMembershipsOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.Cursor > (long)0)
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					long cursor = optionalProperties.Cursor;
					requestParameters.Add("cursor", cursor.ToString(CultureInfo.CurrentCulture));
				}
				else
				{
					base.RequestParameters.Add("cursor", "-1");
				}
				if (optionalProperties.FilterToOwnedLists)
				{
					base.RequestParameters.Add("filter_to_owned_lists", "true");
				}
			}
		}
	}
}