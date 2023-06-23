using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class PublicTimelineCommand : TwitterCommand<TwitterStatusCollection>
	{
		public PublicTimelineCommand(OAuthTokens tokens, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "statuses/public_timeline.json", tokens, options)
		{
		}

		public override void Init()
		{
			base.RequestParameters.Add("include_entities", "true");
		}
	}
}