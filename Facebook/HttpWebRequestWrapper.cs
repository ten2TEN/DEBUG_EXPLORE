using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Facebook
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HttpWebRequestWrapper
	{
		private readonly HttpWebRequest _httpWebRequest;

		private object _cancelledLock = new object();

		public virtual string Accept
		{
			get
			{
				return this._httpWebRequest.Accept;
			}
			set
			{
				this._httpWebRequest.Accept = value;
			}
		}

		public virtual bool AllowAutoRedirect
		{
			get
			{
				return this._httpWebRequest.AllowAutoRedirect;
			}
			set
			{
				this._httpWebRequest.AllowAutoRedirect = value;
			}
		}

		public virtual bool AllowWriteStreamBuffering
		{
			get
			{
				return this._httpWebRequest.AllowWriteStreamBuffering;
			}
			set
			{
				this._httpWebRequest.AllowWriteStreamBuffering = value;
			}
		}

		public virtual DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this._httpWebRequest.AutomaticDecompression;
			}
			set
			{
				this._httpWebRequest.AutomaticDecompression = value;
			}
		}

		public virtual string Connection
		{
			get
			{
				return this._httpWebRequest.Connection;
			}
			set
			{
				this._httpWebRequest.Connection = value;
			}
		}

		public virtual long ContentLength
		{
			get
			{
				return this._httpWebRequest.ContentLength;
			}
			set
			{
				this._httpWebRequest.ContentLength = value;
			}
		}

		public virtual string ContentType
		{
			get
			{
				return this._httpWebRequest.ContentType;
			}
			set
			{
				this._httpWebRequest.ContentType = value;
			}
		}

		public virtual System.Net.CookieContainer CookieContainer
		{
			get
			{
				return this._httpWebRequest.CookieContainer;
			}
			set
			{
				this._httpWebRequest.CookieContainer = value;
			}
		}

		public virtual ICredentials Credentials
		{
			get
			{
				return this._httpWebRequest.Credentials;
			}
			set
			{
				this._httpWebRequest.Credentials = value;
			}
		}

		public virtual string Expect
		{
			get
			{
				return this._httpWebRequest.Expect;
			}
			set
			{
				this._httpWebRequest.Expect = value;
			}
		}

		public virtual WebHeaderCollection Headers
		{
			get
			{
				return this._httpWebRequest.Headers;
			}
			set
			{
				this._httpWebRequest.Headers = value;
			}
		}

		public virtual DateTime IfModifiedSince
		{
			get
			{
				return this._httpWebRequest.IfModifiedSince;
			}
			set
			{
				this._httpWebRequest.IfModifiedSince = value;
			}
		}

		public virtual bool IsCancelled
		{
			get;
			set;
		}

		public virtual string Method
		{
			get
			{
				return this._httpWebRequest.Method;
			}
			set
			{
				this._httpWebRequest.Method = value;
			}
		}

		public virtual IWebProxy Proxy
		{
			get
			{
				return this._httpWebRequest.Proxy;
			}
			set
			{
				this._httpWebRequest.Proxy = value;
			}
		}

		public virtual int ReadWriteTimeout
		{
			get
			{
				return this._httpWebRequest.ReadWriteTimeout;
			}
			set
			{
				this._httpWebRequest.ReadWriteTimeout = value;
			}
		}

		public virtual string Referer
		{
			get
			{
				return this._httpWebRequest.Referer;
			}
			set
			{
				this._httpWebRequest.Referer = value;
			}
		}

		public virtual Uri RequestUri
		{
			get
			{
				return this._httpWebRequest.RequestUri;
			}
		}

		public virtual System.Net.ServicePoint ServicePoint
		{
			get
			{
				return this._httpWebRequest.ServicePoint;
			}
		}

		public virtual int Timeout
		{
			get
			{
				return this._httpWebRequest.Timeout;
			}
			set
			{
				this._httpWebRequest.Timeout = value;
			}
		}

		public virtual string TransferEncoding
		{
			get
			{
				return this._httpWebRequest.TransferEncoding;
			}
			set
			{
				this._httpWebRequest.TransferEncoding = value;
			}
		}

		public virtual string UserAgent
		{
			get
			{
				return this._httpWebRequest.UserAgent;
			}
			set
			{
				this._httpWebRequest.UserAgent = value;
			}
		}

		protected HttpWebRequestWrapper()
		{
		}

		public HttpWebRequestWrapper(HttpWebRequest httpWebRequest)
		{
			if (httpWebRequest == null)
			{
				throw new ArgumentNullException("httpWebRequest");
			}
			this._httpWebRequest = httpWebRequest;
		}

		public virtual void Abort()
		{
			lock (this._cancelledLock)
			{
				try
				{
					try
					{
						this._httpWebRequest.Abort();
					}
					catch (WebException webException)
					{
						throw new WebExceptionWrapper(webException);
					}
				}
				finally
				{
					this.IsCancelled = true;
				}
			}
		}

		public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return this._httpWebRequest.BeginGetRequestStream(callback, state);
		}

		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return this._httpWebRequest.BeginGetResponse(callback, state);
		}

		public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			return this._httpWebRequest.EndGetRequestStream(asyncResult);
		}

		public virtual HttpWebResponseWrapper EndGetResponse(IAsyncResult asyncResult)
		{
			return new HttpWebResponseWrapper((HttpWebResponse)this._httpWebRequest.EndGetResponse(asyncResult));
		}

		public virtual Stream GetRequestStream()
		{
			return this._httpWebRequest.GetRequestStream();
		}

		public virtual Task<Stream> GetRequestStreamAsync()
		{
			TaskFactory<Stream> factory = Task<Stream>.Factory;
			HttpWebRequestWrapper httpWebRequestWrapper = this;
			HttpWebRequestWrapper httpWebRequestWrapper1 = this;
			return factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(httpWebRequestWrapper.BeginGetRequestStream), new Func<IAsyncResult, Stream>(httpWebRequestWrapper1.EndGetRequestStream), null);
		}

		public virtual HttpWebResponseWrapper GetResponse()
		{
			return new HttpWebResponseWrapper((HttpWebResponse)this._httpWebRequest.GetResponse());
		}

		public virtual Task<HttpWebResponseWrapper> GetResponseAsync()
		{
			TaskFactory<HttpWebResponseWrapper> factory = Task<HttpWebResponseWrapper>.Factory;
			HttpWebRequestWrapper httpWebRequestWrapper = this;
			HttpWebRequestWrapper httpWebRequestWrapper1 = this;
			return factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(httpWebRequestWrapper.BeginGetResponse), new Func<IAsyncResult, HttpWebResponseWrapper>(httpWebRequestWrapper1.EndGetResponse), null);
		}

		public virtual bool TrySetContentLength(long contentLength)
		{
			this.ContentLength = contentLength;
			return true;
		}

		public virtual bool TrySetUserAgent(string userAgent)
		{
			this.UserAgent = userAgent;
			return true;
		}
	}
}