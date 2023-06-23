using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace Facebook
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HttpWebResponseWrapper
	{
		private readonly HttpWebResponse _httpWebResponse;

		public virtual string CharacterSet
		{
			get
			{
				return this._httpWebResponse.CharacterSet;
			}
		}

		public virtual string ContentEncoding
		{
			get
			{
				return this._httpWebResponse.ContentEncoding;
			}
		}

		public virtual long ContentLength
		{
			get
			{
				return this._httpWebResponse.ContentLength;
			}
		}

		public virtual string ContentType
		{
			get
			{
				return this._httpWebResponse.ContentType;
			}
		}

		public virtual CookieCollection Cookies
		{
			get
			{
				return this._httpWebResponse.Cookies;
			}
		}

		public virtual WebHeaderCollection Headers
		{
			get
			{
				return this._httpWebResponse.Headers;
			}
		}

		public virtual bool IsMutuallyAuthenticated
		{
			get
			{
				return this._httpWebResponse.IsMutuallyAuthenticated;
			}
		}

		public virtual DateTime LastModified
		{
			get
			{
				return this._httpWebResponse.LastModified;
			}
		}

		public virtual string Method
		{
			get
			{
				return this._httpWebResponse.Method;
			}
		}

		public virtual Version ProtocolVersion
		{
			get
			{
				return this._httpWebResponse.ProtocolVersion;
			}
		}

		public virtual Uri ResponseUri
		{
			get
			{
				return this._httpWebResponse.ResponseUri;
			}
		}

		public virtual string Server
		{
			get
			{
				return this._httpWebResponse.Server;
			}
		}

		public virtual HttpStatusCode StatusCode
		{
			get
			{
				return this._httpWebResponse.StatusCode;
			}
		}

		public virtual string StatusDescription
		{
			get
			{
				return this._httpWebResponse.StatusDescription;
			}
		}

		protected HttpWebResponseWrapper()
		{
		}

		public HttpWebResponseWrapper(HttpWebResponse httpWebResponse)
		{
			if (httpWebResponse == null)
			{
				throw new ArgumentNullException("httpWebResponse");
			}
			this._httpWebResponse = httpWebResponse;
		}

		public virtual Stream GetResponseStream()
		{
			return this._httpWebResponse.GetResponseStream();
		}
	}
}