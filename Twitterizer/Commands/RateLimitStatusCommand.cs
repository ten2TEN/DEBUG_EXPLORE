using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class RateLimitStatusCommand : TwitterCommand<TwitterRateLimitStatus>
	{
		public string Resource
		{
			get;
			set;
		}

		public RateLimitStatusCommand(OAuthTokens requestTokens, string resource, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "application/rate_limit_status.json", requestTokens, options)
		{
			if (!string.IsNullOrEmpty(resource))
			{
				this.Resource = resource;
			}
			base.DeserializationHandler = new SerializationHelper<TwitterRateLimitStatus>.DeserializationHandler(TwitterRateLimitStatus.Deserialize);
		}

		public override void Init()
		{
			if (!string.IsNullOrEmpty(this.Resource))
			{
				base.RequestParameters.Add("resources", this.Resource);
			}
		}
	}
}