using System;
using System.ComponentModel;

namespace Facebook
{
	public class FacebookUploadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		private readonly long _received;

		private readonly long _sent;

		private readonly long _totalRecived;

		private readonly long _totalSend;

		public long BytesReceived
		{
			get
			{
				return this._received;
			}
		}

		public long BytesSent
		{
			get
			{
				return this._sent;
			}
		}

		public long TotalBytesToReceive
		{
			get
			{
				return this._totalRecived;
			}
		}

		public long TotalBytesToSend
		{
			get
			{
				return this._totalSend;
			}
		}

		public FacebookUploadProgressChangedEventArgs(long bytesReceived, long totalBytesToReceive, long bytesSent, long totalBytesToSend, int progressPercentage, object userToken) : base(progressPercentage, userToken)
		{
			this._received = bytesReceived;
			this._totalRecived = totalBytesToReceive;
			this._sent = bytesSent;
			this._totalSend = totalBytesToSend;
		}
	}
}