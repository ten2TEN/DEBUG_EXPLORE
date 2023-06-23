using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Commands;
using Twitterizer.Core;
using Twitterizer.Entities;

namespace Twitterizer
{
	[DataContract]
	[DebuggerDisplay("{User.ScreenName}/{Text}")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterStatus : TwitterObject
	{
		[DataMember]
		[JsonConverter(typeof(TwitterizerDateConverter))]
		[JsonProperty(PropertyName="created_at")]
		public DateTime CreatedDate
		{
			get;
			set;
		}

		[DataMember]
		[JsonConverter(typeof(TwitterEntityCollection.Converter))]
		[JsonProperty(PropertyName="entities")]
		public TwitterEntityCollection Entities
		{
			get;
			set;
		}

		[JsonProperty(PropertyName="favorite_count")]
		public int? FavoriteCount
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="geo")]
		public TwitterGeo Geo
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="id")]
		public decimal Id
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="in_reply_to_screen_name")]
		public string InReplyToScreenName
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="in_reply_to_status_id")]
		public decimal? InReplyToStatusId
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="in_reply_to_user_id")]
		public decimal? InReplyToUserId
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="favorited")]
		public bool? IsFavorited
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="truncated")]
		public bool? IsTruncated
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="place")]
		public TwitterPlace Place
		{
			get;
			set;
		}

		[DataMember]
		public int? RetweetCount
		{
			get
			{
				int num;
				int? nullable;
				int? nullable1;
				if (string.IsNullOrEmpty(this.RetweetCountString))
				{
					nullable1 = null;
					nullable = nullable1;
				}
				else if (!(!this.RetweetCountString.EndsWith("+") ? true : int.TryParse(this.RetweetCountString.Substring(0, this.RetweetCountString.Length - 1), out num)))
				{
					nullable1 = null;
					nullable = nullable1;
				}
				else if (int.TryParse(this.RetweetCountString, out num))
				{
					nullable = new int?(num);
				}
				else
				{
					nullable1 = null;
					nullable = nullable1;
				}
				return nullable;
			}
		}

		[DataMember]
		public bool? RetweetCountPlus
		{
			get
			{
				bool? nullable;
				if (!string.IsNullOrEmpty(this.RetweetCountString))
				{
					nullable = new bool?(this.RetweetCountString.EndsWith("+"));
				}
				else
				{
					nullable = null;
				}
				return nullable;
			}
		}

		[DataMember]
		[JsonProperty(PropertyName="retweet_count")]
		public string RetweetCountString
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="retweeted")]
		public bool Retweeted
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="retweeted_status")]
		public TwitterStatus RetweetedStatus
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="source")]
		public string Source
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="id_str")]
		public string StringId
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="text")]
		public string Text
		{
			get;
			set;
		}

		[DataMember]
		[JsonProperty(PropertyName="user")]
		public TwitterUser User
		{
			get;
			set;
		}

		public TwitterStatus()
		{
		}

		public static TwitterResponse<TwitterStatus> Delete(OAuthTokens tokens, decimal id, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterStatus>(new DeleteStatusCommand(tokens, id, options));
		}

		public static TwitterResponse<TwitterStatus> Delete(OAuthTokens tokens, decimal id)
		{
			return TwitterStatus.Delete(tokens, id, null);
		}

		public TwitterResponse<TwitterStatus> Delete(OAuthTokens tokens, OptionalProperties options)
		{
			return TwitterStatus.Delete(tokens, this.Id, options);
		}

		public TwitterResponse<TwitterStatus> Delete(OAuthTokens tokens)
		{
			return TwitterStatus.Delete(tokens, this.Id, null);
		}

		public string LinkifiedText()
		{
			return TwitterStatus.LinkifiedText(this.Entities, this.Text);
		}

		internal static string LinkifiedText(TwitterEntityCollection entities, string text)
		{
			string str;
			if ((entities == null ? false : entities.Count != 0))
			{
				string str1 = text;
				IEnumerable<TwitterEntity> twitterEntities = (
					from e in entities
					orderby e.StartIndex
					select e).Reverse<TwitterEntity>();
				foreach (TwitterEntity twitterEntity in twitterEntities)
				{
					if (twitterEntity is TwitterHashTagEntity)
					{
						TwitterHashTagEntity twitterHashTagEntity = (TwitterHashTagEntity)twitterEntity;
						str1 = string.Format("{0}<a href=\"http://twitter.com/search?q=%23{1}\">{1}</a>{2}", str1.Substring(0, twitterEntity.StartIndex), twitterHashTagEntity.Text, str1.Substring(twitterEntity.EndIndex));
					}
					if (twitterEntity is TwitterUrlEntity)
					{
						TwitterUrlEntity twitterUrlEntity = (TwitterUrlEntity)twitterEntity;
						str1 = string.Format("{0}<a href=\"{1}\">{1}</a>{2}", str1.Substring(0, twitterEntity.StartIndex), twitterUrlEntity.Url, str1.Substring(twitterEntity.EndIndex));
					}
					if (twitterEntity is TwitterMentionEntity)
					{
						TwitterMentionEntity twitterMentionEntity = (TwitterMentionEntity)twitterEntity;
						str1 = string.Format("{0}<a href=\"http://twitter.com/{1}\">@{1}</a>{2}", str1.Substring(0, twitterEntity.StartIndex), twitterMentionEntity.ScreenName, str1.Substring(twitterEntity.EndIndex));
					}
				}
				str = str1;
			}
			else
			{
				str = text;
			}
			return str;
		}

		public static TwitterResponse<TwitterRelatedTweetsCollection> RelatedResultsShow(OAuthTokens tokens, decimal statusId)
		{
			return CommandPerformer.PerformAction<TwitterRelatedTweetsCollection>(new RelatedResultsCommand(tokens, statusId, null));
		}

		public static TwitterResponse<TwitterRelatedTweetsCollection> RelatedResultsShow(OAuthTokens tokens, decimal statusId, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterRelatedTweetsCollection>(new RelatedResultsCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterStatus> Retweet(OAuthTokens tokens, decimal statusId, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterStatus>(new RetweetCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterStatus> Retweet(OAuthTokens tokens, decimal statusId)
		{
			return TwitterStatus.Retweet(tokens, statusId, null);
		}

		public TwitterResponse<TwitterStatus> Retweet(OAuthTokens tokens, OptionalProperties options)
		{
			return TwitterStatus.Retweet(tokens, this.Id, options);
		}

		public TwitterResponse<TwitterStatus> Retweet(OAuthTokens tokens)
		{
			return TwitterStatus.Retweet(tokens, this.Id, null);
		}

		public static TwitterResponse<TwitterStatusCollection> Retweets(OAuthTokens tokens, decimal statusId, RetweetsOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatusCollection>(new RetweetsCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterStatusCollection> Retweets(OAuthTokens tokens, decimal statusId)
		{
			return TwitterStatus.Retweets(tokens, statusId, null);
		}

		public static TwitterResponse<TwitterStatus> Show(OAuthTokens tokens, decimal statusId, OptionalProperties options)
		{
			return CommandPerformer.PerformAction<TwitterStatus>(new ShowStatusCommand(tokens, statusId, options));
		}

		public static TwitterResponse<TwitterStatus> Show(OAuthTokens tokens, decimal statusId)
		{
			return TwitterStatus.Show(tokens, statusId, null);
		}

		public static TwitterResponse<TwitterStatus> Show(decimal statusId)
		{
			return TwitterStatus.Show(null, statusId);
		}

		public static TwitterResponse<TwitterStatus> Update(OAuthTokens tokens, string text)
		{
			return TwitterStatus.Update(tokens, text, null);
		}

		public static TwitterResponse<TwitterStatus> Update(OAuthTokens tokens, string text, StatusUpdateOptions options)
		{
			return CommandPerformer.PerformAction<TwitterStatus>(new UpdateStatusCommand(tokens, text, options));
		}

		public static TwitterResponse<TwitterStatus> UpdateWithMedia(OAuthTokens tokens, string text, byte[] fileData, StatusUpdateOptions options = null)
		{
			TwitterResponse<TwitterStatus> twitterResponse = CommandPerformer.PerformAction<TwitterStatus>(new UpdateWithMediaCommand(tokens, text, fileData, options));
			return twitterResponse;
		}

		public static TwitterResponse<TwitterStatus> UpdateWithMedia(OAuthTokens tokens, string text, string fileLocation, StatusUpdateOptions options = null)
		{
			TwitterResponse<TwitterStatus> twitterResponse = TwitterStatus.UpdateWithMedia(tokens, text, File.ReadAllBytes(fileLocation), options);
			return twitterResponse;
		}
	}
}