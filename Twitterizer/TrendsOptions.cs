using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class TrendsOptions : LocalTrendsOptions
	{
		public string Date
		{
			get;
			set;
		}

		public TrendsOptions()
		{
		}
	}
}