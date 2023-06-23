using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public static class TwitterIdCollectionExtensions
	{
		public static TwitterIdCollection ToIdCollection(this IEnumerable<decimal> old)
		{
			TwitterIdCollection twitterIdCollection = new TwitterIdCollection();
			foreach (decimal num in old)
			{
				twitterIdCollection.Add(num);
			}
			return twitterIdCollection;
		}
	}
}