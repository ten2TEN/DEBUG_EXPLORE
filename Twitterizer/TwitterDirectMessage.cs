using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using Twitterizer.Commands;
using Twitterizer.Core;
using Twitterizer.Entities;

namespace Twitterizer
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterDirectMessage : TwitterObject
	{
		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="created_at")]
		public DateTime CreatedDate
		{
			get;
			set;
		}

		[JsonConverter(typeof(TwitterEntityCollection.Converter))]
		[JsonProperty(PropertyName="entities")]
		public TwitterEntityCollection Entities
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="id")]
		public decimal Id
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="recipient")]
		public TwitterUser Recipient
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="recipient_id")]
		public decimal RecipientId
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="recipient_screen_name")]
		public string RecipientScreenName
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="sender")]
		public TwitterUser Sender
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="sender_id")]
		public decimal SenderId
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="sender_screen_name")]
		public string SenderScreenName
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="text")]
		public string Text
		{
			get;
			set;
		}

		public TwitterDirectMessage()
		{
		}

		public TwitterResponse<TwitterDirectMessage> Delete(OAuthTokens tokens, OptionalProperties options)
		{
			DeleteDirectMessageCommand deleteDirectMessageCommand = new DeleteDirectMessageCommand(tokens, this.Id, options);
			return CommandPerformer.PerformAction<TwitterDirectMessage>(deleteDirectMessageCommand);
		}

		public static TwitterResponse<TwitterDirectMessage> Delete(OAuthTokens tokens, decimal id, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterDirectMessage>(new DeleteDirectMessageCommand(tokens, id, options));
		}

		public static TwitterResponse<TwitterDirectMessageCollection> DirectMessages(OAuthTokens tokens)
		{
			return TwitterDirectMessage.DirectMessages(tokens, null);
		}

		public static TwitterResponse<TwitterDirectMessageCollection> DirectMessages(OAuthTokens tokens, DirectMessagesOptions options)
		{
			return CommandPerformer.PerformAction<TwitterDirectMessageCollection>(new DirectMessagesCommand(tokens, options));
		}

		public static TwitterResponse<TwitterDirectMessageCollection> DirectMessagesSent(OAuthTokens tokens)
		{
			return TwitterDirectMessage.DirectMessagesSent(tokens, null);
		}

		public static TwitterResponse<TwitterDirectMessageCollection> DirectMessagesSent(OAuthTokens tokens, DirectMessagesSentOptions options)
		{
			return CommandPerformer.PerformAction<TwitterDirectMessageCollection>(new DirectMessagesSentCommand(tokens, options));
		}

		public string LinkifiedText()
		{
			return TwitterStatus.LinkifiedText(this.Entities, this.Text);
		}

		public static TwitterResponse<TwitterDirectMessage> Send(OAuthTokens tokens, decimal userId, string text, OptionalProperties options)
		{
			SendDirectMessageCommand sendDirectMessageCommand = new SendDirectMessageCommand(tokens, text, userId, options);
			return CommandPerformer.PerformAction<TwitterDirectMessage>(sendDirectMessageCommand);
		}

		public static TwitterResponse<TwitterDirectMessage> Send(OAuthTokens tokens, decimal userId, string text)
		{
			return TwitterDirectMessage.Send(tokens, userId, text, null);
		}

		public static TwitterResponse<TwitterDirectMessage> Send(OAuthTokens tokens, string screenName, string text, OptionalProperties options)
		{
			SendDirectMessageCommand sendDirectMessageCommand = new SendDirectMessageCommand(tokens, text, screenName, options);
			return CommandPerformer.PerformAction<TwitterDirectMessage>(sendDirectMessageCommand);
		}

		public static TwitterResponse<TwitterDirectMessage> Send(OAuthTokens tokens, string screenName, string text)
		{
			return TwitterDirectMessage.Send(tokens, screenName, text, null);
		}

		public static TwitterResponse<TwitterDirectMessage> Show(OAuthTokens tokens, decimal id, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterDirectMessage>(new ShowDirectMessageCommand(tokens, id, options));
		}
	}
}