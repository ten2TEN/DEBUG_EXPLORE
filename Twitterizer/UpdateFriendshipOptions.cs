using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class UpdateFriendshipOptions : OptionalProperties
	{
		public bool? DeviceNotifications
		{
			get;
			set;
		}

		public bool? ShowRetweets
		{
			get;
			set;
		}

		public UpdateFriendshipOptions()
		{
			bool? nullable = null;
			this.DeviceNotifications = nullable;
			nullable = null;
			this.ShowRetweets = nullable;
		}
	}
}