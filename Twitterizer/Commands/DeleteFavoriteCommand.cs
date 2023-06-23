using System;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class DeleteFavoriteCommand : TwitterCommand<TwitterStatus>
	{
		public DeleteFavoriteCommand(OAuthTokens tokens, decimal statusId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.InvariantCulture.NumberFormat, "favorites/destroy.json?id={0}", new object[] { statusId }), tokens, options)
		{
			if (statusId <= new decimal(0))
			{
				throw new ArgumentException("Status Id is required.");
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