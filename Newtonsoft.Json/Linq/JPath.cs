using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	internal class JPath
	{
		private readonly string _expression;

		private int _currentIndex;

		public List<object> Parts
		{
			get;
			private set;
		}

		public JPath(string expression)
		{
			ValidationUtils.ArgumentNotNull(expression, "expression");
			this._expression = expression;
			this.Parts = new List<object>();
			this.ParseMain();
		}

		internal JToken Evaluate(JToken root, bool errorWhenNoMatch)
		{
			JToken jTokens;
			JToken item = root;
			List<object>.Enumerator enumerator = this.Parts.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					string str = current as string;
					if (str == null)
					{
						int num = (int)current;
						JArray jArrays = item as JArray;
						JConstructor jConstructor = item as JConstructor;
						if (jArrays != null)
						{
							if (jArrays.Count > num)
							{
								item = jArrays[num];
							}
							else
							{
								if (errorWhenNoMatch)
								{
									throw new IndexOutOfRangeException("Index {0} outside the bounds of JArray.".FormatWith(CultureInfo.InvariantCulture, num));
								}
								jTokens = null;
								return jTokens;
							}
						}
						else if (jConstructor == null)
						{
							if (errorWhenNoMatch)
							{
								throw new JsonException("Index {0} not valid on {1}.".FormatWith(CultureInfo.InvariantCulture, num, item.GetType().Name));
							}
							jTokens = null;
							return jTokens;
						}
						else if (jConstructor.Count > num)
						{
							item = jConstructor[num];
						}
						else
						{
							if (errorWhenNoMatch)
							{
								throw new IndexOutOfRangeException("Index {0} outside the bounds of JConstructor.".FormatWith(CultureInfo.InvariantCulture, num));
							}
							jTokens = null;
							return jTokens;
						}
					}
					else
					{
						JObject jObjects = item as JObject;
						if (jObjects == null)
						{
							if (errorWhenNoMatch)
							{
								throw new JsonException("Property '{0}' not valid on {1}.".FormatWith(CultureInfo.InvariantCulture, str, item.GetType().Name));
							}
							jTokens = null;
							return jTokens;
						}
						else
						{
							item = jObjects[str];
							if (item != null || !errorWhenNoMatch)
							{
								continue;
							}
							throw new JsonException("Property '{0}' does not exist on JObject.".FormatWith(CultureInfo.InvariantCulture, str));
						}
					}
				}
				return item;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return jTokens;
		}

		private void ParseIndexer(char indexerOpenChar)
		{
			this._currentIndex++;
			char chr = (indexerOpenChar == '[' ? ']' : ')');
			int num = this._currentIndex;
			int num1 = 0;
			bool flag = false;
			while (this._currentIndex < this._expression.Length)
			{
				char chr1 = this._expression[this._currentIndex];
				if (!char.IsDigit(chr1))
				{
					if (chr1 != chr)
					{
						throw new JsonException(string.Concat("Unexpected character while parsing path indexer: ", chr1));
					}
					flag = true;
					break;
				}
				else
				{
					num1++;
					this._currentIndex++;
				}
			}
			if (!flag)
			{
				throw new JsonException(string.Concat("Path ended with open indexer. Expected ", chr));
			}
			if (num1 == 0)
			{
				throw new JsonException("Empty path indexer.");
			}
			string str = this._expression.Substring(num, num1);
			this.Parts.Add(Convert.ToInt32(str, CultureInfo.InvariantCulture));
		}

		private void ParseMain()
		{
			char chr;
			int num = this._currentIndex;
			bool flag = false;
			while (true)
			{
				if (this._currentIndex >= this._expression.Length)
				{
					if (this._currentIndex > num)
					{
						string str = this._expression.Substring(num, this._currentIndex - num);
						this.Parts.Add(str);
					}
					return;
				}
				chr = this._expression[this._currentIndex];
				char chr1 = chr;
				switch (chr1)
				{
					case '(':
					{
					Label1:
						if (this._currentIndex > num)
						{
							string str1 = this._expression.Substring(num, this._currentIndex - num);
							this.Parts.Add(str1);
						}
						this.ParseIndexer(chr);
						num = this._currentIndex + 1;
						flag = true;
						break;
					}
					case ')':
					{
						throw new JsonException(string.Concat("Unexpected character while parsing path: ", chr));
					}
					default:
					{
						if (chr1 == '.')
						{
							if (this._currentIndex > num)
							{
								string str2 = this._expression.Substring(num, this._currentIndex - num);
								this.Parts.Add(str2);
							}
							num = this._currentIndex + 1;
							flag = false;
							break;
						}
						else
						{
							switch (chr1)
							{
								case '[':
								{
									goto Label1;
								}
								case '\\':
								{
									if (!flag)
									{
										goto Label2;
									}
									throw new JsonException(string.Concat("Unexpected character following indexer: ", chr));
								}
								case ']':
								{
									throw new JsonException(string.Concat("Unexpected character while parsing path: ", chr));
								}
								default:
								{
									goto case '\\';
								}
							}
						}
						break;
					}
				}
			Label2:
				JPath jPath = this;
				jPath._currentIndex++;
			}
			throw new JsonException(string.Concat("Unexpected character while parsing path: ", chr));
		}
	}
}