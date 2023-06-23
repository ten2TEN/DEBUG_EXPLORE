using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class UserSearchOptions : OptionalProperties
	{
		public int NumberPerPage
		{
			get;
			set;
		}

		public int Page
		{
			get;
			set;
		}

		public UserSearchOptions()
		{
		}
	}
}