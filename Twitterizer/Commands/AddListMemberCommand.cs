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
	internal class AddListMemberCommand : TwitterCommand<TwitterList>
	{
		public string OwnerScreenName
		{
			get;
			set;
		}

		public string Slug
		{
			get;
			set;
		}

		public decimal UserId
		{
			get;
			set;
		}

		public AddListMemberCommand(OAuthTokens requestTokens, string ownerUsername, string slug, decimal userId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "lists/members/create.json", requestTokens, options)
		{
			if (requestTokens == null)
			{
				throw new ArgumentNullException("requestTokens");
			}
			if (string.IsNullOrEmpty(ownerUsername))
			{
				throw new ArgumentNullException("ownerUsername");
			}
			if (string.IsNullOrEmpty(slug))
			{
				throw new ArgumentNullException("slug");
			}
			if (userId <= new decimal(0))
			{
				throw new ArgumentNullException("userId");
			}
			this.UserId = userId;
			this.OwnerScreenName = ownerUsername;
			this.Slug = slug;
		}

		public override void Init()
		{
			Dictionary<string, object> requestParameters = base.RequestParameters;
			decimal userId = this.UserId;
			requestParameters.Add("user_id", userId.ToString(CultureInfo.InvariantCulture.NumberFormat));
			base.RequestParameters.Add("slug", this.Slug);
			base.RequestParameters.Add("owner_screen_name", this.OwnerScreenName);
		}
	}
}