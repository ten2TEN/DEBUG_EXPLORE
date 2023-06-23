using System;
using System.Collections.Generic;

namespace Twitterizer.Core
{
	public interface ITwitterObject
	{
		Dictionary<string, string> Annotations
		{
			get;
			set;
		}
	}
}