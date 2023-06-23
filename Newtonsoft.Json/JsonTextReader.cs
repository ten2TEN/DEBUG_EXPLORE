using Newtonsoft.Json.Utilities;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json
{
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		private const char UnicodeReplacementChar = '\uFFFD';

		private readonly TextReader _reader;

		private char[] _chars;

		private int _charsUsed;

		private int _charPos;

		private int _lineStartPos;

		private int _lineNumber;

		private bool _isEndOfFile;

		private StringBuffer _buffer;

		private StringReference _stringReference;

		public int LineNumber
		{
			get
			{
				if (base.CurrentState == JsonReader.State.Start && this.LinePosition == 0)
				{
					return 0;
				}
				return this._lineNumber;
			}
		}

		public int LinePosition
		{
			get
			{
				return this._charPos - this._lineStartPos;
			}
		}

		public JsonTextReader(TextReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			this._reader = reader;
			this._lineNumber = 1;
			this._chars = new char[0x1001];
		}

		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
			Buffer.BlockCopy(src, srcOffset * 2, dst, dstOffset * 2, count * 2);
		}

		private void ClearRecentString()
		{
			if (this._buffer != null)
			{
				this._buffer.Position = 0;
			}
			this._stringReference = new StringReference();
		}

		public override void Close()
		{
			base.Close();
			if (base.CloseInput && this._reader != null)
			{
				this._reader.Close();
			}
			if (this._buffer != null)
			{
				this._buffer.Clear();
			}
		}

		private bool EatWhitespace(bool oneOrMore)
		{
			bool flag = false;
			bool flag1 = false;
			while (!flag)
			{
				char chr = this._chars[this._charPos];
				char chr1 = chr;
				if (chr1 == '\0')
				{
					if (this._charsUsed != this._charPos)
					{
						this._charPos++;
					}
					else
					{
						if (this.ReadData(false) != 0)
						{
							continue;
						}
						flag = true;
					}
				}
				else if (chr1 == '\n')
				{
					this.ProcessLineFeed();
				}
				else if (chr1 == '\r')
				{
					this.ProcessCarriageReturn(false);
				}
				else if (chr == ' ' || char.IsWhiteSpace(chr))
				{
					flag1 = true;
					this._charPos++;
				}
				else
				{
					flag = true;
				}
			}
			if (oneOrMore)
			{
				return flag1;
			}
			return true;
		}

		private bool EnsureChars(int relativePosition, bool append)
		{
			if (this._charPos + relativePosition < this._charsUsed)
			{
				return true;
			}
			return this.ReadChars(relativePosition, append);
		}

		private StringBuffer GetBuffer()
		{
			if (this._buffer != null)
			{
				this._buffer.Position = 0;
			}
			else
			{
				this._buffer = new StringBuffer(0x1000);
			}
			return this._buffer;
		}

		public bool HasLineInfo()
		{
			return true;
		}

		private bool IsSeperator(char c)
		{
			char chr = c;
			if (chr > ')')
			{
				if (chr <= '/')
				{
					if (chr == ',')
					{
						return true;
					}
					if (chr == '/')
					{
						if (!this.EnsureChars(1, false))
						{
							return false;
						}
						return this._chars[this._charPos + 1] == '*';
					}
					if (char.IsWhiteSpace(c))
					{
						return true;
					}
					return false;
				}
				else if (chr != ']' && chr != '}')
				{
					if (char.IsWhiteSpace(c))
					{
						return true;
					}
					return false;
				}
				return true;
			}
			else
			{
				switch (chr)
				{
					case '\t':
					case '\n':
					case '\r':
					{
						return true;
					}
					case '\v':
					case '\f':
					{
						break;
					}
					default:
					{
						if (chr == ' ')
						{
							return true;
						}
						if (chr == ')')
						{
							if (base.CurrentState != JsonReader.State.Constructor && base.CurrentState != JsonReader.State.ConstructorStart)
							{
								return false;
							}
							return true;
						}
						else
						{
							break;
						}
					}
				}
			}
			if (char.IsWhiteSpace(c))
			{
				return true;
			}
			return false;
		}

		private bool MatchValue(string value)
		{
			if (!this.EnsureChars(value.Length - 1, true))
			{
				return false;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (this._chars[this._charPos + i] != value[i])
				{
					return false;
				}
			}
			this._charPos += value.Length;
			return true;
		}

		private bool MatchValueWithTrailingSeperator(string value)
		{
			if (!this.MatchValue(value))
			{
				return false;
			}
			if (!this.EnsureChars(0, false))
			{
				return true;
			}
			if (this.IsSeperator(this._chars[this._charPos]))
			{
				return true;
			}
			return this._chars[this._charPos] == '\0';
		}

		private void OnNewLine(int pos)
		{
			this._lineNumber++;
			this._lineStartPos = pos - 1;
		}

		private void ParseComment()
		{
			this._charPos++;
			if (!this.EnsureChars(1, false) || this._chars[this._charPos] != '*')
			{
				throw JsonReaderException.Create(this, "Error parsing comment. Expected: *, got {0}.".FormatWith(CultureInfo.InvariantCulture, this._chars[this._charPos]));
			}
			this._charPos++;
			int num = this._charPos;
			bool flag = false;
			while (!flag)
			{
				char chr = this._chars[this._charPos];
				if (chr <= '\n')
				{
					if (chr != '\0')
					{
						if (chr == '\n')
						{
							this.ProcessLineFeed();
							continue;
						}
					}
					else if (this._charsUsed != this._charPos)
					{
						this._charPos++;
						continue;
					}
					else
					{
						if (this.ReadData(true) != 0)
						{
							continue;
						}
						throw JsonReaderException.Create(this, "Unexpected end while parsing comment.");
					}
				}
				else if (chr == '\r')
				{
					this.ProcessCarriageReturn(true);
					continue;
				}
				else if (chr == '*')
				{
					this._charPos++;
					if (!this.EnsureChars(0, true) || this._chars[this._charPos] != '/')
					{
						continue;
					}
					this._stringReference = new StringReference(this._chars, num, this._charPos - num - 1);
					this._charPos++;
					flag = true;
					continue;
				}
				this._charPos++;
			}
			base.SetToken(JsonToken.Comment, this._stringReference.ToString());
			this.ClearRecentString();
		}

		private void ParseConstructor()
		{
			int num;
			if (this.MatchValueWithTrailingSeperator("new"))
			{
				this.EatWhitespace(false);
				int num1 = this._charPos;
				while (true)
				{
					char chr = this._chars[this._charPos];
					if (chr == 0)
					{
						if (this._charsUsed != this._charPos)
						{
							num = this._charPos;
							this._charPos++;
							break;
						}
						else if (this.ReadData(true) == 0)
						{
							throw JsonReaderException.Create(this, "Unexpected end while parsing constructor.");
						}
					}
					else if (char.IsLetterOrDigit(chr))
					{
						this._charPos++;
					}
					else if (chr == '\r')
					{
						num = this._charPos;
						this.ProcessCarriageReturn(true);
						break;
					}
					else if (chr == '\n')
					{
						num = this._charPos;
						this.ProcessLineFeed();
						break;
					}
					else if (!char.IsWhiteSpace(chr))
					{
						if (chr != '(')
						{
							throw JsonReaderException.Create(this, "Unexpected character while parsing constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, chr));
						}
						num = this._charPos;
						break;
					}
					else
					{
						num = this._charPos;
						this._charPos++;
						break;
					}
				}
				this._stringReference = new StringReference(this._chars, num1, num - num1);
				string str = this._stringReference.ToString();
				this.EatWhitespace(false);
				if (this._chars[this._charPos] != '(')
				{
					throw JsonReaderException.Create(this, "Unexpected character while parsing constructor: {0}.".FormatWith(CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
				this._charPos++;
				this.ClearRecentString();
				base.SetToken(JsonToken.StartConstructor, str);
			}
		}

		private bool ParseDateIso(string text)
		{
			DateTimeOffset dateTimeOffset;
			DateTime dateTime;
			if (this._readType != ReadType.ReadAsDateTimeOffset && (this._readType != ReadType.Read || this._dateParseHandling != Newtonsoft.Json.DateParseHandling.DateTimeOffset))
			{
				if (DateTime.TryParseExact(text, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateTime))
				{
					dateTime = JsonConvert.EnsureDateTime(dateTime, base.DateTimeZoneHandling);
					base.SetToken(JsonToken.Date, dateTime);
					return true;
				}
			}
			else if (DateTimeOffset.TryParseExact(text, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateTimeOffset))
			{
				base.SetToken(JsonToken.Date, dateTimeOffset);
				return true;
			}
			return false;
		}

		private void ParseDateMicrosoft(string text)
		{
			DateTime localTime;
			string str = text.Substring(6, text.Length - 8);
			DateTimeKind dateTimeKind = DateTimeKind.Utc;
			int num = str.IndexOf('+', 1);
			if (num == -1)
			{
				num = str.IndexOf('-', 1);
			}
			TimeSpan zero = TimeSpan.Zero;
			if (num != -1)
			{
				dateTimeKind = DateTimeKind.Local;
				zero = JsonTextReader.ReadOffset(str.Substring(num));
				str = str.Substring(0, num);
			}
			long num1 = long.Parse(str, NumberStyles.Integer, CultureInfo.InvariantCulture);
			DateTime dateTime = JsonConvert.ConvertJavaScriptTicksToDateTime(num1);
			if (this._readType == ReadType.ReadAsDateTimeOffset || this._readType == ReadType.Read && this._dateParseHandling == Newtonsoft.Json.DateParseHandling.DateTimeOffset)
			{
				DateTime dateTime1 = dateTime.Add(zero);
				base.SetToken(JsonToken.Date, new DateTimeOffset(dateTime1.Ticks, zero));
				return;
			}
			switch (dateTimeKind)
			{
				case DateTimeKind.Unspecified:
				{
					localTime = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
					break;
				}
				case DateTimeKind.Utc:
				{
					localTime = dateTime;
					break;
				}
				case DateTimeKind.Local:
				{
					localTime = dateTime.ToLocalTime();
					break;
				}
				default:
				{
					goto case DateTimeKind.Utc;
				}
			}
			localTime = JsonConvert.EnsureDateTime(localTime, base.DateTimeZoneHandling);
			base.SetToken(JsonToken.Date, localTime);
		}

		private void ParseFalse()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.False))
			{
				throw JsonReaderException.Create(this, "Error parsing boolean value.");
			}
			base.SetToken(JsonToken.Boolean, false);
		}

		private void ParseNull()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.Null))
			{
				throw JsonReaderException.Create(this, "Error parsing null value.");
			}
			base.SetToken(JsonToken.Null);
		}

		private void ParseNumber()
		{
			object num;
			JsonToken jsonToken;
			this.ShiftBufferIfNeeded();
			char chr = this._chars[this._charPos];
			int num1 = this._charPos;
			this.ReadNumberIntoBuffer();
			this._stringReference = new StringReference(this._chars, num1, this._charPos - num1);
			bool flag = (!char.IsDigit(chr) ? false : this._stringReference.Length == 1);
			bool flag1 = (chr != '0' || this._stringReference.Length <= 1 || this._stringReference.Chars[this._stringReference.StartIndex + 1] == '.' || this._stringReference.Chars[this._stringReference.StartIndex + 1] == 'e' ? false : this._stringReference.Chars[this._stringReference.StartIndex + 1] != 'E');
			if (this._readType == ReadType.ReadAsInt32)
			{
				if (flag)
				{
					num = chr - 48;
				}
				else if (!flag1)
				{
					string str = this._stringReference.ToString();
					num = Convert.ToInt32(str, CultureInfo.InvariantCulture);
				}
				else
				{
					string str1 = this._stringReference.ToString();
					num = (str1.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(str1, 16) : Convert.ToInt32(str1, 8));
				}
				jsonToken = JsonToken.Integer;
			}
			else if (this._readType == ReadType.ReadAsDecimal)
			{
				if (flag)
				{
					num = chr - new decimal(48);
				}
				else if (!flag1)
				{
					string str2 = this._stringReference.ToString();
					num = decimal.Parse(str2, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float, CultureInfo.InvariantCulture);
				}
				else
				{
					string str3 = this._stringReference.ToString();
					num = Convert.ToDecimal((str3.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(str3, 16) : Convert.ToInt64(str3, 8)));
				}
				jsonToken = JsonToken.Float;
			}
			else if (flag)
			{
				num = (long)((ulong)chr - (long)48);
				jsonToken = JsonToken.Integer;
			}
			else if (!flag1)
			{
				string str4 = this._stringReference.ToString();
				if (str4.IndexOf('.') != -1 || str4.IndexOf('E') != -1 || str4.IndexOf('e') != -1)
				{
					num = Convert.ToDouble(str4, CultureInfo.InvariantCulture);
					jsonToken = JsonToken.Float;
				}
				else
				{
					try
					{
						num = Convert.ToInt64(str4, CultureInfo.InvariantCulture);
					}
					catch (OverflowException overflowException1)
					{
						OverflowException overflowException = overflowException1;
						throw JsonReaderException.Create(this, "JSON integer {0} is too large or small for an Int64.".FormatWith(CultureInfo.InvariantCulture, str4), overflowException);
					}
					jsonToken = JsonToken.Integer;
				}
			}
			else
			{
				string str5 = this._stringReference.ToString();
				num = (str5.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(str5, 16) : Convert.ToInt64(str5, 8));
				jsonToken = JsonToken.Integer;
			}
			this.ClearRecentString();
			base.SetToken(jsonToken, num);
		}

		private void ParseNumberNaN()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.NaN))
			{
				throw JsonReaderException.Create(this, "Error parsing NaN value.");
			}
			base.SetToken(JsonToken.Float, double.NaN);
		}

		private void ParseNumberNegativeInfinity()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.NegativeInfinity))
			{
				throw JsonReaderException.Create(this, "Error parsing negative infinity value.");
			}
			base.SetToken(JsonToken.Float, double.NegativeInfinity);
		}

		private void ParseNumberPositiveInfinity()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.PositiveInfinity))
			{
				throw JsonReaderException.Create(this, "Error parsing positive infinity value.");
			}
			base.SetToken(JsonToken.Float, double.PositiveInfinity);
		}

		private bool ParseObject()
		{
			do
			{
			Label1:
				char chr = this._chars[this._charPos];
				char chr1 = chr;
				if (chr1 > '\r')
				{
					if (chr1 == ' ')
					{
						goto Label0;
					}
					if (chr1 == '/')
					{
						this.ParseComment();
						return true;
					}
					if (chr1 == '}')
					{
						base.SetToken(JsonToken.EndObject);
						this._charPos++;
						return true;
					}
				}
				else if (chr1 == '\0')
				{
					if (this._charsUsed == this._charPos)
					{
						continue;
					}
					this._charPos++;
					goto Label1;
				}
				else
				{
					switch (chr1)
					{
						case '\t':
						{
							goto Label0;
						}
						case '\n':
						{
							this.ProcessLineFeed();
							goto Label1;
						}
						case '\r':
						{
							this.ProcessCarriageReturn(false);
							goto Label1;
						}
					}
				}
				if (!char.IsWhiteSpace(chr))
				{
					return this.ParseProperty();
				}
				this._charPos++;
				goto Label1;
			}
			while (this.ReadData(false) != 0);
			return false;
		Label0:
			JsonTextReader jsonTextReader = this;
			jsonTextReader._charPos++;
			goto Label1;
		}

		private bool ParsePostValue()
		{
			do
			{
			Label0:
				char chr = this._chars[this._charPos];
				char chr1 = chr;
				if (chr1 <= ')')
				{
					if (chr1 > '\r')
					{
						if (chr1 == ' ')
						{
							goto Label2;
						}
						if (chr1 == ')')
						{
							this._charPos++;
							base.SetToken(JsonToken.EndConstructor);
							return true;
						}
						goto Label1;
					}
					else if (chr1 == '\0')
					{
						if (this._charsUsed == this._charPos)
						{
							continue;
						}
						this._charPos++;
						goto Label0;
					}
					else
					{
						switch (chr1)
						{
							case '\t':
							{
								break;
							}
							case '\n':
							{
								this.ProcessLineFeed();
								goto Label0;
							}
							case '\r':
							{
								this.ProcessCarriageReturn(false);
								goto Label0;
							}
							default:
							{
								goto Label1;
							}
						}
					}
				Label2:
					JsonTextReader jsonTextReader = this;
					jsonTextReader._charPos++;
					goto Label0;
				}
				else if (chr1 > '/')
				{
					if (chr1 == ']')
					{
						this._charPos++;
						base.SetToken(JsonToken.EndArray);
						return true;
					}
					if (chr1 == '}')
					{
						this._charPos++;
						base.SetToken(JsonToken.EndObject);
						return true;
					}
				}
				else
				{
					if (chr1 == ',')
					{
						this._charPos++;
						base.SetStateBasedOnCurrent();
						return false;
					}
					if (chr1 == '/')
					{
						this.ParseComment();
						return true;
					}
				}
			Label1:
				if (!char.IsWhiteSpace(chr))
				{
					throw JsonReaderException.Create(this, "After parsing a value an unexpected character was encountered: {0}.".FormatWith(CultureInfo.InvariantCulture, chr));
				}
				this._charPos++;
				goto Label0;
			}
			while (this.ReadData(false) != 0);
			this._currentState = JsonReader.State.Finished;
			return false;
		}

		private bool ParseProperty()
		{
			char chr;
			char chr1 = this._chars[this._charPos];
			if (chr1 == '\"' || chr1 == '\'')
			{
				this._charPos++;
				chr = chr1;
				this.ShiftBufferIfNeeded();
				this.ReadStringIntoBuffer(chr);
			}
			else
			{
				if (!this.ValidIdentifierChar(chr1))
				{
					throw JsonReaderException.Create(this, "Invalid property identifier character: {0}.".FormatWith(CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
				chr = '\0';
				this.ShiftBufferIfNeeded();
				this.ParseUnquotedProperty();
			}
			string str = this._stringReference.ToString();
			this.EatWhitespace(false);
			if (this._chars[this._charPos] != ':')
			{
				throw JsonReaderException.Create(this, "Invalid character after parsing property name. Expected ':' but got: {0}.".FormatWith(CultureInfo.InvariantCulture, this._chars[this._charPos]));
			}
			this._charPos++;
			base.SetToken(JsonToken.PropertyName, str);
			this.QuoteChar = chr;
			this.ClearRecentString();
			return true;
		}

		private void ParseString(char quote)
		{
			byte[] numArray;
			this._charPos++;
			this.ShiftBufferIfNeeded();
			this.ReadStringIntoBuffer(quote);
			if (this._readType == ReadType.ReadAsBytes)
			{
				numArray = (this._stringReference.Length != 0 ? Convert.FromBase64CharArray(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length) : new byte[0]);
				base.SetToken(JsonToken.Bytes, numArray);
				return;
			}
			if (this._readType == ReadType.ReadAsString)
			{
				base.SetToken(JsonToken.String, this._stringReference.ToString());
				this.QuoteChar = quote;
				return;
			}
			string str = this._stringReference.ToString();
			if (this._dateParseHandling != Newtonsoft.Json.DateParseHandling.None && str.Length > 0)
			{
				if (str[0] == '/')
				{
					if (str.StartsWith("/Date(", StringComparison.Ordinal) && str.EndsWith(")/", StringComparison.Ordinal))
					{
						this.ParseDateMicrosoft(str);
						return;
					}
				}
				else if (char.IsDigit(str[0]) && str.Length >= 19 && str.Length <= 40 && this.ParseDateIso(str))
				{
					return;
				}
			}
			base.SetToken(JsonToken.String, str);
			this.QuoteChar = quote;
		}

		private void ParseTrue()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.True))
			{
				throw JsonReaderException.Create(this, "Error parsing boolean value.");
			}
			base.SetToken(JsonToken.Boolean, true);
		}

		private void ParseUndefined()
		{
			if (!this.MatchValueWithTrailingSeperator(JsonConvert.Undefined))
			{
				throw JsonReaderException.Create(this, "Error parsing undefined value.");
			}
			base.SetToken(JsonToken.Undefined);
		}

		private char ParseUnicode()
		{
			if (!this.EnsureChars(4, true))
			{
				throw JsonReaderException.Create(this, "Unexpected end while parsing unicode character.");
			}
			string str = new string(this._chars, this._charPos, 4);
			char chr = Convert.ToChar(int.Parse(str, NumberStyles.HexNumber, NumberFormatInfo.InvariantInfo));
			char chr1 = chr;
			this._charPos += 4;
			return chr1;
		}

		private void ParseUnquotedProperty()
		{
			int num = this._charPos;
			do
			{
			Label0:
				if (this._chars[this._charPos] != '\0')
				{
					char chr = this._chars[this._charPos];
					if (!this.ValidIdentifierChar(chr))
					{
						if (!char.IsWhiteSpace(chr) && chr != ':')
						{
							throw JsonReaderException.Create(this, "Invalid JavaScript property identifier character: {0}.".FormatWith(CultureInfo.InvariantCulture, chr));
						}
						this._stringReference = new StringReference(this._chars, num, this._charPos - num);
						return;
					}
					this._charPos++;
					goto Label0;
				}
				else
				{
					if (this._charsUsed == this._charPos)
					{
						continue;
					}
					this._stringReference = new StringReference(this._chars, num, this._charPos - num);
					return;
				}
			}
			while (this.ReadData(true) != 0);
			throw JsonReaderException.Create(this, "Unexpected end while parsing unquoted property name.");
		}

		private bool ParseValue()
		{
			char chr;
			while (true)
			{
				chr = this._chars[this._charPos];
				char chr1 = chr;
				if (chr1 <= 'I')
				{
					if (chr1 > '\r')
					{
						switch (chr1)
						{
							case ' ':
							{
								break;
							}
							case '!':
							{
								goto Label1;
							}
							case '\"':
							{
								this.ParseString(chr);
								return true;
							}
							default:
							{
								switch (chr1)
								{
									case '\'':
									{
										this.ParseString(chr);
										return true;
									}
									case '(':
									case '*':
									case '+':
									case '.':
									{
										goto Label1;
									}
									case ')':
									{
										this._charPos++;
										base.SetToken(JsonToken.EndConstructor);
										return true;
									}
									case ',':
									{
										base.SetToken(JsonToken.Undefined);
										return true;
									}
									case '-':
									{
										if (!this.EnsureChars(1, true) || this._chars[this._charPos + 1] != 'I')
										{
											this.ParseNumber();
										}
										else
										{
											this.ParseNumberNegativeInfinity();
										}
										return true;
									}
									case '/':
									{
										this.ParseComment();
										return true;
									}
									default:
									{
										if (chr1 == 'I')
										{
											this.ParseNumberPositiveInfinity();
											return true;
										}
										goto Label1;
									}
								}
								break;
							}
						}
					}
					else if (chr1 != '\0')
					{
						switch (chr1)
						{
							case '\t':
							{
								break;
							}
							case '\n':
							{
								this.ProcessLineFeed();
								continue;
							}
							case '\r':
							{
								this.ProcessCarriageReturn(false);
								continue;
							}
							default:
							{
								goto Label1;
							}
						}
					}
					else if (this._charsUsed != this._charPos)
					{
						this._charPos++;
						continue;
					}
					else if (this.ReadData(false) == 0)
					{
						return false;
					}
					this._charPos++;
					continue;
				}
				else if (chr1 > 'f')
				{
					if (chr1 == 'n')
					{
						if (!this.EnsureChars(1, true))
						{
							throw JsonReaderException.Create(this, "Unexpected end.");
						}
						char chr2 = this._chars[this._charPos + 1];
						if (chr2 != 'u')
						{
							if (chr2 != 'e')
							{
								throw JsonReaderException.Create(this, "Unexpected character encountered while parsing value: {0}.".FormatWith(CultureInfo.InvariantCulture, this._chars[this._charPos]));
							}
							this.ParseConstructor();
						}
						else
						{
							this.ParseNull();
						}
						return true;
					}
					switch (chr1)
					{
						case 't':
						{
							this.ParseTrue();
							return true;
						}
						case 'u':
						{
							this.ParseUndefined();
							return true;
						}
						default:
						{
							if (chr1 == '{')
							{
								this._charPos++;
								base.SetToken(JsonToken.StartObject);
								return true;
							}
							break;
						}
					}
				}
				else
				{
					if (chr1 == 'N')
					{
						this.ParseNumberNaN();
						return true;
					}
					switch (chr1)
					{
						case '[':
						{
							this._charPos++;
							base.SetToken(JsonToken.StartArray);
							return true;
						}
						case '\\':
						{
							break;
						}
						case ']':
						{
							this._charPos++;
							base.SetToken(JsonToken.EndArray);
							return true;
						}
						default:
						{
							if (chr1 == 'f')
							{
								this.ParseFalse();
								return true;
							}
							break;
						}
					}
				}
			Label1:
				if (!char.IsWhiteSpace(chr))
				{
					if (!char.IsNumber(chr) && chr != '-' && chr != '.')
					{
						throw JsonReaderException.Create(this, "Unexpected character encountered while parsing value: {0}.".FormatWith(CultureInfo.InvariantCulture, chr));
					}
					this.ParseNumber();
					return true;
				}
				this._charPos++;
			}
			this.ParseString(chr);
			return true;
		}

		private void ProcessCarriageReturn(bool append)
		{
			this._charPos++;
			if (this.EnsureChars(1, append) && this._chars[this._charPos] == '\n')
			{
				this._charPos++;
			}
			this.OnNewLine(this._charPos);
		}

		private void ProcessLineFeed()
		{
			this._charPos++;
			this.OnNewLine(this._charPos);
		}

		[DebuggerStepThrough]
		public override bool Read()
		{
			this._readType = ReadType.Read;
			if (this.ReadInternal())
			{
				return true;
			}
			base.SetToken(JsonToken.None);
			return false;
		}

		public override byte[] ReadAsBytes()
		{
			return base.ReadAsBytesInternal();
		}

		public override DateTime? ReadAsDateTime()
		{
			return base.ReadAsDateTimeInternal();
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return base.ReadAsDateTimeOffsetInternal();
		}

		public override decimal? ReadAsDecimal()
		{
			return base.ReadAsDecimalInternal();
		}

		public override int? ReadAsInt32()
		{
			return base.ReadAsInt32Internal();
		}

		public override string ReadAsString()
		{
			return base.ReadAsStringInternal();
		}

		private bool ReadChars(int relativePosition, bool append)
		{
			if (this._isEndOfFile)
			{
				return false;
			}
			int num = this._charPos + relativePosition - this._charsUsed + 1;
			int num1 = 0;
			do
			{
				int num2 = this.ReadData(append, num - num1);
				if (num2 == 0)
				{
					break;
				}
				num1 += num2;
			}
			while (num1 < num);
			if (num1 < num)
			{
				return false;
			}
			return true;
		}

		private int ReadData(bool append)
		{
			return this.ReadData(append, 0);
		}

		private int ReadData(bool append, int charsRequired)
		{
			if (this._isEndOfFile)
			{
				return 0;
			}
			if (this._charsUsed + charsRequired >= (int)this._chars.Length - 1)
			{
				if (!append)
				{
					int num = this._charsUsed - this._charPos;
					if (num + charsRequired + 1 >= (int)this._chars.Length)
					{
						char[] chrArray = new char[num + charsRequired + 1];
						if (num > 0)
						{
							JsonTextReader.BlockCopyChars(this._chars, this._charPos, chrArray, 0, num);
						}
						this._chars = chrArray;
					}
					else if (num > 0)
					{
						JsonTextReader.BlockCopyChars(this._chars, this._charPos, this._chars, 0, num);
					}
					this._lineStartPos -= this._charPos;
					this._charPos = 0;
					this._charsUsed = num;
				}
				else
				{
					int num1 = Math.Max((int)this._chars.Length * 2, this._charsUsed + charsRequired + 1);
					char[] chrArray1 = new char[num1];
					JsonTextReader.BlockCopyChars(this._chars, 0, chrArray1, 0, (int)this._chars.Length);
					this._chars = chrArray1;
				}
			}
			int length = (int)this._chars.Length - this._charsUsed - 1;
			int num2 = this._reader.Read(this._chars, this._charsUsed, length);
			this._charsUsed += num2;
			if (num2 == 0)
			{
				this._isEndOfFile = true;
			}
			this._chars[this._charsUsed] = '\0';
			return num2;
		}

		internal override bool ReadInternal()
		{
			do
			{
			Label0:
				switch (this._currentState)
				{
					case JsonReader.State.Start:
					case JsonReader.State.Property:
					case JsonReader.State.ArrayStart:
					case JsonReader.State.Array:
					case JsonReader.State.ConstructorStart:
					case JsonReader.State.Constructor:
					{
						return this.ParseValue();
					}
					case JsonReader.State.Complete:
					case JsonReader.State.Closed:
					case JsonReader.State.Error:
					{
						goto Label0;
					}
					case JsonReader.State.ObjectStart:
					case JsonReader.State.Object:
					{
						return this.ParseObject();
					}
					case JsonReader.State.PostValue:
					{
						continue;
					}
					case JsonReader.State.Finished:
					{
						if (!this.EnsureChars(0, false))
						{
							return false;
						}
						this.EatWhitespace(false);
						if (this._isEndOfFile)
						{
							return false;
						}
						if (this._chars[this._charPos] != '/')
						{
							throw JsonReaderException.Create(this, "Additional text encountered after finished reading JSON content: {0}.".FormatWith(CultureInfo.InvariantCulture, this._chars[this._charPos]));
						}
						this.ParseComment();
						return true;
					}
				}
				throw JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(CultureInfo.InvariantCulture, base.CurrentState));
			}
			while (!this.ParsePostValue());
			return true;
		}

		private void ReadNumberIntoBuffer()
		{
			int num = this._charPos;
			while (true)
			{
				int num1 = num;
				num = num1 + 1;
				char chr = this._chars[num1];
				if (chr > 'F')
				{
					if (chr != 'X')
					{
						switch (chr)
						{
							case 'a':
							case 'b':
							case 'c':
							case 'd':
							case 'e':
							case 'f':
							{
								continue;
							}
							default:
							{
								if (chr == 'x')
								{
									continue;
								}
								break;
							}
						}
					}
				}
				else if (chr != '\0')
				{
					switch (chr)
					{
						case '+':
						case '-':
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
						case 'A':
						case 'B':
						case 'C':
						case 'D':
						case 'E':
						case 'F':
						{
							continue;
						}
					}
				}
				else if (this._charsUsed == num - 1)
				{
					num--;
					this._charPos = num;
					if (this.ReadData(true) == 0)
					{
						return;
					}
				}
			}
			this._charPos = num - 1;
		}

		private static TimeSpan ReadOffset(string offsetText)
		{
			bool flag = offsetText[0] == '-';
			int num = int.Parse(offsetText.Substring(1, 2), NumberStyles.Integer, CultureInfo.InvariantCulture);
			int num1 = 0;
			if (offsetText.Length >= 5)
			{
				num1 = int.Parse(offsetText.Substring(3, 2), NumberStyles.Integer, CultureInfo.InvariantCulture);
			}
			TimeSpan timeSpan = TimeSpan.FromHours((double)num) + TimeSpan.FromMinutes((double)num1);
			if (flag)
			{
				timeSpan = timeSpan.Negate();
			}
			return timeSpan;
		}

		private void ReadStringIntoBuffer(char quote)
		{
			char chr;
			char chr1;
			bool flag;
			int num = this._charPos;
			int num1 = this._charPos;
			int num2 = this._charPos;
			StringBuffer buffer = null;
			while (true)
			{
				int num3 = num;
				num = num3 + 1;
				char chr2 = this._chars[num3];
				if (chr2 > '\r')
				{
					if (chr2 != '\"' && chr2 != '\'')
					{
						if (chr2 == '\\')
						{
							this._charPos = num;
							if (!this.EnsureChars(0, true))
							{
								this._charPos = num;
								throw JsonReaderException.Create(this, "Unterminated string. Expected delimiter: {0}.".FormatWith(CultureInfo.InvariantCulture, quote));
							}
							int num4 = num - 1;
							chr = this._chars[num];
							char chr3 = chr;
							if (chr3 <= '\\')
							{
								if (chr3 > '\'')
								{
									if (chr3 == '/')
									{
										goto Label2;
									}
									if (chr3 == '\\')
									{
										num++;
										chr1 = '\\';
										goto Label1;
									}
									else
									{
										break;
									}
								}
								else if (chr3 != '\"' && chr3 != '\'')
								{
									break;
								}
							Label2:
								chr1 = chr;
								num++;
							}
							else if (chr3 > 'f')
							{
								if (chr3 == 'n')
								{
									num++;
									chr1 = '\n';
								}
								else
								{
									switch (chr3)
									{
										case 'r':
										{
											num++;
											chr1 = '\r';
											break;
										}
										case 's':
										{
											num++;
											this._charPos = num;
											throw JsonReaderException.Create(this, "Bad JSON escape sequence: {0}.".FormatWith(CultureInfo.InvariantCulture, string.Concat("\\", chr)));
										}
										case 't':
										{
											num++;
											chr1 = '\t';
											break;
										}
										case 'u':
										{
											num++;
											this._charPos = num;
											chr1 = this.ParseUnicode();
											if (StringUtils.IsLowSurrogate(chr1))
											{
												chr1 = '\uFFFD';
											}
											else if (StringUtils.IsHighSurrogate(chr1))
											{
												do
												{
													flag = false;
													if (!this.EnsureChars(2, true) || this._chars[this._charPos] != '\\' || this._chars[this._charPos + 1] != 'u')
													{
														chr1 = '\uFFFD';
													}
													else
													{
														char chr4 = chr1;
														this._charPos += 2;
														chr1 = this.ParseUnicode();
														if (!StringUtils.IsLowSurrogate(chr1))
														{
															if (!StringUtils.IsHighSurrogate(chr1))
															{
																chr4 = '\uFFFD';
															}
															else
															{
																chr4 = '\uFFFD';
																flag = true;
															}
														}
														if (buffer == null)
														{
															buffer = this.GetBuffer();
														}
														this.WriteCharToBuffer(buffer, chr4, num2, num4);
														num2 = this._charPos;
													}
												}
												while (flag);
											}
											num = this._charPos;
											break;
										}
										default:
										{
											num++;
											this._charPos = num;
											throw JsonReaderException.Create(this, "Bad JSON escape sequence: {0}.".FormatWith(CultureInfo.InvariantCulture, string.Concat("\\", chr)));
										}
									}
								}
							}
							else if (chr3 == 'b')
							{
								num++;
								chr1 = '\b';
							}
							else if (chr3 == 'f')
							{
								num++;
								chr1 = '\f';
							}
							else
							{
								break;
							}
						Label1:
							if (buffer == null)
							{
								buffer = this.GetBuffer();
							}
							this.WriteCharToBuffer(buffer, chr1, num2, num4);
							num2 = num;
						}
					}
					else if (this._chars[num - 1] == quote)
					{
						num--;
						if (num1 != num2)
						{
							if (buffer == null)
							{
								buffer = this.GetBuffer();
							}
							if (num > num2)
							{
								buffer.Append(this._chars, num2, num - num2);
							}
							this._stringReference = new StringReference(buffer.GetInternalBuffer(), 0, buffer.Position);
						}
						else
						{
							this._stringReference = new StringReference(this._chars, num1, num - num1);
						}
						num++;
						this._charPos = num;
						return;
					}
				}
				else if (chr2 == '\0')
				{
					if (this._charsUsed == num - 1)
					{
						num--;
						if (this.ReadData(true) == 0)
						{
							this._charPos = num;
							throw JsonReaderException.Create(this, "Unterminated string. Expected delimiter: {0}.".FormatWith(CultureInfo.InvariantCulture, quote));
						}
					}
				}
				else if (chr2 == '\n')
				{
					this._charPos = num - 1;
					this.ProcessLineFeed();
					num = this._charPos;
				}
				else if (chr2 == '\r')
				{
					this._charPos = num - 1;
					this.ProcessCarriageReturn(true);
					num = this._charPos;
				}
			}
			num++;
			this._charPos = num;
			throw JsonReaderException.Create(this, "Bad JSON escape sequence: {0}.".FormatWith(CultureInfo.InvariantCulture, string.Concat("\\", chr)));
		}

		internal void SetCharBuffer(char[] chars)
		{
			this._chars = chars;
		}

		private void ShiftBufferIfNeeded()
		{
			int length = (int)this._chars.Length;
			if ((double)(length - this._charPos) <= (double)length * 0.1)
			{
				int num = this._charsUsed - this._charPos;
				if (num > 0)
				{
					JsonTextReader.BlockCopyChars(this._chars, this._charPos, this._chars, 0, num);
				}
				this._lineStartPos -= this._charPos;
				this._charPos = 0;
				this._charsUsed = num;
				this._chars[this._charsUsed] = '\0';
			}
		}

		private bool ValidIdentifierChar(char value)
		{
			if (char.IsLetterOrDigit(value) || value == '\u005F')
			{
				return true;
			}
			return value == '$';
		}

		private void WriteCharToBuffer(StringBuffer buffer, char writeChar, int lastWritePosition, int writeToPosition)
		{
			if (writeToPosition > lastWritePosition)
			{
				buffer.Append(this._chars, lastWritePosition, writeToPosition - lastWritePosition);
			}
			buffer.Append(writeChar);
		}
	}
}