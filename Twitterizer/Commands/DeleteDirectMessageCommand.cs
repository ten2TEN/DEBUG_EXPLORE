using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Twitterizer;
using Twitterizer.Core;

namespace Twitterizer.Commands
{
	[AuthorizedCommand]
	[Serializable]
	internal sealed class DeleteDirectMessageCommand : TwitterCommand<TwitterDirectMessage>
	{
		public decimal Id
		{
			get;
			set;
		}

		public DeleteDirectMessageCommand(OAuthTokens tokens, decimal id, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, string.Format(CultureInfo.InvariantCulture, "direct_messages/destroy.json?id={0}", new object[] { id }), tokens, options)
		{
			if (id <= new decimal(0))
			{
				throw new ArgumentException("The message id is invalid", "id");
			}
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			this.Id = id;
		}

		public override void Init()
		{
		}
	}
}