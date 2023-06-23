using System;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class DeleteSavedSearchCommand : TwitterCommand<TwitterSavedSearch>
	{
		public DeleteSavedSearchCommand(OAuthTokens tokens, decimal savedsearchId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.InvariantCulture.NumberFormat, "saved_searches/destroy/{0}.json", new object[] { savedsearchId }), tokens, options)
		{
			if (savedsearchId <= new decimal(0))
			{
				throw new ArgumentException("Saved Search Id is required.");
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