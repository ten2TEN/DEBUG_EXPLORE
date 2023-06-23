using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class ListMembershipsOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

		public bool FilterToOwnedLists
		{
			get;
			set;
		}

		public ListMembershipsOptions()
		{
		}
	}
}