using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[Serializable]
	internal sealed class GetListCommand : TwitterCommand<TwitterList>
	{
		public string Slug
		{
			get;
			set;
		}

		public GetListCommand(OAuthTokens requestTokens, string slug, Twitterizer.OptionalProperties options) : base(HTTPVerb.GET, "lists/show.json", requestTokens, options)
		{
			if (base.Tokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			this.Slug = slug;
		}

		public override void Init()
		{
			if (!string.IsNullOrEmpty(this.Slug))
			{
				base.RequestParameters.Add("slug", this.Slug);
			}
		}
	}
}