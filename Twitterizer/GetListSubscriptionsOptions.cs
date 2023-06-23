using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class GetListSubscriptionsOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

		public GetListSubscriptionsOptions()
		{
		}
	}
}