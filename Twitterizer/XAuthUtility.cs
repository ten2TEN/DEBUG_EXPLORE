using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Twitterizer
{
	public static class XAuthUtility
	{
		public static OAuthTokenResponse GetAccessTokens(string consumerKey, string consumerSecret, string username, string password)
		{
			if (string.IsNullOrEmpty(consumerKey))
			{
				throw new ArgumentNullException("consumerKey");
			}
			if (string.IsNullOrEmpty(consumerSecret))
			{
				throw new ArgumentNullException("consumerSecret");
			}
			if (string.IsNullOrEmpty(username))
			{
				throw new ArgumentNullException("username");
			}
			if (string.IsNullOrEmpty(password))
			{
				throw new ArgumentNullException("password");
			}
			OAuthTokenResponse oAuthTokenResponse = new OAuthTokenResponse();
			try
			{
				Uri uri = new Uri("https://api.twitter.com/oauth/access_token");
				OAuthTokens oAuthToken = new OAuthTokens()
				{
					ConsumerKey = consumerKey,
					ConsumerSecret = consumerSecret
				};
				WebRequestBuilder webRequestBuilder = new WebRequestBuilder(uri, HTTPVerb.POST, oAuthToken, "");
				webRequestBuilder.Parameters.Add("x_auth_username", username);
				webRequestBuilder.Parameters.Add("x_auth_password", password);
				webRequestBuilder.Parameters.Add("x_auth_mode", "client_auth");
				string end = (new StreamReader(webRequestBuilder.ExecuteRequest().GetResponseStream())).ReadToEnd();
				oAuthTokenResponse.Token = Regex.Match(end, "oauth_token=([^&]+)").Groups[1].Value;
				oAuthTokenResponse.TokenSecret = Regex.Match(end, "oauth_token_secret=([^&]+)").Groups[1].Value;
				if (end.Contains("user_id="))
				{
					oAuthTokenResponse.UserId = long.Parse(Regex.Match(end, "user_id=([^&]+)").Groups[1].Value, CultureInfo.CurrentCulture);
				}
				oAuthTokenResponse.ScreenName = Regex.Match(end, "screen_name=([^&]+)").Groups[1].Value;
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				throw new TwitterizerException(webException.Message, webException);
			}
			return oAuthTokenResponse;
		}
	}
}