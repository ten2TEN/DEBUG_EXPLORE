using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	public class LookupUsersOptions : OptionalProperties
	{
		public bool IncludeEntities
		{
			get;
			set;
		}

		public Collection<string> ScreenNames
		{
			get;
			set;
		}

		public TwitterIdCollection UserIds
		{
			get;
			set;
		}

		public LookupUsersOptions()
		{
			this.ScreenNames = new Collection<string>();
			this.UserIds = new TwitterIdCollection();
		}
	}
}