using System;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterSavedSearchCollection : TwitterCollection<TwitterSavedSearch>, ITwitterObject
	{
		public TwitterSavedSearchCollection()
		{
		}
	}
}