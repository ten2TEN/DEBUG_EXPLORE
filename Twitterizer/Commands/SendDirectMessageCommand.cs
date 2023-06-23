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
	internal sealed class SendDirectMessageCommand : TwitterCommand<TwitterDirectMessage>
	{
		public decimal RecipientUserId
		{
			get;
			set;
		}

		public string RecipientUserName
		{
			get;
			set;
		}

		public string Text
		{
			get;
			set;
		}

		public SendDirectMessageCommand(OAuthTokens tokens, string text, decimal userId, Twitterizer.OptionalProperties options) : this(tokens, text, options)
		{
			if (userId <= new decimal(0))
			{
				throw new ArgumentException("User Id must be supplied", "userId");
			}
			this.RecipientUserId = userId;
		}

		public SendDirectMessageCommand(OAuthTokens tokens, string text, string userName, Twitterizer.OptionalProperties options) : this(tokens, text, options)
		{
			if (string.IsNullOrEmpty(userName))
			{
				throw new ArgumentNullException("userName");
			}
			this.RecipientUserName = userName;
		}

		private SendDirectMessageCommand(OAuthTokens tokens, string text, Twitterizer.OptionalProperties options) : base(HTTPVerb.POST, "direct_messages/new.json", tokens, options)
		{
			if (tokens == null)
			{
				throw new ArgumentNullException("tokens");
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentNullException("text");
			}
			this.Text = text;
		}

		public override void Init()
		{
			base.RequestParameters.Add("text", this.Text);
			if (this.RecipientUserId > new decimal(0))
			{
				Dictionary<string, object> requestParameters = base.RequestParameters;
				decimal recipientUserId = this.RecipientUserId;
				requestParameters.Add("user_id", recipientUserId.ToString(CultureInfo.InvariantCulture));
			}
			if ((string.IsNullOrEmpty(this.RecipientUserName) ? false : this.RecipientUserId <= new decimal(0)))
			{
				base.RequestParameters.Add("screen_name", this.RecipientUserName);
			}
		}
	}
}