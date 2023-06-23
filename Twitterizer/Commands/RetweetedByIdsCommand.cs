using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal class RetweetedByIdsCommand : TwitterCommand<UserIdCollection>
	{
		public RetweetedByIdsCommand(OAuthTokens tokens, decimal statusId, RetweetedByIdsOptions options) : base(HTTPVerb.GET, string.Format("statuses/{0}/retweeted_by/ids.json", statusId), tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (statusId <= new decimal(0))
			{
				throw new ArgumentNullException("statusId", "Status ID is required.");
			}
		}

		public override void Init()
		{
			int count;
			RetweetedByIdsOptions optionalProperties = base.OptionalProperties as RetweetedByIdsOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.Count > 1)
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					count = optionalProperties.Count;
					requestParameters.Add("count", count.ToString());
				}
				if (optionalProperties.IncludeEntities)
				{
					base.RequestParameters.Add("include_entities", "true");
				}
				if (optionalProperties.TrimUser)
				{
					base.RequestParameters.Add("trim_user", "true");
				}
				if (optionalProperties.Page > 0)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					count = optionalProperties.Page;
					strs.Add("page", count.ToString());
				}
			}
			else
			{
				base.RequestParameters.Add("page", "1");
			}
		}
	}
}