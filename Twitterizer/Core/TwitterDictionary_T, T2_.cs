using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Twitterizer.Core
{
	[DataContract]
	[Serializable]
	public abstract class TwitterDictionary<T, T2> : Dictionary<T, T2>
	where T2 : class, ITwitterObject
	{
		[DataMember]
		public Dictionary<string, string> Annotations
		{
			get;
			set;
		}

		protected TwitterDictionary()
		{
		}
	}
}