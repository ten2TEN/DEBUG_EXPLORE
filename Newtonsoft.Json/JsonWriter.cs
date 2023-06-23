using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	public abstract class JsonWriter : IDisposable
	{
		private readonly static JsonWriter.State[][] StateArray;

		internal readonly static JsonWriter.State[][] StateArrayTempate;

		private readonly List<JsonPosition> _stack;

		private JsonPosition _currentPosition;

		private JsonWriter.State _currentState;

		private Newtonsoft.Json.Formatting _formatting;

		private Newtonsoft.Json.DateFormatHandling _dateFormatHandling;

		private Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;

		public bool CloseOutput
		{
			get;
			set;
		}

		internal string ContainerPath
		{
			get
			{
				IEnumerable<JsonPosition> jsonPositions;
				if (this._currentPosition.Type == JsonContainerType.None)
				{
					return string.Empty;
				}
				if (this._currentPosition.InsideContainer())
				{
					jsonPositions = this._stack;
				}
				else
				{
					List<JsonPosition> jsonPositions1 = this._stack;
					JsonPosition[] jsonPositionArray = new JsonPosition[] { this._currentPosition };
					jsonPositions = jsonPositions1.Concat<JsonPosition>(jsonPositionArray);
				}
				return JsonPosition.BuildPath(jsonPositions);
			}
		}

		public Newtonsoft.Json.DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._dateFormatHandling;
			}
			set
			{
				this._dateFormatHandling = value;
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

		public Newtonsoft.Json.Formatting Formatting
		{
			get
			{
				return this._formatting;
			}
			set
			{
				this._formatting = value;
			}
		}

		public string Path
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

		protected internal int Top
		{
			get
			{
				int count = this._stack.Count;
				if (this.Peek() != JsonContainerType.None)
				{
					count++;
				}
				return count;
			}
		}

		public Newtonsoft.Json.WriteState WriteState
		{
			get
			{
				switch (this._currentState)
				{
					case JsonWriter.State.Start:
					{
						return Newtonsoft.Json.WriteState.Start;
					}
					case JsonWriter.State.Property:
					{
						return Newtonsoft.Json.WriteState.Property;
					}
					case JsonWriter.State.ObjectStart:
					case JsonWriter.State.Object:
					{
						return Newtonsoft.Json.WriteState.Object;
					}
					case JsonWriter.State.ArrayStart:
					case JsonWriter.State.Array:
					{
						return Newtonsoft.Json.WriteState.Array;
					}
					case JsonWriter.State.ConstructorStart:
					case JsonWriter.State.Constructor:
					{
						return Newtonsoft.Json.WriteState.Constructor;
					}
					case JsonWriter.State.Bytes:
					{
						throw JsonWriterException.Create(this, string.Concat("Invalid state: ", this._currentState), null);
					}
					case JsonWriter.State.Closed:
					{
						return Newtonsoft.Json.WriteState.Closed;
					}
					case JsonWriter.State.Error:
					{
						return Newtonsoft.Json.WriteState.Error;
					}
					default:
					{
						throw JsonWriterException.Create(this, string.Concat("Invalid state: ", this._currentState), null);
					}
				}
			}
		}

		static JsonWriter()
		{
			JsonWriter.State[][] stateArray = new JsonWriter.State[8][];
			JsonWriter.State[] stateArray1 = new JsonWriter.State[] { JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[0] = stateArray1;
			JsonWriter.State[] stateArray2 = new JsonWriter.State[] { JsonWriter.State.ObjectStart, JsonWriter.State.ObjectStart, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.ObjectStart, JsonWriter.State.ObjectStart, JsonWriter.State.ObjectStart, JsonWriter.State.ObjectStart, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[1] = stateArray2;
			JsonWriter.State[] stateArray3 = new JsonWriter.State[] { JsonWriter.State.ArrayStart, JsonWriter.State.ArrayStart, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.ArrayStart, JsonWriter.State.ArrayStart, JsonWriter.State.ArrayStart, JsonWriter.State.ArrayStart, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[2] = stateArray3;
			JsonWriter.State[] stateArray4 = new JsonWriter.State[] { JsonWriter.State.ConstructorStart, JsonWriter.State.ConstructorStart, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.ConstructorStart, JsonWriter.State.ConstructorStart, JsonWriter.State.ConstructorStart, JsonWriter.State.ConstructorStart, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[3] = stateArray4;
			JsonWriter.State[] stateArray5 = new JsonWriter.State[] { JsonWriter.State.Property, JsonWriter.State.Error, JsonWriter.State.Property, JsonWriter.State.Property, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[4] = stateArray5;
			JsonWriter.State[] stateArray6 = new JsonWriter.State[] { JsonWriter.State.Start, JsonWriter.State.Property, JsonWriter.State.ObjectStart, JsonWriter.State.Object, JsonWriter.State.ArrayStart, JsonWriter.State.Array, JsonWriter.State.Constructor, JsonWriter.State.Constructor, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[5] = stateArray6;
			JsonWriter.State[] stateArray7 = new JsonWriter.State[] { JsonWriter.State.Start, JsonWriter.State.Property, JsonWriter.State.ObjectStart, JsonWriter.State.Object, JsonWriter.State.ArrayStart, JsonWriter.State.Array, JsonWriter.State.Constructor, JsonWriter.State.Constructor, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[6] = stateArray7;
			JsonWriter.State[] stateArray8 = new JsonWriter.State[] { JsonWriter.State.Start, JsonWriter.State.Object, JsonWriter.State.Error, JsonWriter.State.Error, JsonWriter.State.Array, JsonWriter.State.Array, JsonWriter.State.Constructor, JsonWriter.State.Constructor, JsonWriter.State.Error, JsonWriter.State.Error };
			stateArray[7] = stateArray8;
			JsonWriter.StateArrayTempate = stateArray;
			JsonWriter.StateArray = JsonWriter.BuildStateArray();
		}

		protected JsonWriter()
		{
			this._stack = new List<JsonPosition>(4);
			this._currentState = JsonWriter.State.Start;
			this._formatting = Newtonsoft.Json.Formatting.None;
			this._dateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
			this.CloseOutput = true;
		}

		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
			if (tokenBeingWritten != JsonToken.StartObject && tokenBeingWritten != JsonToken.StartArray && tokenBeingWritten != JsonToken.StartConstructor)
			{
				this.UpdateScopeWithFinishedValue();
			}
			JsonWriter.State stateArray = JsonWriter.StateArray[(int)tokenBeingWritten][(int)this._currentState];
			if (stateArray == JsonWriter.State.Error)
			{
				throw JsonWriterException.Create(this, "Token {0} in state {1} would result in an invalid JSON object.".FormatWith(CultureInfo.InvariantCulture, tokenBeingWritten.ToString(), this._currentState.ToString()), null);
			}
			if ((this._currentState == JsonWriter.State.Object || this._currentState == JsonWriter.State.Array || this._currentState == JsonWriter.State.Constructor) && tokenBeingWritten != JsonToken.Comment)
			{
				this.WriteValueDelimiter();
			}
			else if (this._currentState == JsonWriter.State.Property && this._formatting == Newtonsoft.Json.Formatting.Indented)
			{
				this.WriteIndentSpace();
			}
			if (this._formatting == Newtonsoft.Json.Formatting.Indented)
			{
				Newtonsoft.Json.WriteState writeState = this.WriteState;
				if (tokenBeingWritten == JsonToken.PropertyName && writeState != Newtonsoft.Json.WriteState.Start || writeState == Newtonsoft.Json.WriteState.Array || writeState == Newtonsoft.Json.WriteState.Constructor)
				{
					this.WriteIndent();
				}
			}
			this._currentState = stateArray;
		}

		private void AutoCompleteAll()
		{
			while (this.Top > 0)
			{
				this.WriteEnd();
			}
		}

		private void AutoCompleteClose(JsonToken tokenBeingClosed)
		{
			int num = 0;
			JsonContainerType typeForCloseToken = this.GetTypeForCloseToken(tokenBeingClosed);
			if (this._currentPosition.Type != typeForCloseToken)
			{
				int top = this.Top - 2;
				int num1 = top;
				while (num1 >= 0)
				{
					if (this._stack[top - num1].Type != typeForCloseToken)
					{
						num1--;
					}
					else
					{
						num = num1 + 2;
						break;
					}
				}
			}
			else
			{
				num = 1;
			}
			if (num == 0)
			{
				throw JsonWriterException.Create(this, "No token to close.", null);
			}
			for (int i = 0; i < num; i++)
			{
				JsonToken closeTokenForType = this.GetCloseTokenForType(this.Pop());
				if (this._formatting == Newtonsoft.Json.Formatting.Indented && this._currentState != JsonWriter.State.ObjectStart && this._currentState != JsonWriter.State.ArrayStart)
				{
					this.WriteIndent();
				}
				this.WriteEnd(closeTokenForType);
				JsonContainerType jsonContainerType = this.Peek();
				switch (jsonContainerType)
				{
					case JsonContainerType.None:
					{
						this._currentState = JsonWriter.State.Start;
						break;
					}
					case JsonContainerType.Object:
					{
						this._currentState = JsonWriter.State.Object;
						break;
					}
					case JsonContainerType.Array:
					{
						this._currentState = JsonWriter.State.Array;
						break;
					}
					case JsonContainerType.Constructor:
					{
						this._currentState = JsonWriter.State.Array;
						break;
					}
					default:
					{
						throw JsonWriterException.Create(this, string.Concat("Unknown JsonType: ", jsonContainerType), null);
					}
				}
			}
		}

		internal static JsonWriter.State[][] BuildStateArray()
		{
			List<JsonWriter.State[]> list = JsonWriter.StateArrayTempate.ToList<JsonWriter.State[]>();
			JsonWriter.State[] stateArrayTempate = JsonWriter.StateArrayTempate[0];
			JsonWriter.State[] stateArray = JsonWriter.StateArrayTempate[7];
			foreach (JsonToken value in EnumUtils.GetValues(typeof(JsonToken)))
			{
				if (list.Count > (int)value)
				{
					continue;
				}
				switch (value)
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
						list.Add(stateArray);
						continue;
					}
					case JsonToken.EndObject:
					case JsonToken.EndArray:
					case JsonToken.EndConstructor:
					{
						list.Add(stateArrayTempate);
						continue;
					}
					default:
					{
						goto case JsonToken.EndConstructor;
					}
				}
			}
			return list.ToArray();
		}

		public virtual void Close()
		{
			this.AutoCompleteAll();
		}

		private void Dispose(bool disposing)
		{
			if (this._currentState != JsonWriter.State.Closed)
			{
				this.Close();
			}
		}

		public abstract void Flush();

		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			switch (type)
			{
				case JsonContainerType.Object:
				{
					return JsonToken.EndObject;
				}
				case JsonContainerType.Array:
				{
					return JsonToken.EndArray;
				}
				case JsonContainerType.Constructor:
				{
					return JsonToken.EndConstructor;
				}
			}
			throw JsonWriterException.Create(this, string.Concat("No close token for type: ", type), null);
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
			throw JsonWriterException.Create(this, string.Concat("No type for token: ", token), null);
		}

		private bool IsEndToken(JsonToken token)
		{
			switch (token)
			{
				case JsonToken.EndObject:
				case JsonToken.EndArray:
				case JsonToken.EndConstructor:
				{
					return true;
				}
			}
			return false;
		}

		private bool IsStartToken(JsonToken token)
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

		public virtual void WriteComment(string text)
		{
			this.AutoComplete(JsonToken.Comment);
		}

		private void WriteConstructorDate(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonWriterException.Create(this, "Unexpected end when reading date constructor.", null);
			}
			if (reader.TokenType != JsonToken.Integer)
			{
				throw JsonWriterException.Create(this, string.Concat("Unexpected token when reading date constructor. Expected Integer, got ", reader.TokenType), null);
			}
			DateTime dateTime = JsonConvert.ConvertJavaScriptTicksToDateTime((long)reader.Value);
			if (!reader.Read())
			{
				throw JsonWriterException.Create(this, "Unexpected end when reading date constructor.", null);
			}
			if (reader.TokenType != JsonToken.EndConstructor)
			{
				throw JsonWriterException.Create(this, string.Concat("Unexpected token when reading date constructor. Expected EndConstructor, got ", reader.TokenType), null);
			}
			this.WriteValue(dateTime);
		}

		public virtual void WriteEnd()
		{
			this.WriteEnd(this.Peek());
		}

		private void WriteEnd(JsonContainerType type)
		{
			switch (type)
			{
				case JsonContainerType.Object:
				{
					this.WriteEndObject();
					return;
				}
				case JsonContainerType.Array:
				{
					this.WriteEndArray();
					return;
				}
				case JsonContainerType.Constructor:
				{
					this.WriteEndConstructor();
					return;
				}
			}
			throw JsonWriterException.Create(this, string.Concat("Unexpected type when writing end: ", type), null);
		}

		protected virtual void WriteEnd(JsonToken token)
		{
		}

		public virtual void WriteEndArray()
		{
			this.AutoCompleteClose(JsonToken.EndArray);
		}

		public virtual void WriteEndConstructor()
		{
			this.AutoCompleteClose(JsonToken.EndConstructor);
		}

		public virtual void WriteEndObject()
		{
			this.AutoCompleteClose(JsonToken.EndObject);
		}

		protected virtual void WriteIndent()
		{
		}

		protected virtual void WriteIndentSpace()
		{
		}

		public virtual void WriteNull()
		{
			this.AutoComplete(JsonToken.Null);
		}

		public virtual void WritePropertyName(string name)
		{
			this._currentPosition.PropertyName = name;
			this.AutoComplete(JsonToken.PropertyName);
		}

		public virtual void WriteRaw(string json)
		{
		}

		public virtual void WriteRawValue(string json)
		{
			this.AutoComplete(JsonToken.Undefined);
			this.WriteRaw(json);
		}

		public virtual void WriteStartArray()
		{
			this.AutoComplete(JsonToken.StartArray);
			this.Push(JsonContainerType.Array);
		}

		public virtual void WriteStartConstructor(string name)
		{
			this.AutoComplete(JsonToken.StartConstructor);
			this.Push(JsonContainerType.Constructor);
		}

		public virtual void WriteStartObject()
		{
			this.AutoComplete(JsonToken.StartObject);
			this.Push(JsonContainerType.Object);
		}

		public void WriteToken(JsonReader reader)
		{
			int num;
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType != JsonToken.None)
			{
				num = (this.IsStartToken(reader.TokenType) ? reader.Depth : reader.Depth + 1);
			}
			else
			{
				num = -1;
			}
			this.WriteToken(reader, num);
		}

		internal void WriteToken(JsonReader reader, int initialDepth)
		{
			int depth;
			int num;
			int num1;
			do
			{
				switch (reader.TokenType)
				{
					case JsonToken.None:
					{
						num1 = initialDepth - 1;
						depth = reader.Depth;
						if (this.IsEndToken(reader.TokenType))
						{
							num = 1;
							continue;
						}
						else
						{
							num = 0;
							continue;
						}
					}
					case JsonToken.StartObject:
					{
						this.WriteStartObject();
						goto case JsonToken.None;
					}
					case JsonToken.StartArray:
					{
						this.WriteStartArray();
						goto case JsonToken.None;
					}
					case JsonToken.StartConstructor:
					{
						if (!string.Equals(reader.Value.ToString(), "Date", StringComparison.Ordinal))
						{
							this.WriteStartConstructor(reader.Value.ToString());
							goto case JsonToken.None;
						}
						else
						{
							this.WriteConstructorDate(reader);
							goto case JsonToken.None;
						}
					}
					case JsonToken.PropertyName:
					{
						this.WritePropertyName(reader.Value.ToString());
						goto case JsonToken.None;
					}
					case JsonToken.Comment:
					{
						this.WriteComment(reader.Value.ToString());
						goto case JsonToken.None;
					}
					case JsonToken.Raw:
					{
						this.WriteRawValue((string)reader.Value);
						goto case JsonToken.None;
					}
					case JsonToken.Integer:
					{
						this.WriteValue(Convert.ToInt64(reader.Value, CultureInfo.InvariantCulture));
						goto case JsonToken.None;
					}
					case JsonToken.Float:
					{
						this.WriteValue(Convert.ToDouble(reader.Value, CultureInfo.InvariantCulture));
						goto case JsonToken.None;
					}
					case JsonToken.String:
					{
						this.WriteValue(reader.Value.ToString());
						goto case JsonToken.None;
					}
					case JsonToken.Boolean:
					{
						this.WriteValue(Convert.ToBoolean(reader.Value, CultureInfo.InvariantCulture));
						goto case JsonToken.None;
					}
					case JsonToken.Null:
					{
						this.WriteNull();
						goto case JsonToken.None;
					}
					case JsonToken.Undefined:
					{
						this.WriteUndefined();
						goto case JsonToken.None;
					}
					case JsonToken.EndObject:
					{
						this.WriteEndObject();
						goto case JsonToken.None;
					}
					case JsonToken.EndArray:
					{
						this.WriteEndArray();
						goto case JsonToken.None;
					}
					case JsonToken.EndConstructor:
					{
						this.WriteEndConstructor();
						goto case JsonToken.None;
					}
					case JsonToken.Date:
					{
						this.WriteValue((DateTime)reader.Value);
						goto case JsonToken.None;
					}
					case JsonToken.Bytes:
					{
						this.WriteValue((byte[])reader.Value);
						goto case JsonToken.None;
					}
				}
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException("TokenType", reader.TokenType, "Unexpected token type.");
			}
			while (num1 < depth - num && reader.Read());
		}

		public virtual void WriteUndefined()
		{
			this.AutoComplete(JsonToken.Undefined);
		}

		public virtual void WriteValue(string value)
		{
			this.AutoComplete(JsonToken.String);
		}

		public virtual void WriteValue(int value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		public virtual void WriteValue(long value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		public virtual void WriteValue(float value)
		{
			this.AutoComplete(JsonToken.Float);
		}

		public virtual void WriteValue(double value)
		{
			this.AutoComplete(JsonToken.Float);
		}

		public virtual void WriteValue(bool value)
		{
			this.AutoComplete(JsonToken.Boolean);
		}

		public virtual void WriteValue(short value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		public virtual void WriteValue(char value)
		{
			this.AutoComplete(JsonToken.String);
		}

		public virtual void WriteValue(byte value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
			this.AutoComplete(JsonToken.Integer);
		}

		public virtual void WriteValue(decimal value)
		{
			this.AutoComplete(JsonToken.Float);
		}

		public virtual void WriteValue(DateTime value)
		{
			this.AutoComplete(JsonToken.Date);
		}

		public virtual void WriteValue(DateTimeOffset value)
		{
			this.AutoComplete(JsonToken.Date);
		}

		public virtual void WriteValue(Guid value)
		{
			this.AutoComplete(JsonToken.String);
		}

		public virtual void WriteValue(TimeSpan value)
		{
			this.AutoComplete(JsonToken.String);
		}

		public virtual void WriteValue(int? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(long? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(float? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(double? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(bool? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(short? value)
		{
			int? nullable;
			short? nullable1 = value;
			if (nullable1.HasValue)
			{
				nullable = new int?(nullable1.GetValueOrDefault());
			}
			else
			{
				nullable = null;
			}
			if (!nullable.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
			int? nullable;
			ushort? nullable1 = value;
			if (nullable1.HasValue)
			{
				nullable = new int?((int)nullable1.GetValueOrDefault());
			}
			else
			{
				nullable = null;
			}
			if (!nullable.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(char? value)
		{
			int? nullable;
			char? nullable1 = value;
			if (nullable1.HasValue)
			{
				nullable = new int?(nullable1.GetValueOrDefault());
			}
			else
			{
				nullable = null;
			}
			if (!nullable.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(byte? value)
		{
			int? nullable;
			byte? nullable1 = value;
			if (nullable1.HasValue)
			{
				nullable = new int?((int)nullable1.GetValueOrDefault());
			}
			else
			{
				nullable = null;
			}
			if (!nullable.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
			int? nullable;
			sbyte? nullable1 = value;
			if (nullable1.HasValue)
			{
				nullable = new int?(nullable1.GetValueOrDefault());
			}
			else
			{
				nullable = null;
			}
			if (!nullable.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(decimal? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(DateTime? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(DateTimeOffset? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(Guid? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(TimeSpan? value)
		{
			if (!value.HasValue)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.Value);
		}

		public virtual void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.AutoComplete(JsonToken.Bytes);
		}

		public virtual void WriteValue(Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.AutoComplete(JsonToken.String);
		}

		public virtual void WriteValue(object value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			if (!ConvertUtils.IsConvertible(value))
			{
				if (value is DateTimeOffset)
				{
					this.WriteValue((DateTimeOffset)value);
					return;
				}
				if (value is byte[])
				{
					this.WriteValue((byte[])value);
					return;
				}
				if (value is Guid)
				{
					this.WriteValue((Guid)value);
					return;
				}
				if (value is Uri)
				{
					this.WriteValue((Uri)value);
					return;
				}
				if (value is TimeSpan)
				{
					this.WriteValue((TimeSpan)value);
					return;
				}
			}
			else
			{
				IConvertible convertible = ConvertUtils.ToConvertible(value);
				switch (convertible.GetTypeCode())
				{
					case TypeCode.DBNull:
					{
						this.WriteNull();
						return;
					}
					case TypeCode.Boolean:
					{
						this.WriteValue(convertible.ToBoolean(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Char:
					{
						this.WriteValue(convertible.ToChar(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.SByte:
					{
						this.WriteValue(convertible.ToSByte(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Byte:
					{
						this.WriteValue(convertible.ToByte(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Int16:
					{
						this.WriteValue(convertible.ToInt16(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.UInt16:
					{
						this.WriteValue(convertible.ToUInt16(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Int32:
					{
						this.WriteValue(convertible.ToInt32(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.UInt32:
					{
						this.WriteValue(convertible.ToUInt32(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Int64:
					{
						this.WriteValue(convertible.ToInt64(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.UInt64:
					{
						this.WriteValue(convertible.ToUInt64(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Single:
					{
						this.WriteValue(convertible.ToSingle(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Double:
					{
						this.WriteValue(convertible.ToDouble(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.Decimal:
					{
						this.WriteValue(convertible.ToDecimal(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.DateTime:
					{
						this.WriteValue(convertible.ToDateTime(CultureInfo.InvariantCulture));
						return;
					}
					case TypeCode.String:
					{
						this.WriteValue(convertible.ToString(CultureInfo.InvariantCulture));
						return;
					}
				}
			}
			throw JsonWriterException.Create(this, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".FormatWith(CultureInfo.InvariantCulture, value.GetType()), null);
		}

		protected virtual void WriteValueDelimiter()
		{
		}

		public virtual void WriteWhitespace(string ws)
		{
			if (ws != null && !StringUtils.IsWhiteSpace(ws))
			{
				throw JsonWriterException.Create(this, "Only white space characters should be used.", null);
			}
		}

		internal enum State
		{
			Start,
			Property,
			ObjectStart,
			Object,
			ArrayStart,
			Array,
			ConstructorStart,
			Constructor,
			Bytes,
			Closed,
			Error
		}
	}
}