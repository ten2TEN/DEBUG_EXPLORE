using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Twitterizer
{
	[Serializable]
	public class OptionalProperties
	{
		public string APIBaseAddress
		{
			get;
			set;
		}

		public WebProxy Proxy
		{
			get;
			set;
		}

		public bool UseSSL
		{
			get;
			set;
		}

		public OptionalProperties()
		{
			this.UseSSL = true;
			this.APIBaseAddress = "http://api.twitter.com/1.1/";
		}
	}
}