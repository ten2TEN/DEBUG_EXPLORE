using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Twitterizer.Core;

namespace Twitterizer
{
	[DataContract]
	[Serializable]
	public class TwitterTrendLocation : TwitterObject
	{
		[DataMember]
		public string Country
		{
			get;
			set;
		}

		[DataMember]
		public string CountryCode
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

		[DataMember]
		public TwitterTrendLocationPlaceType PlaceType
		{
			get;
			set;
		}

		[DataMember]
		public string URL
		{
			get;
			set;
		}

		[DataMember]
		public int WOEID
		{
			get;
			set;
		}

		public TwitterTrendLocation()
		{
		}
	}
}