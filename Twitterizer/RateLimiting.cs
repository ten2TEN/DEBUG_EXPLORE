using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class RateLimiting
	{
		public int Remaining
		{
			get;
			internal set;
		}

		public DateTime ResetDate
		{
			get;
			internal set;
		}

		public int Total
		{
			get;
			internal set;
		}

		public RateLimiting()
		{
		}
	}
}