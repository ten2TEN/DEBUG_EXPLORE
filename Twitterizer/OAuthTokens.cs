using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class OAuthTokens
	{
		public string AccessToken
		{
			internal get;
			set;
		}

		public string AccessTokenSecret
		{
			internal get;
			set;
		}

		public string ConsumerKey
		{
			internal get;
			set;
		}

		public string ConsumerSecret
		{
			internal get;
			set;
		}

		public bool HasAccessToken
		{
			get
			{
				return (string.IsNullOrEmpty(this.AccessToken) ? false : !string.IsNullOrEmpty(this.AccessTokenSecret));
			}
		}

		public bool HasBothTokens
		{
			get
			{
				return (!this.HasAccessToken ? false : this.HasConsumerToken);
			}
		}

		public bool HasConsumerToken
		{
			get
			{
				return (string.IsNullOrEmpty(this.ConsumerKey) ? false : !string.IsNullOrEmpty(this.ConsumerSecret));
			}
		}

		public OAuthTokens()
		{
		}
	}
}