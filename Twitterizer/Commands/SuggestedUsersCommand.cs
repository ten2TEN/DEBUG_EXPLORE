using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal class SuggestedUsersCommand : TwitterCommand<TwitterUserCategory>
	{
		public string Slug
		{
			get;
			set;
		}

		public SuggestedUsersCommand(OAuthTokens tokens, string categorySlug, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, string.Format("users/suggestions/{0}.json", categorySlug), tokens, options)
		{
			if (string.IsNullOrEmpty(categorySlug))
			{
				throw new ArgumentNullException("categorySlug", "A category slug is required");
			}
			this.Slug = categorySlug;
		}

		public override void Init()
		{
			base.RequestParameters.Add("slug", this.Slug);
		}
	}
}