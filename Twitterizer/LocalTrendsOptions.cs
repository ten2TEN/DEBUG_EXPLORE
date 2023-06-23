using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class LocalTrendsOptions : OptionalProperties
	{
		public bool ExcludeHashTags
		{
			get;
			set;
		}

		public LocalTrendsOptions()
		{
		}
	}
}