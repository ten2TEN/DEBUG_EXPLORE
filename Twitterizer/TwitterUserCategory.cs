using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Commands;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterUserCategory : TwitterObject
	{
		[JsonProperty(PropertyName="name")]
		public string Name
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="size")]
		public int NumberOfUsers
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="slug")]
		public string Slug
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="users")]
		public TwitterUserCollection Users
		{
			get;
			set;
		}

		public TwitterUserCategory()
		{
		}

		public static TwitterResponse<TwitterUserCategoryCollection> SuggestedUserCategories(OAuthTokens tokens, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterUserCategoryCollection>(new SuggestedUserCategoriesCommand(tokens, options));
		}

		public static TwitterResponse<TwitterUserCategoryCollection> SuggestedUserCategories(OAuthTokens tokens)
		{
			return TwitterUserCategory.SuggestedUserCategories(tokens, null);
		}

		public static TwitterResponse<TwitterUserCategory> SuggestedUsers(OAuthTokens tokens, string categorySlug, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterUserCategory>(new SuggestedUsersCommand(tokens, categorySlug, options));
		}

		public static TwitterResponse<TwitterUserCategory> SuggestedUsers(OAuthTokens tokens, string categorySlug)
		{
			return TwitterUserCategory.SuggestedUsers(tokens, categorySlug, null);
		}
	}
}