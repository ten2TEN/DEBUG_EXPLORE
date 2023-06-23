using System;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class RetweetCommand : TwitterCommand<TwitterStatus>
	{
		private const string Path = "statuses/retweet/{0}.json";

		public RetweetCommand(OAuthTokens tokens, decimal statusId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.InvariantCulture, "statuses/retweet/{0}.json", new object[] { statusId }), tokens, options)
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