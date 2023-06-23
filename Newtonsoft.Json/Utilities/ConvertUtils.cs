using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	internal static class ConvertUtils
	{
		private readonly static ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters;

		static ConvertUtils()
		{
			ConvertUtils.CastConverters = new ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>>(new Func<ConvertUtils.TypeConvertKey, Func<object, object>>(ConvertUtils.CreateCastConverter));
		}

		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			if (initialValue == null)
			{
				throw new ArgumentNullException("initialValue");
			}
			if (ReflectionUtils.IsNullableType(targetType))
			{
				targetType = Nullable.GetUnderlyingType(targetType);
			}
			Type type = initialValue.GetType();
			if (targetType == type)
			{
				return initialValue;
			}
			if (ConvertUtils.IsConvertible(initialValue) && ConvertUtils.IsConvertible(targetType))
			{
				if (targetType.IsEnum())
				{
					if (initialValue is string)
					{
						return Enum.Parse(targetType, initialValue.ToString(), true);
					}
					if (ConvertUtils.IsInteger(initialValue))
					{
						return Enum.ToObject(targetType, initialValue);
					}
				}
				return Convert.ChangeType(initialValue, targetType, culture);
			}
			if (initialValue is string && typeof(Type).IsAssignableFrom(targetType))
			{
				return Type.GetType((string)initialValue, true);
			}
			if (targetType.IsInterface() || targetType.IsGenericTypeDefinition() || targetType.IsAbstract())
			{
				throw new ArgumentException("Target type {0} is not a value type or a non-abstract class.".FormatWith(CultureInfo.InvariantCulture, targetType), "targetType");
			}
			if (initialValue is DateTime && targetType == typeof(DateTimeOffset))
			{
				return new DateTimeOffset((DateTime)initialValue);
			}
			if (initialValue is string)
			{
				if (targetType == typeof(Guid))
				{
					return new Guid((string)initialValue);
				}
				if (targetType == typeof(Uri))
				{
					return new Uri((string)initialValue, UriKind.RelativeOrAbsolute);
				}
				if (targetType == typeof(TimeSpan))
				{
					return TimeSpan.Parse((string)initialValue, CultureInfo.InvariantCulture);
				}
			}
			TypeConverter converter = ConvertUtils.GetConverter(type);
			if (converter != null && converter.CanConvertTo(targetType))
			{
				return converter.ConvertTo(null, culture, initialValue, targetType);
			}
			TypeConverter typeConverter = ConvertUtils.GetConverter(targetType);
			if (typeConverter != null && typeConverter.CanConvertFrom(type))
			{
				return typeConverter.ConvertFrom(null, culture, initialValue);
			}
			if (initialValue == DBNull.Value)
			{
				if (!ReflectionUtils.IsNullable(targetType))
				{
					throw new Exception("Can not convert null {0} into non-nullable {1}.".FormatWith(CultureInfo.InvariantCulture, type, targetType));
				}
				return ConvertUtils.EnsureTypeAssignable(null, type, targetType);
			}
			if (!(initialValue is INullable))
			{
				throw new InvalidOperationException("Can not convert from {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, type, targetType));
			}
			return ConvertUtils.EnsureTypeAssignable(ConvertUtils.ToValue((INullable)initialValue), type, targetType);
		}

		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			object obj;
			if (targetType == typeof(object))
			{
				return initialValue;
			}
			if (initialValue == null && ReflectionUtils.IsNullable(targetType))
			{
				return null;
			}
			if (ConvertUtils.TryConvert(initialValue, culture, targetType, out obj))
			{
				return obj;
			}
			return ConvertUtils.EnsureTypeAssignable(initialValue, ReflectionUtils.GetObjectType(initialValue), targetType);
		}

		private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t)
		{
			Type targetType = t.TargetType;
			Type[] initialType = new Type[] { t.InitialType };
			MethodInfo method = targetType.GetMethod("op_Implicit", initialType);
			if (method == null)
			{
				Type type = t.TargetType;
				Type[] typeArray = new Type[] { t.InitialType };
				method = type.GetMethod("op_Explicit", typeArray);
			}
			if (method == null)
			{
				return null;
			}
			MethodCall<object, object> methodCall = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			return (object o) => methodCall(null, new object[] { o });
		}

		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			Type type;
			if (value != null)
			{
				type = value.GetType();
			}
			else
			{
				type = null;
			}
			Type type1 = type;
			if (value != null)
			{
				if (targetType.IsAssignableFrom(type1))
				{
					return value;
				}
				Func<object, object> func = ConvertUtils.CastConverters.Get(new ConvertUtils.TypeConvertKey(type1, targetType));
				if (func != null)
				{
					return func(value);
				}
			}
			else if (ReflectionUtils.IsNullable(targetType))
			{
				return null;
			}
			throw new ArgumentException("Could not cast or convert from {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, (initialType != null ? initialType.ToString() : "{null}"), targetType));
		}

		internal static TypeConverter GetConverter(Type t)
		{
			return JsonTypeReflector.GetTypeConverter(t);
		}

		public static TypeCode GetTypeCode(this IConvertible convertible)
		{
			return convertible.GetTypeCode();
		}

		public static TypeCode GetTypeCode(object o)
		{
			return Convert.GetTypeCode(o);
		}

		public static TypeCode GetTypeCode(Type t)
		{
			return Type.GetTypeCode(t);
		}

		public static bool IsConvertible(object o)
		{
			return o is IConvertible;
		}

		public static bool IsConvertible(Type t)
		{
			return typeof(IConvertible).IsAssignableFrom(t);
		}

		public static bool IsInteger(object value)
		{
			switch (ConvertUtils.GetTypeCode(value))
			{
				case TypeCode.SByte:
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				{
					return true;
				}
			}
			return false;
		}

		public static IConvertible ToConvertible(object o)
		{
			return o as IConvertible;
		}

		public static object ToValue(INullable nullableValue)
		{
			if (nullableValue == null)
			{
				return null;
			}
			if (nullableValue is SqlInt32)
			{
				return ConvertUtils.ToValue((SqlInt32)nullableValue);
			}
			if (nullableValue is SqlInt64)
			{
				return ConvertUtils.ToValue((SqlInt64)nullableValue);
			}
			if (nullableValue is SqlBoolean)
			{
				return ConvertUtils.ToValue((SqlBoolean)nullableValue);
			}
			if (nullableValue is SqlString)
			{
				return ConvertUtils.ToValue((SqlString)nullableValue);
			}
			if (!(nullableValue is SqlDateTime))
			{
				throw new ArgumentException("Unsupported INullable type: {0}".FormatWith(CultureInfo.InvariantCulture, nullableValue.GetType()));
			}
			return ConvertUtils.ToValue((SqlDateTime)nullableValue);
		}

		public static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object convertedValue)
		{
			return MiscellaneousUtils.TryAction<object>(() => ConvertUtils.Convert(initialValue, culture, targetType), out convertedValue);
		}

		internal struct TypeConvertKey : IEquatable<ConvertUtils.TypeConvertKey>
		{
			private readonly Type _initialType;

			private readonly Type _targetType;

			public Type InitialType
			{
				get
				{
					return this._initialType;
				}
			}

			public Type TargetType
			{
				get
				{
					return this._targetType;
				}
			}

			public TypeConvertKey(Type initialType, Type targetType)
			{
				this._initialType = initialType;
				this._targetType = targetType;
			}

			public override bool Equals(object obj)
			{
				if (!(obj is ConvertUtils.TypeConvertKey))
				{
					return false;
				}
				return this.Equals((ConvertUtils.TypeConvertKey)obj);
			}

			public bool Equals(ConvertUtils.TypeConvertKey other)
			{
				if (this._initialType != other._initialType)
				{
					return false;
				}
				return this._targetType == other._targetType;
			}

			public override int GetHashCode()
			{
				return this._initialType.GetHashCode() ^ this._targetType.GetHashCode();
			}
		}
	}
}