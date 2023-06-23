using System;
using System.Collections.Generic;
using Twitterizer;

namespace Twitterizer.Core
{
	public interface ICommand<T>
	where T : ITwitterObject
	{
		Dictionary<string, object> RequestParameters
		{
			get;
		}

		TwitterResponse<T> ExecuteCommand();

		void Init();
	}
}