using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class CreateFriendshipOptions : OptionalProperties
	{
		public bool Follow
		{
			get;
			set;
		}

		public CreateFriendshipOptions()
		{
		}
	}
}