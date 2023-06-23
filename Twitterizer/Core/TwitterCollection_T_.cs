using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Twitterizer.Core
{
	[DataContract]
	[Serializable]
	public abstract class TwitterCollection<T> : Collection<T>
	where T : class, ITwitterObject
	{
		[DataMember]
		public Dictionary<string, string> Annotations
		{
			get;
			set;
		}

		protected TwitterCollection()
		{
		}
	}
}