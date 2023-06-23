using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class GetListMembersOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

		public GetListMembersOptions()
		{
		}
	}
}