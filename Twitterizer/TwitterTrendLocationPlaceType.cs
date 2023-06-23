using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Twitterizer
{
	[DataContract]
	[Serializable]
	public class TwitterTrendLocationPlaceType
	{
		[DataMember]
		public int Code
		{
			get;
			set;
		}

		[DataMember]
		public string Name
		{
			get;
			set;
		}

		public TwitterTrendLocationPlaceType()
		{
		}
	}
}