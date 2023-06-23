using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Twitterizer.Core;

namespace Twitterizer
{
	[Serializable]
	public class TwitterIdCollection : Collection<decimal>, ITwitterObject
	{
		public Dictionary<string, string> Annotations
		{
			get;
			set;
		}

		public TwitterIdCollection()
		{
		}

		public TwitterIdCollection(List<decimal> items)
		{
			items.ForEach(new Action<decimal>(this.Add));
		}

		public static explicit operator TwitterIdCollection(List<decimal> collection)
		{
			TwitterIdCollection twitterIdCollection = new TwitterIdCollection();
			foreach (decimal num in collection)
			{
				twitterIdCollection.Add(num);
			}
			return twitterIdCollection;
		}
	}
}