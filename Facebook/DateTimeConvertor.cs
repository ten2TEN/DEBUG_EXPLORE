using System;
using System.Globalization;

namespace Facebook
{
	public static class DateTimeConvertor
	{
		private readonly static string[] Iso8601Format;

		public static DateTime Epoch
		{
			get
			{
				return new DateTime(0x7b2, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			}
		}

		static DateTimeConvertor()
		{
			DateTimeConvertor.Iso8601Format = new string[] { "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z", "yyyy-MM-dd\\THH:mm:ss\\Z", "yyyy-MM-dd\\THH:mm:ssK" };
		}

		public static DateTime FromIso8601FormattedDateTime(string iso8601DateTime)
		{
			if (string.IsNullOrEmpty(iso8601DateTime))
			{
				throw new ArgumentNullException("iso8601DateTime");
			}
			return DateTime.ParseExact(iso8601DateTime, DateTimeConvertor.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
		}

		public static DateTime FromUnixTime(double unixTime)
		{
			return DateTimeConvertor.Epoch.AddSeconds(unixTime);
		}

		public static DateTime FromUnixTime(string unixTime)
		{
			double num;
			if (!double.TryParse(unixTime, out num))
			{
				return DateTimeConvertor.FromUnixTime(0);
			}
			return DateTimeConvertor.FromUnixTime(num);
		}

		public static string ToIso8601FormattedDateTime(DateTime dateTime)
		{
			DateTime universalTime = dateTime.ToUniversalTime();
			return universalTime.ToString(DateTimeConvertor.Iso8601Format[0], CultureInfo.InvariantCulture);
		}

		public static double ToUnixTime(DateTime dateTime)
		{
			TimeSpan universalTime = dateTime.ToUniversalTime() - DateTimeConvertor.Epoch;
			return Math.Round(universalTime.TotalSeconds);
		}

		public static double ToUnixTime(DateTimeOffset dateTime)
		{
			return (dateTime.ToUniversalTime() - DateTimeConvertor.Epoch).TotalSeconds;
		}
	}
}