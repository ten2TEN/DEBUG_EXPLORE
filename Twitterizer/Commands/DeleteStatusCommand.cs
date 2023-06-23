using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class DeleteStatusCommand : TwitterCommand<TwitterStatus>
	{
		public decimal Id
		{
			get;
			set;
		}

		public DeleteStatusCommand(OAuthTokens tokens, decimal id, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.InvariantCulture, "statuses/destroy/{0}.json", new object[] { id }), tokens, options)
		{
			this.Id = id;
		}

		public override void Init()
		{
		}
	}
}