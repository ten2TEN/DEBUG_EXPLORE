using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;

namespace Common
{
	public class Account
	{
		// 
		private SecureString u0001;

		// 
		private SecureString u0002;

		// 
		private string u0003 = string.Empty;

		// 
		private string u0004 = string.Empty;

		// 
		private Common.AccountType u0005 = Common.AccountType.Unknown;

		// 
		private int u0006;

		// 
		private int u0007;

		// 
		private bool u0008;

		// 
		private string u000e = string.Empty;

		public SecureString AccountData
		{
			get
			{
				return this.u0001;
			}
		}

		public Common.AccountType AccountType
		{
			get
			{
				return this.u0005;
			}
		}

		public string CardholderName
		{
			get
			{
				return this.u000e;
			}
		}

		public int ExpirationDateMonth
		{
			get
			{
				return this.u0006;
			}
		}

		public int ExpirationDateYear
		{
			get
			{
				return this.u0007;
			}
		}

		public string MaskedAccount
		{
			get
			{
				return this.u0003;
			}
		}

		public string MaskedTrackData
		{
			get
			{
				return this.u0004;
			}
		}

		public bool PassesMOD10
		{
			get
			{
				return this.u0008;
			}
		}

		public SecureString TrackData
		{
			get
			{
				return this.u0002;
			}
		}

		// 
		private void u0010u0004()
		{
			int num = 0;
			int num1 = 0;
			string empty = string.Empty;
			try
			{
				try
				{
					if (this.u0002.Length > 0)
					{
						empty = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(this.u0002));
						num1 = empty.IndexOf("^", 0);
						num = empty.LastIndexOf("^");
						if (num1 <= 0 || num <= 0)
						{
							this.u000e = string.Empty;
						}
						else
						{
							this.u000e = empty.Substring(num1 + 1, num - num1 - 1);
						}
					}
				}
				catch
				{
					this.u000e = string.Empty;
				}
			}
			finally
			{
				empty = string.Empty;
			}
		}

		// 
		private void u0011u0004()
		{
			if (this.u0002.Length > 0)
			{
				if (this.u0005 == Common.AccountType.Track1)
				{
					this.u0013u0004(this.u0002);
					return;
				}
				if (this.u0005 == Common.AccountType.Track2)
				{
					this.u0012u0004(this.u0002);
				}
			}
		}

