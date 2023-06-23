using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class IncomingFriendshipsOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

		public IncomingFriendshipsOptions()
		{
		}
	}
}