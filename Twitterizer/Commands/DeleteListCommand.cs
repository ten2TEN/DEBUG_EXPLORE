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
	internal sealed class DeleteListCommand : TwitterCommand<TwitterList>
	{
		public string Screen_name
		{
			get;
			set;
		}

		public string Slug
		{
			get;
			set;
		}

		public DeleteListCommand(OAuthTokens requestTokens, string screen_name, string slug, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.CurrentCulture, "lists/destroy.json", new object[] { screen_name, slug }), requestTokens, options)
		{
			if (base.Tokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			if (string.IsNullOrEmpty(screen_name))
			{
				throw new ArgumentNullException("screenName");
			}
			if (string.IsNullOrEmpty(slug))
			{
				throw new ArgumentNullException("Slug");
			}
			this.Slug = slug;
			this.Screen_name = screen_name;
		}

		public override void Init()
		{
			base.RequestParameters.Add("owner_screen_name", this.Screen_name);
			base.RequestParameters.Add("slug", this.Slug);
		}
	}
}