using System;
using System.Runtime.CompilerServices;

namespace Facebook
{
	public class FacebookMediaObject
	{
		private byte[] _value;

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

		public FacebookMediaObject()
		{
		}

		public byte[] GetValue()
		{
			return this._value;
		}

		public FacebookMediaObject SetValue(byte[] value)
		{
			this._value = value;
			return this;
		}
	}
}