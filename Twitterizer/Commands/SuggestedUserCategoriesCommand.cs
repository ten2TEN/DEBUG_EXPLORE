using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal class SuggestedUserCategoriesCommand : TwitterCommand<TwitterUserCategoryCollection>
	{
		public SuggestedUserCategoriesCommand(OAuthTokens tokens, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "users/suggestions.json", tokens, options)
		{
		}

		public override void Init()
		{
		}
	}
}