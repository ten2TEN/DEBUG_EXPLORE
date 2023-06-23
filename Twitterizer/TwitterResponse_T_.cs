using System;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterResponse<T>
	where T : ITwitterObject
	{
		public Twitterizer.AccessLevel AccessLevel
		{
			get;
			set;
		}

		public string Content
		{
			get;
			set;
		}

		public string ErrorMessage
		{
			get;
			set;
		}

		public Twitterizer.RateLimiting RateLimiting
		{
			get;
			set;
		}

		public string RequestUrl
		{
			get;
			set;
		}

		public T ResponseObject
		{
			get;
			set;
		}

		public RequestResult Result
		{
			get;
			set;
		}

		internal OAuthTokens Tokens
		{
			get;
			set;
		}

		public TwitterResponse()
		{
		}
	}
}