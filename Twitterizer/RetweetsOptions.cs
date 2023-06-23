using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class RetweetsOptions : OptionalProperties
	{
		public int Count
		{
			get;
			set;
		}

		public RetweetsOptions()
		{
		}
	}
}