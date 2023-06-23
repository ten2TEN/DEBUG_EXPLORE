using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class UpdateListOptions : OptionalProperties
	{
		public string Description
		{
			get;
			set;
		}

		public bool? IsPublic
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public UpdateListOptions()
		{
		}
	}
}