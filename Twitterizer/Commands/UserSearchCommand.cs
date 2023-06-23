using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal sealed class UserSearchCommand : TwitterCommand<TwitterUserCollection>
	{
		public string Query
		{
			get;
			set;
		}

		public UserSearchCommand(OAuthTokens tokens, string query, UserSearchOptions options) : base(HTTPVerb.GET, "users/search.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (string.IsNullOrEmpty(query))
			{
				throw new ArgumentNullException("query");
			}
			this.Query = query;
		}

		public override void Init()
		{
			int numberPerPage;
			object str;
			base.RequestParameters.Add("q", this.Query);
			UserSearchOptions optionalProperties = base.OptionalProperties as UserSearchOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.NumberPerPage > 0)
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					numberPerPage = optionalProperties.NumberPerPage;
					requestParameters.Add("per_page", numberPerPage.ToString(CultureInfo.InvariantCulture));
				}
				Dictionary<string, object> strs = base.RequestParameters;
				if (optionalProperties.Page > 0)
				{
					numberPerPage = optionalProperties.Page;
					str = numberPerPage.ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					str = "1";
				}
				strs.Add("page", str);
			}
			else
			{
				base.RequestParameters.Add("page", "1");
			}
		}
	}
}