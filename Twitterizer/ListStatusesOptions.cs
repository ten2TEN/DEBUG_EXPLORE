using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class ListStatusesOptions : OptionalProperties
	{
		public bool IncludeEntites
		{
			get;
			set;
		}

		public bool IncludeRetweets
		{
			get;
			set;
		}

		public int ItemsPerPage
		{
			get;
			set;
		}

		public long MaxId
		{
			get;
			set;
		}

		public int Page
		{
			get;
			set;
		}

		public long SinceId
		{
			get;
			set;
		}

		public ListStatusesOptions()
		{
		}
	}
}