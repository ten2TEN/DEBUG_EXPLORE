using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class ShowStatusCommand : TwitterCommand<TwitterStatus>
	{
		public ShowStatusCommand(OAuthTokens requestTokens, decimal statusId, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, string.Format(CultureInfo.InvariantCulture, "statuses/show/{0}.json", new object[] { statusId }), requestTokens, options)
		{
			if (statusId <= new decimal(0))
			{
				throw new ArgumentNullException("statusId");
			}
		}

		public override void Init()
		{
			base.RequestParameters.Add("include_entities", "true");
		}
	}
}