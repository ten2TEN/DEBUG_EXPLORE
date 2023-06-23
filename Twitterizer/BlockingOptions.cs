using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class BlockingOptions : OptionalProperties
	{
		public int Page
		{
			get;
			set;
		}

		public BlockingOptions()
		{
		}
	}
}