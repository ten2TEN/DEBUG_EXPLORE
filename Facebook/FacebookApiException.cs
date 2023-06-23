using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Facebook
{
	[Serializable]
	public class FacebookApiException : Exception
	{
		public int ErrorCode
		{
			get;
			set;
		}

		public int ErrorSubcode
		{
			get;
			set;
		}

		public string ErrorType
		{
			get;
			set;
		}

		public FacebookApiException()
		{
		}

		public FacebookApiException(string message) : base(message)
		{
		}

		public FacebookApiException(string message, string errorType) : this(string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[] { errorType ?? "Unknown", message }))
		{
			this.ErrorType = errorType;
		}

		public FacebookApiException(string message, string errorType, int errorCode) : this(string.Format(CultureInfo.InvariantCulture, "({0} - #{1}) {2}", new object[] { errorType ?? "Unknown", errorCode, message }))
		{
			this.ErrorType = errorType;
			this.ErrorCode = errorCode;
		}

		public FacebookApiException(string message, string errorType, int errorCode, int errorSubcode) : this(message, errorType, errorCode)
		{
			this.ErrorSubcode = errorSubcode;
		}

		public FacebookApiException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected FacebookApiException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}