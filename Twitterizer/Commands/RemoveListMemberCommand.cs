using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal class RemoveListMemberCommand : TwitterCommand<TwitterList>
	{
		public string OwnerScreenname
		{
			get;
			set;
		}

		public string Screenname
		{
			get;
			set;
		}

		public string Slug
		{
			get;
			set;
		}

		public RemoveListMemberCommand(OAuthTokens requestTokens, string Owner, string slug, string screen_name, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "lists/members/destroy.json", requestTokens, options)
		{
			if (requestTokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			this.Screenname = screen_name;
			this.Slug = slug;
			this.OwnerScreenname = Owner;
		}

		public override void Init()
		{
			base.RequestParameters.Add("slug", this.Slug);
			base.RequestParameters.Add("screen_name", this.Screenname);
			base.RequestParameters.Add("owner_screen_name", this.OwnerScreenname);
		}
	}
}