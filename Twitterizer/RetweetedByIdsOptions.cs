using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class RetweetedByIdsOptions : OptionalProperties
	{
		public int Count
		{
			get;
			set;
		}

		public bool IncludeEntities
		{
			get;
			set;
		}

		public int Page
		{
			get;
			set;
		}

		public bool TrimUser
		{
			get;
			set;
		}

		public RetweetedByIdsOptions()
		{
		}
	}
}