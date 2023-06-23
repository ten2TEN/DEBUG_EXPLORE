using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Twitterizer
{
	public static class OAuthUtility
	{
		public static void AddOAuthEchoHeader(WebRequest request, OAuthTokens tokens)
		{
			WebRequestBuilder webRequestBuilder = new WebRequestBuilder(new Uri("https://api.twitter.com/1.1/account/verify_credentials.json"), HTTPVerb.POST, tokens, "");
			webRequestBuilder.PrepareRequest();
			request.Headers.Add("X-Verify-Credentials-Authorization", webRequestBuilder.GenerateAuthorizationHeader());
			request.Headers.Add("X-Auth-Service-Provider", "]/1.1/account/verify_credentials.json");
		}

		public static Uri BuildAuthorizationUri(string requestToken)
		{
			return OAuthUtility.BuildAuthorizationUri(requestToken, false);
		}

		public static Uri BuildAuthorizationUri(string requestToken, bool authenticate)
		{
			StringBuilder stringBuilder = new StringBuilder("https://twitter.com/oauth/");
			if (!authenticate)
			{
				stringBuilder.Append("authorize");
			}
			else
			{
				stringBuilder.Append("authenticate");
			}
			stringBuilder.AppendFormat("?oauth_token={0}", requestToken);
			return new Uri(stringBuilder.ToString());
		}

		public static OAuthTokenResponse GetAccessToken(string consumerKey, string consumerSecret, string requestToken, string verifier)
		{
			string end;
			if (string.IsNullOrEmpty(consumerKey))
			{
				throw new ArgumentNullException("consumerKey");
			}
			if (string.IsNullOrEmpty(consumerSecret))
			{
				throw new ArgumentNullException("consumerSecret");
			}
			if (string.IsNullOrEmpty(requestToken))
			{
				throw new ArgumentNullException("requestToken");
			}
			Uri uri = new Uri("https://api.twitter.com/oauth/access_token");
			OAuthTokens oAuthToken = new OAuthTokens()
			{
				ConsumerKey = consumerKey,
				ConsumerSecret = consumerSecret
			};
			WebRequestBuilder webRequestBuilder = new WebRequestBuilder(uri, HTTPVerb.GET, oAuthToken, "");
			if (!string.IsNullOrEmpty(verifier))
			{
				webRequestBuilder.Parameters.Add("oauth_verifier", verifier);
			}
			webRequestBuilder.Parameters.Add("oauth_token", requestToken);
			try
			{
				HttpWebResponse httpWebResponse = webRequestBuilder.ExecuteRequest();
				end = (new StreamReader(httpWebResponse.GetResponseStream())).ReadToEnd();
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				throw new TwitterizerException(webException.Message, webException);
			}
			OAuthTokenResponse oAuthTokenResponse = new OAuthTokenResponse()
			{
				Token = Regex.Match(end, "oauth_token=([^&]+)").Groups[1].Value,
				TokenSecret = Regex.Match(end, "oauth_token_secret=([^&]+)").Groups[1].Value,
				UserId = long.Parse(Regex.Match(end, "user_id=([^&]+)").Groups[1].Value, CultureInfo.CurrentCulture),
				ScreenName = Regex.Match(end, "screen_name=([^&]+)").Groups[1].Value
			};
			return oAuthTokenResponse;
		}

		public static OAuthTokenResponse GetAccessToken(string consumerKey, string consumerSecret, string requestToken, string verifier, WebProxy proxy)
		{
			string end;
			if (string.IsNullOrEmpty(consumerKey))
			{
				throw new ArgumentNullException("consumerKey");
			}
			if (string.IsNullOrEmpty(consumerSecret))
			{
				throw new ArgumentNullException("consumerSecret");
			}
			if (string.IsNullOrEmpty(requestToken))
			{
				throw new ArgumentNullException("requestToken");
			}
			Uri uri = new Uri("https://api.twitter.com/oauth/access_token");
			OAuthTokens oAuthToken = new OAuthTokens()
			{
				ConsumerKey = consumerKey,
				ConsumerSecret = consumerSecret
			};
			WebRequestBuilder webRequestBuilder = new WebRequestBuilder(uri, HTTPVerb.GET, oAuthToken, "")
			{
				Proxy = proxy
			};
			if (!string.IsNullOrEmpty(verifier))
			{
				webRequestBuilder.Parameters.Add("oauth_verifier", verifier);
			}
			webRequestBuilder.Parameters.Add("oauth_token", requestToken);
			try
			{
				HttpWebResponse httpWebResponse = webRequestBuilder.ExecuteRequest();
				end = (new StreamReader(httpWebResponse.GetResponseStream())).ReadToEnd();
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				throw new TwitterizerException(webException.Message, webException);
			}
			OAuthTokenResponse oAuthTokenResponse = new OAuthTokenResponse()
			{
				Token = Regex.Match(end, "oauth_token=([^&]+)").Groups[1].Value,
				TokenSecret = Regex.Match(end, "oauth_token_secret=([^&]+)").Groups[1].Value,
				UserId = long.Parse(Regex.Match(end, "user_id=([^&]+)").Groups[1].Value, CultureInfo.CurrentCulture),
				ScreenName = Regex.Match(end, "screen_name=([^&]+)").Groups[1].Value
			};
			return oAuthTokenResponse;
		}

		public static OAuthTokenResponse GetRequestToken(string consumerKey, string consumerSecret, string callbackAddress)
		{
			if (string.IsNullOrEmpty(consumerKey))
			{
				throw new ArgumentNullException("consumerKey");
			}
			if (string.IsNullOrEmpty(consumerSecret))
			{
				throw new ArgumentNullException("consumerSecret");
			}
			if (string.IsNullOrEmpty(callbackAddress))
			{
				throw new ArgumentNullException("callbackAddress", "You must always provide a callback url when obtaining a request token. For PIN-based authentication, use \"oob\" as the callback url.");
			}
			Uri uri = new Uri("https://api.twitter.com/oauth/request_token");
			OAuthTokens oAuthToken = new OAuthTokens()
			{
				ConsumerKey = consumerKey,
				ConsumerSecret = consumerSecret
			};
			WebRequestBuilder webRequestBuilder = new WebRequestBuilder(uri, HTTPVerb.POST, oAuthToken, "");
			if (!string.IsNullOrEmpty(callbackAddress))
			{
				webRequestBuilder.Parameters.Add("oauth_callback", callbackAddress);
			}
			string end = null;
			try
			{
				Stream responseStream = webRequestBuilder.ExecuteRequest().GetResponseStream();
				if (responseStream != null)
				{
					end = (new StreamReader(responseStream)).ReadToEnd();
				}
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				throw new TwitterizerException(webException.Message, webException);
			}
			OAuthTokenResponse oAuthTokenResponse = new OAuthTokenResponse()
			{
				Token = OAuthUtility.ParseQuerystringParameter("oauth_token", end),
				TokenSecret = OAuthUtility.ParseQuerystringParameter("oauth_token_secret", end),
				VerificationString = OAuthUtility.ParseQuerystringParameter("oauth_verifier", end)
			};
			return oAuthTokenResponse;
		}

		public static OAuthTokenResponse GetRequestToken(string consumerKey, string consumerSecret, string callbackAddress, WebProxy proxy)
		{
			if (string.IsNullOrEmpty(consumerKey))
			{
				throw new ArgumentNullException("consumerKey");
			}
			if (string.IsNullOrEmpty(consumerSecret))
			{
				throw new ArgumentNullException("consumerSecret");
			}
			if (string.IsNullOrEmpty(callbackAddress))
			{
				throw new ArgumentNullException("callbackAddress", "You must always provide a callback url when obtaining a request token. For PIN-based authentication, use \"oob\" as the callback url.");
			}
			Uri uri = new Uri("https://api.twitter.com/oauth/request_token");
			OAuthTokens oAuthToken = new OAuthTokens()
			{
				ConsumerKey = consumerKey,
				ConsumerSecret = consumerSecret
			};
			WebRequestBuilder webRequestBuilder = new WebRequestBuilder(uri, HTTPVerb.POST, oAuthToken, "")
			{
				Proxy = proxy
			};
			WebRequestBuilder webRequestBuilder1 = webRequestBuilder;
			if (!string.IsNullOrEmpty(callbackAddress))
			{
				webRequestBuilder1.Parameters.Add("oauth_callback", callbackAddress);
			}
			string end = null;
			try
			{
				Stream responseStream = webRequestBuilder1.ExecuteRequest().GetResponseStream();
				if (responseStream != null)
				{
					end = (new StreamReader(responseStream)).ReadToEnd();
				}
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				throw new TwitterizerException(webException.Message, webException);
			}
			Match match = Regex.Match(end, "oauth_token=(?<token>[^&]+)|oauth_token_secret=(?<secret>[^&]+)|oauth_verifier=(?<verifier>[^&]+)");
			OAuthTokenResponse oAuthTokenResponse = new OAuthTokenResponse()
			{
				Token = match.Groups["token"].Value,
				TokenSecret = match.Groups["secret"].Value,
				VerificationString = match.Groups["verifier"].Value
			};
			return oAuthTokenResponse;
		}

		private static string ParseQuerystringParameter(string parameterName, string text)
		{
			string str;
			Match match = Regex.Match(text, string.Format("{0}=(?<value>[^&]+)", parameterName));
			str = (match.Success ? match.Groups["value"].Value : string.Empty);
			return str;
		}
	}
}