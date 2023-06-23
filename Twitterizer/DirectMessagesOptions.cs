using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class DirectMessagesOptions : OptionalProperties
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

		public DirectMessagesOptions()
		{
			this.Page = 1;
		}
	}
}