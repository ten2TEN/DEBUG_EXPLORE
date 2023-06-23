using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class AvailableTrendsOptions : OptionalProperties
	{
		public double? Lat
		{
			get;
			set;
		}

		public double? Long
		{
			get;
			set;
		}

		public AvailableTrendsOptions()
		{
		}
	}
}