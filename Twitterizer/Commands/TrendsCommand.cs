using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class TrendsCommand : TwitterCommand<TwitterTrendCollection>
	{
		public TrendsCommand(OAuthTokens tokens, int WOEID, LocalTrendsOptions options) : base(HTTPVerb.GET, string.Format(CultureInfo.InvariantCulture, "trends/place.json?id={0}", new object[] { WOEID }), tokens, options)
		{
		}

		public override void Init()
		{
			LocalTrendsOptions optionalProperties = base.OptionalProperties as LocalTrendsOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.ExcludeHashTags)
				{
					base.RequestParameters.Add("exclude", "hashtags");
				}
			}
		}
	}
}