		// 
		private void u0012u0004(SecureString trackData)
		{
			string empty = string.Empty;
			int length = 0;
			int num = 0;
			int num1 = 0;
			string stringUni = string.Empty;
			try
			{
				stringUni = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(trackData));
				num = 0;
				num1 = stringUni.IndexOf("=", 0);
				if (num1 != -1)
				{
					length = num1 - 10;
					empty = stringUni.Substring(num, length + 10);
					Account account = this;
					account.u0004 = string.Concat(account.u0004, this.u0014u0004(stringUni, num, length, empty));
					Account account1 = this;
					account1.u0004 = string.Concat(account1.u0004, "=", string.Empty.PadRight(stringUni.Length - (num1 + 1), 'X'));
				}
				else if (stringUni.Length > 0)
				{
					if (stringUni.Length < 14)
					{
						length = 4;
						empty = stringUni.Substring(num, stringUni.Length);
					}
					else
					{
						length = stringUni.Length - 10;
						empty = stringUni.Substring(num, length + 10);
					}
					this.u0004 = this.u0014u0004(stringUni, num, length, empty);
				}
			}
			catch
			{
				this.u0016u0004();
			}
		}

		// 
		private void u0013u0004(SecureString trackData)
		{
			string empty = string.Empty;
			int num = 0;
			int num1 = 0;
			int num2 = 0;
			int num3 = 0;
			string stringUni = string.Empty;
			try
			{
				if (this.u0002.Length > 0)
				{
					stringUni = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(trackData));
					num1 = 1;
					num3 = stringUni.IndexOf("^", 0);
					num = num3 - 11;
					num2 = num + 10;
					empty = stringUni.Substring(num1, num2);
					num2 = stringUni.LastIndexOf("^");
					this.u0004 = "B";
					Account account = this;
					account.u0004 = string.Concat(account.u0004, this.u0014u0004(stringUni, num1, num, empty));
					Account account1 = this;
					account1.u0004 = string.Concat(account1.u0004, "^");
					Account account2 = this;
					account2.u0004 = string.Concat(account2.u0004, string.Empty.PadRight(num2 - (num3 + 1), 'X'));
					Account account3 = this;
					account3.u0004 = string.Concat(account3.u0004, "^");
					Account account4 = this;
					account4.u0004 = string.Concat(account4.u0004, string.Empty.PadRight(stringUni.Length - (num2 + 1), 'X'));
				}
			}
			catch
			{
				this.u0016u0004();
			}
		}

		// 
		private string u0014u0004(string accountData, int startIndex, int maskCount, string account)
		{
			string empty = string.Empty;
			if (accountData.Length >= 14)
			{
				empty = accountData.Substring(startIndex, 6);
				empty = string.Concat(empty, string.Empty.PadRight(maskCount, 'X'));
				empty = string.Concat(empty, account.Substring(account.Length - 4, 4));
			}
			else if (accountData.Length < 14)
			{
				if (accountData.Length < 6)
				{
					empty = accountData;
					empty = string.Concat(empty, string.Empty.PadRight(maskCount, 'X'));
				}
				else
				{
					empty = accountData.Substring(startIndex, 6);
					empty = string.Concat(empty, string.Empty.PadRight(maskCount, 'X'));
				}
			}
			return empty;
		}

		// 
		private void u0015u0004()
		{
			string empty = string.Empty;
			int length = 0;
			int num = 0;
			string stringUni = string.Empty;
			if (this.u0001.Length > 0)
			{
				stringUni = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(this.u0001));
				num = 0;
				if (stringUni.Length >= 14)
				{
					length = stringUni.Length - 10;
					empty = stringUni.Substring(num, length + 10);
				}
				else if (stringUni.Length < 14)
				{
					length = 4;
					empty = stringUni.Substring(num, stringUni.Length);
				}
				this.u0003 = this.u0014u0004(stringUni, num, length, empty);
			}
			stringUni = string.Empty;
			empty = string.Empty;
		}

		// 
		private void u0016u0004()
		{
			this.u0003 = string.Empty;
			this.u0004 = string.Empty;
			this.u0005 = Common.AccountType.Unknown;
			this.u0002.Clear();
			this.u0001.Clear();
		}

		// 
		private bool u0017u0004(SecureString swipe)
		{
			bool flag = false;
			string empty = string.Empty;
			string str = "%B[0-9 ]+\\^[A-Za-z0-9/& ]*\\^[0-9]+\\?";
			string str1 = ";[0-9]+(=[0-9]+)?\\?";
			string str2 = "=[0-9]{4}";
			string str3 = "[0-9]+=?";
			string str4 = "[0-9]+\\^";
			string str5 = "\\^[0-9]{4}";
			if (this.u007fu0002(swipe, str, out this.u0002))
			{
				this.u0080u0002(this.u0002, str4, out this.u0001);
				this.u0081u0002(this.u0002, str5, out this.u0006, out this.u0007);
				this.u0005 = Common.AccountType.Track1;
				this.u0010u0004();
				flag = true;
			}
			if (this.u007fu0002(swipe, str1, out this.u0002))
			{
				this.u0080u0002(this.u0002, str3, out this.u0001);
				this.u0081u0002(this.u0002, str2, out this.u0006, out this.u0007);
				this.u0005 = Common.AccountType.Track2;
				flag = true;
			}
			if (this.u0005 == Common.AccountType.Unknown)
			{
				this.u0001 = swipe;
				this.u0005 = Common.AccountType.Manual;
			}
			return flag;
		}

		// 
		private bool u007fu0002(SecureString swipe, string matchPattern, out SecureString track)
		{
			if (this.u0002.Length <= 0)
			{
				track = new SecureString();
			}
			else
			{
				track = this.u0002.Copy();
			}
			bool flag = false;
			char[] chrArray = new char[] { ';', '%', '?' };
			string empty = string.Empty;
			try
			{
				try
				{
					IntPtr bSTR = Marshal.SecureStringToBSTR(swipe);
					Match match = Regex.Match(Marshal.PtrToStringUni(bSTR), matchPattern);
					if (match.Success)
					{
						empty = match.ToString();
						empty = empty.TrimStart(chrArray).TrimEnd(chrArray);
						track.Clear();
						string str = empty;
						for (int i = 0; i < str.Length; i++)
						{
							track.AppendChar(str[i]);
						}
						flag = true;
					}
				}
				catch
				{
					empty = string.Empty;
					flag = false;
				}
			}
			finally
			{
				empty = string.Empty;
			}
			return flag;
		}

		public Account()
		{
			this.u0001 = new SecureString();
			this.u0002 = new SecureString();
		}

		public Account(SecureString trackData)
		{
			this.u0001 = new SecureString();
			this.u0002 = new SecureString();
			if (this.u0017u0004(trackData))
			{
				this.u0011u0004();
			}
			this.u0008 = this.PassesMOD10Check(this.u0001);
			this.u0015u0004();
		}

		public Account(SecureString accountData, int expirationDateMonth, int expirationDateYear)
		{
			this.u0001 = new SecureString();
			this.u0002 = new SecureString();
			this.u0017u0004(accountData);
			this.u0011u0004();
			this.u0015u0004();
			this.u0008 = this.PassesMOD10Check(this.u0001);
			this.u0006 = expirationDateMonth;
			this.u0007 = expirationDateYear;
		}

		// 
		private void u0080u0002(SecureString track, string matchpattern, out SecureString account)
		{
			account = new SecureString();
			account.Clear();
			string empty = string.Empty;
			char[] chrArray = new char[] { '\u005E', '=' };
			try
			{
				try
				{
					empty = Marshal.PtrToStringUni(Marshal.SecureStringToBSTR(track));
					empty = empty.Replace(" ", string.Empty);
					Match match = Regex.Match(empty, matchpattern);
					if (match.Success)
					{
						string str = match.ToString().Trim(chrArray);
						for (int i = 0; i < str.Length; i++)
						{
							account.AppendChar(str[i]);
						}
					}
				}
				catch
				{
					account.Clear();
				}
			}
			finally
			{
				empty = string.Empty;
			}
		}

		// 
		private void u0081u0002(SecureString track, string matchPattern, out int expDateMonth, out int expDateYear)
		{
			expDateMonth = 0;
			expDateYear = 0;
			string empty = string.Empty;
			char[] chrArray = new char[] { '\u005E', '=' };
			try
			{
				IntPtr bSTR = Marshal.SecureStringToBSTR(track);
				Match match = Regex.Match(Marshal.PtrToStringUni(bSTR), matchPattern);
				if (match.Success)
				{
					empty = match.ToString();
					empty = empty.TrimEnd(chrArray);
					empty = empty.TrimStart(chrArray);
					expDateMonth = int.Parse(empty.Substring(2, 2));
					expDateYear = int.Parse(empty.Substring(0, 2)) + 0x7d0;
				}
			}
			catch
			{
				expDateMonth = 0;
				expDateYear = 0;
			}
		}

		~Account()
		{
			this.u0001.Clear();
			this.u0002.Clear();
			this.u0001 = null;
			this.u0002 = null;
		}

		public static bool IsMercuryGift(string account)
		{
			bool flag = false;
			try
			{
				if (account.Length > 0 && account.Length == 19 && account.Substring(0, 6) == "605011")
				{
					flag = true;
				}
			}
			catch
			{
			}
			return flag;
		}

		public bool PassesMOD10Check(SecureString account)
		{
			int length = 0;
			int num = 0;
			int num1 = 0;
			int num2 = 0;
			bool flag = false;
			try
			{
				length = account.Length;
				char[] charArray = new char[length];
				IntPtr bSTR = Marshal.SecureStringToBSTR(account);
				charArray = Marshal.PtrToStringUni(bSTR).ToCharArray();
				Array.Reverse(charArray, 0, length);
				for (int i = 0; i < length; i++)
				{
					if (i % 2 != 0)
					{
						num2 = (Convert.ToInt32(charArray[i]) - 48) * 2;
						if (num2 > 9)
						{
							num2 -= 9;
						}
						num1 += num2;
					}
					else
					{
						num = num + (Convert.ToInt32(charArray.GetValue(i)) - 48);
					}
				}
				if ((num + num1) % 10 != 0)
				{
					flag = true;
				}
			}
			catch
			{
				flag = true;
			}
			return !flag;
		}
	}
}