using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class DirectMessagesSentOptions : OptionalProperties
	{
		public int Count
		{
			get;
			set;
		}

		public bool IncludeEntites
		{
			get;
			set;
		}

		public decimal MaxStatusId
		{
			get;
			set;
		}

		public int Page
		{
			get;
			set;
		}

		public decimal SinceStatusId
		{
			get;
			set;
		}

		public DirectMessagesSentOptions()
		{
			this.Page = 1;
		}
	}
}