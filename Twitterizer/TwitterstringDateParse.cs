using System;
using System.Globalization;

namespace Twitterizer
{
	public class TwitterstringDateParse
	{
		protected const string DateFormat = "ddd MMM dd HH:mm:ss zz00 yyyy";

		public TwitterstringDateParse()
		{
		}

		public DateTime Parse(string Datestr)
		{
			DateTime dateTime;
			return (DateTime.TryParseExact(Datestr, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime) ? dateTime : new DateTime());
		}
	}
}