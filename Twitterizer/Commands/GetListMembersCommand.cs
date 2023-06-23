using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal class GetListMembersCommand : TwitterCommand<TwitterUserCollection>
	{
		public string Slug
		{
			get;
			set;
		}

		public string Username
		{
			get;
			set;
		}

		public GetListMembersCommand(OAuthTokens requestTokens, string username, string slug, GetListMembersOptions options) : base(HTTPVerb.GET, "lists/members.json", requestTokens, options)
		{
			if (requestTokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			if (string.IsNullOrEmpty(username))
			{
				throw new ArgumentNullException("username");
			}
			if (string.IsNullOrEmpty(slug))
			{
				throw new ArgumentNullException("slug");
			}
			this.Slug = slug;
			this.Username = username;
			base.DeserializationHandler = new SerializationHelper<TwitterUserCollection>.DeserializationHandler(TwitterUserCollection.DeserializeWrapper);
		}

		public override void Init()
		{
			GetListMembersOptions optionalProperties = base.OptionalProperties as GetListMembersOptions;
			if (!string.IsNullOrEmpty(this.Slug))
			{
				base.RequestParameters.Add("slug", this.Slug);
			}
			if (!string.IsNullOrEmpty(this.Username))
			{
				base.RequestParameters.Add("owner_screen_name", this.Username);
			}
			if ((optionalProperties == null ? false : optionalProperties.Cursor != (long)0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				long cursor = optionalProperties.Cursor;
				requestParameters.Add("cursor", cursor.ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				base.RequestParameters.Add("cursor", "-1");
			}
		}
	}
}