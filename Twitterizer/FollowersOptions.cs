using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class FollowersOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

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

		public FollowersOptions()
		{
		}
	}
}