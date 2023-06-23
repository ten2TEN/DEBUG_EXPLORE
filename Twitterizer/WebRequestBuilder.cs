using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Twitterizer
{
	public sealed class WebRequestBuilder
	{
		public const string Realm = "Twitter API";

		private byte[] formData;

		private readonly string userAgent;

		private readonly NetworkCredential networkCredentials;

		private readonly static string[] OAuthParametersToIncludeInHeader;

		private readonly static string[] SecretParameters;

		public bool Multipart
		{
			get;
			set;
		}

		public Dictionary<string, object> Parameters
		{
			get;
			private set;
		}

		public WebProxy Proxy
		{
			get;
			set;
		}

		public Uri RequestUri
		{
			get;
			set;
		}

		public OAuthTokens Tokens
		{
			private get;
			set;
		}

		public bool UseCompression
		{
			get;
			set;
		}

		public bool UseOAuth
		{
			get;
			private set;
		}

		public HTTPVerb Verb
		{
			get;
			set;
		}

		static WebRequestBuilder()
		{
			string[] strArrays = new string[] { "oauth_version", "oauth_nonce", "oauth_timestamp", "oauth_signature_method", "oauth_consumer_key", "oauth_token", "oauth_verifier" };
			WebRequestBuilder.OAuthParametersToIncludeInHeader = strArrays;
			strArrays = new string[] { "oauth_consumer_secret", "oauth_token_secret", "oauth_signature" };
			WebRequestBuilder.SecretParameters = strArrays;
		}

		public WebRequestBuilder(Uri requestUri, HTTPVerb verb, string userAgent, NetworkCredential networkCredentials)
		{
			if (requestUri == null)
			{
				throw new ArgumentNullException("requestUri");
			}
			this.RequestUri = requestUri;
			this.Verb = verb;
			this.userAgent = userAgent;
			this.UseOAuth = false;
			if (networkCredentials != null)
			{
				this.networkCredentials = networkCredentials;
			}
			this.Parameters = new Dictionary<string, object>();
			if (!string.IsNullOrEmpty(this.RequestUri.Query))
			{
				foreach (Match match in Regex.Matches(this.RequestUri.Query, "(?<key>[^&?=]+)=(?<value>[^&?=]+)"))
				{
					this.Parameters.Add(match.Groups["key"].Value, match.Groups["value"].Value);
				}
				this.RequestUri = new Uri(this.RequestUri.AbsoluteUri.Replace(this.RequestUri.Query, ""));
			}
		}

		public WebRequestBuilder(Uri requestUri, HTTPVerb verb, OAuthTokens tokens, string userAgent = "") : this(requestUri, verb, userAgent, null)
		{
			this.Tokens = tokens;
			if (tokens != null)
			{
				if ((string.IsNullOrEmpty(this.Tokens.ConsumerKey) ? true : string.IsNullOrEmpty(this.Tokens.ConsumerSecret)))
				{
					throw new ArgumentException("Consumer key and secret are required for OAuth requests.");
				}
				if (string.IsNullOrEmpty(this.Tokens.AccessToken) ^ string.IsNullOrEmpty(this.Tokens.AccessTokenSecret))
				{
					throw new ArgumentException("The access token is invalid. You must specify the key AND secret values.");
				}
				this.UseOAuth = true;
			}
		}

		private void AddQueryStringParametersToUri()
		{
			StringBuilder stringBuilder = new StringBuilder(this.RequestUri.AbsoluteUri);
			stringBuilder.Append((this.RequestUri.Query.Length == 0 ? "?" : "&"));
			Dictionary<string, object> strs = new Dictionary<string, object>((
				from p in this.Parameters
				where (WebRequestBuilder.OAuthParametersToIncludeInHeader.Contains<string>(p.Key) ? false : !WebRequestBuilder.SecretParameters.Contains<string>(p.Key))
				select p).ToDictionary<KeyValuePair<string, object>, string, object>((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value));
			foreach (KeyValuePair<string, object> str in strs)
			{
				if (str.Value is string)
				{
					stringBuilder.AppendFormat("{0}={1}&", str.Key, WebRequestBuilder.UrlEncode((string)str.Value));
				}
			}
			if (stringBuilder.Length != 0)
			{
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
				this.RequestUri = new Uri(stringBuilder.ToString());
			}
		}

		public HttpWebResponse ExecuteRequest()
		{
			return (HttpWebResponse)this.PrepareRequest().GetResponse();
		}

		public string GenerateAuthorizationHeader()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("OAuth realm=\"{0}\"", "Twitter API");
			IOrderedEnumerable<KeyValuePair<string, object>> parameters = 
				from p in this.Parameters
				where WebRequestBuilder.OAuthParametersToIncludeInHeader.Contains<string>(p.Key)
				orderby p.Key, WebRequestBuilder.UrlEncode((p.Value is string ? (string)p.Value : string.Empty))
				select p;
			foreach (KeyValuePair<string, object> parameter in parameters)
			{
				stringBuilder.AppendFormat(",{0}=\"{1}\"", WebRequestBuilder.UrlEncode(parameter.Key), WebRequestBuilder.UrlEncode(parameter.Value as string));
			}
			stringBuilder.AppendFormat(",oauth_signature=\"{0}\"", WebRequestBuilder.UrlEncode(this.Parameters["oauth_signature"] as string));
			return stringBuilder.ToString();
		}

		public static string GenerateNonce()
		{
			int num = (new Random()).Next(0x1e208, 0x7fffffff);
			return num.ToString("X", CultureInfo.InvariantCulture);
		}

		public string GenerateSignature()
		{
			IEnumerable<KeyValuePair<string, object>> keyValuePairs;
			keyValuePairs = (!this.Multipart ? 
				from p in this.Parameters
				where !WebRequestBuilder.SecretParameters.Contains<string>(p.Key)
				select p : 
				from p in this.Parameters
				where (WebRequestBuilder.SecretParameters.Contains<string>(p.Key) ? false : p.Key.StartsWith("oauth_"))
				select p);
			Uri requestUri = this.RequestUri;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object[] upper = new object[] { this.Verb.ToString().ToUpper(CultureInfo.InvariantCulture), WebRequestBuilder.UrlEncode(WebRequestBuilder.NormalizeUrl(requestUri)), WebRequestBuilder.UrlEncode(keyValuePairs) };
			string str = string.Format(invariantCulture, "{0}&{1}&{2}", upper);
			CultureInfo cultureInfo = CultureInfo.InvariantCulture;
			upper = new object[] { WebRequestBuilder.UrlEncode(this.Tokens.ConsumerSecret), WebRequestBuilder.UrlEncode(this.Tokens.AccessTokenSecret) };
			string str1 = string.Format(cultureInfo, "{0}&{1}", upper);
			HMACSHA1 hMACSHA1 = new HMACSHA1(Encoding.UTF8.GetBytes(str1));
			byte[] numArray = hMACSHA1.ComputeHash(Encoding.UTF8.GetBytes(str));
			return Convert.ToBase64String(numArray);
		}

		public static string GenerateTimeStamp()
		{
			TimeSpan utcNow = DateTime.UtcNow - new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
			long num = Convert.ToInt64(utcNow.TotalSeconds, CultureInfo.CurrentCulture);
			return num.ToString(CultureInfo.CurrentCulture);
		}

		private byte[] GetMultipartFormData(Dictionary<string, object> param, string boundary)
		{
			string str;
			byte[] bytes;
			Stream memoryStream = new MemoryStream();
			Encoding uTF8 = Encoding.UTF8;
			Dictionary<string, object> strs = new Dictionary<string, object>((
				from p in param
				where (WebRequestBuilder.OAuthParametersToIncludeInHeader.Contains<string>(p.Key) ? false : !WebRequestBuilder.SecretParameters.Contains<string>(p.Key))
				select p).ToDictionary<KeyValuePair<string, object>, string, object>((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value));
			foreach (KeyValuePair<string, object> keyValuePair in strs)
			{
				if (!(keyValuePair.Value.GetType() == typeof(byte[])))
				{
					str = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", boundary, keyValuePair.Key, keyValuePair.Value);
					bytes = uTF8.GetBytes(str);
					memoryStream.Write(bytes, 0, (int)bytes.Length);
				}
				else
				{
					byte[] value = (byte[])keyValuePair.Value;
					str = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\";\r\nContent-Type: application/octet-stream\r\n\r\n", boundary, keyValuePair.Key, keyValuePair.Key);
					bytes = uTF8.GetBytes(str);
					memoryStream.Write(bytes, 0, (int)bytes.Length);
					memoryStream.Write(value, 0, (int)value.Length);
				}
			}
			string str1 = string.Format("\r\n--{0}--\r\n", boundary);
			memoryStream.Write(uTF8.GetBytes(str1), 0, str1.Length);
			memoryStream.Position = (long)0;
			byte[] numArray = new byte[checked((IntPtr)memoryStream.Length)];
			memoryStream.Read(numArray, 0, (int)numArray.Length);
			memoryStream.Close();
			return numArray;
		}

		public static string NormalizeUrl(Uri url)
		{
			bool flag;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object[] scheme = new object[] { url.Scheme, url.Host };
			string str = string.Format(invariantCulture, "{0}://{1}", scheme);
			if (!(url.Scheme == "http") || url.Port != 80)
			{
				flag = (url.Scheme != "https" ? false : url.Port == 0x1bb);
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				str = string.Concat(str, ":", url.Port);
			}
			str = string.Concat(str, url.AbsolutePath);
			return str;
		}

		public HttpWebRequest PrepareRequest()
		{
			object length;
			string str;
			this.SetupOAuth();
			this.formData = null;
			string empty = string.Empty;
			if (this.Multipart)
			{
				string str1 = "--------------------r4nd0m";
				empty = string.Concat("multipart/form-data; boundary=", str1);
				this.formData = this.GetMultipartFormData(this.Parameters, str1);
				this.Verb = HTTPVerb.POST;
			}
			else
			{
				this.AddQueryStringParametersToUri();
			}
			HttpWebRequest proxy = (HttpWebRequest)WebRequest.Create(this.RequestUri);
			if (!this.UseCompression)
			{
				proxy.AutomaticDecompression = DecompressionMethods.None;
			}
			else
			{
				proxy.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			}
			if (this.Proxy != null)
			{
				proxy.Proxy = this.Proxy;
			}
			if ((this.UseOAuth ? true : this.networkCredentials == null))
			{
				proxy.UseDefaultCredentials = true;
			}
			else
			{
				proxy.Credentials = this.networkCredentials;
				proxy.UseDefaultCredentials = false;
			}
			proxy.Method = this.Verb.ToString();
			HttpWebRequest httpWebRequest = proxy;
			if (!this.Multipart)
			{
				length = null;
			}
			else if (this.formData != null)
			{
				length = (int)this.formData.Length;
			}
			else
			{
				length = null;
			}
			httpWebRequest.ContentLength = (long)length;
			HttpWebRequest httpWebRequest1 = proxy;
			if (string.IsNullOrEmpty(this.userAgent))
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object[] version = new object[] { Assembly.GetExecutingAssembly().GetName().Version };
				str = string.Format(invariantCulture, "Twitterizer/{0}", version);
			}
			else
			{
				str = this.userAgent;
			}
			httpWebRequest1.UserAgent = str;
			proxy.ServicePoint.Expect100Continue = false;
			if (this.UseOAuth)
			{
				proxy.Headers.Add("Authorization", this.GenerateAuthorizationHeader());
			}
			if (this.Multipart)
			{
				proxy.ContentType = empty;
				Stream requestStream = proxy.GetRequestStream();
				try
				{
					if (this.formData != null)
					{
						requestStream.Write(this.formData, 0, (int)this.formData.Length);
					}
				}
				finally
				{
					if (requestStream != null)
					{
						((IDisposable)requestStream).Dispose();
					}
				}
			}
			return proxy;
		}

		private void SetupOAuth()
		{
			if (this.UseOAuth)
			{
				this.Parameters.Add("oauth_version", "1.0");
				this.Parameters.Add("oauth_nonce", WebRequestBuilder.GenerateNonce());
				this.Parameters.Add("oauth_timestamp", WebRequestBuilder.GenerateTimeStamp());
				this.Parameters.Add("oauth_signature_method", "HMAC-SHA1");
				this.Parameters.Add("oauth_consumer_key", this.Tokens.ConsumerKey);
				this.Parameters.Add("oauth_consumer_secret", this.Tokens.ConsumerSecret);
				if (!string.IsNullOrEmpty(this.Tokens.AccessToken))
				{
					this.Parameters.Add("oauth_token", this.Tokens.AccessToken);
				}
				if (!string.IsNullOrEmpty(this.Tokens.AccessTokenSecret))
				{
					this.Parameters.Add("oauth_token_secret", this.Tokens.AccessTokenSecret);
				}
				string str = this.GenerateSignature();
				this.Parameters.Add("oauth_signature", str);
			}
		}

		public static string UrlEncode(string value)
		{
			string empty;
			if (!string.IsNullOrEmpty(value))
			{
				value = Uri.EscapeDataString(value);
				value = Regex.Replace(value, "(%[0-9a-f][0-9a-f])", (Match c) => c.Value.ToUpper());
				value = value.Replace("(", "%28").Replace(")", "%29").Replace("$", "%24").Replace("!", "%21").Replace("*", "%2A").Replace("'", "%27");
				value = value.Replace("%7E", "~");
				empty = value;
			}
			else
			{
				empty = string.Empty;
			}
			return empty;
		}

		private static string UrlEncode(IEnumerable<KeyValuePair<string, object>> parameters)
		{
			StringBuilder stringBuilder = new StringBuilder();
			IOrderedEnumerable<KeyValuePair<string, object>> keyValuePairs = 
				from p in parameters
				orderby p.Key, p.Value
				select p;
			foreach (KeyValuePair<string, object> keyValuePair in keyValuePairs)
			{
				if (keyValuePair.Value is string)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append("&");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object[] objArray = new object[] { WebRequestBuilder.UrlEncode(keyValuePair.Key), WebRequestBuilder.UrlEncode((string)keyValuePair.Value) };
					stringBuilder.Append(string.Format(invariantCulture, "{0}={1}", objArray));
				}
			}
			return WebRequestBuilder.UrlEncode(stringBuilder.ToString());
		}
	}
}