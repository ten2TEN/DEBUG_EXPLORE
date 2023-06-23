using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal sealed class DirectMessagesCommand : TwitterCommand<TwitterDirectMessageCollection>
	{
		public DirectMessagesCommand(OAuthTokens tokens, DirectMessagesOptions options) : base(HTTPVerb.GET, "direct_messages.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
		}

		public override void Init()
		{
			decimal sinceStatusId;
			int count;
			object str;
			DirectMessagesOptions optionalProperties = base.OptionalProperties as DirectMessagesOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.SinceStatusId > new decimal(0))
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					sinceStatusId = optionalProperties.SinceStatusId;
					requestParameters.Add("since_id", sinceStatusId.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.MaxStatusId > new decimal(0))
				{
					Dictionary<string, object> strs = base.RequestParameters;
					sinceStatusId = optionalProperties.MaxStatusId;
					strs.Add("max_id", sinceStatusId.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.Count > 0)
				{
					Dictionary<string, object> requestParameters1 = base.RequestParameters;
					count = optionalProperties.Count;
					requestParameters1.Add("count", count.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.IncludeEntites)
				{
					base.RequestParameters.Add("include_entities", "true");
				}
				Dictionary<string, object> strs1 = base.RequestParameters;
				if (optionalProperties.Page > 0)
				{
					count = optionalProperties.Page;
					str = count.ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					str = "1";
				}
				strs1.Add("page", str);
			}
			else
			{
				base.RequestParameters.Add("page", "1");
			}
		}
	}
}