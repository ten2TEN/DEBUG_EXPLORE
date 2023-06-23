using System;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	public static class TwitterSearch
	{
		public static TwitterResponse<TwitterSearchResultCollection> Search(OAuthTokens tokens, string query, SearchOptions options)
		{
			if (options == null)
			{
				options = new SearchOptions();
			}
			return CommandPerformer.PerformAction<TwitterSearchResultCollection>(new SearchCommand(tokens, query, options));
		}
	}
}