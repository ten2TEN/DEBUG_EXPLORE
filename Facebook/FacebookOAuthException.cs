using System;
using System.Runtime.Serialization;

namespace Facebook
{
	[Serializable]
	public class FacebookOAuthException : FacebookApiException
	{
		public FacebookOAuthException()
		{
		}

		public FacebookOAuthException(string message) : base(message)
		{
		}

		public FacebookOAuthException(string message, string errorType) : base(message, errorType)
		{
		}

		public FacebookOAuthException(string message, string errorType, int errorCode) : base(message, errorType, errorCode)
		{
		}

		public FacebookOAuthException(string message, string errorType, int errorCode, int errorSubcode) : base(message, errorType, errorCode, errorSubcode)
		{
		}

		public FacebookOAuthException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected FacebookOAuthException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}