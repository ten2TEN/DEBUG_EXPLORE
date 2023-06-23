using System;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal sealed class RelatedResultsCommand : TwitterCommand<TwitterRelatedTweetsCollection>
	{
		private const string Path = "related_results/show/{0}.json";

		public RelatedResultsCommand(OAuthTokens tokens, decimal statusId, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, string.Format(CultureInfo.InvariantCulture, "related_results/show/{0}.json", new object[] { statusId }), tokens, options)
		{
			if (statusId <= new decimal(0))
			{
				throw new ArgumentException("Status ID is invalid", "statusId");
			}
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
		}

		public override void Init()
		{
		}
	}
}