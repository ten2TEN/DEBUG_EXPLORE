using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class UserTimelineOptions : TimelineOptions
	{
		public string ScreenName
		{
			get;
			set;
		}

		public decimal UserId
		{
			get;
			set;
		}

		public UserTimelineOptions()
		{
		}
	}
}