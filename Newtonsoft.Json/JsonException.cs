using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonException : Exception
	{
		public JsonException()
		{
		}

		public JsonException(string message) : base(message)
		{
		}

		public JsonException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public JsonException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		internal static string FormatExceptionMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			if (!message.EndsWith(Environment.NewLine))
			{
				message = message.Trim();
				if (!message.EndsWith("."))
				{
					message = string.Concat(message, ".");
				}
				message = string.Concat(message, " ");
			}
			message = string.Concat(message, "Path '{0}'".FormatWith(CultureInfo.InvariantCulture, path));
			if (lineInfo != null && lineInfo.HasLineInfo())
			{
				message = string.Concat(message, ", line {0}, position {1}".FormatWith(CultureInfo.InvariantCulture, lineInfo.LineNumber, lineInfo.LinePosition));
			}
			message = string.Concat(message, ".");
			return message;
		}
	}
}