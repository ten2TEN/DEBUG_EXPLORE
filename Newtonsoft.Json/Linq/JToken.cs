using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Linq
{
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		private JContainer _parent;

		private JToken _previous;

		private JToken _next;

		private static JTokenEqualityComparer _equalityComparer;

		private int? _lineNumber;

		private int? _linePosition;

		public static JTokenEqualityComparer EqualityComparer
		{
			get
			{
				if (JToken._equalityComparer == null)
				{
					JToken._equalityComparer = new JTokenEqualityComparer();
				}
				return JToken._equalityComparer;
			}
		}

		public virtual JToken First
		{
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, this.GetType()));
			}
		}

		public abstract bool HasValues
		{
			get;
		}

		public virtual JToken this[object key]
		{
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, this.GetType()));
			}
			set
			{
				throw new InvalidOperationException("Cannot set child value on {0}.".FormatWith(CultureInfo.InvariantCulture, this.GetType()));
			}
		}

		public virtual JToken Last
		{
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, this.GetType()));
			}
		}

		int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			get
			{
				int? nullable = this._lineNumber;
				if (!nullable.HasValue)
				{
					return 0;
				}
				return nullable.GetValueOrDefault();
			}
		}

		int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			get
			{
				int? nullable = this._linePosition;
				if (!nullable.HasValue)
				{
					return 0;
				}
				return nullable.GetValueOrDefault();
			}
		}

		IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.this[object key]
		{
			get
			{
				return this[key];
			}
		}

		public JToken Next
		{
			get
			{
				return this._next;
			}
			internal set
			{
				this._next = value;
			}
		}

		public JContainer Parent
		{
			[DebuggerStepThrough]
			get
			{
				return this._parent;
			}
			internal set
			{
				this._parent = value;
			}
		}

		public JToken Previous
		{
			get
			{
				return this._previous;
			}
			internal set
			{
				this._previous = value;
			}
		}

		public JToken Root
		{
			get
			{
				JContainer parent = this.Parent;
				if (parent == null)
				{
					return this;
				}
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				return parent;
			}
		}

		public abstract JTokenType Type
		{
			get;
		}

		internal JToken()
		{
		}

		public void AddAfterSelf(object content)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int num = this._parent.IndexOfItem(this);
			this._parent.AddInternal(num + 1, content, false);
		}

		public void AddBeforeSelf(object content)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int num = this._parent.IndexOfItem(this);
			this._parent.AddInternal(num, content, false);
		}

		public IEnumerable<JToken> AfterSelf()
		{
			if (this.Parent != null)
			{
				for (JToken i = this.Next; i != null; i = i.Next)
				{
					yield return i;
				}
			}
		}

		public IEnumerable<JToken> Ancestors()
		{
			for (JToken i = this.Parent; i != null; i = i.Parent)
			{
				yield return i;
			}
		}

		public IEnumerable<JToken> BeforeSelf()
		{
			for (JToken i = this.Parent.First; i != this; i = i.Next)
			{
				yield return i;
			}
		}

		public virtual JEnumerable<JToken> Children()
		{
			return JEnumerable<JToken>.Empty;
		}

		public JEnumerable<T> Children<T>()
		where T : JToken
		{
			return new JEnumerable<T>(this.Children().OfType<T>());
		}

		internal abstract JToken CloneToken();

		public JsonReader CreateReader()
		{
			return new JTokenReader(this);
		}

		public JToken DeepClone()
		{
			return this.CloneToken();
		}

		internal abstract bool DeepEquals(JToken node);

		public static bool DeepEquals(JToken t1, JToken t2)
		{
			if (t1 == t2)
			{
				return true;
			}
			if (t1 == null || t2 == null)
			{
				return false;
			}
			return t1.DeepEquals(t2);
		}

		private static JValue EnsureValue(JToken value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value is JProperty)
			{
				value = ((JProperty)value).Value;
			}
			return value as JValue;
		}

		public static JToken FromObject(object o)
		{
			return JToken.FromObjectInternal(o, new JsonSerializer());
		}

		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return JToken.FromObjectInternal(o, jsonSerializer);
		}

		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			JToken token;
			ValidationUtils.ArgumentNotNull(o, "o");
			ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			using (JTokenWriter jTokenWriter = new JTokenWriter())
			{
				jsonSerializer.Serialize(jTokenWriter, o);
				token = jTokenWriter.Token;
			}
			return token;
		}

		internal abstract int GetDeepHashCode();

		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JToken>(parameter, this, new DynamicProxy<JToken>(), true);
		}

		private static string GetType(JToken token)
		{
			ValidationUtils.ArgumentNotNull(token, "token");
			if (token is JProperty)
			{
				token = ((JProperty)token).Value;
			}
			return token.Type.ToString();
		}

		private static bool IsNullable(JToken o)
		{
			if (o.Type == JTokenType.Undefined)
			{
				return true;
			}
			return o.Type == JTokenType.Null;
		}

		public static JToken Load(JsonReader reader)
		{
			return JToken.ReadFrom(reader);
		}

		bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			if (!this._lineNumber.HasValue)
			{
				return false;
			}
			return this._linePosition.HasValue;
		}

		public static explicit operator Boolean(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateBoolean(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToBoolean(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator DateTimeOffset(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateDate(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return (DateTimeOffset)jValue.Value;
		}

		public static explicit operator Nullable<Boolean>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateBoolean(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Int64(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToInt64(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator Nullable<DateTime>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateDate(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new DateTime?(Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Nullable<DateTimeOffset>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateDate(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return (DateTimeOffset?)jValue.Value;
		}

		public static explicit operator Nullable<Decimal>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateFloat(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new decimal?(Convert.ToDecimal(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Nullable<Double>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateFloat(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return (double?)jValue.Value;
		}

		public static explicit operator Int32(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToInt32(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator Int16(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture);
		}

		[CLSCompliant(false)]
		public static explicit operator UInt16(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToUInt16(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator Nullable<Int32>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new int?(Convert.ToInt32(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Nullable<Int16>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new short?(Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture));
		}

		[CLSCompliant(false)]
		public static explicit operator Nullable<UInt16>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new ushort?((ushort)Convert.ToInt16(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator DateTime(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateDate(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToDateTime(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator Nullable<Int64>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new long?(Convert.ToInt64(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Nullable<Single>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateFloat(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new float?(Convert.ToSingle(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Decimal(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateFloat(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToDecimal(jValue.Value, CultureInfo.InvariantCulture);
		}

		[CLSCompliant(false)]
		public static explicit operator Nullable<UInt32>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new uint?(Convert.ToUInt32(jValue.Value, CultureInfo.InvariantCulture));
		}

		[CLSCompliant(false)]
		public static explicit operator Nullable<UInt64>(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return new ulong?(Convert.ToUInt64(jValue.Value, CultureInfo.InvariantCulture));
		}

		public static explicit operator Double(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateFloat(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToDouble(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator Single(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateFloat(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToSingle(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator String(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateString(jValue))
			{
				throw new ArgumentException("Can not convert {0} to String.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jValue.Value == null)
			{
				return null;
			}
			return Convert.ToString(jValue.Value, CultureInfo.InvariantCulture);
		}

		[CLSCompliant(false)]
		public static explicit operator UInt32(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToUInt32(jValue.Value, CultureInfo.InvariantCulture);
		}

		[CLSCompliant(false)]
		public static explicit operator UInt64(JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateInteger(jValue, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return Convert.ToUInt64(jValue.Value, CultureInfo.InvariantCulture);
		}

		public static explicit operator Byte[](JToken value)
		{
			JValue jValue = JToken.EnsureValue(value);
			if (jValue == null || !JToken.ValidateBytes(jValue))
			{
				throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return (byte[])jValue.Value;
		}

		public static implicit operator JToken(bool value)
		{
			return new JValue(value);
		}

		public static implicit operator JToken(DateTimeOffset value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(bool? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(long value)
		{
			return new JValue(value);
		}

		public static implicit operator JToken(DateTime? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(DateTimeOffset? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(decimal? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(double? value)
		{
			return new JValue((object)value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(short value)
		{
			return new JValue((long)value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(ushort value)
		{
			return new JValue((long)((ulong)value));
		}

		public static implicit operator JToken(int value)
		{
			return new JValue((long)value);
		}

		public static implicit operator JToken(int? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(DateTime value)
		{
			return new JValue(value);
		}

		public static implicit operator JToken(long? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(float? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(decimal value)
		{
			return new JValue((object)value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(short? value)
		{
			return new JValue((object)value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(ushort? value)
		{
			return new JValue((object)value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(uint? value)
		{
			return new JValue((object)value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(ulong? value)
		{
			return new JValue((object)value);
		}

		public static implicit operator JToken(double value)
		{
			return new JValue(value);
		}

		public static implicit operator JToken(float value)
		{
			return new JValue((double)value);
		}

		public static implicit operator JToken(string value)
		{
			return new JValue(value);
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(uint value)
		{
			return new JValue((long)((ulong)value));
		}

		[CLSCompliant(false)]
		public static implicit operator JToken(ulong value)
		{
			return new JValue(value);
		}

		public static implicit operator JToken(byte[] value)
		{
			return new JValue(value);
		}

		public static JToken Parse(string json)
		{
			JsonReader jsonTextReader = new JsonTextReader(new StringReader(json));
			JToken jTokens = JToken.Load(jsonTextReader);
			if (jsonTextReader.Read() && jsonTextReader.TokenType != JsonToken.Comment)
			{
				throw JsonReaderException.Create(jsonTextReader, "Additional text found in JSON string after parsing content.");
			}
			return jTokens;
		}

		public static JToken ReadFrom(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader.");
			}
			if (reader.TokenType == JsonToken.StartObject)
			{
				return JObject.Load(reader);
			}
			if (reader.TokenType == JsonToken.StartArray)
			{
				return JArray.Load(reader);
			}
			if (reader.TokenType == JsonToken.PropertyName)
			{
				return JProperty.Load(reader);
			}
			if (reader.TokenType == JsonToken.StartConstructor)
			{
				return JConstructor.Load(reader);
			}
			if (JsonReader.IsStartToken(reader.TokenType))
			{
				throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader. Unexpected token: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			return new JValue(reader.Value);
		}

		public void Remove()
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this._parent.RemoveItem(this);
		}

		public void Replace(JToken value)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this._parent.ReplaceItem(this, value);
		}

		public JToken SelectToken(string path)
		{
			return this.SelectToken(path, false);
		}

		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			return (new JPath(path)).Evaluate(this, errorWhenNoMatch);
		}

		internal void SetLineInfo(IJsonLineInfo lineInfo)
		{
			if (lineInfo == null || !lineInfo.HasLineInfo())
			{
				return;
			}
			this.SetLineInfo(lineInfo.LineNumber, lineInfo.LinePosition);
		}

		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			this._lineNumber = new int?(lineNumber);
			this._linePosition = new int?(linePosition);
		}

		IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<JToken>)this).GetEnumerator();
		}

		DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return this.GetMetaObject(parameter);
		}

		object System.ICloneable.Clone()
		{
			return this.DeepClone();
		}

		public T ToObject<T>()
		{
			return this.ToObject<T>(new JsonSerializer());
		}

		public T ToObject<T>(JsonSerializer jsonSerializer)
		{
			T t;
			ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			using (JTokenReader jTokenReader = new JTokenReader(this))
			{
				t = jsonSerializer.Deserialize<T>(jTokenReader);
			}
			return t;
		}

		public override string ToString()
		{
			return this.ToString(Formatting.Indented, new JsonConverter[0]);
		}

		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			string str;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter)
				{
					Formatting = formatting
				};
				this.WriteTo(jsonTextWriter, converters);
				str = stringWriter.ToString();
			}
			return str;
		}

		private static bool ValidateBoolean(JToken o, bool nullable)
		{
			if (o.Type == JTokenType.Boolean)
			{
				return true;
			}
			if (!nullable)
			{
				return false;
			}
			return JToken.IsNullable(o);
		}

		private static bool ValidateBytes(JToken o)
		{
			if (o.Type == JTokenType.Bytes)
			{
				return true;
			}
			return JToken.IsNullable(o);
		}

		private static bool ValidateDate(JToken o, bool nullable)
		{
			if (o.Type == JTokenType.Date)
			{
				return true;
			}
			if (!nullable)
			{
				return false;
			}
			return JToken.IsNullable(o);
		}

		private static bool ValidateFloat(JToken o, bool nullable)
		{
			if (o.Type == JTokenType.Float || o.Type == JTokenType.Integer)
			{
				return true;
			}
			if (!nullable)
			{
				return false;
			}
			return JToken.IsNullable(o);
		}

		private static bool ValidateInteger(JToken o, bool nullable)
		{
			if (o.Type == JTokenType.Integer)
			{
				return true;
			}
			if (!nullable)
			{
				return false;
			}
			return JToken.IsNullable(o);
		}

		private static bool ValidateString(JToken o)
		{
			if (o.Type == JTokenType.String || o.Type == JTokenType.Comment || o.Type == JTokenType.Raw)
			{
				return true;
			}
			return JToken.IsNullable(o);
		}

		public virtual T Value<T>(object key)
		{
			return this[key].Convert<JToken, T>();
		}

		public virtual IEnumerable<T> Values<T>()
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, this.GetType()));
		}

		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);
	}
}