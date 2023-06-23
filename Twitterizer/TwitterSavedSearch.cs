using System;
using System.Runtime.CompilerServices;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public sealed class TwitterSavedSearch : TwitterObject
	{
		public DateTime CreatedAt
		{
			get;
			set;
		}

		public decimal Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public int? Position
		{
			get;
			set;
		}

		public string Query
		{
			get;
			set;
		}

		public TwitterSavedSearch()
		{
		}

		public static TwitterResponse<TwitterSavedSearch> Create(OAuthTokens tokens, string query, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterSavedSearch>(new CreateSavedSearchCommand(tokens, query, options));
		}

		public static TwitterResponse<TwitterSavedSearch> Create(OAuthTokens tokens, string query)
		{
			return TwitterSavedSearch.Create(tokens, query, null);
		}

		public static TwitterResponse<TwitterSavedSearch> Delete(OAuthTokens tokens, decimal savedsearchId, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterSavedSearch>(new DeleteSavedSearchCommand(tokens, savedsearchId, options));
		}

		public static TwitterResponse<TwitterSavedSearch> Delete(OAuthTokens tokens, decimal savedsearchId)
		{
			return TwitterSavedSearch.Delete(tokens, savedsearchId, null);
		}

		public static TwitterResponse<TwitterSavedSearchCollection> SavedSearches(OAuthTokens tokens, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterSavedSearchCollection>(new SavedSearchesCommand(tokens, options));
		}

		public static TwitterResponse<TwitterSavedSearchCollection> SavedSearches(OAuthTokens tokens)
		{
			return TwitterSavedSearch.SavedSearches(tokens, null);
		}

		public static TwitterResponse<TwitterSavedSearchCollection> SavedSearches(OptionalProperties options)
		{
			return TwitterSavedSearch.SavedSearches(null, options);
		}
	}
}