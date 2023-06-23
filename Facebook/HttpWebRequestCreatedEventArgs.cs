using System;

namespace Facebook
{
	internal class HttpWebRequestCreatedEventArgs : EventArgs
	{
		private readonly object _userToken;

		private readonly HttpWebRequestWrapper _httpWebRequestWrapper;

		public HttpWebRequestWrapper HttpWebRequest
		{
			get
			{
				return this._httpWebRequestWrapper;
			}
		}

		public object UserState
		{
			get
			{
				return this._userToken;
			}
		}

		public HttpWebRequestCreatedEventArgs(object userToken, HttpWebRequestWrapper httpWebRequestWrapper)
		{
			this._userToken = userToken;
			this._httpWebRequestWrapper = httpWebRequestWrapper;
		}
	}
}