using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal sealed class UpdateProfileCommand : TwitterCommand<TwitterUser>
	{
		public UpdateProfileCommand(OAuthTokens tokens, UpdateProfileOptions options) : base(HTTPVerb.POST, "account/update_profile.json", tokens, options)
		{
		}

		public override void Init()
		{
			base.RequestParameters.Add("include_entities", "true");
			UpdateProfileOptions optionalProperties = base.OptionalProperties as UpdateProfileOptions;
			if (optionalProperties != null)
			{
				base.RequestParameters.Add("name", optionalProperties.Name);
				base.RequestParameters.Add("description", optionalProperties.Description);
				base.RequestParameters.Add("location", optionalProperties.Location);
				base.RequestParameters.Add("url", optionalProperties.Url);
			}
		}
	}
}