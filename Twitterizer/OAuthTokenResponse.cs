using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class OAuthTokenResponse
	{
		public string ScreenName
		{
			get;
			set;
		}

		public string Token
		{
			get;
			set;
		}

		public string TokenSecret
		{
			get;
			set;
		}

		public decimal UserId
		{
			get;
			set;
		}

		public string VerificationString
		{
			get;
			set;
		}

		public OAuthTokenResponse()
		{
		}
	}
}