using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Facebook
{
	public class FacebookMediaStream : IDisposable
	{
		private Stream _value;

		public string ContentType
		{
			get;
			set;
		}

		public string FileName
		{
			get;
			set;
		}

		public FacebookMediaStream()
		{
		}

		public void Dispose()
		{
			Stream value = this.GetValue();
			if (value != null)
			{
				value.Dispose();
			}
		}

		public Stream GetValue()
		{
			return this._value;
		}

		public FacebookMediaStream SetValue(Stream value)
		{
			this._value = value;
			return this;
		}
	}
}