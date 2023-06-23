using System;
using System.Runtime.CompilerServices;

namespace Twitterizer.Entities
{
	[Serializable]
	public class TwitterUrlEntity : TwitterEntity
	{
		public string DisplayUrl
		{
			get;
			set;
		}

		public string ExpandedUrl
		{
			get;
			set;
		}

		public string Url
		{
			get;
			set;
		}

		public TwitterUrlEntity()
		{
		}
	}
}