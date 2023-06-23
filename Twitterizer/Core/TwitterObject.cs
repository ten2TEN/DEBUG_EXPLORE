using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Twitterizer.Core
{
	[Serializable]
	public class TwitterObject : ITwitterObject
	{
		protected const string DateFormat = "ddd MMM dd HH:mm:ss zz00 yyyy";

		protected const string SearchDateFormat = "ddd, dd MMM yyyy HH:mm:ss +zz00";

		[JsonProperty(PropertyName="annotations")]
		public Dictionary<string, string> Annotations
		{
			get;
			set;
		}

		public TwitterObject()
		{
		}
	}
}