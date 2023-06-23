using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class OutgoingFriendshipsOptions : OptionalProperties
	{
		public long Cursor
		{
			get;
			set;
		}

		public OutgoingFriendshipsOptions()
		{
		}
	}
}