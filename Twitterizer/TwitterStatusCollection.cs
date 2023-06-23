using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Core;

namespace Twitterizer
{
	[DataContract]
	[Serializable]
	public class TwitterStatusCollection : TwitterCollection<TwitterStatus>, ITwitterObject
	{
		[DataMember]
		public int Page
		{
			get;
			set;
		}

		public TwitterStatusCollection()
		{
		}
	}
}