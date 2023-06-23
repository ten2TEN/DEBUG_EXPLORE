using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class RetweetsCommand : TwitterCommand<TwitterStatusCollection>
	{
		public decimal StatusId
		{
			get;
			set;
		}

		public RetweetsCommand(OAuthTokens tokens, decimal statusId, RetweetsOptions options) : base(HTTPVerb.GET, string.Format(CultureInfo.InvariantCulture, "statuses/retweets/{0}.json", new object[] { statusId }), tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (statusId <= new decimal(0))
			{
				throw new ArgumentNullException("statusId");
			}
			this.StatusId = statusId;
		}

		public override void Init()
		{
			Dictionary<string, object> requestParameters = base.RequestParameters;
			decimal statusId = this.StatusId;
			requestParameters.Add("id", statusId.ToString(CultureInfo.InvariantCulture));
			RetweetsOptions optionalProperties = base.OptionalProperties as RetweetsOptions;
			if (optionalProperties != null)
			{
				if (optionalProperties.Count > 0)
				{
					Dictionary<string, object> strs = base.RequestParameters;
					int count = optionalProperties.Count;
					strs.Add("count", count.ToString(CultureInfo.InvariantCulture));
				}
			}
		}
	}
}