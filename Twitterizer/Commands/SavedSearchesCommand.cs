using System;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class SavedSearchesCommand : TwitterCommand<TwitterSavedSearchCollection>
	{
		public SavedSearchesCommand(OAuthTokens tokens, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "saved_searches/list.json", tokens, options)
		{
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