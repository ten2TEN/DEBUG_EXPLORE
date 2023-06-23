using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Linq
{
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>
	{
		private JTokenType _valueType;

		private object _value;

		public override bool HasValues
		{
			get
			{
				return false;
			}
		}

		public override JTokenType Type
		{
			get
			{
				return this._valueType;
			}
		}

		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				System.Type type;
				System.Type type1;
				if (this._value != null)
				{
					type = this._value.GetType();
				}
				else
				{
					type = null;
				}
				System.Type type2 = type;
				if (value != null)
				{
					type1 = value.GetType();
				}
				else
				{
					type1 = null;
				}
				if (type2 != type1)
				{
					this._valueType = JValue.GetValueType(new JTokenType?(this._valueType), value);
				}
				this._value = value;
			}
		}

		internal JValue(object value, JTokenType type)
		{
			this._value = value;
			this._valueType = type;
		}

		public JValue(JValue other) : this(other.Value, other.Type)
		{
		}

		public JValue(long value) : this(value, JTokenType.Integer)
		{
		}

		[CLSCompliant(false)]
		public JValue(ulong value) : this(value, JTokenType.Integer)
		{
		}

		public JValue(double value) : this(value, JTokenType.Float)
		{
		}

		public JValue(DateTime value) : this(value, JTokenType.Date)
		{
		}

		public JValue(bool value) : this(value, JTokenType.Boolean)
		{
		}

		public JValue(string value) : this(value, JTokenType.String)
		{
		}

		public JValue(Guid value) : this(value, JTokenType.String)
		{
		}

		public JValue(Uri value) : this(value, JTokenType.String)
		{
		}

		public JValue(TimeSpan value) : this(value, JTokenType.String)
		{
		}

		public JValue(object value) : this(value, JValue.GetValueType(null, value))
		{
		}

		internal override JToken CloneToken()
		{
			return new JValue(this);
		}

		private static int Compare(JTokenType valueType, object objA, object objB)
		{
			if (objA == null && objB == null)
			{
				return 0;
			}
			if (objA != null && objB == null)
			{
				return 1;
			}
			if (objA == null && objB != null)
			{
				return -1;
			}
			switch (valueType)
			{
				case JTokenType.Comment:
				case JTokenType.String:
				case JTokenType.Raw:
				{
					string str = Convert.ToString(objA, CultureInfo.InvariantCulture);
					string str1 = Convert.ToString(objB, CultureInfo.InvariantCulture);
					return string.CompareOrdinal(str, str1);
				}
				case JTokenType.Integer:
				{
					if (objA is ulong || objB is ulong || objA is decimal || objB is decimal)
					{
						decimal num = Convert.ToDecimal(objA, CultureInfo.InvariantCulture);
						return num.CompareTo(Convert.ToDecimal(objB, CultureInfo.InvariantCulture));
					}
					if (objA is float || objB is float || objA is double || objB is double)
					{
						return JValue.CompareFloat(objA, objB);
					}
					long num1 = Convert.ToInt64(objA, CultureInfo.InvariantCulture);
					return num1.CompareTo(Convert.ToInt64(objB, CultureInfo.InvariantCulture));
				}
				case JTokenType.Float:
				{
					return JValue.CompareFloat(objA, objB);
				}
				case JTokenType.Boolean:
				{
					bool flag = Convert.ToBoolean(objA, CultureInfo.InvariantCulture);
					bool flag1 = Convert.ToBoolean(objB, CultureInfo.InvariantCulture);
					return flag.CompareTo(flag1);
				}
				case JTokenType.Null:
				case JTokenType.Undefined:
				{
					throw MiscellaneousUtils.CreateArgumentOutOfRangeException("valueType", valueType, "Unexpected value type: {0}".FormatWith(CultureInfo.InvariantCulture, valueType));
				}
				case JTokenType.Date:
				{
					if (objA is DateTime)
					{
						DateTime dateTime = Convert.ToDateTime(objA, CultureInfo.InvariantCulture);
						DateTime dateTime1 = Convert.ToDateTime(objB, CultureInfo.InvariantCulture);
						return dateTime.CompareTo(dateTime1);
					}
					if (!(objB is DateTimeOffset))
					{
						throw new ArgumentException("Object must be of type DateTimeOffset.");
					}
					return ((DateTimeOffset)objA).CompareTo((DateTimeOffset)objB);
				}
				case JTokenType.Bytes:
				{
					if (!(objB is byte[]))
					{
						throw new ArgumentException("Object must be of type byte[].");
					}
					byte[] numArray = objA as byte[];
					byte[] numArray1 = objB as byte[];
					if (numArray == null)
					{
						return -1;
					}
					if (numArray1 == null)
					{
						return 1;
					}
					return MiscellaneousUtils.ByteArrayCompare(numArray, numArray1);
				}
				case JTokenType.Guid:
				{
					if (!(objB is Guid))
					{
						throw new ArgumentException("Object must be of type Guid.");
					}
					return ((Guid)objA).CompareTo((Guid)objB);
				}
				case JTokenType.Uri:
				{
					if (!(objB is Uri))
					{
						throw new ArgumentException("Object must be of type Uri.");
					}
					Uri uri = (Uri)objA;
					Uri uri1 = (Uri)objB;
					return Comparer<string>.Default.Compare(uri.ToString(), uri1.ToString());
				}
				case JTokenType.TimeSpan:
				{
					if (!(objB is TimeSpan))
					{
						throw new ArgumentException("Object must be of type TimeSpan.");
					}
					return ((TimeSpan)objA).CompareTo((TimeSpan)objB);
				}
				default:
				{
					throw MiscellaneousUtils.CreateArgumentOutOfRangeException("valueType", valueType, "Unexpected value type: {0}".FormatWith(CultureInfo.InvariantCulture, valueType));
				}
			}
		}

		private static int CompareFloat(object objA, object objB)
		{
			double num = Convert.ToDouble(objA, CultureInfo.InvariantCulture);
			double num1 = Convert.ToDouble(objB, CultureInfo.InvariantCulture);
			if (MathUtils.ApproxEquals(num, num1))
			{
				return 0;
			}
			return num.CompareTo(num1);
		}

		public int CompareTo(JValue obj)
		{
			if (obj == null)
			{
				return 1;
			}
			return JValue.Compare(this._valueType, this._value, obj._value);
		}

		public static JValue CreateComment(string value)
		{
			return new JValue(value, JTokenType.Comment);
		}

		public static JValue CreateString(string value)
		{
			return new JValue(value, JTokenType.String);
		}

		internal override bool DeepEquals(JToken node)
		{
			JValue jValue = node as JValue;
			if (jValue == null)
			{
				return false;
			}
			if (jValue == this)
			{
				return true;
			}
			return JValue.ValuesEquals(this, jValue);
		}

		public bool Equals(JValue other)
		{
			if (other == null)
			{
				return false;
			}
			return JValue.ValuesEquals(this, other);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			JValue jValue = obj as JValue;
			if (jValue != null)
			{
				return this.Equals(jValue);
			}
			return base.Equals(obj);
		}

		internal override int GetDeepHashCode()
		{
			return this._valueType.GetHashCode() ^ (this._value != null ? this._value.GetHashCode() : 0);
		}

		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JValue>(parameter, this, new JValue.JValueDynamicProxy(), true);
		}

		private static JTokenType GetStringValueType(JTokenType? current)
		{
			if (!current.HasValue)
			{
				return JTokenType.String;
			}
			JTokenType value = current.Value;
			if (value != JTokenType.Comment && value != JTokenType.String && value != JTokenType.Raw)
			{
				return JTokenType.String;
			}
			return current.Value;
		}

		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			if (value == null)
			{
				return JTokenType.Null;
			}
			if (value == DBNull.Value)
			{
				return JTokenType.Null;
			}
			if (value is string)
			{
				return JValue.GetStringValueType(current);
			}
			if (value is long || value is int || value is short || value is sbyte || value is ulong || value is uint || value is ushort || value is byte)
			{
				return JTokenType.Integer;
			}
			if (value is Enum)
			{
				return JTokenType.Integer;
			}
			if (value is double || value is float || value is decimal)
			{
				return JTokenType.Float;
			}
			if (value is DateTime)
			{
				return JTokenType.Date;
			}
			if (value is DateTimeOffset)
			{
				return JTokenType.Date;
			}
			if (value is byte[])
			{
				return JTokenType.Bytes;
			}
			if (value is bool)
			{
				return JTokenType.Boolean;
			}
			if (value is Guid)
			{
				return JTokenType.Guid;
			}
			if (value is Uri)
			{
				return JTokenType.Uri;
			}
			if (!(value is TimeSpan))
			{
				throw new ArgumentException("Could not determine JSON object type for type {0}.".FormatWith(CultureInfo.InvariantCulture, value.GetType()));
			}
			return JTokenType.TimeSpan;
		}

		private static bool Operation(ExpressionType operation, object objA, object objB, out object result)
		{
			string str;
			string str1;
			if ((objA is string || objB is string) && (operation == ExpressionType.Add || operation == ExpressionType.AddAssign))
			{
				if (objA != null)
				{
					str = objA.ToString();
				}
				else
				{
					str = null;
				}
				if (objB != null)
				{
					str1 = objB.ToString();
				}
				else
				{
					str1 = null;
				}
				result = string.Concat(str, str1);
				return true;
			}
			if (objA is ulong || objB is ulong || objA is decimal || objB is decimal)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				decimal num = Convert.ToDecimal(objA, CultureInfo.InvariantCulture);
				decimal num1 = Convert.ToDecimal(objB, CultureInfo.InvariantCulture);
				ExpressionType expressionType = operation;
				if (expressionType > ExpressionType.Multiply)
				{
					if (expressionType > ExpressionType.DivideAssign)
					{
						if (expressionType == ExpressionType.MultiplyAssign)
						{
							result = num * num1;
							return true;
						}
						if (expressionType == ExpressionType.SubtractAssign)
						{
							result = num - num1;
							return true;
						}
						result = null;
						return false;
					}
					else
					{
						if (expressionType == ExpressionType.Subtract)
						{
							result = num - num1;
							return true;
						}
						switch (expressionType)
						{
							case ExpressionType.AddAssign:
							{
								result = num + num1;
								return true;
							}
							case ExpressionType.AndAssign:
							{
								result = null;
								return false;
							}
							case ExpressionType.DivideAssign:
							{
								result = num / num1;
								return true;
							}
							default:
							{
								result = null;
								return false;
							}
						}
					}
					result = num - num1;
					return true;
				}
				else
				{
					if (expressionType == ExpressionType.Add)
					{
						result = num + num1;
						return true;
					}
					if (expressionType == ExpressionType.Divide)
					{
						result = num / num1;
						return true;
					}
					if (expressionType == ExpressionType.Multiply)
					{
						result = num * num1;
						return true;
					}
					result = null;
					return false;
				}
				result = num / num1;
				return true;
			}
			else if (objA is float || objB is float || objA is double || objB is double)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				double num2 = Convert.ToDouble(objA, CultureInfo.InvariantCulture);
				double num3 = Convert.ToDouble(objB, CultureInfo.InvariantCulture);
				ExpressionType expressionType1 = operation;
				if (expressionType1 > ExpressionType.Multiply)
				{
					if (expressionType1 > ExpressionType.DivideAssign)
					{
						if (expressionType1 == ExpressionType.MultiplyAssign)
						{
							result = num2 * num3;
							return true;
						}
						if (expressionType1 == ExpressionType.SubtractAssign)
						{
							result = num2 - num3;
							return true;
						}
						result = null;
						return false;
					}
					else
					{
						if (expressionType1 == ExpressionType.Subtract)
						{
							result = num2 - num3;
							return true;
						}
						switch (expressionType1)
						{
							case ExpressionType.AddAssign:
							{
								result = num2 + num3;
								return true;
							}
							case ExpressionType.AndAssign:
							{
								result = null;
								return false;
							}
							case ExpressionType.DivideAssign:
							{
								result = num2 / num3;
								return true;
							}
							default:
							{
								result = null;
								return false;
							}
						}
					}
					result = num2 - num3;
					return true;
				}
				else
				{
					if (expressionType1 == ExpressionType.Add)
					{
						result = num2 + num3;
						return true;
					}
					if (expressionType1 == ExpressionType.Divide)
					{
						result = num2 / num3;
						return true;
					}
					if (expressionType1 == ExpressionType.Multiply)
					{
						result = num2 * num3;
						return true;
					}
					result = null;
					return false;
				}
				result = num2 / num3;
				return true;
			}
			else if (objA is int || objA is uint || objA is long || objA is short || objA is ushort || objA is sbyte || objA is byte || objB is int || objB is uint || objB is long || objB is short || objB is ushort || objB is sbyte || objB is byte)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				long num4 = Convert.ToInt64(objA, CultureInfo.InvariantCulture);
				long num5 = Convert.ToInt64(objB, CultureInfo.InvariantCulture);
				ExpressionType expressionType2 = operation;
				if (expressionType2 > ExpressionType.Multiply)
				{
					if (expressionType2 > ExpressionType.DivideAssign)
					{
						if (expressionType2 == ExpressionType.MultiplyAssign)
						{
							result = num4 * num5;
							return true;
						}
						if (expressionType2 == ExpressionType.SubtractAssign)
						{
							result = num4 - num5;
							return true;
						}
						result = null;
						return false;
					}
					else
					{
						if (expressionType2 == ExpressionType.Subtract)
						{
							result = num4 - num5;
							return true;
						}
						switch (expressionType2)
						{
							case ExpressionType.AddAssign:
							{
								result = num4 + num5;
								return true;
							}
							case ExpressionType.AndAssign:
							{
								result = null;
								return false;
							}
							case ExpressionType.DivideAssign:
							{
								result = num4 / num5;
								return true;
							}
							default:
							{
								result = null;
								return false;
							}
						}
					}
					result = num4 - num5;
					return true;
				}
				else
				{
					if (expressionType2 == ExpressionType.Add)
					{
						result = num4 + num5;
						return true;
					}
					if (expressionType2 == ExpressionType.Divide)
					{
						result = num4 / num5;
						return true;
					}
					if (expressionType2 == ExpressionType.Multiply)
					{
						result = num4 * num5;
						return true;
					}
					result = null;
					return false;
				}
				result = num4 / num5;
				return true;
			}
			result = null;
			return false;
		}

		int System.IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			return JValue.Compare(this._valueType, this._value, (obj is JValue ? ((JValue)obj).Value : obj));
		}

		public override string ToString()
		{
			if (this._value == null)
			{
				return string.Empty;
			}
			return this._value.ToString();
		}

		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return this.ToString(null, formatProvider);
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (this._value == null)
			{
				return string.Empty;
			}
			IFormattable formattable = this._value as IFormattable;
			if (formattable == null)
			{
				return this._value.ToString();
			}
			return formattable.ToString(format, formatProvider);
		}

		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			if (v1 == v2)
			{
				return true;
			}
			if (v1._valueType != v2._valueType)
			{
				return false;
			}
			return JValue.Compare(v1._valueType, v1._value, v2._value) == 0;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			string str;
			string str1;
			string str2;
			JTokenType jTokenType = this._valueType;
			if (jTokenType == JTokenType.Comment)
			{
				writer.WriteComment(this._value.ToString());
				return;
			}
			switch (jTokenType)
			{
				case JTokenType.Null:
				{
					writer.WriteNull();
					return;
				}
				case JTokenType.Undefined:
				{
					writer.WriteUndefined();
					return;
				}
				case JTokenType.Date:
				{
					if (this._value != null)
					{
						JsonConverter matchingConverter = JsonSerializer.GetMatchingConverter(converters, this._value.GetType());
						JsonConverter jsonConverter = matchingConverter;
						if (matchingConverter != null)
						{
							jsonConverter.WriteJson(writer, this._value, new JsonSerializer());
							return;
						}
					}
					switch (this._valueType)
					{
						case JTokenType.Integer:
						{
							writer.WriteValue(Convert.ToInt64(this._value, CultureInfo.InvariantCulture));
							return;
						}
						case JTokenType.Float:
						{
							writer.WriteValue(Convert.ToDouble(this._value, CultureInfo.InvariantCulture));
							return;
						}
						case JTokenType.String:
						{
							JsonWriter jsonWriter = writer;
							if (this._value != null)
							{
								str = this._value.ToString();
							}
							else
							{
								str = null;
							}
							jsonWriter.WriteValue(str);
							return;
						}
						case JTokenType.Boolean:
						{
							writer.WriteValue(Convert.ToBoolean(this._value, CultureInfo.InvariantCulture));
							return;
						}
						case JTokenType.Null:
						case JTokenType.Undefined:
						case JTokenType.Raw:
						{
							throw MiscellaneousUtils.CreateArgumentOutOfRangeException("TokenType", this._valueType, "Unexpected token type.");
						}
						case JTokenType.Date:
						{
							if (this._value is DateTimeOffset)
							{
								writer.WriteValue((DateTimeOffset)this._value);
								return;
							}
							writer.WriteValue(Convert.ToDateTime(this._value, CultureInfo.InvariantCulture));
							return;
						}
						case JTokenType.Bytes:
						{
							writer.WriteValue((byte[])this._value);
							return;
						}
						case JTokenType.Guid:
						case JTokenType.Uri:
						case JTokenType.TimeSpan:
						{
							JsonWriter jsonWriter1 = writer;
							if (this._value != null)
							{
								str1 = this._value.ToString();
							}
							else
							{
								str1 = null;
							}
							jsonWriter1.WriteValue(str1);
							return;
						}
						default:
						{
							throw MiscellaneousUtils.CreateArgumentOutOfRangeException("TokenType", this._valueType, "Unexpected token type.");
						}
					}
					break;
				}
				case JTokenType.Raw:
				{
					JsonWriter jsonWriter2 = writer;
					if (this._value != null)
					{
						str2 = this._value.ToString();
					}
					else
					{
						str2 = null;
					}
					jsonWriter2.WriteRawValue(str2);
					return;
				}
				default:
				{
					goto case JTokenType.Date;
				}
			}
		}

		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
			public JValueDynamicProxy()
			{
			}

			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result)
			{
				object obj = (arg is JValue ? ((JValue)arg).Value : arg);
				ExpressionType operation = binder.Operation;
				if (operation <= ExpressionType.NotEqual)
				{
					if (operation > ExpressionType.LessThanOrEqual)
					{
						if (operation == ExpressionType.Multiply)
						{
							if (JValue.Operation(binder.Operation, instance.Value, obj, out result))
							{
								result = new JValue(result);
								return true;
							}
							result = null;
							return false;
						}
						if (operation == ExpressionType.NotEqual)
						{
							result = JValue.Compare(instance.Type, instance.Value, obj) != 0;
							return true;
						}
						result = null;
						return false;
					}
					else if (operation != ExpressionType.Add)
					{
						switch (operation)
						{
							case ExpressionType.Divide:
							{
								break;
							}
							case ExpressionType.Equal:
							{
								result = JValue.Compare(instance.Type, instance.Value, obj) == 0;
								return true;
							}
							case ExpressionType.ExclusiveOr:
							case ExpressionType.Invoke:
							case ExpressionType.Lambda:
							case ExpressionType.LeftShift:
							{
								result = null;
								return false;
							}
							case ExpressionType.GreaterThan:
							{
								result = JValue.Compare(instance.Type, instance.Value, obj) > 0;
								return true;
							}
							case ExpressionType.GreaterThanOrEqual:
							{
								result = JValue.Compare(instance.Type, instance.Value, obj) >= 0;
								return true;
							}
							case ExpressionType.LessThan:
							{
								result = JValue.Compare(instance.Type, instance.Value, obj) < 0;
								return true;
							}
							case ExpressionType.LessThanOrEqual:
							{
								result = JValue.Compare(instance.Type, instance.Value, obj) <= 0;
								return true;
							}
							default:
							{
								result = null;
								return false;
							}
						}
					}
				}
				else if (operation > ExpressionType.DivideAssign)
				{
					if (operation == ExpressionType.MultiplyAssign || operation == ExpressionType.SubtractAssign)
					{
						if (JValue.Operation(binder.Operation, instance.Value, obj, out result))
						{
							result = new JValue(result);
							return true;
						}
						result = null;
						return false;
					}
					result = null;
					return false;
				}
				else if (operation != ExpressionType.Subtract)
				{
					switch (operation)
					{
						case ExpressionType.AddAssign:
						case ExpressionType.DivideAssign:
						{
							break;
						}
						case ExpressionType.AndAssign:
						{
							result = null;
							return false;
						}
						default:
						{
							result = null;
							return false;
						}
					}
				}
				if (JValue.Operation(binder.Operation, instance.Value, obj, out result))
				{
					result = new JValue(result);
					return true;
				}
				result = null;
				return false;
			}

			public override bool TryConvert(JValue instance, ConvertBinder binder, out object result)
			{
				if (binder.Type == typeof(JValue))
				{
					result = instance;
					return true;
				}
				if (instance.Value == null)
				{
					result = null;
					return ReflectionUtils.IsNullable(binder.Type);
				}
				result = ConvertUtils.Convert(instance.Value, CultureInfo.InvariantCulture, binder.Type);
				return true;
			}
		}
	}
}