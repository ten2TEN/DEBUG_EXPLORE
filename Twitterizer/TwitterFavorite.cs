using System;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public sealed class TwitterFavorite : TwitterObject
	{
		public TwitterFavorite()
		{
		}

		public static TwitterResponse<TwitterStatus> Create(OAuthTokens tokens, decimal statusId, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterStatus>(new CreateFavoriteCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterStatus> Create(OAuthTokens tokens, decimal statusId)
		{
			return TwitterFavorite.Create(tokens, statusId, null);
		}

		public static TwitterResponse<TwitterStatus> Delete(OAuthTokens tokens, decimal statusId, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterStatus>(new DeleteFavoriteCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterStatus> Delete(OAuthTokens tokens, decimal statusId)
		{
			return TwitterFavorite.Delete(tokens, statusId, null);
		}

		public static TwitterResponse<TwitterStatusCollection> List(OAuthTokens tokens, ListFavoritesOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new ListFavoritesCommand(tokens, options));
		}

		public static TwitterResponse<TwitterStatusCollection> List(OAuthTokens tokens)
		{
			return TwitterFavorite.List(tokens, null);
		}

		public static TwitterResponse<TwitterStatusCollection> List(ListFavoritesOptions options)
		{
			return TwitterFavorite.List(null, options);
		}
	}
}