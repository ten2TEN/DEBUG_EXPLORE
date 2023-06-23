using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal sealed class ListStatusesCommand : TwitterCommand<TwitterStatusCollection>
	{
		public string ListId
		{
			get;
			set;
		}

		public string Ownerscreenname
		{
			get;
			set;
		}

		public ListStatusesCommand(OAuthTokens requestTokens, string username, string slug, ListStatusesOptions options) : base(HTTPVerb.GET, "lists/statuses.json", requestTokens, options)
		{
			if (string.IsNullOrEmpty(username))
			{
				throw new ArgumentNullException("username");
			}
			if (string.IsNullOrEmpty(slug))
			{
				throw new ArgumentNullException("slug");
			}
			this.Ownerscreenname = username;
			this.ListId = slug;
		}

		public override void Init()
		{
			long sinceId;
			int itemsPerPage;
			object str;
			ListStatusesOptions optionalProperties = base.OptionalProperties as ListStatusesOptions;
			base.RequestParameters.Add("owner_screen_name", this.Ownerscreenname);
			base.RequestParameters.Add("slug", this.ListId);
			if (optionalProperties != null)
			{
				if (optionalProperties.SinceId > (long)0)
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					sinceId = optionalProperties.SinceId;
					requestParameters.Add("since_id", sinceId.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.MaxId > (long)0)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					sinceId = optionalProperties.MaxId;
					strs.Add("max_id", sinceId.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.ItemsPerPage > 0)
				{
					Dictionary<string, object> requestParameters1 = base.RequestParameters;
					itemsPerPage = optionalProperties.ItemsPerPage;
					requestParameters1.Add("per_page", itemsPerPage.ToString(CultureInfo.InvariantCulture));
				}
				if (optionalProperties.IncludeEntites)
				{
					base.RequestParameters.Add("include_entities", "true");
				}
				if (optionalProperties.IncludeRetweets)
				{
					base.RequestParameters.Add("include_rts", "true");
				}
				Dictionary<string, object> strs1 = base.RequestParameters;
				if (optionalProperties.Page > 0)
				{
					itemsPerPage = optionalProperties.Page;
					str = itemsPerPage.ToString(CultureInfo.InvariantCulture);
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