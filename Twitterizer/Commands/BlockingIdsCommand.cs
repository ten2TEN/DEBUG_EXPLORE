using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal class BlockingIdsCommand : TwitterCommand<TwitterIdCollection>
	{
		public BlockingIdsCommand(OAuthTokens tokens, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "blocks/ids.json", tokens, options)
		{
		}

		public override void Init()
		{
		}
	}
}