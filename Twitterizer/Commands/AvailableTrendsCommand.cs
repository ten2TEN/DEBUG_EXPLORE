using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class AvailableTrendsCommand : TwitterCommand<TwitterTrendLocationCollection>
	{
		public AvailableTrendsCommand(OAuthTokens tokens, AvailableTrendsOptions options) : base(HTTPVerb.GET, "trends/available.json", tokens, options)
		{
		}

		public override void Init()
		{
			double? lat;
			AvailableTrendsOptions optionalProperties = base.OptionalProperties as AvailableTrendsOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.Lat.HasValue)
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					lat = optionalProperties.Lat;
					requestParameters.Add("lat", lat.ToString());
				}
				if (optionalProperties.Long.HasValue)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					lat = optionalProperties.Long;
					strs.Add("long", lat.ToString());
				}
			}
		}
	}
}