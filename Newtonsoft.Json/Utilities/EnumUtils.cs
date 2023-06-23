using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	internal static class EnumUtils
	{
		public static IList<T> GetFlagsValues<T>(T value)
		where T : struct
		{
			Type type = typeof(T);
			if (!type.IsDefined(typeof(FlagsAttribute), false))
			{
				throw new ArgumentException("Enum type {0} is not a set of flags.".FormatWith(CultureInfo.InvariantCulture, type));
			}
			Type underlyingType = Enum.GetUnderlyingType(value.GetType());
			ulong num = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
			EnumValues<ulong> namesAndValues = EnumUtils.GetNamesAndValues<T>();
			IList<T> ts = new List<T>();
			foreach (EnumValue<ulong> namesAndValue in namesAndValues)
			{
				if ((num & namesAndValue.Value) != namesAndValue.Value || namesAndValue.Value == (long)0)
				{
					continue;
				}
				ts.Add((T)Convert.ChangeType(namesAndValue.Value, underlyingType, CultureInfo.CurrentCulture));
			}
			if (ts.Count == 0 && namesAndValues.SingleOrDefault<EnumValue<ulong>>((EnumValue<ulong> v) => v.Value == (long)0) != null)
			{
				ts.Add(default(T));
			}
			return ts;
		}

		public static IList<string> GetNames(Type enumType)
		{
			if (!enumType.IsEnum())
			{
				throw new ArgumentException(string.Concat("Type '", enumType.Name, "' is not an enum."));
			}
			List<string> strs = new List<string>();
			IEnumerable<FieldInfo> fields = 
				from field in (IEnumerable<FieldInfo>)enumType.GetFields()
				where field.IsLiteral
				select field;
			foreach (FieldInfo fieldInfo in fields)
			{
				strs.Add(fieldInfo.Name);
			}
			return strs;
		}

		public static EnumValues<ulong> GetNamesAndValues<T>()
		where T : struct
		{
			return EnumUtils.GetNamesAndValues<ulong>(typeof(T));
		}

		public static EnumValues<TUnderlyingType> GetNamesAndValues<TUnderlyingType>(Type enumType)
		where TUnderlyingType : struct
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			ValidationUtils.ArgumentTypeIsEnum(enumType, "enumType");
			IList<object> values = EnumUtils.GetValues(enumType);
			IList<string> names = EnumUtils.GetNames(enumType);
			EnumValues<TUnderlyingType> enumValue = new EnumValues<TUnderlyingType>();
			for (int i = 0; i < values.Count; i++)
			{
				try
				{
					enumValue.Add(new EnumValue<TUnderlyingType>(names[i], (TUnderlyingType)Convert.ChangeType(values[i], typeof(TUnderlyingType), CultureInfo.CurrentCulture)));
				}
				catch (OverflowException overflowException1)
				{
					OverflowException overflowException = overflowException1;
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object[] underlyingType = new object[] { Enum.GetUnderlyingType(enumType), typeof(TUnderlyingType), Convert.ToUInt64(values[i], CultureInfo.InvariantCulture) };
					throw new InvalidOperationException(string.Format(invariantCulture, "Value from enum with the underlying type of {0} cannot be added to dictionary with a value type of {1}. Value was too large: {2}", underlyingType), overflowException);
				}
			}
			return enumValue;
		}

		public static IList<object> GetValues(Type enumType)
		{
			if (!enumType.IsEnum())
			{
				throw new ArgumentException(string.Concat("Type '", enumType.Name, "' is not an enum."));
			}
			List<object> objs = new List<object>();
			IEnumerable<FieldInfo> fields = 
				from field in (IEnumerable<FieldInfo>)enumType.GetFields()
				where field.IsLiteral
				select field;
			foreach (FieldInfo fieldInfo in fields)
			{
				objs.Add(fieldInfo.GetValue(enumType));
			}
			return objs;
		}
	}
}