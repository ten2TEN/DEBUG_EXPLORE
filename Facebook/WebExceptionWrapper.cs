using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.Serialization;

namespace Facebook
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	public class WebExceptionWrapper : Exception
	{
		private readonly WebException _webException;

		private readonly WebExceptionStatus _status = WebExceptionStatus.UnknownError;

		public virtual WebException ActualWebException
		{
			get
			{
				return this._webException;
			}
		}

		public virtual WebExceptionStatus Status
		{
			get
			{
				return this._status;
			}
		}

		protected WebExceptionWrapper()
		{
		}

		public WebExceptionWrapper(WebException webException) : base((webException == null ? null : webException.Message), (webException == null ? null : webException.InnerException))
		{
			this._webException = webException;
			this._status = (webException == null ? WebExceptionStatus.UnknownError : webException.Status);
		}

		protected WebExceptionWrapper(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public virtual HttpWebResponseWrapper GetResponse()
		{
			if (this._webException.Response == null)
			{
				return null;
			}
			return new HttpWebResponseWrapper((HttpWebResponse)this._webException.Response);
		}
	}
}