using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal sealed class ShowDirectMessageCommand : TwitterCommand<TwitterDirectMessage>
	{
		internal ShowDirectMessageCommand(OAuthTokens tokens, decimal id, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, string.Format("direct_messages/{0}.json", id), tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens", "The tokens parameter is required.");
			}
			if (id <= new decimal(0))
			{
				throw new ArgumentOutOfRangeException("id", "The id parameter must be greater than zero.");
			}
		}

		public override void Init()
		{
		}
	}
}