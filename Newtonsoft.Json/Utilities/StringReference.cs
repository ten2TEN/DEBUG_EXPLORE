using System;

namespace Newtonsoft.Json.Utilities
{
	internal struct StringReference
	{
		private readonly char[] _chars;

		private readonly int _startIndex;

		private readonly int _length;

		public char[] Chars
		{
			get
			{
				return this._chars;
			}
		}

		public int Length
		{
			get
			{
				return this._length;
			}
		}

		public int StartIndex
		{
			get
			{
				return this._startIndex;
			}
		}

		public StringReference(char[] chars, int startIndex, int length)
		{
			this._chars = chars;
			this._startIndex = startIndex;
			this._length = length;
		}

		public override string ToString()
		{
			return new string(this._chars, this._startIndex, this._length);
		}
	}
}