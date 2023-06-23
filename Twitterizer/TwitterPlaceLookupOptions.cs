using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class TwitterPlaceLookupOptions : OptionalProperties
	{
		public string Accuracy
		{
			get;
			set;
		}

		public string Granularity
		{
			get;
			set;
		}

		public int? MaxResults
		{
			get;
			set;
		}

		public TwitterPlaceLookupOptions()
		{
		}
	}
}