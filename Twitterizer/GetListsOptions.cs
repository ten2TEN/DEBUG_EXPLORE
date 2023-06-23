using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class GetListsOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

		public GetListsOptions()
		{
		}
	}
}