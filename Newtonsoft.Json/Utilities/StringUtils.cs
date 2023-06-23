using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	internal static class StringUtils
	{
		public const string CarriageReturnLineFeed = "\r\n";

		public const string Empty = "";

		public const char CarriageReturn = '\r';

		public const char LineFeed = '\n';

		public const char Tab = '\t';

		public static StringWriter CreateStringWriter(int capacity)
		{
			return new StringWriter(new StringBuilder(capacity), CultureInfo.InvariantCulture);
		}

		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (valueSelector == null)
			{
				throw new ArgumentNullException("valueSelector");
			}
			IEnumerable<TSource> tSources = 
				from  in source
				where string.Equals(valueSelector(s), testValue, StringComparison.OrdinalIgnoreCase)
				select ;
			if (tSources.Count<TSource>() <= 1)
			{
				return tSources.SingleOrDefault<TSource>();
			}
			IEnumerable<TSource> tSources1 = 
				from  in source
				where string.Equals(valueSelector(s), testValue, StringComparison.Ordinal)
				select ;
			return tSources1.SingleOrDefault<TSource>();
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			object[] objArray = new object[] { arg0 };
			return format.FormatWith(provider, objArray);
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			object[] objArray = new object[] { arg0, arg1 };
			return format.FormatWith(provider, objArray);
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			object[] objArray = new object[] { arg0, arg1, arg2 };
			return format.FormatWith(provider, objArray);
		}

		public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			ValidationUtils.ArgumentNotNull(format, "format");
			return string.Format(provider, format, args);
		}

		public static int? GetLength(string value)
		{
			if (value == null)
			{
				return null;
			}
			return new int?(value.Length);
		}

		public static bool IsHighSurrogate(char c)
		{
			return char.IsHighSurrogate(c);
		}

		public static bool IsLowSurrogate(char c)
		{
			return char.IsLowSurrogate(c);
		}

		public static bool IsWhiteSpace(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (!char.IsWhiteSpace(s[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static string NullEmptyString(string s)
		{
			if (!string.IsNullOrEmpty(s))
			{
				return s;
			}
			return null;
		}

		public static string ToCamelCase(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return s;
			}
			if (!char.IsUpper(s[0]))
			{
				return s;
			}
			string str = null;
			char lower = char.ToLower(s[0], CultureInfo.InvariantCulture);
			str = lower.ToString(CultureInfo.InvariantCulture);
			if (s.Length > 1)
			{
				str = string.Concat(str, s.Substring(1));
			}
			return str;
		}

		public static string ToCharAsUnicode(char c)
		{
			char hex = MathUtils.IntToHex(c >> '\f' & 15);
			char chr = MathUtils.IntToHex(c >> '\b' & 15);
			char hex1 = MathUtils.IntToHex(c >> '\u0004' & 15);
			char chr1 = MathUtils.IntToHex(c & '\u000F');
			char[] chrArray = new char[] { '\\', 'u', hex, chr, hex1, chr1 };
			return new string(chrArray);
		}
	}
}