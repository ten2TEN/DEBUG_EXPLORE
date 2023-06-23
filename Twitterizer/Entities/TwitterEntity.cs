using System;
using System.Runtime.CompilerServices;

namespace Twitterizer.Entities
{
	[Serializable]
	public class TwitterEntity
	{
		public int EndIndex
		{
			get;
			set;
		}

		public int StartIndex
		{
			get;
			set;
		}

		internal TwitterEntity()
		{
		}
	}
}