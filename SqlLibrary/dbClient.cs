using A;
using Chilkat;
using ErrorHandler;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace SqlLibrary
{
	public class dbClient : SqlBase
	{
		private SqlParameter[] cd955ea14127f673c1e77e436c7b2d31e;

		private DbLocation c159fce105a6ad06c71422bf493aa6e90;

		public dbClient()
		{
			this.c159fce105a6ad06c71422bf493aa6e90 = new DbLocation();
		}

		public bool ActivateClientPackage(int CPID, DateTime dtExpire)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x82e5);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = CPID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x73fe);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.DateTime);
			sqlParameter[1].Value = dtExpire;
			try
			{
				try
				{
					string connection = this.Connection;
					string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x82f0);
					int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str2, sqlParameter);
					flag = true;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				sqlParameter = null;
			}
			return flag;
		}

		public bool Add_DebugLog(DateTime dt, string str, int LocNum)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[3];
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			sqlParameter[0] = new SqlParameter(str1, SqlDbType.DateTime, 4);
			sqlParameter[0].Value = dt;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ee4);
			sqlParameter[1] = new SqlParameter(str2, SqlDbType.NVarChar, 0x3e8);
			sqlParameter[1].Value = str;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[2] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[2].Value = LocNum;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8eed);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool Add_TransLog(string EmpNum, string EmpName, string Area, string Action, bool bSuccess, int LocNum)
		{
			bool flag;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e6a);
			string str1 = str;
			try
			{
				string name = c0dd4fc6869fba3aacef6b22faaca2a82.c282a1b8dbdb6daa513a65a018abb4906.Name;
				IPAddress[] hostAddresses = Dns.GetHostAddresses(name);
				string str2 = hostAddresses[1].ToString();
				str1 = str2.Trim();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e79);
			sqlParameter[0] = new SqlParameter(str3, SqlDbType.NVarChar, 20);
			sqlParameter[0].Value = EmpNum;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66fd);
			sqlParameter[1] = new SqlParameter(str4, SqlDbType.NVarChar, 50);
			sqlParameter[1].Value = EmpName;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e88);
			sqlParameter[2] = new SqlParameter(str5, SqlDbType.NVarChar, 0xff);
			sqlParameter[2].Value = Area;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e93), SqlDbType.NVarChar, 0xff);
			SqlParameter sqlParameter1 = sqlParameter[3];
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ea2);
			string str7 = string.Concat(Action, str6, str1, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8eaf));
			sqlParameter1.Value = str7;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8eb2);
			sqlParameter[4] = new SqlParameter(str8, SqlDbType.Bit, 2);
			sqlParameter[4].Value = bSuccess;
			sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
			sqlParameter[5].Value = LocNum;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ec5), sqlParameter);
				flag = true;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				string str9 = exception1.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str9, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool AlreadyHasit(ref int PandSID, int clientID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::AlreadyHasit(System.Int32&,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean AlreadyHasit(System.Int32&,System.Int32)
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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void bgSendTan(SqlParameter[] Sqlparams)
		{
			try
			{
				this.ADOFillNonQuery(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8471), Sqlparams);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				string productName = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996.Info.ProductName;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x848a);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x848a);
				DialogResult dialogResult = (new frmError(exception, productName, str, str1)).ShowDialog();
				ProjectData.ClearProjectError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void c3059d05a1813a6f9d4a3cadc62c399ff(SqlParameter[] c6dc80b81207c2e4f5a9c1fcc712e8979)
		{
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8511);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, c6dc80b81207c2e4f5a9c1fcc712e8979);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				AssemblyInfo info = _cef4fffd9795b6af60f35514532347eb4.Info;
				string productName = info.ProductName;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x848a);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x848a);
				DialogResult dialogResult = (new frmError(exception, productName, str1, str2)).ShowDialog();
				ProjectData.ClearProjectError();
			}
		}

		public bool CancelEFT(int ClientID, int ClientPkgID, int PkgID, string EmpName)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[4];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ClientID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x94b9);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = ClientPkgID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7349);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[2].Value = PkgID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66fd);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.NVarChar, 100);
			sqlParameter[3].Value = EmpName;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9510);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str5 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str5, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool CCReqResp(string Req, string Resp, int store, int drawer)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8536), SqlDbType.NVarChar, 0x3e8), null, null, null };
				sqlParameter[0].Value = Req;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x853f);
				sqlParameter[1] = new SqlParameter(str, SqlDbType.NVarChar, 0x3e8);
				sqlParameter[1].Value = Resp;
				sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
				sqlParameter[2].Value = store;
				sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x854a), SqlDbType.Int, 8);
				sqlParameter[3].Value = drawer;
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8559);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public DataSet CCReqResp(int LogID, string Printdata, string Req, string Resp, int store, int drawer, decimal Amount, int TransType, bool bOveride, bool bUseUI, string UserID, string InvoiceNumber, string ReferenceNumber, string MerchantLanguage, string UserTraceData, string MerchantID, string ComPort, bool bManual, string VoiceAuth, bool bDebit, string SequenceNumber, bool bCanadianEMVGratuityPrompt, string EMVResponsePrintData, string EMVResponseMerchantID, string EMVResponseSequenceNo, string EMVResponseCmdStatus, string EMVResponseCaptureStatus, string EMVResponseXmlResponse)
		{
			DataSet dataSet;
			DataSet dataSet1 = new DataSet();
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[28];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8536);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.NVarChar);
				sqlParameter[0].Value = Req;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x853f);
				sqlParameter[1] = new SqlParameter(str1, SqlDbType.NVarChar);
				sqlParameter[1].Value = Resp;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				sqlParameter[2] = new SqlParameter(str2, SqlDbType.Int, 8);
				sqlParameter[2].Value = store;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x854a);
				sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
				sqlParameter[3].Value = drawer;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8572);
				sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int);
				sqlParameter[4].Value = LogID;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x857f);
				sqlParameter[5] = new SqlParameter(str5, SqlDbType.NVarChar);
				sqlParameter[5].Value = Printdata;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8594);
				sqlParameter[6] = new SqlParameter(str6, SqlDbType.Decimal);
				sqlParameter[6].Value = Amount;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x85a3);
				sqlParameter[7] = new SqlParameter(str7, SqlDbType.Int);
				sqlParameter[7].Value = TransType;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x85b8);
				sqlParameter[8] = new SqlParameter(str8, SqlDbType.Bit);
				sqlParameter[8].Value = bOveride;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x85cb);
				sqlParameter[9] = new SqlParameter(str9, SqlDbType.Bit);
				sqlParameter[9].Value = bUseUI;
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x85da);
				sqlParameter[10] = new SqlParameter(str10, SqlDbType.NVarChar);
				sqlParameter[10].Value = UserID;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x85e9);
				sqlParameter[11] = new SqlParameter(str11, SqlDbType.NVarChar);
				sqlParameter[11].Value = InvoiceNumber;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8606);
				sqlParameter[12] = new SqlParameter(str12, SqlDbType.NVarChar);
				sqlParameter[12].Value = ReferenceNumber;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8627);
				sqlParameter[13] = new SqlParameter(str13, SqlDbType.NVarChar);
				sqlParameter[13].Value = MerchantLanguage;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x864a);
				sqlParameter[14] = new SqlParameter(str14, SqlDbType.NVarChar);
				sqlParameter[14].Value = UserTraceData;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8667);
				sqlParameter[15] = new SqlParameter(str15, SqlDbType.NVarChar);
				sqlParameter[15].Value = MerchantID;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x867e);
				sqlParameter[16] = new SqlParameter(str16, SqlDbType.NVarChar);
				sqlParameter[16].Value = ComPort;
				sqlParameter[17] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x868f), SqlDbType.Bit);
				sqlParameter[17].Value = bManual;
				sqlParameter[18] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x86a0), SqlDbType.NVarChar);
				sqlParameter[18].Value = VoiceAuth;
				sqlParameter[19] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x86b5), SqlDbType.Bit);
				sqlParameter[19].Value = bDebit;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x86c4);
				sqlParameter[20] = new SqlParameter(str17, SqlDbType.NVarChar);
				sqlParameter[20].Value = SequenceNumber;
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x86e3);
				sqlParameter[21] = new SqlParameter(str18, SqlDbType.Bit);
				sqlParameter[21].Value = bCanadianEMVGratuityPrompt;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x871a);
				sqlParameter[22] = new SqlParameter(str19, SqlDbType.NVarChar);
				sqlParameter[22].Value = EMVResponsePrintData;
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8745);
				sqlParameter[23] = new SqlParameter(str20, SqlDbType.NVarChar);
				sqlParameter[23].Value = EMVResponseMerchantID;
				sqlParameter[24] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8772), SqlDbType.NVarChar);
				sqlParameter[24].Value = EMVResponseSequenceNo;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x879f);
				sqlParameter[25] = new SqlParameter(str21, SqlDbType.NVarChar);
				sqlParameter[25].Value = EMVResponseCmdStatus;
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x87ca);
				sqlParameter[26] = new SqlParameter(str22, SqlDbType.NVarChar);
				sqlParameter[26].Value = EMVResponseCaptureStatus;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x87fd);
				sqlParameter[27] = new SqlParameter(str23, SqlDbType.NVarChar);
				sqlParameter[27].Value = EMVResponseXmlResponse;
				string connection = this.Connection;
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x882c);
				DataSet dataSet2 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str24, sqlParameter);
				dataSet1 = dataSet2;
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = dataSet1;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void cf6f4cf4ec89a07f64ddf822a9a38ab87(SqlParameter[] c6dc80b81207c2e4f5a9c1fcc712e8979)
		{
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x84be);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, c6dc80b81207c2e4f5a9c1fcc712e8979);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				AssemblyInfo info = _cef4fffd9795b6af60f35514532347eb4.Info;
				string productName = info.ProductName;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x848a);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x848a);
				DialogResult dialogResult = (new frmError(exception, productName, str1, str2)).ShowDialog();
				ProjectData.ClearProjectError();
			}
		}

		public static byte[] ConvertToByteArray(Bitmap value)
		{
			byte[] numArray;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				ImageFormat jpeg = ImageFormat.Jpeg;
				value.Save(memoryStream, jpeg);
				byte[] array = memoryStream.ToArray();
				numArray = array;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				numArray = null;
				ProjectData.ClearProjectError();
			}
			return numArray;
		}

		public DataSet CountryList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b79), null, null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool DeleteClient(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8c76);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool DeleteClientNotes(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8d8b), sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool DeleteClientVisit(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8d2f);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool DeleteEFT(int ID, bool bAll)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x90d8);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Bit);
			sqlParameter[1].Value = bAll;
			try
			{
				string connection = this.Connection;
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x90e3), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool deleteFingerPrint(int Client_ID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9645);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Client_ID), null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool DeletePicture(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8c95);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public DataSet GenderList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b9c);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public int get_Appointment_Client_ID(string Client_Name, DateTime Start_Date, int BedID, int Loc_Num)
		{
			int num;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9705);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x973e);
				SqlParameter sqlParameter = new SqlParameter(str1, Client_Name);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d31);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)Start_Date);
				SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5986), (object)BedID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
				int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str3, (object)Loc_Num), null, null, null, null, null));
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public SqlDataReader GetAddress_And_Email(int IsEmail)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7c72);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7cb5);
				sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)IsEmail), null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				sqlDataReader = null;
				ProjectData.ClearProjectError();
			}
			return sqlDataReader;
		}

		public DataSet GetAddressAndEmail(int IsEmail)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7c72), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7cb5), (object)IsEmail), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public int GetBedDelay(int RoomNumber, int LocNum)
		{
			int num;
			DataSet dataSet = new DataSet();
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e4d);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64d9);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)RoomNumber), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum), null, null, null, null, null, null, null);
				DataTableCollection tables = dataSet1.Tables;
				DataRowCollection rows = tables[0].Rows;
				DataRow item = rows[0];
				object obj = item[0];
				int integer = Conversions.ToInteger(obj);
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public DataSet GetClientAppointmentStats(int ClientID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8cf6);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ClientID), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetClientPackageByID(string PackageID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7c43);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, PackageID), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DateTime GetClientPackageExpiry(ref int PandSID, int clientID, int day, int month, int i)
		{
			// 
			// Current member / type: System.DateTime SqlLibrary.dbClient::GetClientPackageExpiry(System.Int32&,System.Int32,System.Int32,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.DateTime GetClientPackageExpiry(System.Int32&,System.Int32,System.Int32,System.Int32,System.Int32)
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

		public DataSet GetClientPackageExpiryUpgrade(ref int FromPandSID, int clientID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x920b);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x677e);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)FromPandSID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f0c);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)clientID), null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetClientRewardStats(int ID)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x72bb);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ID), null, null, null, null, null, null, null, null);
			return dataSet1;
		}

		public DataSet GetClientsEMailsbySalesAverage(DateTime Start_Date, DateTime End_Date, int Loc_Num, decimal dPriceHigh, decimal dPriceLow, bool bIncludeAllSales)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d8b);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d31), (object)Start_Date);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d48);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)End_Date);
				SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7df6), (object)Loc_Num);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e11);
				SqlParameter sqlParameter3 = new SqlParameter(str2, (object)dPriceHigh);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e42);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str3, (object)dPriceLow), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e71), (object)bIncludeAllSales), null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetClientTotalSales(int ItemType, int ClientID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8cb6);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ce3);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)ItemType);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)ClientID), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetEFTRecurType(int clientpkgid, DateTime dtmin)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x924c);
				string str1 = str;
				string connection = this.Connection;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9486);
				SqlParameter sqlParameter = new SqlParameter(str2, (object)clientpkgid);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x949f);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.Text, str1, sqlParameter, new SqlParameter(str3, (object)dtmin), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public SqlDataReader GetFinger_Prints(int ClientID = 0, bool IsClient = true)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b22);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ClientID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b47);
				SqlDataReader sqlDataReader1 = this.ADOFillReader(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)IsClient), null, null, null, null, null);
				sqlDataReader = sqlDataReader1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				sqlDataReader = null;
				ProjectData.ClearProjectError();
			}
			return sqlDataReader;
		}

		public DataSet GetFingerPrints(int ClientID = 0, bool IsClient = true)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b22), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ClientID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b47), (object)IsClient), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetFrozenClientPackageInfo(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8d58);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet GetInactiveClientsByNoPackage(short Report_Type, int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e96);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)Loc_Num);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d72);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)Report_Type), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetInactiveClientsByvisit(DateTime Start_Date, DateTime End_Date, DateTime Begin_Date, int Loc_Num, short Report_Type)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7cc6);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d31), (object)Start_Date);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d48);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)End_Date);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d5b);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)Begin_Date);
				SqlParameter sqlParameter3 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b), (object)Loc_Num);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d72);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str3, (object)Report_Type), null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetPackageByID(string PackageID, int ClientPKGID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7c07);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, PackageID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7c2a), (object)ClientPKGID), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet getPackageQtys(ref int Client_ID)
		{
			DataSet dataSet;
			try
			{
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8)
				{
					Value = Client_ID
				};
				string connection = this.Connection;
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9529), sqlParameter, null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public string GetPhone(int ID)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x82a3), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
			DataTable item = dataSet.Tables[0];
			DataRowCollection rows = item.Rows;
			DataRow dataRow = rows[0];
			object obj = dataRow[0];
			string str = Conversions.ToString(obj);
			return str;
		}

		public DataSet GetPurchaseByID(int clientID, int partprocess = 1)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f1f);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)clientID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f44);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)partprocess), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public decimal GetRewards(int id)
		{
			decimal num;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x961e);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)id);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71c9);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)2), null, null, null, null, null, null, null);
				num = Conversions.ToDecimal(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = decimal.Zero;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public bool HasActivePackage(int ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::HasActivePackage(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean HasActivePackage(System.Int32)
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

		public bool HasAppointment(int ID, int LocNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::HasAppointment(System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean HasAppointment(System.Int32,System.Int32)
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

		public int HasAppointmentToday(int ID, int LocNum, DateTime dt)
		{
			int integer;
			SqlParameter[] sqlParameter = new SqlParameter[3];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = LocNum;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.DateTime, 4);
			sqlParameter[2].Value = dt;
			try
			{
				string connection = this.Connection;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8fc6);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str3, sqlParameter);
				integer = Conversions.ToInteger(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				integer = 0;
				ProjectData.ClearProjectError();
			}
			return integer;
		}

		public bool HasEnoughQty(int id, int bucketID, decimal qty, int ClientID)
		{
			bool flag;
			try
			{
				DataSet dataSet = new DataSet();
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x96e6);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x677e);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)id);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6982);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)bucketID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7411);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)qty);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str4, (object)ClientID), null, null, null, null, null);
				DataTable item = dataSet1.Tables[0];
				DataRowCollection rows = item.Rows;
				int count = rows.Count;
				flag = (count <= 0 ? false : true);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool hasFingerPrint(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8f5d);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null, null, null);
				bool flag1 = Conversions.ToBoolean(obj);
				flag = flag1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public string HasUnlimited(int ID)
		{
			string str;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter = new SqlParameter(str1, SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8f3e);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str2, sqlParameter, null, null, null, null, null, null, null, null);
				string str3 = Conversions.ToString(obj);
				str = str3;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fb6);
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public int IsBedUsebyAppointment(int clientID, int Duration, int roomnumber, int StoreNum)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[4];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f0c);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = clientID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8336);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = Duration;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9090);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[2].Value = roomnumber;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[3].Value = StoreNum;
			try
			{
				string connection = this.Connection;
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x90a7), sqlParameter);
				int integer = Conversions.ToInteger(obj);
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str4 = exception.ToString();
				Interaction.MsgBox(str4, MsgBoxStyle.OkOnly, null);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public bool IsClientNumberDuplicate(int ID, string num)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::IsClientNumberDuplicate(System.Int32,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean IsClientNumberDuplicate(System.Int32,System.String)
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

		public DataSet IsDuplicate(string Firstname, string Lastname, string DL)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ddb);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e08);
				SqlParameter sqlParameter = new SqlParameter(str1, Firstname);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e1d);
				SqlParameter sqlParameter1 = new SqlParameter(str2, Lastname);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e30);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, DL), null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet IsEFTCardExpiry(int clientid)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7ee3);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f0c);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)clientid), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool IsTimerWorking(int StoreNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::IsTimerWorking(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean IsTimerWorking(System.Int32)
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

		public int IsUsingTimer(int RoomNum, int StoreNum)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = RoomNum;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = StoreNum;
			try
			{
				try
				{
					string connection = this.Connection;
					string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x82c6);
					int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str2, sqlParameter));
					num = integer;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					num = 0;
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				sqlParameter = null;
			}
			return num;
		}

		public DataSet ListPackages()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7bbd);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadAppointmentsForTan(int RoomNumber, int StoreNUM)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x79ac);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64d9);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)RoomNumber), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)StoreNUM), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str2 = exception.ToString();
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7956);
				bool flag = str2.Contains(str3);
				if (!flag)
				{
					dataSet = null;
					ProjectData.ClearProjectError();
				}
				else
				{
					Interaction.MsgBox(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7965), MsgBoxStyle.OkOnly, null);
					dataSet = null;
					ProjectData.ClearProjectError();
				}
			}
			return dataSet;
		}

		public SqlDataReader LoadClient_Appointments(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x728a);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			SqlDataReader sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null);
			return sqlDataReader;
		}

		public SqlDataReader LoadClient_Notes(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x716a);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			SqlDataReader sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null);
			return sqlDataReader;
		}

		public SqlDataReader LoadClient_Referral(int id, int Part = 1)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x95ca);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				SqlDataReader sqlDataReader1 = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)id), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71c9), (object)Part), null, null, null, null, null);
				sqlDataReader = sqlDataReader1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				sqlDataReader = null;
				ProjectData.ClearProjectError();
			}
			return sqlDataReader;
		}

		public SqlDataReader LoadClient_Rewards(int id, int Part)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x961e);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)id);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71c9);
				SqlDataReader sqlDataReader1 = this.ADOFillReader(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)Part), null, null, null, null, null);
				sqlDataReader = sqlDataReader1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				sqlDataReader = null;
				ProjectData.ClearProjectError();
			}
			return sqlDataReader;
		}

		public SqlDataReader LoadClient_Visits(int ID)
		{
			string connection = this.Connection;
			return this.ADOFillReader(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7265), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ID), null, null, null, null, null, null);
		}

		public DataSet LoadClientAppointments(int ID)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x728a);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet1;
		}

		public dsClient LoadClientByID(int ID)
		{
			dsClient _dsClient = new dsClient();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
			{
				Value = ID
			};
			string connection = this.Connection;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x711a);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xff3);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str1, _dsClient, str2, sqlParameter, null, null, null, null, null);
			string connection1 = this.Connection;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x713b);
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1002);
			DataSet dataSet1 = this.ADOFilldataset(connection1, CommandType.StoredProcedure, str3, _dsClient, str4, sqlParameter, null, null, null, null, null);
			return _dsClient;
		}

		public dsClient LoadClientByMember(string member, bool bdemo = false)
		{
			int integer = 0;
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x70d1);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x70fe);
			SqlParameter sqlParameter = new SqlParameter(str1, member);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d);
			object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)bdemo), null, null, null, null, null, null, null);
			integer = Conversions.ToInteger(obj);
			dsClient _dsClient = new dsClient();
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter1 = new SqlParameter(str3, SqlDbType.Int, 8)
			{
				Value = integer
			};
			string connection1 = this.Connection;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x711a);
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xff3);
			DataSet dataSet = this.ADOFilldataset(connection1, CommandType.StoredProcedure, str4, _dsClient, str5, sqlParameter1, null, null, null, null, null);
			string connection2 = this.Connection;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x713b);
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1002);
			DataSet dataSet1 = this.ADOFilldataset(connection2, CommandType.StoredProcedure, str6, _dsClient, str7, sqlParameter1, null, null, null, null, null);
			return _dsClient;
		}

		public DataSet LoadClientLastVisit(int ID)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbClient::LoadClientLastVisit(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadClientLastVisit(System.Int32)
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

		public DataSet LoadClientNotes(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x716a);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
		}

		public DataSet LoadClientPackages(int ID, bool IsActive)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbClient::LoadClientPackages(System.Int32,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadClientPackages(System.Int32,System.Boolean)
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

		public DataSet LoadClientPackagesForSales(int ID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x78e9);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				string str2 = exception.ToString();
				if (!str2.Contains(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x77ac)))
				{
					string str3 = exception.ToString();
					MsgBoxResult msgBoxResult = Interaction.MsgBox(str3, MsgBoxStyle.OkOnly, null);
				}
				else
				{
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x77cb);
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7840);
					MsgBoxResult msgBoxResult1 = Interaction.MsgBox(str4, MsgBoxStyle.OkOnly, str5);
				}
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadClientPackagesForTan(int ID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x78b4);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				string str2 = exception.ToString();
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x77ac);
				if (!str2.Contains(str3))
				{
					string str4 = exception.ToString();
					MsgBoxResult msgBoxResult = Interaction.MsgBox(str4, MsgBoxStyle.OkOnly, null);
				}
				else
				{
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x77cb);
					string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7840);
					MsgBoxResult msgBoxResult1 = Interaction.MsgBox(str5, MsgBoxStyle.OkOnly, str6);
				}
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public SqlDataReader LoadClientPurchase(int clientID, int partprocess)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f1f);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)clientID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f44);
				sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)partprocess), null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				sqlDataReader = null;
				ProjectData.ClearProjectError();
			}
			return sqlDataReader;
		}

		public DataSet LoadClientReferral(int id)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x954c);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457);
				SqlParameter sqlParameter = new SqlParameter(str1, SqlDbType.BigInt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579);
				SqlParameter sqlParameter1 = new SqlParameter(str2, SqlDbType.BigInt);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)id);
				SqlParameter sqlParameter3 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65), (object)-1);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9586);
				SqlParameter sqlParameter4 = new SqlParameter(str4, (object)1);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x95a7);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, new SqlParameter(str5, (object)1), null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool LoadClientReferral(int id, DateTime dtstart, DateTime dtend, int storenum, int drawer, int storeLoc)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x954c);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457), (object)dtstart);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)dtend);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)id);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				SqlParameter sqlParameter3 = new SqlParameter(str3, (object)storenum);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9586);
				SqlParameter sqlParameter4 = new SqlParameter(str4, (object)storeLoc);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x95a7);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, new SqlParameter(str5, (object)drawer), null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public DataSet LoadClientRewards(int id)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x95f5);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457), SqlDbType.BigInt);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579);
				SqlParameter sqlParameter1 = new SqlParameter(str1, SqlDbType.BigInt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)id);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				SqlParameter sqlParameter3 = new SqlParameter(str3, (object)-1);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9586);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str4, (object)1), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x95a7), (object)1), null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadClientTransfers(int ID, bool IsOut)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbClient::LoadClientTransfers(System.Int32,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadClientTransfers(System.Int32,System.Boolean)
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

		public DataSet LoadClientVisits(int ID)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7265);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet1;
		}

		public SqlDataReader LoadEFT_Payments(int ID, decimal tax1, decimal tax2, decimal tax3, bool IsASC = false, int partprocess = 1)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x718d);
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ID);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71bc);
			SqlParameter sqlParameter1 = new SqlParameter(str1, (object)IsASC);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71c9);
			SqlParameter sqlParameter2 = new SqlParameter(str2, (object)partprocess);
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4);
			SqlParameter sqlParameter3 = new SqlParameter(str3, (object)tax1);
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df);
			return this.ADOFillReader(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str4, (object)tax2), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea), (object)tax3), null);
		}

		public SqlDataReader LoadEFT_PaymentsMTSEmail(int ID, int ReqType, decimal tax1, decimal tax2, decimal tax3)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71f5);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6917);
			SqlParameter sqlParameter1 = new SqlParameter(str2, (object)ReqType);
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4);
			SqlDataReader sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, (object)tax1), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df), (object)tax2), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea), (object)tax3), null, null);
			return sqlDataReader;
		}

		public SqlDataReader LoadEFT_PaymentsPrepay(int ID, decimal tax1, decimal tax2, decimal tax3)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x722a);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			return this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4), (object)tax1), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df), (object)tax2), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea), (object)tax3), null, null, null);
		}

		public DataSet LoadEFTPayments(int ID, decimal tax1, decimal tax2, decimal tax3, bool IsASC = false, int partprocess = 1)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x718d);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71bc);
			SqlParameter sqlParameter1 = new SqlParameter(str2, (object)IsASC);
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71c9);
			SqlParameter sqlParameter2 = new SqlParameter(str3, (object)partprocess);
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4);
			SqlParameter sqlParameter3 = new SqlParameter(str4, (object)tax1);
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df);
			SqlParameter sqlParameter4 = new SqlParameter(str5, (object)tax2);
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, new SqlParameter(str6, (object)tax3), null, null, null);
			return dataSet;
		}

		public DataSet LoadPackageBed(int ID, int StoreNUM, int bucketID, int ClientID, bool bSmallSalon)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbClient::LoadPackageBed(System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadPackageBed(System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean)
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

		public DataSet LoadPackageBedUpGrade(int ID, int StoreNUM, int bucketID, int ClientID)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbClient::LoadPackageBedUpGrade(System.Int32,System.Int32,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadPackageBedUpGrade(System.Int32,System.Int32,System.Int32,System.Int32)
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

		public DataSet RecurringList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7be0);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet ReferralList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cd4);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool RemoveClientPackage(int ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::RemoveClientPackage(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean RemoveClientPackage(System.Int32)
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

		public bool RemoveClientPackage_PrevEFTPayment(int PackageID, int ClientID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7349);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = PackageID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), SqlDbType.Int, 8);
			sqlParameter[1].Value = ClientID;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x735e), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveCardprocess(bool bapproved, string last4, decimal amt, string response, int ClientID, int EFTID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9127);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.NVarChar, 5);
			sqlParameter[0].Value = last4;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7477);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Decimal, 5);
			sqlParameter[1].Value = amt;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9134);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.NVarChar, 0xff);
			sqlParameter[2].Value = response;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[3].Value = ClientID;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9147);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[4].Value = EFTID;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9154);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Bit, 2);
			sqlParameter[5].Value = bapproved;
			try
			{
				int num = this.ADOFillNonQuery(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9169), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str6 = exception.ToString();
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x918e);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str6, MsgBoxStyle.OkOnly, str7);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveClientNotes(int NoteID, int ClientID, string Notes, string EmpName, bool IsNew, int LocNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::SaveClientNotes(System.Int32,System.Int32,System.String,System.String,System.Boolean,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveClientNotes(System.Int32,System.Int32,System.String,System.String,System.Boolean,System.Int32)
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

		public bool SaveClientPackage(int PackageID, int ClientID, string PackageName, DateTime DtExpire, double Qty, bool bFreeze, bool IsNew, int ClientPackageID, int StoreNum, bool IsEFT, DateTime dtStart, DateTime dtNext, double amt, int Recurring, bool bActivate_First_Use, DateTime? dtStartForced, int? Start_Type_ID, int? End_Type_ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::SaveClientPackage(System.Int32,System.Int32,System.String,System.DateTime,System.Double,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Boolean,System.DateTime,System.DateTime,System.Double,System.Int32,System.Boolean,System.Nullable`1<System.DateTime>,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveClientPackage(System.Int32,System.Int32,System.String,System.DateTime,System.Double,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Boolean,System.DateTime,System.DateTime,System.Double,System.Int32,System.Boolean,System.Nullable<System.DateTime>,System.Nullable<System.Int32>,System.Nullable<System.Int32>)
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

		public bool SaveEFT(int EFTID, DateTime dt, decimal amt, int IsAll, int clientpkgid, int dtDiff)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9147);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = EFTID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.DateTime, 4);
			sqlParameter[1].Value = dt;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7477);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = amt;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x94ac);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[3].Value = IsAll;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x94b9);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[4].Value = clientpkgid;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x94d2);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[5].Value = dtDiff;
			try
			{
				string connection = this.Connection;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x94e1);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str6, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str7 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str7, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public int SaveFromSale(string FirstName, string Middle, string LastName, string Home, string Work, string Cell, string Address, string City, string State, string Zip, string Email, DateTime dtBdate, string Refer, string Gender, string EXT, string Dlnumber, string DLState, string skintype, int StoreNum, string Country, int refid, string refname, string county)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbClient::SaveFromSale(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.DateTime,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.Int32,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 SaveFromSale(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.DateTime,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.Int32,System.String,System.String)
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

		public DataSet SearchClient(string FirstName, string MI, string LastName, string PhoneArea, string CellArea, string Zip, string Email, string MemberNumber, bool IsDemo)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbClient::SearchClient(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet SearchClient(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean)
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

		public DataSet SearchClientByFinger(int ID, bool IsDemo, DataSet ds)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7ae9);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d6b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)IsDemo), null, null, null, null, null, null, null);
				ds.Merge(dataSet1);
				dataSet = ds;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool SendTan(int RoomNumber, int ID, string Name, int PandSID, string PandSName, int Delay, int Dur, int ClientPackageID, bool bOverride, bool IsUpgradePackage, decimal UpgradeCharge, int StoreNum, int BucketID, decimal MinPointCost, string EmpName, int EmpID, string OverrideName, int OverrideID, int Drawer, int WaitID, bool IsCheckIn, bool IsMultiple, string ClientPackageIDs, decimal StoreCharge, bool bOutOfNetwork)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[25];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64d9);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = RoomNumber;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), SqlDbType.Int, 8);
			sqlParameter[1].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.NVarChar, 100);
			sqlParameter[2].Value = Name;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x677e);
			sqlParameter[3] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[3].Value = PandSID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7fb2);
			sqlParameter[4] = new SqlParameter(str3, SqlDbType.NVarChar, 60);
			sqlParameter[4].Value = PandSName;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8321);
			sqlParameter[5] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[5].Value = Delay;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8336);
			sqlParameter[6] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[6].Value = Dur;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7429);
			sqlParameter[7] = new SqlParameter(str6, SqlDbType.Int, 8);
			sqlParameter[7].Value = ClientPackageID;
			sqlParameter[8] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8349), SqlDbType.Bit, 2);
			sqlParameter[8].Value = bOverride;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x835e);
			sqlParameter[9] = new SqlParameter(str7, SqlDbType.Bit, 2);
			sqlParameter[9].Value = IsUpgradePackage;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6761);
			sqlParameter[10] = new SqlParameter(str8, SqlDbType.Decimal, 5);
			sqlParameter[10].Value = UpgradeCharge;
			sqlParameter[11] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65), SqlDbType.Int, 8);
			sqlParameter[11].Value = StoreNum;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6982);
			sqlParameter[12] = new SqlParameter(str9, SqlDbType.Int, 8);
			sqlParameter[12].Value = BucketID;
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8381);
			sqlParameter[13] = new SqlParameter(str10, SqlDbType.Decimal, 5);
			sqlParameter[13].Value = MinPointCost;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66fd);
			sqlParameter[14] = new SqlParameter(str11, SqlDbType.NVarChar, 60);
			sqlParameter[14].Value = EmpName;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0);
			sqlParameter[15] = new SqlParameter(str12, SqlDbType.Int, 8);
			sqlParameter[15].Value = EmpID;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x839c);
			sqlParameter[16] = new SqlParameter(str13, SqlDbType.NVarChar, 50);
			sqlParameter[16].Value = OverrideName;
			sqlParameter[17] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83b7), SqlDbType.Int, 8);
			sqlParameter[17].Value = OverrideID;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83ce);
			sqlParameter[18] = new SqlParameter(str14, SqlDbType.Int, 8);
			sqlParameter[18].Value = Drawer;
			string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83dd);
			sqlParameter[19] = new SqlParameter(str15, SqlDbType.Int, 8);
			sqlParameter[19].Value = WaitID;
			string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83ec);
			sqlParameter[20] = new SqlParameter(str16, SqlDbType.Bit, 2);
			sqlParameter[20].Value = IsMultiple;
			string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8403);
			sqlParameter[21] = new SqlParameter(str17, SqlDbType.Bit, 2);
			sqlParameter[21].Value = IsCheckIn;
			string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8418);
			sqlParameter[22] = new SqlParameter(str18, SqlDbType.NVarChar);
			sqlParameter[22].Value = ClientPackageIDs;
			sqlParameter[23] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x843b), SqlDbType.Bit, 2);
			sqlParameter[23].Value = bOutOfNetwork;
			string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8458);
			sqlParameter[24] = new SqlParameter(str19, SqlDbType.Decimal, 5);
			sqlParameter[24].Value = StoreCharge;
			try
			{
				Thread thread = new Thread((object cf4422554f7fcfbb55fa3fde234b7483e) => this.bgSendTan((SqlParameter[])cf4422554f7fcfbb55fa3fde234b7483e))
				{
					IsBackground = true
				};
				thread.Start(sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SendTanDirect(int RoomNumber, int ID, string Name, int PandSID, string PandSName, int Delay, int Dur, int ClientPackageID, bool bOverride, bool IsUpgradePackage, decimal UpgradeCharge, int StoreNum, int WaitID, int Drawer)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[14];
			sqlParameter[0] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x64d9), SqlDbType.Int, 8);
			sqlParameter[0].Value = RoomNumber;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[1] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[1].Value = ID;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e), SqlDbType.NVarChar, 100);
			sqlParameter[2].Value = Name;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x677e), SqlDbType.Int, 8);
			sqlParameter[3].Value = PandSID;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7fb2), SqlDbType.NVarChar, 60);
			sqlParameter[4].Value = PandSName;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8321);
			sqlParameter[5] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[5].Value = Delay;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8336);
			sqlParameter[6] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[6].Value = Dur;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7429);
			sqlParameter[7] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[7].Value = ClientPackageID;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8349);
			sqlParameter[8] = new SqlParameter(str4, SqlDbType.Bit, 2);
			sqlParameter[8].Value = bOverride;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x835e);
			sqlParameter[9] = new SqlParameter(str5, SqlDbType.Bit, 2);
			sqlParameter[9].Value = IsUpgradePackage;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6761);
			sqlParameter[10] = new SqlParameter(str6, SqlDbType.Decimal, 5);
			sqlParameter[10].Value = UpgradeCharge;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
			sqlParameter[11] = new SqlParameter(str7, SqlDbType.Int, 8);
			sqlParameter[11].Value = StoreNum;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83dd);
			sqlParameter[12] = new SqlParameter(str8, SqlDbType.Int, 8);
			sqlParameter[12].Value = WaitID;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x83ce);
			sqlParameter[13] = new SqlParameter(str9, SqlDbType.Int, 8);
			sqlParameter[13].Value = Drawer;
			try
			{
				Thread thread = new Thread((object cf4422554f7fcfbb55fa3fde234b7483e) => this.c3059d05a1813a6f9d4a3cadc62c399ff((SqlParameter[])cf4422554f7fcfbb55fa3fde234b7483e))
				{
					IsBackground = true
				};
				thread.Start(sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SendTanFromWait(int RoomNumber, int ID, string Name, int PandSID, string PandSName, int Delay, int Dur, int ClientPackageID, bool bOverride, bool IsUpgradePackage, decimal UpgradeCharge, int StoreNum, int BucketID, decimal MinPointCost, string EmpName, int EmpID, string OverrideName, int OverrideID, int Drawer, int ApptID, bool IsMultiple, int companyid, string ClientPackageIDs, decimal StoreCharge, bool bOutOfNetwork)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::SendTanFromWait(System.Int32,System.Int32,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean,System.Decimal,System.Int32,System.Int32,System.Decimal,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Int32,System.String,System.Decimal,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SendTanFromWait(System.Int32,System.Int32,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean,System.Decimal,System.Int32,System.Int32,System.Decimal,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Int32,System.String,System.Decimal,System.Boolean)
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

		public bool SendWait(int RoomNumber, int ID, string Name, int PandSID, string PandSName, int Delay, int Dur, int ClientPackageID, bool bOverride, bool IsUpgradePackage, decimal UpgradeCharge, int StoreNum, int BucketID, decimal MinPointCost, string EmpName, int EmpID, string OverrideName, int OverrideID, int AppointmentID, bool IsMultiple, int companyid, string ClientPackageIDs, int WaitID, decimal StoreCharge, bool bOutOfNetwork)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::SendWait(System.Int32,System.Int32,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean,System.Decimal,System.Int32,System.Int32,System.Decimal,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Boolean,System.Int32,System.String,System.Int32,System.Decimal,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SendWait(System.Int32,System.Int32,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Int32,System.Boolean,System.Boolean,System.Decimal,System.Int32,System.Int32,System.Decimal,System.String,System.Int32,System.String,System.Int32,System.Int32,System.Boolean,System.Int32,System.String,System.Int32,System.Decimal,System.Boolean)
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

		public DataSet SkinTypeList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d2c);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet StateList(string country)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b5a);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7680);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, country), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool StopVacationalHold(int clientid)
		{
			bool flag;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
				{
					Value = clientid
				};
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8239);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool TakeClientOffVacHold(DateTime dtstart, DateTime dtend, int clientid, string clientname, int locnum, string empname, string empnum)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[7];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81a0);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.DateTime, 5);
				sqlParameter[0].Value = dtstart;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81bb);
				sqlParameter[1] = new SqlParameter(str1, SqlDbType.DateTime, 5);
				sqlParameter[1].Value = dtend;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				sqlParameter[2] = new SqlParameter(str2, SqlDbType.Int, 8);
				sqlParameter[2].Value = clientid;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e);
				sqlParameter[3] = new SqlParameter(str3, SqlDbType.NVarChar, 0xff);
				sqlParameter[3].Value = clientname;
				sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81d4), SqlDbType.NVarChar, 0xff);
				sqlParameter[4].Value = empname;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81ef);
				sqlParameter[5] = new SqlParameter(str4, SqlDbType.NVarChar, 10);
				sqlParameter[5].Value = empnum;
				sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
				sqlParameter[6].Value = locnum;
				string connection = this.Connection;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8274);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str5, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str6 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str6, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public int totalCustomer()
		{
			int num;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8db2);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				int integer = Conversions.ToInteger(obj);
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public bool TransferPackage(int ID, int FromclientID, int ToclientID, decimal fromQty, decimal ToQty, int PackageID, DateTime dtExpiry, string PandSName, int PkgtypeID, string ClientNameFrom, string ClientNameTo, string EmpID, string EmpName, int LocNum, int Start_Type_ID, int End_Type_ID, DateTime? dtForced, int ExpiryMonths, int ExpiryDays, bool bRollover, bool bActivate_First_Use)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::TransferPackage(System.Int32,System.Int32,System.Int32,System.Decimal,System.Decimal,System.Int32,System.DateTime,System.String,System.Int32,System.String,System.String,System.String,System.String,System.Int32,System.Int32,System.Int32,System.Nullable`1<System.DateTime>,System.Int32,System.Int32,System.Boolean,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean TransferPackage(System.Int32,System.Int32,System.Int32,System.Decimal,System.Decimal,System.Int32,System.DateTime,System.String,System.Int32,System.String,System.String,System.String,System.String,System.Int32,System.Int32,System.Int32,System.Nullable<System.DateTime>,System.Int32,System.Int32,System.Boolean,System.Boolean)
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

		public bool Update_fingerPrint(int Client_ID, byte[] blob_write, string blobID, int locnum, int drawernum)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[5];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = Client_ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x967e);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Image, checked((int)blob_write.Length));
			if (blob_write == null)
			{
				sqlParameter[1].Value = null;
			}
			else if (checked((int)blob_write.Length) != 2)
			{
				sqlParameter[1].Value = blob_write;
			}
			else
			{
				sqlParameter[1].Value = null;
			}
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9689);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.NVarChar, 100);
			sqlParameter[2].Value = blobID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[3].Value = locnum;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9698);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[4].Value = drawernum;
			try
			{
				string connection = this.Connection;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x96af);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str5, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str6 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str6, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool UpdateAppointment(int ID, int LocNum, int dur, int companyid)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::UpdateAppointment(System.Int32,System.Int32,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean UpdateAppointment(System.Int32,System.Int32,System.Int32,System.Int32)
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

		public bool UpdateAppointmentByID(int ID, int RoomNumber, int LocNum, int dur, bool isSendDown, int companyid, DateTime Start_date)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::UpdateAppointmentByID(System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean,System.Int32,System.DateTime)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean UpdateAppointmentByID(System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean,System.Int32,System.DateTime)
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

		public int UpdateClient(string ID, string FName, string MName, string LName, string Address, string City, string State, string Zip, string EMail, string PhoneHome, string PhoneWork, string PhoneCell, bool opt, int skintype, DateTime dtDOB, string DLNumber, string DLState, int Referral, string SpecialNote, string MemberNumber, DateTime dtRelease, DateTime dtContract, bool AllowEMail, bool AllowDirectMail, string ext, bool bEFTCC, bool bEFTChecking, string CardNumber, string nameOnCard, DateTime dtExpiry, string billingAddress, string eftzip, string routing, string account, Bitmap img, Bitmap smallImage, int StoreNumber, decimal MinRemain, decimal PointRemain, bool IsPictureExist, int PictureId, string Country, string txtState, int refID, string refName, DateTime dtconsent, int comanyid, string EFT_Checking_Transit, string EFT_Checking_Institution, string EFT_Checking_Payor_FName, string EFT_Checking_Payor_LName, int EFT_Checking_CType, bool bAllowChecks, bool bAllowCreditCards, bool bAllowDebitCards, bool bAllowOnlineAppointments, bool bOAB_Synced, int OAB_ID)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbClient::UpdateClient(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Int32,System.DateTime,System.String,System.String,System.Int32,System.String,System.String,System.DateTime,System.DateTime,System.Boolean,System.Boolean,System.String,System.Boolean,System.Boolean,System.String,System.String,System.DateTime,System.String,System.String,System.String,System.String,System.Drawing.Bitmap,System.Drawing.Bitmap,System.Int32,System.Decimal,System.Decimal,System.Boolean,System.Int32,System.String,System.String,System.Int32,System.String,System.DateTime,System.Int32,System.String,System.String,System.String,System.String,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 UpdateClient(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Int32,System.DateTime,System.String,System.String,System.Int32,System.String,System.String,System.DateTime,System.DateTime,System.Boolean,System.Boolean,System.String,System.Boolean,System.Boolean,System.String,System.String,System.DateTime,System.String,System.String,System.String,System.String,System.Drawing.Bitmap,System.Drawing.Bitmap,System.Int32,System.Decimal,System.Decimal,System.Boolean,System.Int32,System.String,System.String,System.Int32,System.String,System.DateTime,System.Int32,System.String,System.String,System.String,System.String,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32)
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

		public bool UpdateClientEFT(int ID, bool bEFTCC, bool bEFTChecking, string CardNumber, string nameOnCard, DateTime dtExpiry, string billingAddress, string zip, string routing, string account, string EFT_Checking_Transit, string EFT_Checking_Institution, string EFT_Checking_Payor_FName, string EFT_Checking_Payor_LName, int EFT_Checking_CType)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[15];
			DbLocation dbLocation = new DbLocation();
			dbLocation.SetCryptValues();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x896f);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Bit, 2);
			sqlParameter[1].Value = bEFTCC;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x897e), SqlDbType.Bit, 2);
			sqlParameter[2].Value = bEFTChecking;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8999);
			sqlParameter[3] = new SqlParameter(str2, SqlDbType.NVarChar, 100);
			SqlParameter sqlParameter1 = sqlParameter[3];
			Crypt2 crypt = dbLocation.Crypt;
			string str3 = crypt.EncryptStringENC(CardNumber);
			sqlParameter1.Value = str3;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x89b0), SqlDbType.NVarChar, 100);
			SqlParameter sqlParameter2 = sqlParameter[4];
			string str4 = dbLocation.Crypt.EncryptStringENC(nameOnCard);
			sqlParameter2.Value = str4;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f9f);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.DateTime, 4);
			sqlParameter[5].Value = dtExpiry;
			sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x89c7), SqlDbType.NVarChar, 50);
			sqlParameter[6].Value = billingAddress;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8c48);
			sqlParameter[7] = new SqlParameter(str6, SqlDbType.NVarChar, 10);
			sqlParameter[7].Value = zip;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x89f5);
			sqlParameter[8] = new SqlParameter(str7, SqlDbType.NVarChar, 100);
			SqlParameter sqlParameter3 = sqlParameter[8];
			Crypt2 crypt2 = dbLocation.Crypt;
			string str8 = crypt2.EncryptStringENC(routing);
			sqlParameter3.Value = str8;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8a06);
			sqlParameter[9] = new SqlParameter(str9, SqlDbType.NVarChar, 100);
			SqlParameter sqlParameter4 = sqlParameter[9];
			string str10 = dbLocation.Crypt.EncryptStringENC(account);
			sqlParameter4.Value = str10;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ae3);
			sqlParameter[10] = new SqlParameter(str11, SqlDbType.NVarChar, 50);
			sqlParameter[10].Value = EFT_Checking_Transit;
			sqlParameter[11] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8b0e), SqlDbType.NVarChar, 50);
			sqlParameter[11].Value = EFT_Checking_Institution;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8b41);
			sqlParameter[12] = new SqlParameter(str12, SqlDbType.NVarChar, 50);
			sqlParameter[12].Value = EFT_Checking_Payor_FName;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8b74);
			sqlParameter[13] = new SqlParameter(str13, SqlDbType.NVarChar, 50);
			sqlParameter[13].Value = EFT_Checking_Payor_LName;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ba7);
			sqlParameter[14] = new SqlParameter(str14, SqlDbType.Int, 8);
			sqlParameter[14].Value = EFT_Checking_CType;
			try
			{
				string connection = this.Connection;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8c51);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str15, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool UpdateClientRewards(int ClientID, decimal amount)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x73a9);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Decimal);
			sqlParameter[0].Value = amount;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = ClientID;
			try
			{
				try
				{
					string connection = this.Connection;
					string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x73b8);
					this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str2, sqlParameter);
					flag = true;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				sqlParameter = null;
			}
			return flag;
		}

		public bool UpdateClientVisit(int ID, int Length)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbClient::UpdateClientVisit(System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean UpdateClientVisit(System.Int32,System.Int32)
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

		public bool VacationalHold(int clientid, DateTime dtstart, DateTime dtend, bool bVac)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[4];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
				sqlParameter[0].Value = clientid;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6f29);
				sqlParameter[1] = new SqlParameter(str1, SqlDbType.DateTime, 4);
				sqlParameter[1].Value = dtstart;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6f3a);
				sqlParameter[2] = new SqlParameter(str2, SqlDbType.DateTime, 4);
				sqlParameter[2].Value = dtend;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8174);
				sqlParameter[3] = new SqlParameter(str3, SqlDbType.Bit, 2);
				sqlParameter[3].Value = bVac;
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x817f);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str5 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str5, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool VacationalHoldStart(int clientid, string clientname, DateTime dtstart, DateTime dtend, int locnum, string empname, string empnum)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[7];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
				sqlParameter[0].Value = clientid;
				sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e), SqlDbType.NVarChar, 0xff);
				sqlParameter[1].Value = clientname;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81a0);
				sqlParameter[2] = new SqlParameter(str1, SqlDbType.DateTime, 5);
				sqlParameter[2].Value = dtstart;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81bb);
				sqlParameter[3] = new SqlParameter(str2, SqlDbType.DateTime, 5);
				sqlParameter[3].Value = dtend;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81d4);
				sqlParameter[4] = new SqlParameter(str3, SqlDbType.NVarChar, 0xff);
				sqlParameter[4].Value = empname;
				sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x81ef), SqlDbType.NVarChar, 10);
				sqlParameter[5].Value = empnum;
				sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
				sqlParameter[6].Value = locnum;
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x820e);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str5 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str5, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
	}
}