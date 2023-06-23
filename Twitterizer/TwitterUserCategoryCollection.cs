using System;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterUserCategoryCollection : TwitterCollection<TwitterUserCategory>, ITwitterObject
	{
		public TwitterUserCategoryCollection()
		{
		}
	}
}