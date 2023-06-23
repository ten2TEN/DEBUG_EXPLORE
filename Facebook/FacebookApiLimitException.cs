using System;
using System.Runtime.Serialization;

namespace Facebook
{
	[Serializable]
	public class FacebookApiLimitException : FacebookApiException
	{
		public FacebookApiLimitException()
		{
		}

		public FacebookApiLimitException(string message) : base(message)
		{
		}

		public FacebookApiLimitException(string message, string errorType) : base(message, errorType)
		{
		}

		public FacebookApiLimitException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected FacebookApiLimitException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}