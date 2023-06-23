using System;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	internal static class JavaScriptUtils
	{
		public static string ToEscapedJavaScriptString(string value)
		{
			return JavaScriptUtils.ToEscapedJavaScriptString(value, '\"', true);
		}

		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters)
		{
			string str;
			int? length = StringUtils.GetLength(value);
			using (StringWriter stringWriter = StringUtils.CreateStringWriter((length.HasValue ? length.GetValueOrDefault() : 16)))
			{
				JavaScriptUtils.WriteEscapedJavaScriptString(stringWriter, value, delimiter, appendDelimiters);
				str = stringWriter.ToString();
			}
			return str;
		}

		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters)
		{
			char chr;
			string str;
			string charAsUnicode;
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
			if (s != null)
			{
				char[] charArray = null;
				int num = 0;
				for (int i = 0; i < s.Length; i++)
				{
					chr = s[i];
					if (chr < ' ' || chr >= '\u0080' || chr == '\\' || chr == delimiter)
					{
						char chr1 = chr;
						if (chr1 <= '\'')
						{
							switch (chr1)
							{
								case '\b':
								{
									str = "\\b";
									break;
								}
								case '\t':
								{
									str = "\\t";
									break;
								}
								case '\n':
								{
									str = "\\n";
									break;
								}
								case '\v':
								{
									goto Label0;
								}
								case '\f':
								{
									str = "\\f";
									break;
								}
								case '\r':
								{
									str = "\\r";
									break;
								}
								default:
								{
									if (chr1 == '\"')
									{
										str = "\\\"";
										break;
									}
									else if (chr1 == '\'')
									{
										str = "\\'";
										break;
									}
									else
									{
										goto Label0;
									}
								}
							}
						}
						else if (chr1 == '\\')
						{
							str = "\\\\";
						}
						else if (chr1 == '\u0085')
						{
							str = "\\u0085";
						}
						else
						{
							switch (chr1)
							{
								case '\u2028':
								{
									str = "\\u2028";
									break;
								}
								case '\u2029':
								{
									str = "\\u2029";
									break;
								}
								default:
								{
									goto Label0;
								}
							}
						}
					Label1:
						if (str != null)
						{
							if (i > num)
							{
								if (charArray == null)
								{
									charArray = s.ToCharArray();
								}
								writer.Write(charArray, num, i - num);
							}
							num = i + 1;
							writer.Write(str);
						}
					}
				}
				if (num != 0)
				{
					if (charArray == null)
					{
						charArray = s.ToCharArray();
					}
					writer.Write(charArray, num, s.Length - num);
				}
				else
				{
					writer.Write(s);
				}
			}
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
			return;
		Label0:
			if (chr <= '\u001F')
			{
				charAsUnicode = StringUtils.ToCharAsUnicode(chr);
			}
			else
			{
				charAsUnicode = null;
			}
			str = charAsUnicode;
			goto Label1;
		}
	}
}