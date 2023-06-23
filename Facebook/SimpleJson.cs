using Facebook.Reflection;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Facebook
{
	[GeneratedCode("simple-json", "1.0.0")]
	internal static class SimpleJson
	{
		private const int TOKEN_NONE = 0;

		private const int TOKEN_CURLY_OPEN = 1;

		private const int TOKEN_CURLY_CLOSE = 2;

		private const int TOKEN_SQUARED_OPEN = 3;

		private const int TOKEN_SQUARED_CLOSE = 4;

		private const int TOKEN_COLON = 5;

		private const int TOKEN_COMMA = 6;

		private const int TOKEN_STRING = 7;

		private const int TOKEN_NUMBER = 8;

		private const int TOKEN_TRUE = 9;

		private const int TOKEN_FALSE = 10;

		private const int TOKEN_NULL = 11;

		private const int BUILDER_CAPACITY = 0x7d0;

		private readonly static char[] EscapeTable;

		private readonly static char[] EscapeCharacters;

		private readonly static string EscapeCharactersString;

		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		private static Facebook.PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		private static Facebook.DataContractJsonSerializerStrategy _dataContractJsonSerializerStrategy;

		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			get
			{
				object dataContractJsonSerializerStrategy = SimpleJson._currentJsonSerializerStrategy;
				if (dataContractJsonSerializerStrategy == null)
				{
					dataContractJsonSerializerStrategy = SimpleJson.DataContractJsonSerializerStrategy;
					SimpleJson._currentJsonSerializerStrategy = (IJsonSerializerStrategy)dataContractJsonSerializerStrategy;
				}
				return dataContractJsonSerializerStrategy;
			}
			set
			{
				SimpleJson._currentJsonSerializerStrategy = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Facebook.DataContractJsonSerializerStrategy DataContractJsonSerializerStrategy
		{
			get
			{
				Facebook.DataContractJsonSerializerStrategy dataContractJsonSerializerStrategy = SimpleJson._dataContractJsonSerializerStrategy;
				if (dataContractJsonSerializerStrategy == null)
				{
					dataContractJsonSerializerStrategy = new Facebook.DataContractJsonSerializerStrategy();
					SimpleJson._dataContractJsonSerializerStrategy = dataContractJsonSerializerStrategy;
				}
				return dataContractJsonSerializerStrategy;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Facebook.PocoJsonSerializerStrategy PocoJsonSerializerStrategy
		{
			get
			{
				Facebook.PocoJsonSerializerStrategy pocoJsonSerializerStrategy = SimpleJson._pocoJsonSerializerStrategy;
				if (pocoJsonSerializerStrategy == null)
				{
					pocoJsonSerializerStrategy = new Facebook.PocoJsonSerializerStrategy();
					SimpleJson._pocoJsonSerializerStrategy = pocoJsonSerializerStrategy;
				}
				return pocoJsonSerializerStrategy;
			}
		}

		static SimpleJson()
		{
			SimpleJson.EscapeCharacters = new char[] { '\"', '\\', '\b', '\f', '\n', '\r', '\t' };
			SimpleJson.EscapeCharactersString = new string(SimpleJson.EscapeCharacters);
			SimpleJson.EscapeTable = new char[93];
			SimpleJson.EscapeTable[34] = '\"';
			SimpleJson.EscapeTable[92] = '\\';
			SimpleJson.EscapeTable[8] = 'b';
			SimpleJson.EscapeTable[12] = 'f';
			SimpleJson.EscapeTable[10] = 'n';
			SimpleJson.EscapeTable[13] = 'r';
			SimpleJson.EscapeTable[9] = 't';
		}

		private static string ConvertFromUtf32(int utf32)
		{
			if (utf32 < 0 || utf32 > 0x10ffff)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must be from 0 to 0x10FFFF.");
			}
			if (0xd800 <= utf32 && utf32 <= 0xdfff)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must not be in surrogate pair range.");
			}
			if (utf32 < 0x10000)
			{
				return new string((char)utf32, 1);
			}
			utf32 -= 0x10000;
			char[] chrArray = new char[] { (char)((utf32 >> 10) + 0xd800), (char)(utf32 % 0x400 + 0xdc00) };
			return new string(chrArray);
		}

		public static object DeserializeObject(string json)
		{
			object obj;
			if (!SimpleJson.TryDeserializeObject(json, out obj))
			{
				throw new SerializationException("Invalid JSON string");
			}
			return obj;
		}

		public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			object obj = SimpleJson.DeserializeObject(json);
			if (type == null || obj != null && ReflectionUtils.IsAssignableFrom(obj.GetType(), type))
			{
				return obj;
			}
			return (jsonSerializerStrategy ?? SimpleJson.CurrentJsonSerializerStrategy).DeserializeObject(obj, type);
		}

		public static object DeserializeObject(string json, Type type)
		{
			return SimpleJson.DeserializeObject(json, type, null);
		}

		public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return (T)SimpleJson.DeserializeObject(json, typeof(T), jsonSerializerStrategy);
		}

		public static T DeserializeObject<T>(string json)
		{
			return (T)SimpleJson.DeserializeObject(json, typeof(T), null);
		}

		private static void EatWhitespace(char[] json, ref int index)
		{
			while (index < (int)json.Length)
			{
				if (" \t\n\r\b\f".IndexOf(json[index]) == -1)
				{
					return;
				}
				index++;
			}
		}

		public static string EscapeToJavascriptString(string jsonString)
		{
			if (string.IsNullOrEmpty(jsonString))
			{
				return jsonString;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			while (num < jsonString.Length)
			{
				int num1 = num;
				num = num1 + 1;
				char chr = jsonString[num1];
				if (chr != '\\')
				{
					stringBuilder.Append(chr);
				}
				else
				{
					if (jsonString.Length - num < 2)
					{
						continue;
					}
					char chr1 = jsonString[num];
					if (chr1 == '\\')
					{
						stringBuilder.Append('\\');
						num++;
					}
					else if (chr1 == '\"')
					{
						stringBuilder.Append("\"");
						num++;
					}
					else if (chr1 == 't')
					{
						stringBuilder.Append('\t');
						num++;
					}
					else if (chr1 == 'b')
					{
						stringBuilder.Append('\b');
						num++;
					}
					else if (chr1 != 'n')
					{
						if (chr1 != 'r')
						{
							continue;
						}
						stringBuilder.Append('\r');
						num++;
					}
					else
					{
						stringBuilder.Append('\n');
						num++;
					}
				}
			}
			return stringBuilder.ToString();
		}

		private static int GetLastIndexOfNumber(char[] json, int index)
		{
			int num = index;
			while (num < (int)json.Length && "0123456789+-.eE".IndexOf(json[num]) != -1)
			{
				num++;
			}
			return num - 1;
		}

		private static bool IsNumeric(object value)
		{
			if (value is sbyte)
			{
				return true;
			}
			if (value is byte)
			{
				return true;
			}
			if (value is short)
			{
				return true;
			}
			if (value is ushort)
			{
				return true;
			}
			if (value is int)
			{
				return true;
			}
			if (value is uint)
			{
				return true;
			}
			if (value is long)
			{
				return true;
			}
			if (value is ulong)
			{
				return true;
			}
			if (value is float)
			{
				return true;
			}
			if (value is double)
			{
				return true;
			}
			if (value is decimal)
			{
				return true;
			}
			return false;
		}

		private static int LookAhead(char[] json, int index)
		{
			int num = index;
			return SimpleJson.NextToken(json, ref num);
		}

		private static int NextToken(char[] json, ref int index)
		{
			int length;
			SimpleJson.EatWhitespace(json, ref index);
			if (index == (int)json.Length)
			{
				return 0;
			}
			char chr = json[index];
			index++;
			char chr1 = chr;
			switch (chr1)
			{
				case '\"':
				{
					return 7;
				}
				case '#':
				case '$':
				case '%':
				case '&':
				case '\'':
				case '(':
				case ')':
				case '*':
				case '+':
				case '.':
				case '/':
				{
					index--;
					length = (int)json.Length - index;
					if (length >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
					{
						index += 5;
						return 10;
					}
					if (length >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
					{
						index += 4;
						return 9;
					}
					if (length < 4 || json[index] != 'n' || json[index + 1] != 'u' || json[index + 2] != 'l' || json[index + 3] != 'l')
					{
						return 0;
					}
					index += 4;
					return 11;
				}
				case ',':
				{
					return 6;
				}
				case '-':
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
				{
					return 8;
				}
				case ':':
				{
					return 5;
				}
				default:
				{
					switch (chr1)
					{
						case '[':
						{
							return 3;
						}
						case '\\':
						{
							index--;
							length = (int)json.Length - index;
							if (length >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
							{
								index += 5;
								return 10;
							}
							if (length >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
							{
								index += 4;
								return 9;
							}
							if (length < 4 || json[index] != 'n' || json[index + 1] != 'u' || json[index + 2] != 'l' || json[index + 3] != 'l')
							{
								return 0;
							}
							index += 4;
							return 11;
						}
						case ']':
						{
							return 4;
						}
						default:
						{
							switch (chr1)
							{
								case '{':
								{
									return 1;
								}
								case '|':
								{
									index--;
									length = (int)json.Length - index;
									if (length >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
									{
										index += 5;
										return 10;
									}
									if (length >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
									{
										index += 4;
										return 9;
									}
									if (length < 4 || json[index] != 'n' || json[index + 1] != 'u' || json[index + 2] != 'l' || json[index + 3] != 'l')
									{
										return 0;
									}
									index += 4;
									return 11;
								}
								case '}':
								{
									return 2;
								}
								default:
								{
									index--;
									length = (int)json.Length - index;
									if (length >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
									{
										index += 5;
										return 10;
									}
									if (length >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
									{
										index += 4;
										return 9;
									}
									if (length < 4 || json[index] != 'n' || json[index + 1] != 'u' || json[index + 2] != 'l' || json[index + 3] != 'l')
									{
										return 0;
									}
									index += 4;
									return 11;
								}
							}
							break;
						}
					}
					break;
				}
			}
		}

		private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
		{
			JsonArray jsonArray = new JsonArray();
			SimpleJson.NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				int num = SimpleJson.LookAhead(json, index);
				if (num == 0)
				{
					success = false;
					return null;
				}
				if (num == 6)
				{
					SimpleJson.NextToken(json, ref index);
				}
				else if (num != 4)
				{
					object obj = SimpleJson.ParseValue(json, ref index, ref success);
					if (!success)
					{
						return null;
					}
					jsonArray.Add(obj);
				}
				else
				{
					SimpleJson.NextToken(json, ref index);
					break;
				}
			}
			return jsonArray;
		}

		private static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			object obj;
			double num;
			long num1;
			SimpleJson.EatWhitespace(json, ref index);
			int lastIndexOfNumber = SimpleJson.GetLastIndexOfNumber(json, index);
			int num2 = lastIndexOfNumber - index + 1;
			string str = new string(json, index, num2);
			if (str.IndexOf(".", StringComparison.OrdinalIgnoreCase) != -1 || str.IndexOf("e", StringComparison.OrdinalIgnoreCase) != -1)
			{
				success = double.TryParse(new string(json, index, num2), NumberStyles.Any, CultureInfo.InvariantCulture, out num);
				obj = num;
			}
			else
			{
				success = long.TryParse(new string(json, index, num2), NumberStyles.Any, CultureInfo.InvariantCulture, out num1);
				obj = num1;
			}
			index = lastIndexOfNumber + 1;
			return obj;
		}

		private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			IDictionary<string, object> jsonObjects = new JsonObject();
			SimpleJson.NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				int num = SimpleJson.LookAhead(json, index);
				if (num == 0)
				{
					success = false;
					return null;
				}
				if (num != 6)
				{
					if (num == 2)
					{
						SimpleJson.NextToken(json, ref index);
						return jsonObjects;
					}
					string str = SimpleJson.ParseString(json, ref index, ref success);
					if (!success)
					{
						success = false;
						return null;
					}
					num = SimpleJson.NextToken(json, ref index);
					if (num != 5)
					{
						success = false;
						return null;
					}
					object obj = SimpleJson.ParseValue(json, ref index, ref success);
					if (!success)
					{
						success = false;
						return null;
					}
					jsonObjects[str] = obj;
				}
				else
				{
					SimpleJson.NextToken(json, ref index);
				}
			}
			return jsonObjects;
		}

		private static string ParseString(char[] json, ref int index, ref bool success)
		{
			uint num;
			uint num1;
			StringBuilder stringBuilder = new StringBuilder(0x7d0);
			SimpleJson.EatWhitespace(json, ref index);
			int num2 = index;
			int num3 = num2;
			index = num2 + 1;
			char chr = json[num3];
			bool flag = false;
			while (!flag && index != (int)json.Length)
			{
				int num4 = index;
				int num5 = num4;
				index = num4 + 1;
				chr = json[num5];
				if (chr == '\"')
				{
					flag = true;
					break;
				}
				else if (chr != '\\')
				{
					stringBuilder.Append(chr);
				}
				else
				{
					if (index == (int)json.Length)
					{
						break;
					}
					int num6 = index;
					int num7 = num6;
					index = num6 + 1;
					chr = json[num7];
					if (chr == '\"')
					{
						stringBuilder.Append('\"');
					}
					else if (chr == '\\')
					{
						stringBuilder.Append('\\');
					}
					else if (chr == '/')
					{
						stringBuilder.Append('/');
					}
					else if (chr == 'b')
					{
						stringBuilder.Append('\b');
					}
					else if (chr == 'f')
					{
						stringBuilder.Append('\f');
					}
					else if (chr == 'n')
					{
						stringBuilder.Append('\n');
					}
					else if (chr == 'r')
					{
						stringBuilder.Append('\r');
					}
					else if (chr != 't')
					{
						if (chr != 'u')
						{
							continue;
						}
						if ((int)json.Length - index < 4)
						{
							break;
						}
						bool flag1 = uint.TryParse(new string(json, index, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num);
						bool flag2 = flag1;
						success = flag1;
						if (!flag2)
						{
							return "";
						}
						if (0xd800 > num || num > 0xdbff)
						{
							stringBuilder.Append(SimpleJson.ConvertFromUtf32((int)num));
							index += 4;
						}
						else
						{
							index += 4;
							if ((int)json.Length - index < 6 || !(new string(json, index, 2) == "\\u") || !uint.TryParse(new string(json, index + 2, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num1) || 0xdc00 > num1 || num1 > 0xdfff)
							{
								success = false;
								return "";
							}
							stringBuilder.Append((char)num);
							stringBuilder.Append((char)num1);
							index += 6;
						}
					}
					else
					{
						stringBuilder.Append('\t');
					}
				}
			}
			if (flag)
			{
				return stringBuilder.ToString();
			}
			success = false;
			return null;
		}

		private static object ParseValue(char[] json, ref int index, ref bool success)
		{
			switch (SimpleJson.LookAhead(json, index))
			{
				case 0:
				case 2:
				case 4:
				case 5:
				case 6:
				{
					success = false;
					return null;
				}
				case 1:
				{
					return SimpleJson.ParseObject(json, ref index, ref success);
				}
				case 3:
				{
					return SimpleJson.ParseArray(json, ref index, ref success);
				}
				case 7:
				{
					return SimpleJson.ParseString(json, ref index, ref success);
				}
				case 8:
				{
					return SimpleJson.ParseNumber(json, ref index, ref success);
				}
				case 9:
				{
					SimpleJson.NextToken(json, ref index);
					return true;
				}
				case 10:
				{
					SimpleJson.NextToken(json, ref index);
					return false;
				}
				case 11:
				{
					SimpleJson.NextToken(json, ref index);
					return null;
				}
				default:
				{
					success = false;
					return null;
				}
			}
		}

		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			bool flag;
			builder.Append("[");
			bool flag1 = true;
			IEnumerator enumerator = anArray.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					if (!flag1)
					{
						builder.Append(",");
					}
					if (SimpleJson.SerializeValue(jsonSerializerStrategy, current, builder))
					{
						flag1 = false;
					}
					else
					{
						flag = false;
						return flag;
					}
				}
				builder.Append("]");
				return true;
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			return flag;
		}

		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			if (number is long)
			{
				long num = (long)number;
				builder.Append(num.ToString(CultureInfo.InvariantCulture));
			}
			else if (number is ulong)
			{
				ulong num1 = (ulong)number;
				builder.Append(num1.ToString(CultureInfo.InvariantCulture));
			}
			else if (number is int)
			{
				int num2 = (int)number;
				builder.Append(num2.ToString(CultureInfo.InvariantCulture));
			}
			else if (number is uint)
			{
				uint num3 = (uint)number;
				builder.Append(num3.ToString(CultureInfo.InvariantCulture));
			}
			else if (number is decimal)
			{
				decimal num4 = (decimal)number;
				builder.Append(num4.ToString(CultureInfo.InvariantCulture));
			}
			else if (!(number is float))
			{
				double num5 = Convert.ToDouble(number, CultureInfo.InvariantCulture);
				builder.Append(num5.ToString("r", CultureInfo.InvariantCulture));
			}
			else
			{
				float single = (float)number;
				builder.Append(single.ToString(CultureInfo.InvariantCulture));
			}
			return true;
		}

		public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			StringBuilder stringBuilder = new StringBuilder(0x7d0);
			if (!SimpleJson.SerializeValue(jsonSerializerStrategy, json, stringBuilder))
			{
				return null;
			}
			return stringBuilder.ToString();
		}

		public static string SerializeObject(object json)
		{
			return SimpleJson.SerializeObject(json, SimpleJson.CurrentJsonSerializerStrategy);
		}

		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			builder.Append("{");
			IEnumerator enumerator = keys.GetEnumerator();
			IEnumerator enumerator1 = values.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext() && enumerator1.MoveNext())
			{
				object current = enumerator.Current;
				object obj = enumerator1.Current;
				if (!flag)
				{
					builder.Append(",");
				}
				string str = current as string;
				if (str != null)
				{
					SimpleJson.SerializeString(str, builder);
				}
				else if (!SimpleJson.SerializeValue(jsonSerializerStrategy, obj, builder))
				{
					return false;
				}
				builder.Append(":");
				if (!SimpleJson.SerializeValue(jsonSerializerStrategy, obj, builder))
				{
					return false;
				}
				flag = false;
			}
			builder.Append("}");
			return true;
		}

		private static bool SerializeString(string aString, StringBuilder builder)
		{
			if (aString.IndexOfAny(SimpleJson.EscapeCharacters) == -1)
			{
				builder.Append('\"');
				builder.Append(aString);
				builder.Append('\"');
				return true;
			}
			builder.Append('\"');
			int num = 0;
			char[] charArray = aString.ToCharArray();
			for (int i = 0; i < (int)charArray.Length; i++)
			{
				char chr = charArray[i];
				if (chr >= (char)((int)SimpleJson.EscapeTable.Length) || SimpleJson.EscapeTable[chr] == 0)
				{
					num++;
				}
				else
				{
					if (num > 0)
					{
						builder.Append(charArray, i - num, num);
						num = 0;
					}
					builder.Append('\\');
					builder.Append(SimpleJson.EscapeTable[chr]);
				}
			}
			if (num > 0)
			{
				builder.Append(charArray, (int)charArray.Length - num, num);
			}
			builder.Append('\"');
			return true;
		}

		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			object obj;
			bool flag = true;
			string str = value as string;
			if (str == null)
			{
				IDictionary<string, object> strs = value as IDictionary<string, object>;
				if (strs == null)
				{
					IDictionary<string, string> strs1 = value as IDictionary<string, string>;
					if (strs1 == null)
					{
						IEnumerable enumerable = value as IEnumerable;
						if (enumerable != null)
						{
							flag = SimpleJson.SerializeArray(jsonSerializerStrategy, enumerable, builder);
						}
						else if (SimpleJson.IsNumeric(value))
						{
							flag = SimpleJson.SerializeNumber(value, builder);
						}
						else if (value is bool)
						{
							builder.Append(((bool)value ? "true" : "false"));
						}
						else if (value != null)
						{
							flag = jsonSerializerStrategy.TrySerializeNonPrimitiveObject(value, out obj);
							if (flag)
							{
								SimpleJson.SerializeValue(jsonSerializerStrategy, obj, builder);
							}
						}
						else
						{
							builder.Append("null");
						}
					}
					else
					{
						flag = SimpleJson.SerializeObject(jsonSerializerStrategy, strs1.Keys, strs1.Values, builder);
					}
				}
				else
				{
					flag = SimpleJson.SerializeObject(jsonSerializerStrategy, strs.Keys, strs.Values, builder);
				}
			}
			else
			{
				flag = SimpleJson.SerializeString(str, builder);
			}
			return flag;
		}

		public static bool TryDeserializeObject(string json, out object obj)
		{
			bool flag = true;
			if (json == null)
			{
				obj = null;
			}
			else
			{
				char[] charArray = json.ToCharArray();
				int num = 0;
				obj = SimpleJson.ParseValue(charArray, ref num, ref flag);
			}
			return flag;
		}
	}
}