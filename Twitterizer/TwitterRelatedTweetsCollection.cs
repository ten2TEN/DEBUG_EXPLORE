using System;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterRelatedTweetsCollection : TwitterCollection<TwitterRelatedTweets>, ITwitterObject
	{
		public TwitterRelatedTweetsCollection()
		{
		}
	}
}