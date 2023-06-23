using System;
using System.Collections.Generic;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	internal class CreateListMembershipCommand : TwitterCommand<TwitterList>
	{
		private readonly decimal listId;

		public CreateListMembershipCommand(OAuthTokens tokens, decimal listId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "lists/subscribers/create.json", tokens, options)
		{
			if ((tokens == null ? true : !tokens.HasBothTokens))
			{
				throw new ArgumentNullException("tokens");
			}
			if (listId <= new decimal(0))
			{
				throw new ArgumentNullException("listId");
			}
			this.listId = listId;
		}

		public override void Init()
		{
			base.RequestParameters.Add("list_id", this.listId.ToString());
		}
	}
}