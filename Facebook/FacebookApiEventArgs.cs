using System;
using System.ComponentModel;

namespace Facebook
{
	public class FacebookApiEventArgs : AsyncCompletedEventArgs
	{
		private readonly object _result;

		public FacebookApiEventArgs(Exception error, bool cancelled, object userState, object result) : base(error, cancelled, userState)
		{
			this._result = result;
		}

		public object GetResultData()
		{
			base.RaiseExceptionIfNecessary();
			return this._result;
		}

		public TResult GetResultData<TResult>()
		{
			base.RaiseExceptionIfNecessary();
			return (TResult)this._result;
		}
	}
}