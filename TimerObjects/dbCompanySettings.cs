using A;
using Microsoft.ApplicationBlocks.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace TimerObjects
{
	public class dbCompanySettings : SqlBase
	{
		private SqlParameter[] cd955ea14127f673c1e77e436c7b2d31e;

		public dbCompanySettings()
		{
		}

		public bool Add_TransLog(string EmpNum, string EmpName, string Area, string Action, bool bSuccess, int LocNum)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1989);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.NVarChar, 20);
			sqlParameter[0].Value = EmpNum;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1998);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.NVarChar, 50);
			sqlParameter[1].Value = EmpName;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19a9);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.NVarChar, 0xff);
			sqlParameter[2].Value = Area;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19b4), SqlDbType.NVarChar, 0xff);
			sqlParameter[3].Value = Action;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19c3), SqlDbType.Bit, 2);
			sqlParameter[4].Value = bSuccess;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19d6);
			sqlParameter[5] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[5].Value = LocNum;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x19e5);
				int num = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
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

		public bool InsertQBData(string QBID, DateTime QBdt, DateTime dtStart, DateTime dtEnd, DateTime dtSale, decimal Sub_Total, decimal Sales_Tax, decimal Sales_Tax2, decimal Sales_Tax3)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[9];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a04);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = QBID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a0f);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.DateTime, 5);
			sqlParameter[1].Value = QBdt;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a1a);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.DateTime, 5);
			sqlParameter[2].Value = dtStart;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a2b);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.DateTime, 5);
			sqlParameter[3].Value = dtEnd;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a38);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.DateTime, 5);
			sqlParameter[4].Value = dtSale;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a47);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Decimal, 5);
			sqlParameter[5].Value = Sub_Total;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a5c);
			sqlParameter[6] = new SqlParameter(str6, SqlDbType.Decimal, 5);
			sqlParameter[6].Value = Sales_Tax;
			sqlParameter[7] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a71), SqlDbType.Decimal, 5);
			sqlParameter[7].Value = Sales_Tax2;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a88);
			sqlParameter[8] = new SqlParameter(str7, SqlDbType.Decimal, 5);
			sqlParameter[8].Value = Sales_Tax3;
			try
			{
				string connection = this.Connection;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1a9f);
				int num = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, str8, sqlParameter);
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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public DataSet Load(string MAC_Address, string Processor_ID, string Computer_Model, bool bUSA)
		{
			// 
			// Current member / type: System.Data.DataSet TimerObjects.dbCompanySettings::Load(System.String,System.String,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet Load(System.String,System.String,System.String,System.Boolean)
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

		public bool LoadCompanySuccess(string MAC_Address, string Processor_ID, string Computer_Model, bool bUSA)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7f);
				SqlParameter[] sqlParameter = new SqlParameter[4];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xeaa);
				sqlParameter[0] = new SqlParameter(str1, MAC_Address);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xec3);
				sqlParameter[1] = new SqlParameter(str2, Processor_ID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xede);
				sqlParameter[2] = new SqlParameter(str3, Computer_Model);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xefd);
				sqlParameter[3] = new SqlParameter(str4, (object)bUSA);
				DataSet dataSet = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, str, sqlParameter);
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

		public bool RestoreDB(string dir)
		{
			bool flag;
			try
			{
				string connectionMaster = this.ConnectionMaster;
				string[] strArrays = new string[7];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1390);
				strArrays[0] = str;
				strArrays[1] = dir;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x147a);
				strArrays[2] = str1;
				strArrays[3] = dir;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14c3);
				strArrays[4] = str2;
				strArrays[5] = dir;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1516);
				strArrays[6] = str3;
				SqlHelper.ExecuteNonQuery(connectionMaster, CommandType.Text, string.Concat(strArrays));
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

		public bool SaveNewComanyInfo(string MAC_Address, string Processor_ID, string Computer_Model)
		{
			// 
			// Current member / type: System.Boolean TimerObjects.dbCompanySettings::SaveNewComanyInfo(System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveNewComanyInfo(System.String,System.String,System.String)
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
	}
}