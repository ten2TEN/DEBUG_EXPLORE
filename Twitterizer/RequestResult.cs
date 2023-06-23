using System;

namespace Twitterizer
{
	public enum RequestResult
	{
		Success,
		FileNotFound,
		BadRequest,
		Unauthorized,
		NotAcceptable,
		RateLimited,
		TwitterIsDown,
		TwitterIsOverloaded,
		ConnectionFailure,
		Unknown,
		ProxyAuthenticationRequired
	}
}