using System;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterDirectMessageCollection : TwitterCollection<TwitterDirectMessage>, ITwitterObject
	{
		public TwitterDirectMessageCollection()
		{
		}
	}
}