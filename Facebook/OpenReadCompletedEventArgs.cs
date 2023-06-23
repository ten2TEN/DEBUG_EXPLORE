using System;
using System.ComponentModel;
using System.IO;

namespace Facebook
{
	internal class OpenReadCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly Stream _result;

		public Stream Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		public OpenReadCompletedEventArgs(Stream result, Exception error, bool cancelled, object userState) : base(error, cancelled, userState)
		{
			this._result = result;
		}
	}
}