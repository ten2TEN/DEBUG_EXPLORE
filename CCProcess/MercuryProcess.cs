using A;
using CCProcess.com.mercurypay.w1;
using CCProcess.net.mercurydev.w1;
using Chilkat;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace CCProcess
{
	public class MercuryProcess
	{
		private CCProcess.net.mercurydev.w1.ws c8ed35b6de5d84d3bc1df11377038c041;

		private CCProcess.com.mercurypay.w1.ws c1ff54aa3120ea341de2e708c111787de;

		private string cdbd028816c24be62871eb59b17dc5238;

		private decimal c052c8b8cb26cefc5e0d78cd9e45de371;

		private string cbfc1cf92d4099c22daf06edc8c27e566;

		private string c3ccfe4e6e806673fa919395a7ff90411;

		private string c7d449f0b9ac750cc5d4279213cb78a89;

		private string cb450569a60b36809cae035c8b77947a9;

		private string ca206234482b37852319829e78019f499;

		private string cc2285327b960726f2924c32034b88b6c;

		private bool c47e6c2ee8594d8e285d37df30f81ef05;

		private string cbde6d20955ade39d370b1a5adfeca112;

		private string c74a3fb93bfede071b8df8b99ebc32ab4;

		private string c11112a2019fdc46d7a3ebb3b14309586;

		private string cff5344d60ffdf45cf01df1da9c9458b2;

		private string cd4a8bcc1d52c539bec7941ed77e197e2;

		private string c707871753af05a552a1e1f49ca1a0e1e;

		private string cf977853483ae673707635b078b08f635;

		private string c7bac126ab8d8a8cbbc13386b8513c35b;

		private string c621fefab4abba63179372cbf0b276c7f;

		private string cd4b66190528182605f5cd30f4d4a41ac;

		private string c5197932e1605d215a7828015bb806e98;

		private string ca61a1ae50d3bb36253ba5a2664359991;

		private string c36744a363977269c956d60b14870bd2d;

		private DbLocation c233604abeca67a6e6b798fdea78cdf5f;

		public string Pinblock;

		public string Derivedkey;

		public string Server;

		public string bksver;

		public string Auth
		{
			get
			{
				return this.cdbd028816c24be62871eb59b17dc5238;
			}
			set
			{
				this.cdbd028816c24be62871eb59b17dc5238 = value;
			}
		}

		public string MerchantID
		{
			get
			{
				Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				return crypt.DecryptStringENC(this.cbfc1cf92d4099c22daf06edc8c27e566);
			}
			set
			{
				this.cbfc1cf92d4099c22daf06edc8c27e566 = value;
			}
		}

		public string Password
		{
			get
			{
				string str = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(this.c3ccfe4e6e806673fa919395a7ff90411);
				return str;
			}
			set
			{
				this.c3ccfe4e6e806673fa919395a7ff90411 = value;
			}
		}

		public decimal PaymentLimit
		{
			get
			{
				Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				string str = Conversions.ToString(this.c052c8b8cb26cefc5e0d78cd9e45de371);
				string str1 = crypt.DecryptStringENC(str);
				return Conversions.ToDecimal(str1);
			}
			set
			{
				this.c052c8b8cb26cefc5e0d78cd9e45de371 = value;
			}
		}

		public string Trans
		{
			get
			{
				return this.c7d449f0b9ac750cc5d4279213cb78a89;
			}
			set
			{
				this.c7d449f0b9ac750cc5d4279213cb78a89 = value;
			}
		}

		public CCProcess.net.mercurydev.w1.ws WSDev
		{
			get
			{
				return this.c8ed35b6de5d84d3bc1df11377038c041;
			}
			set
			{
				this.c8ed35b6de5d84d3bc1df11377038c041 = value;
			}
		}

		public CCProcess.com.mercurypay.w1.ws WSPay
		{
			get
			{
				return this.c1ff54aa3120ea341de2e708c111787de;
			}
			set
			{
				this.c1ff54aa3120ea341de2e708c111787de = value;
			}
		}

		public MercuryProcess()
		{
			this.c8ed35b6de5d84d3bc1df11377038c041 = new CCProcess.net.mercurydev.w1.ws();
			this.c1ff54aa3120ea341de2e708c111787de = new CCProcess.com.mercurypay.w1.ws();
			this.cdbd028816c24be62871eb59b17dc5238 = "";
			this.c052c8b8cb26cefc5e0d78cd9e45de371 = new decimal();
			this.cb450569a60b36809cae035c8b77947a9 = "";
			this.ca206234482b37852319829e78019f499 = "";
			this.cc2285327b960726f2924c32034b88b6c = "";
			this.c47e6c2ee8594d8e285d37df30f81ef05 = false;
			this.cbde6d20955ade39d370b1a5adfeca112 = "";
			this.c74a3fb93bfede071b8df8b99ebc32ab4 = "";
			this.c11112a2019fdc46d7a3ebb3b14309586 = "";
			this.cff5344d60ffdf45cf01df1da9c9458b2 = "";
			this.cd4a8bcc1d52c539bec7941ed77e197e2 = "";
			this.c707871753af05a552a1e1f49ca1a0e1e = "";
			this.cf977853483ae673707635b078b08f635 = "";
			this.c7bac126ab8d8a8cbbc13386b8513c35b = "";
			this.c621fefab4abba63179372cbf0b276c7f = "";
			this.cd4b66190528182605f5cd30f4d4a41ac = "";
			this.c5197932e1605d215a7828015bb806e98 = "";
			this.ca61a1ae50d3bb36253ba5a2664359991 = "";
			this.c36744a363977269c956d60b14870bd2d = "";
			this.Pinblock = "";
			this.Derivedkey = "";
			this.Server = "";
			this.bksver = "";
			this.c233604abeca67a6e6b798fdea78cdf5f = new DbLocation();
			this.c233604abeca67a6e6b798fdea78cdf5f.SetCryptValues();
			this.WSDev = new CCProcess.net.mercurydev.w1.ws();
			this.WSPay = new CCProcess.com.mercurypay.w1.ws();
			CCProcess.net.mercurydev.w1.ws wSDev = this.WSDev;
			wSDev.Url = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x160c);
			CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1655);
			wSPay.Url = str;
		}

		public bool CreditCharge()
		{
			CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
			string trans = this.Trans;
			string password = this.Password;
			string str = wSPay.CreditTransaction(trans, password);
			bool flag = Conversions.ToBoolean(str);
			return flag;
		}

		public bool DebitCharge()
		{
			CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
			string merchantID = this.MerchantID;
			string password = this.Password;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x385);
			string str1 = wSPay.CTranDetail(merchantID, password, str);
			return Conversions.ToBoolean(str1);
		}

		protected override void Finalize()
		{
			this.Finalize();
		}

		public string GetSaleToken_By_AcctNum(string MerID, string OperID, string TransactionType, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string NameOnCC, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, bool bOverride, string Frequency, string Address = "", string Zip = "", string CVV = "")
		{
			// 
			// Current member / type: System.String CCProcess.MercuryProcess::GetSaleToken_By_AcctNum(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String GetSaleToken_By_AcctNum(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string GetSaleToken_By_Track2(string MerID, string OperID, string TransactionType, string TransCode, string Invoice, string RefNumber, string MEMO, string PurchaseAmt, string AuthAmt, string wsPassword, string Frequency, string Track2 = "")
		{
			string str;
			string[] operID = new string[] { c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4), MerID, null, null, null };
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			operID[2] = str1;
			operID[3] = OperID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x462);
			operID[4] = str2;
			string str3 = string.Concat(operID);
			this.Trans = str3;
			operID = new string[14];
			string trans = this.Trans;
			operID[0] = trans;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e9);
			operID[1] = str4;
			operID[2] = TransactionType;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7b);
			operID[3] = str5;
			operID[4] = TransCode;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5a2);
			operID[5] = str6;
			operID[6] = Invoice;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
			operID[7] = str7;
			operID[8] = RefNumber;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
			operID[9] = str8;
			operID[10] = MEMO;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xeee);
			operID[11] = str9;
			operID[12] = Frequency;
			operID[13] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf70);
			this.Trans = string.Concat(operID);
			string trans1 = this.Trans;
			string str10 = string.Concat(trans1, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x632));
			this.Trans = str10;
			Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
			string str11 = crypt.DecryptStringENC(Track2);
			Track2 = str11;
			string str12 = Track2.Trim();
			Track2 = str12;
			string str13 = Track2.Replace(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x649), "");
			Track2 = str13;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64c);
			string str15 = Track2.Replace(str14, "");
			Track2 = str15;
			string str16 = string.Concat(this.Trans, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64f), Track2, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x660));
			this.Trans = str16;
			string str17 = string.Concat(this.Trans, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x697));
			this.Trans = str17;
			string trans2 = this.Trans;
			string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e4);
			string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf8d);
			this.Trans = string.Concat(trans2, str18, PurchaseAmt, str19);
			string str20 = string.Concat(this.Trans, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871));
			this.Trans = str20;
			try
			{
				this.WSPay.Url = this.Server;
				string str21 = this.WSPay.CreditTransaction(this.Trans, wsPassword);
				str = str21;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				string trans3 = this.Trans;
				string str22 = w.CreditTransaction(trans3, wsPassword);
				str = str22;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string PartialAuthTransaction_SwipeOnly(string MerID, string OperID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string NameOnCC, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, bool bOverride, string Track1 = "", string Track2 = "", string Address = "", string Zip = "", string CVV = "")
		{
			string str;
			string[] merID = new string[5];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
			merID[0] = str1;
			merID[1] = MerID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			merID[2] = str2;
			merID[3] = OperID;
			merID[4] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x462);
			this.Trans = string.Concat(merID);
			string trans = this.Trans;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4e9);
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fe);
			this.Trans = string.Concat(trans, str3, TransactionType, str4);
			merID = new string[8];
			string trans1 = this.Trans;
			merID[0] = trans1;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1242);
			merID[1] = str5;
			merID[2] = Invoice;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
			merID[3] = str6;
			merID[4] = RefNumber;
			merID[5] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
			merID[6] = MEMO;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c4);
			merID[7] = str7;
			string str8 = string.Concat(merID);
			this.Trans = str8;
			this.c233604abeca67a6e6b798fdea78cdf5f.SetCryptValues();
			string trans2 = this.Trans;
			this.Trans = string.Concat(trans2, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x632));
			Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
			string str9 = crypt.DecryptStringENC(Track2);
			Track2 = str9;
			string str10 = Track2.Trim();
			Track2 = str10;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x649);
			string str12 = Track2.Replace(str11, "");
			Track2 = str12;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64c);
			Track2 = Track2.Replace(str13, "");
			string trans3 = this.Trans;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64f);
			string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x660);
			string str16 = string.Concat(trans3, str14, Track2, str15);
			this.Trans = str16;
			string trans4 = this.Trans;
			string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x697);
			string str18 = string.Concat(trans4, str17);
			this.Trans = str18;
			string trans5 = this.Trans;
			string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e4);
			string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf8d);
			string str21 = string.Concat(trans5, str19, PurchaseAmt, str20);
			this.Trans = str21;
			string trans6 = this.Trans;
			this.Trans = string.Concat(trans6, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871));
			try
			{
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				string trans7 = this.Trans;
				string str22 = w.CreditTransaction(trans7, wsPassword);
				str = str22;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
				wSPay1.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w1 = this.WSPay;
				string trans8 = this.Trans;
				string str23 = w1.CreditTransaction(trans8, wsPassword);
				str = str23;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string PreAuthCapture_PartialAuth(string MerID, string OperID, string TransactionType, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, string Authcode, string AcqRefData, string ProcessData)
		{
			string str;
			string[] merID = new string[13];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
			merID[0] = str1;
			merID[1] = MerID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			merID[2] = str2;
			merID[3] = OperID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xfbe);
			merID[4] = str3;
			merID[5] = TransactionType;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x128f);
			merID[6] = str4;
			merID[7] = Invoice;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
			merID[8] = str5;
			merID[9] = RefNumber;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
			merID[10] = str6;
			merID[11] = MEMO;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c4);
			merID[12] = str7;
			string str8 = string.Concat(merID);
			this.Trans = str8;
			this.c233604abeca67a6e6b798fdea78cdf5f.SetCryptValues();
			merID = new string[16];
			merID[0] = this.Trans;
			merID[1] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b0);
			string str9 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(AcctNum);
			merID[2] = str9;
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
			merID[3] = str10;
			Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
			string str11 = crypt.DecryptStringENC(Expiry);
			merID[4] = str11;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
			merID[5] = str12;
			merID[6] = PurchaseAmt;
			merID[7] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x80d);
			merID[8] = PurchaseAmt;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x130a);
			merID[9] = str13;
			merID[10] = Authcode;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1369);
			merID[11] = str14;
			merID[12] = AcqRefData;
			string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139c);
			merID[13] = str15;
			merID[14] = ProcessData;
			merID[15] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13d5);
			string str16 = string.Concat(merID);
			this.Trans = str16;
			string trans = this.Trans;
			string str17 = string.Concat(trans, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871));
			this.Trans = str17;
			try
			{
				this.WSPay.Url = this.Server;
				string str18 = this.WSPay.CreditTransaction(this.Trans, wsPassword);
				str = str18;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.bksver;
				string str19 = this.WSPay.CreditTransaction(this.Trans, wsPassword);
				str = str19;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string PreAuthPartialTransaction(string MerID, string OperID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string NameOnCC, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, bool bOverride, string Track1 = "", string Track2 = "", string Address = "", string Zip = "", string CVV = "")
		{
			string str;
			string[] merID = new string[13];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
			merID[0] = str1;
			merID[1] = MerID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			merID[2] = str2;
			merID[3] = OperID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xfbe);
			merID[4] = str3;
			merID[5] = TransactionType;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1157);
			merID[6] = str4;
			merID[7] = Invoice;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
			merID[8] = str5;
			merID[9] = RefNumber;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
			merID[10] = str6;
			merID[11] = MEMO;
			merID[12] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c4);
			string str7 = string.Concat(merID);
			this.Trans = str7;
			this.c233604abeca67a6e6b798fdea78cdf5f.SetCryptValues();
			string trans = this.Trans;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x632);
			string str9 = string.Concat(trans, str8);
			this.Trans = str9;
			Track2 = Track2;
			string str10 = Track2.Trim();
			Track2 = str10;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x649);
			Track2 = Track2.Replace(str11, "");
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64c);
			string str13 = Track2.Replace(str12, "");
			Track2 = str13;
			string trans1 = this.Trans;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64f);
			string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x660);
			string str16 = string.Concat(trans1, str14, Track2, str15);
			this.Trans = str16;
			string trans2 = this.Trans;
			string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x121b);
			this.Trans = string.Concat(trans2, str17);
			string trans3 = this.Trans;
			string str18 = string.Concat(trans3, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x697));
			this.Trans = str18;
			merID = new string[6];
			string trans4 = this.Trans;
			merID[0] = trans4;
			string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e4);
			merID[1] = str19;
			merID[2] = PurchaseAmt;
			string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x80d);
			merID[3] = str20;
			merID[4] = PurchaseAmt;
			string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83e);
			merID[5] = str21;
			this.Trans = string.Concat(merID);
			string trans5 = this.Trans;
			string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871);
			string str23 = string.Concat(trans5, str22);
			this.Trans = str23;
			try
			{
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				string trans6 = this.Trans;
				string str24 = w.CreditTransaction(trans6, wsPassword);
				str = str24;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
				wSPay1.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w1 = this.WSPay;
				string trans7 = this.Trans;
				string str25 = w1.CreditTransaction(trans7, wsPassword);
				str = str25;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string Prepare_Token_Transaction(string MerID, string OperID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string NameOnCC, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, bool bOverride, string Track1 = "", string Track2 = "", string Address = "", string Zip = "", string CVV = "")
		{
			// 
			// Current member / type: System.String CCProcess.MercuryProcess::Prepare_Token_Transaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String Prepare_Token_Transaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string PrepareDebitTransaction(string MerID, string CardTYPE, string TransCode, string Invoice, string RefNumber, string PurchaseAmt, string Track2, string Memo, string wsPassword, string Track1 = "")
		{
			// 
			// Current member / type: System.String CCProcess.MercuryProcess::PrepareDebitTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String PrepareDebitTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string PrepareReturnDebitTransaction(string MerID, string CardTYPE, string Invoice, string RefNumber, string PurchaseAmt, string Track2, string pin, string der, string Memo, string wsPassword, string Track1 = "")
		{
			string str;
			string[] merID;
			try
			{
				int num = Operators.CompareString(Track1, "", false);
				if (num != 0)
				{
					merID = new string[19];
					string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
					merID[0] = str1;
					merID[1] = MerID;
					string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xce3);
					merID[2] = str2;
					merID[3] = Invoice;
					merID[4] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
					merID[5] = RefNumber;
					merID[6] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
					merID[7] = Memo;
					string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa84);
					merID[8] = str3;
					Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
					merID[9] = crypt.DecryptStringENC(Track1);
					merID[10] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xabd);
					string str4 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(Track2);
					merID[11] = str4;
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xbaf);
					merID[12] = str5;
					merID[13] = PurchaseAmt;
					merID[14] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc06);
					merID[15] = pin;
					string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc59);
					merID[16] = str6;
					merID[17] = der;
					merID[18] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc88);
					string str7 = string.Concat(merID);
					this.Trans = str7;
				}
				else
				{
					merID = new string[17];
					string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
					merID[0] = str8;
					merID[1] = MerID;
					string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xce3);
					merID[2] = str9;
					merID[3] = Invoice;
					string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
					merID[4] = str10;
					merID[5] = RefNumber;
					merID[6] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
					merID[7] = Memo;
					string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xb76);
					merID[8] = str11;
					string str12 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(Track2);
					merID[9] = str12;
					merID[10] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xbaf);
					merID[11] = PurchaseAmt;
					string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc06);
					merID[12] = str13;
					merID[13] = pin;
					string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc59);
					merID[14] = str14;
					merID[15] = der;
					string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xc88);
					merID[16] = str15;
					string str16 = string.Concat(merID);
					this.Trans = str16;
				}
				try
				{
					CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
					wSPay.Url = this.Server;
					CCProcess.com.mercurypay.w1.ws w = this.WSPay;
					string trans = this.Trans;
					string str17 = w.CreditTransaction(trans, wsPassword);
					str = str17;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					this.WSPay.Url = this.bksver;
					CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
					string trans1 = this.Trans;
					string str18 = wSPay1.CreditTransaction(trans1, wsPassword);
					str = str18;
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				string str19 = exception1.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str19, MsgBoxStyle.OkOnly, null);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string PrepareTransaction(string MerID, string OperID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string NameOnCC, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, bool bOverride, string LaneID, string Track1 = "", string Track2 = "", string Address = "", string Zip = "", string CVV = "")
		{
			// 
			// Current member / type: System.String CCProcess.MercuryProcess::PrepareTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String PrepareTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public Collection PrepareTransactionDebug(string MerID, string OperID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string NameOnCC, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, bool bOverride, string LaneID, string Track1 = "", string Track2 = "", string Address = "", string Zip = "", string CVV = "")
		{
			// 
			// Current member / type: Microsoft.VisualBasic.Collection CCProcess.MercuryProcess::PrepareTransactionDebug(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: Microsoft.VisualBasic.Collection PrepareTransactionDebug(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string PrepareVoiceAuthTransaction(string MerID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string PurchaseAmt, string AuthCode, string wsPassword, string Track1 = "", string Track2 = "")
		{
			string str;
			string[] merID;
			int num = Operators.CompareString(Track1, "", false);
			if (num != 0)
			{
				merID = new string[27];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
				merID[0] = str1;
				merID[1] = MerID;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ce);
				merID[2] = str2;
				merID[3] = TransactionType;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf2);
				merID[4] = str3;
				merID[5] = TransCode;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5a2);
				merID[6] = str4;
				merID[7] = Invoice;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe21);
				merID[8] = str5;
				merID[9] = CardTYPE;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe52);
				merID[10] = str6;
				merID[11] = RefNumber;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
				merID[12] = str7;
				merID[13] = MEMO;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa84);
				merID[14] = str8;
				Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				string str9 = crypt.DecryptStringENC(Track1);
				merID[15] = str9;
				merID[16] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xabd);
				Crypt2 crypt2 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				merID[17] = crypt2.DecryptStringENC(Track2);
				merID[18] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xae4);
				string str10 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(AcctNum);
				merID[19] = str10;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
				merID[20] = str11;
				merID[21] = Expiry;
				merID[22] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
				merID[23] = PurchaseAmt;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9c2);
				merID[24] = str12;
				merID[25] = AuthCode;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa1f);
				merID[26] = str13;
				string str14 = string.Concat(merID);
				this.Trans = str14;
			}
			else
			{
				merID = new string[23];
				merID[0] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
				merID[1] = MerID;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ce);
				merID[2] = str15;
				merID[3] = TransactionType;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf2);
				merID[4] = str16;
				merID[5] = TransCode;
				merID[6] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5a2);
				merID[7] = Invoice;
				merID[8] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe21);
				merID[9] = CardTYPE;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe52);
				merID[10] = str17;
				merID[11] = RefNumber;
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
				merID[12] = str18;
				merID[13] = MEMO;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x930);
				merID[14] = str19;
				string str20 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(AcctNum);
				merID[15] = str20;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
				merID[16] = str21;
				merID[17] = Expiry;
				merID[18] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
				merID[19] = PurchaseAmt;
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9c2);
				merID[20] = str22;
				merID[21] = AuthCode;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa1f);
				merID[22] = str23;
				string str24 = string.Concat(merID);
				this.Trans = str24;
			}
			try
			{
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				string str25 = w.CreditTransaction(this.Trans, wsPassword);
				str = str25;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
				wSPay1.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w1 = this.WSPay;
				string str26 = w1.CreditTransaction(this.Trans, wsPassword);
				str = str26;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string PrepareVoidReturnDebitTransaction(string MerID, string CardTYPE, string Invoice, string RefNumber, string PurchaseAmt, string Track2, string pin, string der, string Memo, string wsPassword, string Track1 = "")
		{
			// 
			// Current member / type: System.String CCProcess.MercuryProcess::PrepareVoidReturnDebitTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String PrepareVoidReturnDebitTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string PrepareVoidReturnTransaction(string MerID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string AcctNum, string Expiry, string PurchaseAmt, string AuthAmt, string AuthCode, string Memo, string wsPassword, string Track1 = "", string Track2 = "")
		{
			// 
			// Current member / type: System.String CCProcess.MercuryProcess::PrepareVoidReturnTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\CCProcess.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String PrepareVoidReturnTransaction(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// 
			// Queue empty.
			//    at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.(ICollection`1 ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 525
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 445
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 363
			//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\TypeInference\TypeInferer.cs:line 307
			//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\ExpressionDecompilerStep.cs:line 86
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		public string PrepareVoidTransaction(string MerID, string TransactionType, string CardTYPE, string TransCode, string Invoice, string RefNumber, string AcctNum, string Expiry, string PurchaseAmt, string AuthAmt, string AuthCode, string Memo, string wsPassword, string Track1 = "", string Track2 = "")
		{
			string str;
			string[] merID;
			int num = Operators.CompareString(Track1, "", false);
			if (num != 0)
			{
				merID = new string[27];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
				merID[0] = str1;
				merID[1] = MerID;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ce);
				merID[2] = str2;
				merID[3] = TransactionType;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x901);
				merID[4] = str3;
				merID[5] = CardTYPE;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x573);
				merID[6] = str4;
				merID[7] = TransCode;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5a2);
				merID[8] = str5;
				merID[9] = Invoice;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
				merID[10] = str6;
				merID[11] = RefNumber;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
				merID[12] = str7;
				merID[13] = Memo;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa84);
				merID[14] = str8;
				Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				string str9 = crypt.DecryptStringENC(Track1);
				merID[15] = str9;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xabd);
				merID[16] = str10;
				Crypt2 crypt2 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				string str11 = crypt2.DecryptStringENC(Track2);
				merID[17] = str11;
				merID[18] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xae4);
				Crypt2 crypt1 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
				string str12 = crypt1.DecryptStringENC(AcctNum);
				merID[19] = str12;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
				merID[20] = str13;
				merID[21] = Expiry;
				merID[22] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
				merID[23] = PurchaseAmt;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9c2);
				merID[24] = str14;
				merID[25] = AuthCode;
				merID[26] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa1f);
				string str15 = string.Concat(merID);
				this.Trans = str15;
			}
			else
			{
				merID = new string[23];
				merID[0] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
				merID[1] = MerID;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ce);
				merID[2] = str16;
				merID[3] = TransactionType;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x901);
				merID[4] = str17;
				merID[5] = CardTYPE;
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x573);
				merID[6] = str18;
				merID[7] = TransCode;
				merID[8] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5a2);
				merID[9] = Invoice;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
				merID[10] = str19;
				merID[11] = RefNumber;
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fe);
				merID[12] = str20;
				merID[13] = Memo;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x930);
				merID[14] = str21;
				string str22 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(AcctNum);
				merID[15] = str22;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
				merID[16] = str23;
				merID[17] = Expiry;
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
				merID[18] = str24;
				merID[19] = PurchaseAmt;
				string str25 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9c2);
				merID[20] = str25;
				merID[21] = AuthCode;
				merID[22] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa1f);
				string str26 = string.Concat(merID);
				this.Trans = str26;
			}
			try
			{
				this.WSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				string str27 = wSPay.CreditTransaction(this.Trans, wsPassword);
				str = str27;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				w.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
				string trans = this.Trans;
				string str28 = wSPay1.CreditTransaction(trans, wsPassword);
				str = str28;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string Token_Transaction(string MerID, string OperID, string TranType, string PartialAuth, string TransCode, string Invoice, string RefNumber, string PurchaseAmt, string RecordNo, string Frequency, string wsPassword)
		{
			string str;
			string[] merID = new string[21];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
			merID[0] = str1;
			merID[1] = MerID;
			merID[2] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			merID[3] = OperID;
			merID[4] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xfbe);
			merID[5] = TranType;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xff1);
			merID[6] = str2;
			merID[7] = PartialAuth;
			merID[8] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1026);
			merID[9] = TransCode;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5a2);
			merID[10] = str3;
			merID[11] = Invoice;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d3);
			merID[12] = str4;
			merID[13] = RefNumber;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x105b);
			merID[14] = str5;
			merID[15] = RecordNo;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1084);
			merID[16] = str6;
			merID[17] = Frequency;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b5);
			merID[18] = str7;
			merID[19] = PurchaseAmt;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10fa);
			merID[20] = str8;
			string str9 = string.Concat(merID);
			this.Trans = str9;
			try
			{
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				string trans = this.Trans;
				string str10 = w.CreditTransaction(trans, wsPassword);
				str = str10;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
				wSPay1.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w1 = this.WSPay;
				str = w1.CreditTransaction(this.Trans, wsPassword);
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string VoidSale_Reversal_PreAuthCapture(string MerID, string OperID, string TransactionType, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, string Authcode, string AcqRefData, string ProcessData)
		{
			string str;
			string[] merID = new string[13];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
			merID[0] = str1;
			merID[1] = MerID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			merID[2] = str2;
			merID[3] = OperID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xfbe);
			merID[4] = str3;
			merID[5] = TransactionType;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x140c);
			merID[6] = str4;
			merID[7] = RefNumber;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1473);
			merID[8] = str5;
			merID[9] = Invoice;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x149e);
			merID[10] = str6;
			merID[11] = MEMO;
			merID[12] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14c7);
			string str7 = string.Concat(merID);
			this.Trans = str7;
			this.c233604abeca67a6e6b798fdea78cdf5f.SetCryptValues();
			merID = new string[14];
			merID[0] = this.Trans;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b0);
			merID[1] = str8;
			string str9 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(AcctNum);
			merID[2] = str9;
			merID[3] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
			Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
			merID[4] = crypt.DecryptStringENC(Expiry);
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
			merID[5] = str10;
			merID[6] = PurchaseAmt;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14d6);
			merID[7] = str11;
			merID[8] = AcqRefData;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139c);
			merID[9] = str12;
			merID[10] = ProcessData;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1537);
			merID[11] = str13;
			merID[12] = Authcode;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x156c);
			merID[13] = str14;
			string str15 = string.Concat(merID);
			this.Trans = str15;
			string trans = this.Trans;
			string str16 = string.Concat(trans, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871));
			this.Trans = str16;
			try
			{
				this.WSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				str = wSPay.CreditTransaction(this.Trans, wsPassword);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				this.WSPay.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				str = w.CreditTransaction(this.Trans, wsPassword);
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public string VoidSaleRequest_Reversal_PartialAuthTransaction(string MerID, string OperID, string TransactionType, string Invoice, string RefNumber, string MEMO, string AcctNum, string Expiry, string PurchaseAmt, string AuthAmt, string TerminalName, string wsPassword, string Authcode, string AcqRefData, string ProcessData)
		{
			string str;
			string[] merID = new string[13];
			merID[0] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x3b4);
			merID[1] = MerID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x42b);
			merID[2] = str1;
			merID[3] = OperID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xfbe);
			merID[4] = str2;
			merID[5] = TransactionType;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x140c);
			merID[6] = str3;
			merID[7] = RefNumber;
			merID[8] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1473);
			merID[9] = Invoice;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x149e);
			merID[10] = str4;
			merID[11] = MEMO;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14c7);
			merID[12] = str5;
			string str6 = string.Concat(merID);
			this.Trans = str6;
			this.c233604abeca67a6e6b798fdea78cdf5f.SetCryptValues();
			merID = new string[14];
			string trans = this.Trans;
			merID[0] = trans;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b0);
			merID[1] = str7;
			Crypt2 crypt = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt;
			string str8 = crypt.DecryptStringENC(AcctNum);
			merID[2] = str8;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d7);
			merID[3] = str9;
			string str10 = this.c233604abeca67a6e6b798fdea78cdf5f.Crypt.DecryptStringENC(Expiry);
			merID[4] = str10;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x969);
			merID[5] = str11;
			merID[6] = PurchaseAmt;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14d6);
			merID[7] = str12;
			merID[8] = AcqRefData;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139c);
			merID[9] = str13;
			merID[10] = ProcessData;
			merID[11] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1537);
			merID[12] = Authcode;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x156c);
			merID[13] = str14;
			string str15 = string.Concat(merID);
			this.Trans = str15;
			string trans1 = this.Trans;
			this.Trans = string.Concat(trans1, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871));
			try
			{
				CCProcess.com.mercurypay.w1.ws wSPay = this.WSPay;
				wSPay.Url = this.Server;
				CCProcess.com.mercurypay.w1.ws w = this.WSPay;
				string trans2 = this.Trans;
				string str16 = w.CreditTransaction(trans2, wsPassword);
				str = str16;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				CCProcess.com.mercurypay.w1.ws wSPay1 = this.WSPay;
				wSPay1.Url = this.bksver;
				CCProcess.com.mercurypay.w1.ws w1 = this.WSPay;
				string str17 = w1.CreditTransaction(this.Trans, wsPassword);
				str = str17;
				ProjectData.ClearProjectError();
			}
			return str;
		}
	}
}