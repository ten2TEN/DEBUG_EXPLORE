using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Transaction
{
	public class Utils
	{
		public Utils()
		{
		}

		public static bool IsAlphaNumeric(string str)
		{
			bool flag;
			try
			{
				flag = (!string.IsNullOrEmpty(str) ? ((IEnumerable<char>)str.ToCharArray()).All<char>((char c) => {
					if (char.IsLetter(c))
					{
						return true;
					}
					return char.IsNumber(c);
				}) : false);
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool IsAlphaNumSpace(string str)
		{
			bool flag;
			try
			{
				flag = (!string.IsNullOrEmpty(str) ? ((IEnumerable<char>)str.ToCharArray()).All<char>((char c) => {
					if (char.IsLetter(c) || char.IsNumber(c))
					{
						return true;
					}
					return c == ' ';
				}) : false);
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool IsNumericString(string str)
		{
			bool flag = true;
			try
			{
				if (!string.IsNullOrEmpty(str))
				{
					string str1 = str;
					int num = 0;
					while (num < str1.Length)
					{
						if (char.IsDigit(str1[num]))
						{
							num++;
						}
						else
						{
							flag = false;
							break;
						}
					}
				}
				else
				{
					flag = false;
				}
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static string MaskTransactionData(string transaction)
		{
			StringBuilder stringBuilder = new StringBuilder(transaction);
			foreach (Match match in (new Regex("<Track2>\\S*</Track2>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match.ToString(), "<Track2>XXXXXXXXXXXXXXXX=XXXXXXXXXXXXXXXXXXXX</Track2>");
			}
			foreach (Match match1 in (new Regex("<Track1>\\S*</Track1>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match1.ToString(), "<Track1>BXXXXXXXXXXXXXXXX^XXXX/XXX^XXXXXXXXXXXXXXXX</Track1>");
			}
			foreach (Match match2 in (new Regex("<AcctNo>\\S*</AcctNo>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match2.ToString(), "<AcctNo>XXXXXXXXXXXXXXX</AcctNo>");
			}
			foreach (Match match3 in (new Regex("<ExpDate>\\S*</ExpDate>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match3.ToString(), "<ExpDate>XXXX</ExpDate>");
			}
			foreach (Match match4 in (new Regex("<CVVData>\\S*</CVVData>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match4.ToString(), "<CVVData>XXX</CVVData>");
			}
			foreach (Match match5 in (new Regex("<PINBLock>\\S*</PINBLock>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match5.ToString(), "<PINBLock>XXXXXXXXXXXXXXX</PINBLock>");
			}
			foreach (Match match6 in (new Regex("<DervdKey>\\S*</DervdKey>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match6.ToString(), "<DervdKey>XXXXXXXXXXXXXXXX</DervdKey>");
			}
			foreach (Match match7 in (new Regex("<DriversLicense>\\S*</DriversLicense>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match7.ToString(), "<DriversLicense>XXXXXXXXXXXXXXXX</DriversLicense>");
			}
			foreach (Match match8 in (new Regex("<RoutingNo>\\S*</RoutingNo>", RegexOptions.IgnoreCase)).Matches(stringBuilder.ToString()))
			{
				stringBuilder.Replace(match8.ToString(), "<RoutingNo>XXXXXXXXXXXXXXXX</RoutingNo>");
			}
			return stringBuilder.ToString();
		}
	}
}