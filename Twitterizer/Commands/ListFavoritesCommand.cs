using System;
using System.Collections.Generic;
using System.Globalization;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class ListFavoritesCommand : TwitterCommand<TwitterStatusCollection>
	{
		public ListFavoritesCommand(OAuthTokens tokens, ListFavoritesOptions options) : base(HTTPVerb.GET, "favorites/list.json", tokens, options)
		{
			bool flag;
			if (tokens != null)
			{
				flag = true;
			}
			else
			{
				flag = (options == null ? false : !string.IsNullOrEmpty(options.UserNameOrId));
			}
			if (!flag)
			{
				throw new ArgumentException("Valid tokens or user must be supplied.");
			}
		}

		public override void Init()
		{
			int page;
			decimal sinceStatusId;
			object str;
			base.RequestParameters.Add("include_entities", "true");
			ListFavoritesOptions optionalProperties = base.OptionalProperties as ListFavoritesOptions;
			if (optionalProperties != null)
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				if (optionalProperties.Page > 0)
				{
					page = optionalProperties.Page;
					str = page.ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					str = "1";
				}
				requestParameters.Add("page", str);
				if (!string.IsNullOrEmpty(optionalProperties.UserNameOrId))
				{
					base.RequestParameters.Add("id", optionalProperties.UserNameOrId);
				}
				if (optionalProperties.Count > 0)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					page = optionalProperties.Count;
					strs.Add("count", page.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.SinceStatusId > new decimal(0))
				{
					Dictionary<string, object> requestParameters1 = base.RequestParameters;
					sinceStatusId = optionalProperties.SinceStatusId;
					requestParameters1.Add("since_id", sinceStatusId.ToString());
				}
				if (optionalProperties.MaxStatusId > new decimal(0))
				{
					Dictionary<string, object> strs1 = base.RequestParameters;
					sinceStatusId = optionalProperties.MaxStatusId;
					strs1.Add("max_id", sinceStatusId.ToString());
				}
			}
			else
			{
				base.RequestParameters.Add("page", "1");
			}
		}
	}
}