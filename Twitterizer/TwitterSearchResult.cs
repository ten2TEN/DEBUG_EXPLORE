using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Core;
using Twitterizer.Entities;

namespace Twitterizer
{
	[JsonObject(MemberSerialization=MemberSerialization.OptIn)]
	[Serializable]
	public class TwitterSearchResult : TwitterObject
	{
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

		[JsonProperty(PropertyName="id_str")]
		public decimal Id
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

		[JsonProperty(PropertyName="source")]
		public string Source
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

		[DataMember]
		[JsonProperty(PropertyName="user")]
		public TwitterUser User
		{
			get;
			set;
		}

		public TwitterSearchResult()
		{
		}

		public string LinkifiedText()
		{
			return TwitterStatus.LinkifiedText(this.Entities, this.Text);
		}
	}
}