using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterizerException : WebException
	{
		public string BugReport
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("\n--------------- ERROR MESSAGE ---------------\n{0}\n\n--------------- STACK TRACE -----------------\n{1}\n\n--------------- RESPONSE BODY ---------------\n{2}\n", this.Message, this.StackTrace, this.ResponseBody);
				stringBuilder.Append("--------------- HTTP HEADERS ----------------");
				for (int i = 0; i < this.Response.Headers.Count; i++)
				{
					stringBuilder.AppendFormat("{0} = \"{1}\"", this.Response.Headers.AllKeys[i], this.Response.Headers[this.Response.Headers.AllKeys[i]]);
				}
				return stringBuilder.ToString();
			}
		}

		public TwitterErrorDetails ErrorDetails
		{
			get;
			protected set;
		}

		public Twitterizer.RateLimiting RateLimiting
		{
			get;
			protected set;
		}

		public new WebResponse Response
		{
			get
			{
				WebResponse response;
				if (base.InnerException == null)
				{
					response = null;
				}
				else
				{
					response = ((WebException)base.InnerException).Response;
				}
				return response;
			}
		}

		public string ResponseBody
		{
			get;
			protected set;
		}

		public RequestResult Result
		{
			get;
			set;
		}

		public TwitterizerException()
		{
		}

		public TwitterizerException(string message) : base(message)
		{
		}

		public TwitterizerException(string message, Exception innerException) : base(message, innerException)
		{
			if (innerException.GetType() == typeof(WebException))
			{
				HttpWebResponse response = (HttpWebResponse)((WebException)innerException).Response;
				if (response != null)
				{
					Stream responseStream = response.GetResponseStream();
					if (responseStream == null)
					{
						return;
					}
					byte[] numArray = ConversionUtility.ReadStream(responseStream);
					this.ResponseBody = Encoding.UTF8.GetString(numArray, 0, (int)numArray.Length);
					this.ParseRateLimitHeaders(response);
					if (response.ContentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase))
					{
						this.ErrorDetails = SerializationHelper<TwitterErrorDetails>.Deserialize(numArray, null);
					}
					else if (response.ContentType.StartsWith("text/xml", StringComparison.OrdinalIgnoreCase))
					{
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(TwitterErrorDetails));
						this.ErrorDetails = xmlSerializer.Deserialize(new MemoryStream(numArray)) as TwitterErrorDetails;
					}
				}
				else
				{
					return;
				}
			}
		}

		protected void ParseRateLimitHeaders(WebResponse response)
		{
			this.RateLimiting = new Twitterizer.RateLimiting();
			if ((!response.Headers.AllKeys.Contains<string>("X-RateLimit-Limit") ? false : !string.IsNullOrEmpty(response.Headers["X-RateLimit-Limit"])))
			{
				this.RateLimiting.Total = int.Parse(response.Headers["X-RateLimit-Limit"], CultureInfo.InvariantCulture);
			}
			if ((!response.Headers.AllKeys.Contains<string>("X-RateLimit-Remaining") ? false : !string.IsNullOrEmpty(response.Headers["X-RateLimit-Remaining"])))
			{
				this.RateLimiting.Remaining = int.Parse(response.Headers["X-RateLimit-Remaining"], CultureInfo.InvariantCulture);
			}
			if ((string.IsNullOrEmpty(response.Headers["X-RateLimit-Reset"]) ? false : !string.IsNullOrEmpty(response.Headers["X-RateLimit-Reset"])))
			{
				Twitterizer.RateLimiting rateLimiting = this.RateLimiting;
				DateTime dateTime = new DateTime(0x7b2, 1, 1, 0, 0, 0, 0);
				rateLimiting.ResetDate = DateTime.SpecifyKind(dateTime.AddSeconds(double.Parse(response.Headers["X-RateLimit-Reset"], CultureInfo.InvariantCulture)), DateTimeKind.Utc);
			}
		}
	}
}