using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	internal class DestroyListSubscriber : TwitterCommand<TwitterList>
	{
		public decimal ListId
		{
			get;
			set;
		}

		public DestroyListSubscriber(OAuthTokens tokens, decimal listId, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "lists/subscribers/destroy.json", tokens, options)
		{
			this.ListId = listId;
		}

		public override void Init()
		{
			base.RequestParameters.Add("list_id", this.ListId.ToString());
		}
	}
}