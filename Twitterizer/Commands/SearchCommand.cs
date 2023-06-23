using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class SearchCommand : TwitterCommand<TwitterSearchResultCollection>
	{
		public string Query
		{
			get;
			set;
		}

		public SearchCommand(OAuthTokens requestTokens, string query, SearchOptions options) : base(HTTPVerb.GET, "tweets.json", requestTokens, options)
		{
			if (string.IsNullOrEmpty(query))
			{
				throw new ArgumentNullException("query");
			}
			this.Query = query;
			base.DeserializationHandler = new SerializationHelper<TwitterSearchResultCollection>.DeserializationHandler(TwitterSearchResultCollection.Deserialize);
		}

		public override void Init()
		{
			decimal maxId;
			int numberPerPage;
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
			base.RequestParameters.Add("q", this.Query);
			SearchOptions optionalProperties = base.OptionalProperties as SearchOptions;
			if (optionalProperties != null)
			{
				if (!string.IsNullOrEmpty(optionalProperties.Language))
				{
					base.RequestParameters.Add("lang", optionalProperties.Language);
				}
				if (!string.IsNullOrEmpty(optionalProperties.Locale))
				{
					base.RequestParameters.Add("locale", optionalProperties.Locale);
				}
				if (optionalProperties.MaxId > new decimal(0))
				{
					Dictionary<string, object> requestParameters = base.RequestParameters;
					maxId = optionalProperties.MaxId;
					requestParameters.Add("max_id", maxId.ToString(cultureInfo));
				}
				if (optionalProperties.NumberPerPage > 0)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					numberPerPage = optionalProperties.NumberPerPage;
					strs.Add("count", numberPerPage.ToString(cultureInfo));
				}
				if (optionalProperties.PageNumber > 0)
				{
					Dictionary<string, object> requestParameters1 = base.RequestParameters;
					numberPerPage = optionalProperties.PageNumber;
					requestParameters1.Add("page", numberPerPage.ToString(cultureInfo));
				}
				DateTime sinceDate = optionalProperties.SinceDate;
				DateTime untilDate = new DateTime();
				if (sinceDate > untilDate)
				{
					Dictionary<string, object> strs1 = base.RequestParameters;
					untilDate = optionalProperties.SinceDate;
					strs1.Add("since", untilDate.ToString("yyyy-MM-dd", cultureInfo));
				}
				if (optionalProperties.SinceId > new decimal(0))
				{
					Dictionary<string, object> requestParameters2 = base.RequestParameters;
					maxId = optionalProperties.SinceId;
					requestParameters2.Add("since_id", maxId.ToString(cultureInfo));
				}
				if (!string.IsNullOrEmpty(optionalProperties.GeoCode))
				{
					base.RequestParameters.Add("geocode", optionalProperties.GeoCode);
				}
				if (optionalProperties.PrefixUsername)
				{
					base.RequestParameters.Add("show_user", "true");
				}
				DateTime dateTime = optionalProperties.UntilDate;
				untilDate = new DateTime();
				if (dateTime > untilDate)
				{
					Dictionary<string, object> strs2 = base.RequestParameters;
					untilDate = optionalProperties.UntilDate;
					strs2.Add("until", untilDate.ToString("{0:yyyy-MM-dd}", cultureInfo));
				}
				switch (optionalProperties.ResultType)
				{
					case SearchOptionsResultType.Mixed:
					{
						base.RequestParameters.Add("result_type", "mixed");
						break;
					}
					case SearchOptionsResultType.Recent:
					{
						base.RequestParameters.Add("result_type", "recent");
						break;
					}
					case SearchOptionsResultType.Popular:
					{
						base.RequestParameters.Add("result_type", "popular");
						break;
					}
				}
				if (optionalProperties.WithTwitterUserID)
				{
					base.RequestParameters.Add("with_twitter_user_id", "true");
				}
				if (optionalProperties.IncludeEntities)
				{
					base.RequestParameters.Add("include_entities", "true");
				}
			}
		}
	}
}