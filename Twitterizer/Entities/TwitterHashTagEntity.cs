using System;
using System.Runtime.CompilerServices;

namespace Twitterizer.Entities
{
	[Serializable]
	public class TwitterHashTagEntity : TwitterEntity
	{
		public string Text
		{
			get;
			set;
		}

		public TwitterHashTagEntity()
		{
		}
	}
}