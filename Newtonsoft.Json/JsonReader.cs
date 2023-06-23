using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	public abstract class JsonReader : IDisposable
	{
		private JsonToken _tokenType;

		private object _value;

		private char _quoteChar;

		internal JsonReader.State _currentState;

		internal ReadType _readType;

		private JsonPosition _currentPosition;

		private CultureInfo _culture;

		private Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;

		private int? _maxDepth;

		private bool _hasExceededMaxDepth;

		internal Newtonsoft.Json.DateParseHandling _dateParseHandling;

		private readonly List<JsonPosition> _stack;

		public bool CloseInput
		{
			get;
			set;
		}

		public CultureInfo Culture
		{
			get
			{
				return this._culture ?? CultureInfo.InvariantCulture;
			}
			set
			{
				this._culture = value;
			}
		}

		protected JsonReader.State CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		public Newtonsoft.Json.DateParseHandling DateParseHandling
		{
			get
			{
				return this._dateParseHandling;
			}
			set
			{
				this._dateParseHandling = value;
			}
		}

		public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this._dateTimeZoneHandling;
			}
			set
			{
				this._dateTimeZoneHandling = value;
			}
		}

		public virtual int Depth
		{
			get
			{
				int count = this._stack.Count;
				if (JsonReader.IsStartToken(this.TokenType) || this._currentPosition.Type == JsonContainerType.None)
				{
					return count;
				}
				return count + 1;
			}
		}

		public int? MaxDepth
		{
			get
			{
				return this._maxDepth;
			}
			set
			{
				int? nullable = value;
				if ((nullable.GetValueOrDefault() > 0 ? false : nullable.HasValue))
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this._maxDepth = value;
			}
		}

		public virtual string Path
		{
			get
			{
				if (this._currentPosition.Type == JsonContainerType.None)
				{
					return string.Empty;
				}
				List<JsonPosition> jsonPositions = this._stack;
				JsonPosition[] jsonPositionArray = new JsonPosition[] { this._currentPosition };
				return JsonPosition.BuildPath(jsonPositions.Concat<JsonPosition>(jsonPositionArray));
			}
		}

		public virtual char QuoteChar
		{
			get
			{
				return this._quoteChar;
			}
			protected internal set
			{
				this._quoteChar = value;
			}
		}

		public virtual JsonToken TokenType
		{
			get
			{
				return this._tokenType;
			}
		}

		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		public virtual Type ValueType
		{
			get
			{
				if (this._value == null)
				{
					return null;
				}
				return this._value.GetType();
			}
		}

		protected JsonReader()
		{
			this._currentState = JsonReader.State.Start;
			this._stack = new List<JsonPosition>(4);
			this._dateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
			this._dateParseHandling = Newtonsoft.Json.DateParseHandling.DateTime;
			this.CloseInput = true;
		}

		public virtual void Close()
		{
			this._currentState = JsonReader.State.Closed;
			this._tokenType = JsonToken.None;
			this._value = null;
		}

		protected virtual void Dispose(bool disposing)
		{
			if (this._currentState != JsonReader.State.Closed && disposing)
			{
				this.Close();
			}
		}

		internal JsonPosition GetPosition(int depth)
		{
			if (depth >= this._stack.Count)
			{
				return this._currentPosition;
			}
			return this._stack[depth];
		}

		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			switch (token)
			{
				case JsonToken.EndObject:
				{
					return JsonContainerType.Object;
				}
				case JsonToken.EndArray:
				{
					return JsonContainerType.Array;
				}
				case JsonToken.EndConstructor:
				{
					return JsonContainerType.Constructor;
				}
			}
			throw JsonReaderException.Create(this, "Not a valid close JsonToken: {0}".FormatWith(CultureInfo.InvariantCulture, token));
		}

		internal static bool IsPrimitiveToken(JsonToken token)
		{
			switch (token)
			{
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.String:
				case JsonToken.Boolean:
				case JsonToken.Null:
				case JsonToken.Undefined:
				case JsonToken.Date:
				case JsonToken.Bytes:
				{
					return true;
				}
				case JsonToken.EndObject:
				case JsonToken.EndArray:
				case JsonToken.EndConstructor:
				{
					return false;
				}
				default:
				{
					return false;
				}
			}
		}

		internal static bool IsStartToken(JsonToken token)
		{
			switch (token)
			{
				case JsonToken.StartObject:
				case JsonToken.StartArray:
				case JsonToken.StartConstructor:
				{
					return true;
				}
			}
			return false;
		}

		private bool IsWrappedInTypeObject()
		{
			this._readType = ReadType.Read;
			if (this.TokenType != JsonToken.StartObject)
			{
				return false;
			}
			if (!this.ReadInternal())
			{
				throw JsonReaderException.Create(this, "Unexpected end when reading bytes.");
			}
			if (this.Value.ToString() == "$type")
			{
				this.ReadInternal();
				if (this.Value != null && this.Value.ToString().StartsWith("System.Byte[]"))
				{
					this.ReadInternal();
					if (this.Value.ToString() == "$value")
					{
						return true;
					}
				}
			}
			throw JsonReaderException.Create(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, JsonToken.StartObject));
		}

		private JsonContainerType Peek()
		{
			return this._currentPosition.Type;
		}

		private JsonContainerType Pop()
		{
			JsonPosition jsonPosition;
			if (this._stack.Count <= 0)
			{
				jsonPosition = this._currentPosition;
				this._currentPosition = new JsonPosition();
			}
			else
			{
				jsonPosition = this._currentPosition;
				this._currentPosition = this._stack[this._stack.Count - 1];
				this._stack.RemoveAt(this._stack.Count - 1);
			}
			if (this._maxDepth.HasValue)
			{
				int depth = this.Depth;
				int? nullable = this._maxDepth;
				if ((depth > nullable.GetValueOrDefault() ? false : nullable.HasValue))
				{
					this._hasExceededMaxDepth = false;
				}
			}
			return jsonPosition.Type;
		}

		private void Push(JsonContainerType value)
		{
			this.UpdateScopeWithFinishedValue();
			if (this._currentPosition.Type == JsonContainerType.None)
			{
				this._currentPosition.Type = value;
				return;
			}
			this._stack.Add(this._currentPosition);
			this._currentPosition = new JsonPosition()
			{
				Type = value
			};
			if (this._maxDepth.HasValue)
			{
				int depth = this.Depth + 1;
				int? nullable = this._maxDepth;
				if ((depth <= nullable.GetValueOrDefault() ? false : nullable.HasValue) && !this._hasExceededMaxDepth)
				{
					this._hasExceededMaxDepth = true;
					throw JsonReaderException.Create(this, "The reader's MaxDepth of {0} has been exceeded.".FormatWith(CultureInfo.InvariantCulture, this._maxDepth));
				}
			}
		}

		public abstract bool Read();

		public abstract byte[] ReadAsBytes();

		internal byte[] ReadAsBytesInternal()
		{
			this._readType = ReadType.ReadAsBytes;
			do
			{
				if (this.ReadInternal())
				{
					continue;
				}
				this.SetToken(JsonToken.None);
				return null;
			}
			while (this.TokenType == JsonToken.Comment);
			if (this.IsWrappedInTypeObject())
			{
				byte[] numArray = this.ReadAsBytes();
				this.ReadInternal();
				this.SetToken(JsonToken.Bytes, numArray);
				return numArray;
			}
			if (this.TokenType == JsonToken.String)
			{
				string value = (string)this.Value;
				this.SetToken(JsonToken.Bytes, (value.Length == 0 ? new byte[0] : Convert.FromBase64String(value)));
			}
			if (this.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (this.TokenType == JsonToken.Bytes)
			{
				return (byte[])this.Value;
			}
			if (this.TokenType != JsonToken.StartArray)
			{
				if (this.TokenType != JsonToken.EndArray)
				{
					throw JsonReaderException.Create(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
				}
				return null;
			}
			List<byte> nums = new List<byte>();
			while (this.ReadInternal())
			{
				JsonToken tokenType = this.TokenType;
				switch (tokenType)
				{
					case JsonToken.Comment:
					{
						continue;
					}
					case JsonToken.Raw:
					{
						throw JsonReaderException.Create(this, "Unexpected token when reading bytes: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
					}
					case JsonToken.Integer:
					{
						nums.Add(Convert.ToByte(this.Value, CultureInfo.InvariantCulture));
						continue;
					}
					default:
					{
						if (tokenType == JsonToken.EndArray)
						{
							byte[] array = nums.ToArray();
							this.SetToken(JsonToken.Bytes, array);
							return array;
						}
						throw JsonReaderException.Create(this, "Unexpected token when reading bytes: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
					}
				}
			}
			throw JsonReaderException.Create(this, "Unexpected end when reading bytes.");
		}

		public abstract DateTime? ReadAsDateTime();

		internal DateTime? ReadAsDateTimeInternal()
		{
			DateTime dateTime;
			this._readType = ReadType.ReadAsDateTime;
			do
			{
				if (this.ReadInternal())
				{
					continue;
				}
				this.SetToken(JsonToken.None);
				return null;
			}
			while (this.TokenType == JsonToken.Comment);
			if (this.TokenType == JsonToken.Date)
			{
				return new DateTime?((DateTime)this.Value);
			}
			if (this.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (this.TokenType != JsonToken.String)
			{
				if (this.TokenType != JsonToken.EndArray)
				{
					throw JsonReaderException.Create(this, "Error reading date. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
				}
				return null;
			}
			string value = (string)this.Value;
			if (string.IsNullOrEmpty(value))
			{
				this.SetToken(JsonToken.Null);
				return null;
			}
			if (!DateTime.TryParse(value, this.Culture, DateTimeStyles.RoundtripKind, out dateTime))
			{
				throw JsonReaderException.Create(this, "Could not convert string to DateTime: {0}.".FormatWith(CultureInfo.InvariantCulture, this.Value));
			}
			dateTime = JsonConvert.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
			this.SetToken(JsonToken.Date, dateTime);
			return new DateTime?(dateTime);
		}

		public abstract DateTimeOffset? ReadAsDateTimeOffset();

		internal DateTimeOffset? ReadAsDateTimeOffsetInternal()
		{
			DateTimeOffset dateTimeOffset;
			this._readType = ReadType.ReadAsDateTimeOffset;
			do
			{
				if (this.ReadInternal())
				{
					continue;
				}
				this.SetToken(JsonToken.None);
				return null;
			}
			while (this.TokenType == JsonToken.Comment);
			if (this.TokenType == JsonToken.Date)
			{
				if (this.Value is DateTime)
				{
					this.SetToken(JsonToken.Date, new DateTimeOffset((DateTime)this.Value));
				}
				return new DateTimeOffset?((DateTimeOffset)this.Value);
			}
			if (this.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (this.TokenType != JsonToken.String)
			{
				if (this.TokenType != JsonToken.EndArray)
				{
					throw JsonReaderException.Create(this, "Error reading date. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
				}
				return null;
			}
			if (!DateTimeOffset.TryParse((string)this.Value, this.Culture, DateTimeStyles.RoundtripKind, out dateTimeOffset))
			{
				throw JsonReaderException.Create(this, "Could not convert string to DateTimeOffset: {0}.".FormatWith(CultureInfo.InvariantCulture, this.Value));
			}
			this.SetToken(JsonToken.Date, dateTimeOffset);
			return new DateTimeOffset?(dateTimeOffset);
		}

		public abstract decimal? ReadAsDecimal();

		internal decimal? ReadAsDecimalInternal()
		{
			decimal num;
			this._readType = ReadType.ReadAsDecimal;
			do
			{
				if (this.ReadInternal())
				{
					continue;
				}
				this.SetToken(JsonToken.None);
				return null;
			}
			while (this.TokenType == JsonToken.Comment);
			if (this.TokenType == JsonToken.Integer || this.TokenType == JsonToken.Float)
			{
				if (!(this.Value is decimal))
				{
					this.SetToken(JsonToken.Float, Convert.ToDecimal(this.Value, CultureInfo.InvariantCulture));
				}
				return new decimal?((decimal)this.Value);
			}
			if (this.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (this.TokenType != JsonToken.String)
			{
				if (this.TokenType != JsonToken.EndArray)
				{
					throw JsonReaderException.Create(this, "Error reading decimal. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
				}
				return null;
			}
			if (!decimal.TryParse((string)this.Value, NumberStyles.Number, this.Culture, out num))
			{
				throw JsonReaderException.Create(this, "Could not convert string to decimal: {0}.".FormatWith(CultureInfo.InvariantCulture, this.Value));
			}
			this.SetToken(JsonToken.Float, num);
			return new decimal?(num);
		}

		public abstract int? ReadAsInt32();

		internal int? ReadAsInt32Internal()
		{
			int num;
			this._readType = ReadType.ReadAsInt32;
			do
			{
				if (this.ReadInternal())
				{
					continue;
				}
				this.SetToken(JsonToken.None);
				return null;
			}
			while (this.TokenType == JsonToken.Comment);
			if (this.TokenType == JsonToken.Integer || this.TokenType == JsonToken.Float)
			{
				if (!(this.Value is int))
				{
					this.SetToken(JsonToken.Integer, Convert.ToInt32(this.Value, CultureInfo.InvariantCulture));
				}
				return new int?((int)this.Value);
			}
			if (this.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (this.TokenType != JsonToken.String)
			{
				if (this.TokenType != JsonToken.EndArray)
				{
					throw JsonReaderException.Create(this, "Error reading integer. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
				}
				return null;
			}
			if (!int.TryParse((string)this.Value, NumberStyles.Integer, this.Culture, out num))
			{
				throw JsonReaderException.Create(this, "Could not convert string to integer: {0}.".FormatWith(CultureInfo.InvariantCulture, this.Value));
			}
			this.SetToken(JsonToken.Integer, num);
			return new int?(num);
		}

		public abstract string ReadAsString();

		internal string ReadAsStringInternal()
		{
			string str;
			this._readType = ReadType.ReadAsString;
			do
			{
				if (this.ReadInternal())
				{
					continue;
				}
				this.SetToken(JsonToken.None);
				return null;
			}
			while (this.TokenType == JsonToken.Comment);
			if (this.TokenType == JsonToken.String)
			{
				return (string)this.Value;
			}
			if (this.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (!JsonReader.IsPrimitiveToken(this.TokenType) || this.Value == null)
			{
				if (this.TokenType != JsonToken.EndArray)
				{
					throw JsonReaderException.Create(this, "Error reading string. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.TokenType));
				}
				return null;
			}
			if (!ConvertUtils.IsConvertible(this.Value))
			{
				str = (!(this.Value is IFormattable) ? this.Value.ToString() : ((IFormattable)this.Value).ToString(null, this.Culture));
			}
			else
			{
				str = ConvertUtils.ToConvertible(this.Value).ToString(this.Culture);
			}
			this.SetToken(JsonToken.String, str);
			return str;
		}

		internal virtual bool ReadInternal()
		{
			throw new NotImplementedException();
		}

		protected void SetStateBasedOnCurrent()
		{
			JsonContainerType jsonContainerType = this.Peek();
			switch (jsonContainerType)
			{
				case JsonContainerType.None:
				{
					this._currentState = JsonReader.State.Finished;
					return;
				}
				case JsonContainerType.Object:
				{
					this._currentState = JsonReader.State.Object;
					return;
				}
				case JsonContainerType.Array:
				{
					this._currentState = JsonReader.State.Array;
					return;
				}
				case JsonContainerType.Constructor:
				{
					this._currentState = JsonReader.State.Constructor;
					return;
				}
			}
			throw JsonReaderException.Create(this, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".FormatWith(CultureInfo.InvariantCulture, jsonContainerType));
		}

		protected void SetToken(JsonToken newToken)
		{
			this.SetToken(newToken, null);
		}

		protected void SetToken(JsonToken newToken, object value)
		{
			this._tokenType = newToken;
			this._value = value;
			switch (newToken)
			{
				case JsonToken.StartObject:
				{
					this._currentState = JsonReader.State.ObjectStart;
					this.Push(JsonContainerType.Object);
					return;
				}
				case JsonToken.StartArray:
				{
					this._currentState = JsonReader.State.ArrayStart;
					this.Push(JsonContainerType.Array);
					return;
				}
				case JsonToken.StartConstructor:
				{
					this._currentState = JsonReader.State.ConstructorStart;
					this.Push(JsonContainerType.Constructor);
					return;
				}
				case JsonToken.PropertyName:
				{
					this._currentState = JsonReader.State.Property;
					this._currentPosition.PropertyName = (string)value;
					return;
				}
				case JsonToken.Comment:
				{
					return;
				}
				case JsonToken.Raw:
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.String:
				case JsonToken.Boolean:
				case JsonToken.Null:
				case JsonToken.Undefined:
				case JsonToken.Date:
				case JsonToken.Bytes:
				{
					this._currentState = (this.Peek() != JsonContainerType.None ? JsonReader.State.PostValue : JsonReader.State.Finished);
					this.UpdateScopeWithFinishedValue();
					return;
				}
				case JsonToken.EndObject:
				{
					this.ValidateEnd(JsonToken.EndObject);
					return;
				}
				case JsonToken.EndArray:
				{
					this.ValidateEnd(JsonToken.EndArray);
					return;
				}
				case JsonToken.EndConstructor:
				{
					this.ValidateEnd(JsonToken.EndConstructor);
					return;
				}
				default:
				{
					return;
				}
			}
		}

		public void Skip()
		{
			if (this.TokenType == JsonToken.PropertyName)
			{
				this.Read();
			}
			if (JsonReader.IsStartToken(this.TokenType))
			{
				int depth = this.Depth;
				while (this.Read() && depth < this.Depth)
				{
				}
			}
		}

		void System.IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		private void UpdateScopeWithFinishedValue()
		{
			int? nullable;
			if (this._currentPosition.Type == JsonContainerType.Array || this._currentPosition.Type == JsonContainerType.Constructor)
			{
				if (!this._currentPosition.Position.HasValue)
				{
					this._currentPosition.Position = new int?(0);
					return;
				}
				ref JsonPosition jsonPositionPointer = ref this._currentPosition;
				int? position = jsonPositionPointer.Position;
				if (position.HasValue)
				{
					nullable = new int?(position.GetValueOrDefault() + 1);
				}
				else
				{
					nullable = null;
				}
				jsonPositionPointer.Position = nullable;
			}
		}

		private void ValidateEnd(JsonToken endToken)
		{
			JsonContainerType jsonContainerType = this.Pop();
			if (this.GetTypeForCloseToken(endToken) != jsonContainerType)
			{
				throw JsonReaderException.Create(this, "JsonToken {0} is not valid for closing JsonType {1}.".FormatWith(CultureInfo.InvariantCulture, endToken, jsonContainerType));
			}
			this._currentState = (this.Peek() != JsonContainerType.None ? JsonReader.State.PostValue : JsonReader.State.Finished);
		}

		protected internal enum State
		{
			Start,
			Complete,
			Property,
			ObjectStart,
			Object,
			ArrayStart,
			Array,
			Closed,
			PostValue,
			ConstructorStart,
			Constructor,
			Error,
			Finished
		}
	}
}