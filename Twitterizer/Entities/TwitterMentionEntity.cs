using System;
using System.Runtime.CompilerServices;

namespace Twitterizer.Entities
{
	[Serializable]
	public class TwitterMentionEntity : TwitterEntity
	{
		public string Name
		{
			get;
			set;
		}

		public string ScreenName
		{
			get;
			set;
		}

		public decimal UserId
		{
			get;
			set;
		}

		public TwitterMentionEntity()
		{
		}
	}
}