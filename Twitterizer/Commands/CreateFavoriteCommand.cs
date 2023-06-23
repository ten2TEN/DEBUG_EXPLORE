using System;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class CreateFavoriteCommand : TwitterCommand<TwitterStatus>
	{
		public CreateFavoriteCommand(OAuthTokens tokens, decimal statusId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.InvariantCulture.NumberFormat, "favorites/create.json?id={0}", new object[] { statusId }), tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (statusId <= new decimal(0))
			{
				throw new ArgumentException("Status Id is required.");
			}
		}

		public override void Init()
		{
		}
	}
}