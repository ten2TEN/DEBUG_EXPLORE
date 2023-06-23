using System;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	public class TwitterSpam
	{
		public TwitterSpam()
		{
		}

		public static TwitterResponse<TwitterUser> ReportUser(OAuthTokens tokens, decimal userId, OptionalProperties options)
		{
			ReportSpamCommand reportSpamCommand = new ReportSpamCommand(tokens, userId, string.Empty, options);
			return CommandPerformer.PerformAction<TwitterUser>(reportSpamCommand);
		}

		public static TwitterResponse<TwitterUser> ReportUser(OAuthTokens tokens, decimal userId)
		{
			return TwitterSpam.ReportUser(tokens, userId, null);
		}

		public static TwitterResponse<TwitterUser> ReportUser(OAuthTokens tokens, string screenName, OptionalProperties options)
		{
			ReportSpamCommand reportSpamCommand = new ReportSpamCommand(tokens, new decimal(0), screenName, options);
			return CommandPerformer.PerformAction<TwitterUser>(reportSpamCommand);
		}

		public static TwitterResponse<TwitterUser> ReportUser(OAuthTokens tokens, string screenName)
		{
			return TwitterSpam.ReportUser(tokens, screenName, null);
		}
	}
}