using System;

namespace Twitterizer.Core
{
	public delegate void TwitterAsyncCallback<T>(T result)
	where T : ITwitterObject;
}