using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal class VerifyCredentialsCommand : TwitterCommand<TwitterUser>
	{
		public VerifyCredentialsCommand(OAuthTokens requestTokens, VerifyCredentialsOptions options) : base(HTTPVerb.GET, "account/verify_credentials.json", requestTokens, options)
		{
		}

		public override void Init()
		{
			VerifyCredentialsOptions optionalProperties = base.OptionalProperties as VerifyCredentialsOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.IncludeEntities)
				{
					base.RequestParameters.Add("include_entities", "true");
				}
			}
		}
	}
}