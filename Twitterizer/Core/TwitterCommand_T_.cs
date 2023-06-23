using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Twitterizer;

namespace Twitterizer.Core
{
	[Serializable]
	internal abstract class TwitterCommand<T> : ICommand<T>
	where T : ITwitterObject
	{
		protected SerializationHelper<T>.DeserializationHandler DeserializationHandler
		{
			get;
			set;
		}

		protected bool Multipart
		{
			get;
			set;
		}

		protected Twitterizer.OptionalProperties OptionalProperties
		{
			get;
			set;
		}

		public Dictionary<string, object> RequestParameters
		{
			get
			{
				return JustDecompileGenerated_get_RequestParameters();
			}
			set
			{
				JustDecompileGenerated_set_RequestParameters(value);
			}
		}

		private Dictionary<string, object> JustDecompileGenerated_RequestParameters_k__BackingField;

		public Dictionary<string, object> JustDecompileGenerated_get_RequestParameters()
		{
			return this.JustDecompileGenerated_RequestParameters_k__BackingField;
		}

		public void JustDecompileGenerated_set_RequestParameters(Dictionary<string, object> value)
		{
			this.JustDecompileGenerated_RequestParameters_k__BackingField = value;
		}

		internal OAuthTokens Tokens
		{
			get;
			private set;
		}

		private System.Uri Uri
		{
			get;
			set;
		}

		private HTTPVerb Verb
		{
			get;
			set;
		}

		protected TwitterCommand(HTTPVerb method, string endPoint, OAuthTokens tokens, Twitterizer.OptionalProperties optionalProperties)
		{
			this.RequestParameters = new Dictionary<string, object>();
			this.Verb = method;
			this.Tokens = tokens;
			this.OptionalProperties = optionalProperties ?? new Twitterizer.OptionalProperties();
			this.SetCommandUri(endPoint);
		}

		public TwitterResponse<T> ExecuteCommand()
		{
			KeyValuePair<string, object> requestParameter = new KeyValuePair<string, object>();
			RateLimiting rateLimiting;
			AccessLevel accessLevel;
			byte[] numArray;
			TwitterResponse<T> twitterResponse;
			object[] type;
			TwitterResponse<T> absoluteUri = new TwitterResponse<T>();
			if (this.OptionalProperties.UseSSL)
			{
				this.Uri = new System.Uri(this.Uri.AbsoluteUri.Replace("http://", "https://"));
			}
			object[] customAttributes = this.GetType().GetCustomAttributes(false);
			for (int i = 0; i < (int)customAttributes.Length; i++)
			{
				if ((Attribute)customAttributes[i] is AuthorizedCommandAttribute)
				{
					if (this.Tokens == null)
					{
						CultureInfo currentCulture = CultureInfo.CurrentCulture;
						type = new object[] { this.GetType() };
						throw new ArgumentException(string.Format(currentCulture, "Tokens are required for the \"{0}\" command.", type));
					}
					if ((string.IsNullOrEmpty(this.Tokens.ConsumerKey) || string.IsNullOrEmpty(this.Tokens.ConsumerSecret) || string.IsNullOrEmpty(this.Tokens.AccessToken) ? true : string.IsNullOrEmpty(this.Tokens.AccessTokenSecret)))
					{
						CultureInfo cultureInfo = CultureInfo.CurrentCulture;
						type = new object[] { this.GetType() };
						throw new ArgumentException(string.Format(cultureInfo, "Token values cannot be null when executing the \"{0}\" command.", type));
					}
				}
			}
			Dictionary<string, object> strs = new Dictionary<string, object>();
			foreach (KeyValuePair<string, object> requestParameter in this.RequestParameters)
			{
				strs.Add(requestParameter.Key, requestParameter.Value);
			}
			absoluteUri.ResponseObject = default(T);
			absoluteUri.RequestUrl = this.Uri.AbsoluteUri;
			try
			{
				WebRequestBuilder webRequestBuilder = new WebRequestBuilder(this.Uri, this.Verb, this.Tokens, "")
				{
					Multipart = this.Multipart
				};
				WebRequestBuilder proxy = webRequestBuilder;
				if (this.OptionalProperties != null)
				{
					proxy.Proxy = this.OptionalProperties.Proxy;
				}
				foreach (KeyValuePair<string, object> str in strs)
				{
					proxy.Parameters.Add(str.Key, str.Value);
				}
				HttpWebResponse httpWebResponse = proxy.ExecuteRequest();
				if (httpWebResponse != null)
				{
					numArray = ConversionUtility.ReadStream(httpWebResponse.GetResponseStream());
					absoluteUri.Content = Encoding.UTF8.GetString(numArray, 0, (int)numArray.Length);
					absoluteUri.RequestUrl = proxy.RequestUri.AbsoluteUri;
					rateLimiting = TwitterCommand<T>.ParseRateLimitHeaders(httpWebResponse.Headers);
					accessLevel = this.ParseAccessLevel(httpWebResponse.Headers);
					TwitterCommand<T>.SetStatusCode(absoluteUri, httpWebResponse.StatusCode, rateLimiting);
					absoluteUri.RateLimiting = rateLimiting;
					absoluteUri.AccessLevel = accessLevel;
					goto Label0;
				}
				else
				{
					absoluteUri.Result = RequestResult.Unknown;
					twitterResponse = absoluteUri;
				}
			}
			catch (WebException webException1)
			{
				WebException webException = webException1;
				WebExceptionStatus[] webExceptionStatusArray = new WebExceptionStatus[] { WebExceptionStatus.Timeout, WebExceptionStatus.ConnectionClosed, WebExceptionStatus.ConnectFailure };
				if (!webExceptionStatusArray.Contains<WebExceptionStatus>(webException.Status))
				{
					HttpWebResponse response = webException.Response as HttpWebResponse;
					if (response == null)
					{
						throw;
					}
					numArray = ConversionUtility.ReadStream(response.GetResponseStream());
					absoluteUri.Content = Encoding.UTF8.GetString(numArray, 0, (int)numArray.Length);
					rateLimiting = TwitterCommand<T>.ParseRateLimitHeaders(response.Headers);
					accessLevel = this.ParseAccessLevel(response.Headers);
					try
					{
						absoluteUri.ErrorMessage = SerializationHelper<TwitterErrorDetails>.Deserialize(numArray).ErrorMessage;
					}
					catch (Exception exception)
					{
					}
					TwitterCommand<T>.SetStatusCode(absoluteUri, response.StatusCode, rateLimiting);
					absoluteUri.RateLimiting = rateLimiting;
					absoluteUri.AccessLevel = accessLevel;
					if (webException.Status == WebExceptionStatus.UnknownError)
					{
						throw;
					}
					twitterResponse = absoluteUri;
				}
				else
				{
					absoluteUri.Result = RequestResult.ConnectionFailure;
					absoluteUri.ErrorMessage = webException.Message;
					twitterResponse = absoluteUri;
				}
			}
			return twitterResponse;
		Label0:
			try
			{
				absoluteUri.ResponseObject = SerializationHelper<T>.Deserialize(numArray, this.DeserializationHandler);
			}
			catch (JsonReaderException jsonReaderException)
			{
				absoluteUri.ErrorMessage = "Unable to parse JSON";
				absoluteUri.Result = RequestResult.Unknown;
				twitterResponse = absoluteUri;
				return twitterResponse;
			}
			catch (JsonSerializationException jsonSerializationException)
			{
				absoluteUri.ErrorMessage = "Unable to parse JSON";
				absoluteUri.Result = RequestResult.Unknown;
				twitterResponse = absoluteUri;
				return twitterResponse;
			}
			absoluteUri.Tokens = this.Tokens;
			twitterResponse = absoluteUri;
			return twitterResponse;
		}

		public abstract void Init();

		private AccessLevel ParseAccessLevel(WebHeaderCollection responseHeaders)
		{
			AccessLevel accessLevel;
			if (!responseHeaders.AllKeys.Contains<string>("X-Access-Level"))
			{
				accessLevel = AccessLevel.Unavailable;
			}
			else
			{
				string lower = responseHeaders["X-Access-Level"].ToLower();
				if (lower != null)
				{
					if (lower == "read")
					{
						accessLevel = AccessLevel.Read;
						return accessLevel;
					}
					else if (lower == "read-write")
					{
						accessLevel = AccessLevel.ReadWrite;
						return accessLevel;
					}
					else
					{
						if (!(lower == "read-write-privatemessages") && !(lower == "read-write-directmessages"))
						{
							goto Label2;
						}
						accessLevel = AccessLevel.ReadWriteDirectMessage;
						return accessLevel;
					}
				}
			Label2:
				accessLevel = AccessLevel.Unknown;
			}
			return accessLevel;
		}

		private static RateLimiting ParseRateLimitHeaders(WebHeaderCollection responseHeaders)
		{
			DateTime dateTime;
			RateLimiting rateLimiting = new RateLimiting();
			if (responseHeaders.AllKeys.Contains<string>("x-rate-limit-limit"))
			{
				rateLimiting.Total = int.Parse(responseHeaders["x-rate-limit-limit"], CultureInfo.InvariantCulture);
			}
			if (responseHeaders.AllKeys.Contains<string>("x-rate-limit-remaining"))
			{
				rateLimiting.Remaining = int.Parse(responseHeaders["x-rate-limit-remaining"], CultureInfo.InvariantCulture);
			}
			if (!string.IsNullOrEmpty(responseHeaders["x-rate-limit-reset"]))
			{
				dateTime = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
				rateLimiting.ResetDate = DateTime.SpecifyKind(dateTime.AddSeconds(double.Parse(responseHeaders["x-rate-limit-reset"], CultureInfo.InvariantCulture)), DateTimeKind.Utc);
			}
			else if (!string.IsNullOrEmpty(responseHeaders["Retry-After"]))
			{
				dateTime = DateTime.UtcNow;
				rateLimiting.ResetDate = dateTime.AddSeconds((double)Convert.ToInt32(responseHeaders["Retry-After"]));
			}
			return rateLimiting;
		}

		protected void SetCommandUri(string endPoint)
		{
			if (endPoint.StartsWith("/"))
			{
				throw new ArgumentException("The API endpoint cannot begin with a forward slash. This will result in 404 errors and headaches.", "endPoint");
			}
			this.Uri = new System.Uri(string.Concat(this.OptionalProperties.APIBaseAddress, endPoint));
		}

		private static void SetStatusCode(TwitterResponse<T> twitterResponse, HttpStatusCode statusCode, RateLimiting rateLimiting)
		{
			HttpStatusCode httpStatusCode = statusCode;
			if (httpStatusCode == HttpStatusCode.OK)
			{
				twitterResponse.Result = RequestResult.Success;
			}
			else
			{
				switch (httpStatusCode)
				{
					case HttpStatusCode.BadRequest:
					{
						twitterResponse.Result = (rateLimiting == null || rateLimiting.Remaining != 0 ? RequestResult.BadRequest : RequestResult.RateLimited);
						break;
					}
					case HttpStatusCode.Unauthorized:
					{
						twitterResponse.Result = RequestResult.Unauthorized;
						break;
					}
					case HttpStatusCode.PaymentRequired:
					case HttpStatusCode.MethodNotAllowed:
					case HttpStatusCode.NotAcceptable:
					{
						twitterResponse.Result = RequestResult.Unknown;
						break;
					}
					case HttpStatusCode.Forbidden:
					{
						twitterResponse.Result = RequestResult.Unauthorized;
						break;
					}
					case HttpStatusCode.NotFound:
					{
						twitterResponse.Result = RequestResult.FileNotFound;
						break;
					}
					case HttpStatusCode.ProxyAuthenticationRequired:
					{
						twitterResponse.Result = RequestResult.ProxyAuthenticationRequired;
						break;
					}
					case HttpStatusCode.RequestTimeout:
					{
						twitterResponse.Result = RequestResult.TwitterIsOverloaded;
						break;
					}
					default:
					{
						if ((int)httpStatusCode == 0x1a4)
						{
							twitterResponse.Result = RequestResult.RateLimited;
							break;
						}
						else
						{
							goto case HttpStatusCode.NotAcceptable;
						}
					}
				}
			}
		}
	}
}