using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Facebook
{
	internal class CombinationStream : Stream
	{
		private readonly IList<Stream> _streams;

		private readonly IList<int> _streamsToDispose;

		private int _currentStreamIndex;

		private Stream _currentStream;

		private long _length = (long)-1;

		private long _postion;

		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public IList<Stream> InternalStreams
		{
			get
			{
				return this._streams;
			}
		}

		public override long Length
		{
			get
			{
				if (this._length == (long)-1)
				{
					this._length = (long)0;
					foreach (Stream _stream in this._streams)
					{
						this._length += _stream.Length;
					}
				}
				return this._length;
			}
		}

		public override long Position
		{
			get
			{
				return this._postion;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public CombinationStream(IList<Stream> streams) : this(streams, null)
		{
		}

		public CombinationStream(IList<Stream> streams, IList<int> streamsToDispose)
		{
			if (streams == null)
			{
				throw new ArgumentNullException("streams");
			}
			this._streams = streams;
			this._streamsToDispose = streamsToDispose;
			if (streams.Count > 0)
			{
				CombinationStream combinationStream = this;
				int num = combinationStream._currentStreamIndex;
				int num1 = num;
				combinationStream._currentStreamIndex = num + 1;
				this._currentStream = streams[num1];
			}
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			CombinationStream.CombinationStreamAsyncResult combinationStreamAsyncResult = new CombinationStream.CombinationStreamAsyncResult(state);
			if (count <= 0)
			{
				combinationStreamAsyncResult.CompletedSynchronously = true;
				combinationStreamAsyncResult.SetAsyncWaitHandle();
				combinationStreamAsyncResult.IsCompleted = true;
				callback(combinationStreamAsyncResult);
			}
			else
			{
				AsyncCallback asyncCallback = null;
				asyncCallback = (IAsyncResult readresult) => {
					try
					{
						int num = this.CSu0024u003cu003e8__locals2.u003cu003e4__this._currentStream.EndRead(readresult);
						this.CSu0024u003cu003e8__locals2.asyncResult.BytesRead += num;
						this.buffPostion += num;
						this.CSu0024u003cu003e8__locals2.u003cu003e4__this._postion += (long)num;
						if (num <= this.CSu0024u003cu003e8__locals2.count)
						{
							this.CSu0024u003cu003e8__locals2.count -= num;
						}
						if (this.CSu0024u003cu003e8__locals2.count <= 0)
						{
							this.CSu0024u003cu003e8__locals2.asyncResult.CompletedSynchronously = false;
							this.CSu0024u003cu003e8__locals2.asyncResult.SetAsyncWaitHandle();
							this.CSu0024u003cu003e8__locals2.asyncResult.IsCompleted = true;
							this.CSu0024u003cu003e8__locals2.callback(this.CSu0024u003cu003e8__locals2.asyncResult);
						}
						else if (this.CSu0024u003cu003e8__locals2.u003cu003e4__this._currentStreamIndex < this.CSu0024u003cu003e8__locals2.u003cu003e4__this._streams.Count)
						{
							CombinationStream u003cu003e4_this = this.CSu0024u003cu003e8__locals2.u003cu003e4__this;
							IList<Stream> streams = this.CSu0024u003cu003e8__locals2.u003cu003e4__this._streams;
							CombinationStream combinationStream = this.CSu0024u003cu003e8__locals2.u003cu003e4__this;
							int num1 = combinationStream._currentStreamIndex;
							int num2 = num1;
							combinationStream._currentStreamIndex = num1 + 1;
							u003cu003e4_this._currentStream = streams[num2];
							this.CSu0024u003cu003e8__locals2.u003cu003e4__this._currentStream.BeginRead(this.CSu0024u003cu003e8__locals2.buffer, this.buffPostion, this.CSu0024u003cu003e8__locals2.count, this.rc, readresult.AsyncState);
						}
						else
						{
							this.CSu0024u003cu003e8__locals2.asyncResult.CompletedSynchronously = false;
							this.CSu0024u003cu003e8__locals2.asyncResult.SetAsyncWaitHandle();
							this.CSu0024u003cu003e8__locals2.asyncResult.IsCompleted = true;
							this.CSu0024u003cu003e8__locals2.callback(this.CSu0024u003cu003e8__locals2.asyncResult);
						}
					}
					catch (Exception exception)
					{
						this.CSu0024u003cu003e8__locals2.asyncResult.Exception = exception;
						this.CSu0024u003cu003e8__locals2.asyncResult.CompletedSynchronously = false;
						this.CSu0024u003cu003e8__locals2.asyncResult.SetAsyncWaitHandle();
						this.CSu0024u003cu003e8__locals2.asyncResult.IsCompleted = true;
						this.CSu0024u003cu003e8__locals2.callback(this.CSu0024u003cu003e8__locals2.asyncResult);
					}
				};
				this._currentStream.BeginRead(buffer, offset, count, asyncCallback, state);
			}
			return combinationStreamAsyncResult;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new InvalidOperationException("Stream is not writable");
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (this._streamsToDispose != null)
			{
				for (int i = 0; i < this.InternalStreams.Count; i++)
				{
					this.InternalStreams[i].Dispose();
				}
			}
			else
			{
				foreach (Stream internalStream in this.InternalStreams)
				{
					internalStream.Dispose();
				}
			}
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			asyncResult.AsyncWaitHandle.WaitOne();
			CombinationStream.CombinationStreamAsyncResult combinationStreamAsyncResult = (CombinationStream.CombinationStreamAsyncResult)asyncResult;
			if (combinationStreamAsyncResult.Exception != null)
			{
				throw combinationStreamAsyncResult.Exception;
			}
			return combinationStreamAsyncResult.BytesRead;
		}

		public override void Flush()
		{
			if (this._currentStream != null)
			{
				this._currentStream.Flush();
			}
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = 0;
			int num1 = offset;
			while (count > 0)
			{
				int num2 = this._currentStream.Read(buffer, num1, count);
				num += num2;
				num1 += num2;
				this._postion += (long)num2;
				if (num2 <= count)
				{
					count -= num2;
				}
				if (count <= 0)
				{
					continue;
				}
				if (this._currentStreamIndex >= this._streams.Count)
				{
					break;
				}
				IList<Stream> streams = this._streams;
				CombinationStream combinationStream = this;
				int num3 = combinationStream._currentStreamIndex;
				int num4 = num3;
				combinationStream._currentStreamIndex = num3 + 1;
				this._currentStream = streams[num4];
			}
			return num;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new InvalidOperationException("Stream is not seekable.");
		}

		public override void SetLength(long value)
		{
			this._length = value;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new InvalidOperationException("Stream is not writable");
		}

		internal class CombinationStreamAsyncResult : IAsyncResult
		{
			private readonly object _asyncState;

			private readonly ManualResetEvent _manualResetEvent;

			public int BytesRead;

			public object AsyncState
			{
				get
				{
					return this._asyncState;
				}
			}

			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return this._manualResetEvent;
				}
			}

			public bool CompletedSynchronously
			{
				get
				{
					return get_CompletedSynchronously();
				}
				set
				{
					set_CompletedSynchronously(value);
				}
			}

			// <CompletedSynchronously>k__BackingField
			private bool u003cCompletedSynchronouslyu003ek__BackingField;

			public bool get_CompletedSynchronously()
			{
				return this.u003cCompletedSynchronouslyu003ek__BackingField;
			}

			internal void set_CompletedSynchronously(bool value)
			{
				this.u003cCompletedSynchronouslyu003ek__BackingField = value;
			}

			public Exception Exception
			{
				get;
				internal set;
			}

			public bool IsCompleted
			{
				get
				{
					return get_IsCompleted();
				}
				set
				{
					set_IsCompleted(value);
				}
			}

			// <IsCompleted>k__BackingField
			private bool u003cIsCompletedu003ek__BackingField;

			public bool get_IsCompleted()
			{
				return this.u003cIsCompletedu003ek__BackingField;
			}

			internal void set_IsCompleted(bool value)
			{
				this.u003cIsCompletedu003ek__BackingField = value;
			}

			public CombinationStreamAsyncResult(object asyncState)
			{
				this._asyncState = asyncState;
				this._manualResetEvent = new ManualResetEvent(false);
			}

			internal void SetAsyncWaitHandle()
			{
				this._manualResetEvent.Set();
			}
		}
	}
}