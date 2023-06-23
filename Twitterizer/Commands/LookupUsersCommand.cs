using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class LookupUsersCommand : TwitterCommand<TwitterUserCollection>
	{
		public LookupUsersCommand(OAuthTokens tokens, LookupUsersOptions options) : base(HTTPVerb.GET, "users/lookup.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if ((options.ScreenNames.Count != 0 ? false : options.UserIds.Count == 0))
			{
				throw new ArgumentException("At least one screen name or user id must be specified.");
			}
		}

		public override void Init()
		{
			LookupUsersOptions optionalProperties = base.OptionalProperties as LookupUsersOptions;
			if (optionalProperties == null)
			{
				throw new NullReferenceException("The optional parameters class is not valid for this command.");
			}
			if (optionalProperties.UserIds.Count > 0)
			{
				base.RequestParameters.Add("user_id", string.Join(",", (
					from id in optionalProperties.UserIds
					where id > new decimal(0)
					select id.ToString()).ToArray<string>()));
			}
			if (optionalProperties.ScreenNames.Count > 0)
			{
				base.RequestParameters.Add("screen_name", string.Join(",", optionalProperties.ScreenNames.ToArray<string>()));
			}
			if (optionalProperties.IncludeEntities)
			{
				base.RequestParameters.Add("include_entities", "true");
			}
		}
	}
}