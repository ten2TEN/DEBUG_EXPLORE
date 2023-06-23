using System;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public sealed class StatusUpdateOptions : OptionalProperties
	{
		public decimal InReplyToStatusId
		{
			get;
			set;
		}

		public double Latitude
		{
			get;
			set;
		}

		public double Longitude
		{
			get;
			set;
		}

		public string PlaceId
		{
			get;
			set;
		}

		public bool PlacePin
		{
			get;
			set;
		}

		public bool WrapLinks
		{
			get;
			set;
		}

		public StatusUpdateOptions()
		{
		}
	}
}