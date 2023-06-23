using A;
using ErrorHandler;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SqlLibrary
{
	public class dbCompanySettings : SqlBase
	{
		private SqlParameter[] cd955ea14127f673c1e77e436c7b2d31e;

		public string bCopyCompanysettingsAlert;

		public dbCompanySettings()
		{
		}

		public bool Add_TransLog(string EmpNum, string EmpName, string Area, string Action, bool bSuccess, int LocNum)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e79), SqlDbType.NVarChar, 20), null, null, null, null, null };
			sqlParameter[0].Value = EmpNum;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66fd);
			sqlParameter[1] = new SqlParameter(str, SqlDbType.NVarChar, 50);
			sqlParameter[1].Value = EmpName;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e88);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.NVarChar, 0xff);
			sqlParameter[2].Value = Area;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e93);
			sqlParameter[3] = new SqlParameter(str2, SqlDbType.NVarChar, 0xff);
			sqlParameter[3].Value = Action;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8eb2);
			sqlParameter[4] = new SqlParameter(str3, SqlDbType.Bit, 2);
			sqlParameter[4].Value = bSuccess;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[5] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[5].Value = LocNum;
			try
			{
				string connection = this.Connection;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ec5);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str5, sqlParameter);
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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool BackUpDB(int day, DateTime time, string dir, bool Isnow)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbCompanySettings::BackUpDB(System.Int32,System.DateTime,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean BackUpDB(System.Int32,System.DateTime,System.String,System.Boolean)
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

		public bool BackupDB_PreLoad(string strFileName, string strFileDesc)
		{
			bool flag;
			try
			{
				string connectionMaster = this.ConnectionMaster;
				string[] database = new string[7];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa5d1);
				database[0] = str;
				database[1] = this.Database;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa5f4);
				database[2] = str1;
				database[3] = strFileName;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa60d);
				database[4] = str2;
				database[5] = strFileDesc;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa64e);
				database[6] = str3;
				string str4 = string.Concat(database);
				int num = this.ADOFillNonQuery(connectionMaster, CommandType.Text, str4, null, null, null, null, null, null, null);
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

		public DataSet Backupstatus()
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbCompanySettings::Backupstatus()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet Backupstatus()
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

		public bool BulbHourLow(int LocNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbCompanySettings::BulbHourLow(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean BulbHourLow(System.Int32)
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

		private object c1bc28cd475801d59c351a27abc5e6655(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			// 
			// Current member / type: System.Object SqlLibrary.dbCompanySettings::c1bc28cd475801d59c351a27abc5e6655(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Object c1bc28cd475801d59c351a27abc5e6655(System.Object)
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

		private object c3bc900a99de27ac4c6d81d37133ad7ac(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			// 
			// Current member / type: System.Object SqlLibrary.dbCompanySettings::c3bc900a99de27ac4c6d81d37133ad7ac(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Object c3bc900a99de27ac4c6d81d37133ad7ac(System.Object)
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

		private object c44ed1fb33af52de6b09ff496e8676f13(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			// 
			// Current member / type: System.Object SqlLibrary.dbCompanySettings::c44ed1fb33af52de6b09ff496e8676f13(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Object c44ed1fb33af52de6b09ff496e8676f13(System.Object)
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

		private object c54053c054c594249ed9f0deaf9429e33(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			// 
			// Current member / type: System.Object SqlLibrary.dbCompanySettings::c54053c054c594249ed9f0deaf9429e33(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Object c54053c054c594249ed9f0deaf9429e33(System.Object)
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

		private object cc39cc2964e42b4b6a382e8d8c36c3865(object ce5f8f2f2cdceaf36fe8cd52bf4c9f139)
		{
			// 
			// Current member / type: System.Object SqlLibrary.dbCompanySettings::cc39cc2964e42b4b6a382e8d8c36c3865(System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Object cc39cc2964e42b4b6a382e8d8c36c3865(System.Object)
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

		public bool checkDBBackupSpace()
		{
			bool flag;
			try
			{
				DataSet dataSet = new DataSet();
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe652);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				DataTableCollection tables = dataSet.Tables;
				DataRowCollection rows = tables[0].Rows;
				DataRow item = rows[0];
				object obj = item[1];
				decimal num = Conversions.ToDecimal(obj);
				DataTableCollection dataTableCollection = dataSet.Tables;
				DataTable dataTable = dataTableCollection[1];
				DataRowCollection dataRowCollection = dataTable.Rows;
				DataRow dataRow = dataRowCollection[0];
				object item1 = dataRow[1];
				string str1 = item1.ToString();
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe673);
				string str3 = str1.Replace(str2, "");
				decimal num1 = Conversions.ToDecimal(str3);
				flag = (decimal.Compare(num, num1) > 0 ? true : false);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public string CheckMPSAuth(string phone)
		{
			string str;
			try
			{
				string str1 = this[false];
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe678);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
				object obj = this.ADOFillScalar(str1, CommandType.StoredProcedure, str2, new SqlParameter(str3, phone), null, null, null, null, null, null, null, null);
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				str = Conversions.ToString(objectValue);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xabd4);
				str = str4;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public bool clearProcessingLog()
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe9ca);
				int num = this.ADOFillNonQuery(connection, CommandType.Text, str, null, null, null, null, null, null, null);
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

		public DataSet CountofDailySummaries(bool NewClients, bool Visits, bool Refund, bool sales, int storeNum)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbCompanySettings::CountofDailySummaries(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet CountofDailySummaries(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32)
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

		public DataSet CountryList()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b79);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
		}

		public DataSet DashBoard(DateTime dtStart, DateTime dtEnd, int LocNum)
		{
			DataSet dataSet;
			SqlParameter[] sqlParameter = new SqlParameter[3];
			try
			{
				try
				{
					string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457);
					sqlParameter[0] = new SqlParameter(str, SqlDbType.DateTime);
					sqlParameter[0].Value = dtStart;
					string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
					sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int);
					sqlParameter[1].Value = LocNum;
					sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579), SqlDbType.DateTime);
					sqlParameter[2].Value = dtEnd;
					DataSet dataSet1 = this.ADOFilldataset(this.Connection, CommandType.Text, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd97b), sqlParameter);
					dataSet = dataSet1;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					dataSet = null;
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				sqlParameter = null;
			}
			return dataSet;
		}

		public bool DeleteAll_EFT_CC_CHK_Data(int store)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa69d);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)store), null, null, null, null, null, null);
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

		public bool DeleteAppointments(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdd8c);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684), (object)dt);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)LocNum), null, null, null, null, null);
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

		public bool DeleteEFTCC(int clientid, string cc, string cctype, int Day, int locnum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe856);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)clientid);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe881);
				SqlParameter sqlParameter1 = new SqlParameter(str2, cc);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe888);
				SqlParameter sqlParameter2 = new SqlParameter(str3, cctype);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe897);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str4, (object)Day), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)locnum), null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str5 = exception.ToString();
				Interaction.MsgBox(str5, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public DataSet DeleteInActClient(DateTime dtDelete, bool bDelete, int LocNum)
		{
			DataSet dataSet;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xde6a), SqlDbType.Date, 20), null, null };
			sqlParameter[0].Value = dtDelete;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xde7b);
			sqlParameter[1] = new SqlParameter(str, SqlDbType.Bit, 2);
			sqlParameter[1].Value = bDelete;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[2].Value = LocNum;
			try
			{
				string connection = this.Connection;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xde92);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str2, sqlParameter);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str3 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str3, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool DeleteInActPkg(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xde10);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)dt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
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

		public bool DeleteMaintenance(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xddad);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684), (object)dt);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)LocNum), null, null, null, null, null);
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

		public bool DeleteNotes(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdded);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)dt), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum), null, null, null, null, null);
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

		public bool DeletePrivUse(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdec3);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)dt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
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

		public bool DeleteSale(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf32);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)dt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
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

		public bool DeleteTimeInOut(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdeea);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)dt), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum), null, null, null, null, null);
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

		public bool DeleteUV(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xddd0);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)dt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
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

		public bool DeleteVisitHist(int dt, int LocNum)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xde3f);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)dt);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
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

		public DataSet EFTYearList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd9e2);
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

		public DataSet EmployeeList(bool bAllowAll)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xda49);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			dataSet = dataSet1;
			if (bAllowAll)
			{
				DataTableCollection tables = dataSet.Tables;
				DataTable item = tables[0];
				DataRow dataRow = item.NewRow();
				DataRow dataRow1 = dataRow;
				dataRow1[0] = -1;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd974);
				dataRow1[1] = str1;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd974);
				dataRow1[2] = str2;
				DataTableCollection dataTableCollection = dataSet.Tables;
				DataTable dataTable = dataTableCollection[0];
				DataRowCollection rows = dataTable.Rows;
				rows.InsertAt(dataRow1, 0);
				dataRow1 = null;
			}
			return dataSet;
		}

		public DataTable getAgeRange()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xda05);
			DataTableCollection tables = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null).Tables;
			DataTable item = tables[0];
			return item;
		}

		public DataSet getBedList(int LocNum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf6e), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum), null, null, null, null, null, null, null, null);
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

		public string GetCompanyGUID(int OAB_ID)
		{
			// 
			// Current member / type: System.String SqlLibrary.dbCompanySettings::GetCompanyGUID(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String GetCompanyGUID(System.Int32)
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

		public int GetCountforProgressBar(string scalarname, int id, bool IsSrv, bool IsPrd, bool IsPkg, int RoomNum = 0)
		{
			int integer;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe76a);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe78d);
				SqlParameter sqlParameter = new SqlParameter(str1, scalarname);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)id);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7a4);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)IsSrv);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7b1);
				SqlParameter sqlParameter3 = new SqlParameter(str4, (object)IsPrd);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7be);
				SqlParameter sqlParameter4 = new SqlParameter(str5, (object)IsPkg);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, new SqlParameter(str6, (object)RoomNum), null, null, null);
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

		public DateTime getCurrentDatetime(int storeNum)
		{
			DateTime dateTime;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe699);
				string str1 = Conversions.ToString(storeNum);
				object obj = this.ADOFillScalar(connection, CommandType.Text, string.Concat(str, str1, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe743)), null, null, null, null, null, null, null, null, null);
				DateTime date = Conversions.ToDate(obj);
				dateTime = date;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				DateTime today = DateAndTime.Today;
				DateTime date1 = today.Date;
				dateTime = date1;
				ProjectData.ClearProjectError();
			}
			return dateTime;
		}

		public DataSet GetCustomerEmailList(string parm1, int LocNum, string parm2 = "", string parm3 = "")
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd8b7);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd890);
				SqlParameter sqlParameter = new SqlParameter(str1, parm1);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd89d), parm2);
				SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd8aa), parm3);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet GetDeleteEFTCC_Clients(int num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe815);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8f0c), (object)num), null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public int[] GetDemoTop20(string demo)
		{
			// 
			// Current member / type: System.Int32[] SqlLibrary.dbCompanySettings::GetDemoTop20(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32[] GetDemoTop20(System.String)
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

		public int GetLastBackupDate()
		{
			int integer;
			try
			{
				object obj = this.ADOFillScalar(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe8a0), null, null, null, null, null, null, null, null, null);
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

		public bool GetNonSaleProduct(DateTime dtstart, DateTime dtend)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdfbb);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)dtstart);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6f3a);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)dtend), null, null, null, null, null);
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

		public DataSet GetQBData(DateTime startdate, DateTime enddate, int Locnum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe8c9);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)startdate);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)enddate);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, (object)Locnum), null, null, null, null, null, null);
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

		public DataSet GetTimeClockQBData(DateTime startdate, DateTime enddate, int Locnum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe8e2);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457), (object)startdate);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)enddate), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)Locnum), null, null, null, null, null, null);
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

		public int GetTotal(string cform, int LocNum)
		{
			int num;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf89);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdfa2);
				SqlParameter sqlParameter = new SqlParameter(str1, cform);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null, null, null));
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

		public DataSet getZipCode(int LocNum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf53);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)LocNum), null, null, null, null, null, null, null, null);
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

		public DataSet HomeStoreList(bool bAllowALL = false)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbCompanySettings::HomeStoreList(System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet HomeStoreList(System.Boolean)
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

		public bool InsertQBData(string QBID, DateTime QBdt, DateTime dtStart, DateTime dtEnd, int locnum)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe986), SqlDbType.Text, 8), null, null, null, null };
			sqlParameter[0].Value = QBID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe991), SqlDbType.DateTime, 5);
			sqlParameter[1].Value = QBdt;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457), SqlDbType.DateTime, 5);
			sqlParameter[2].Value = dtStart;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579), SqlDbType.DateTime, 5);
			sqlParameter[3].Value = dtEnd;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe99c);
			sqlParameter[4] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[4].Value = locnum;
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe9ab);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter);
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

		public bool InventoryLow(int LocNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbCompanySettings::InventoryLow(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean InventoryLow(System.Int32)
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

		public DataSet ListPackages(bool Isactive)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7bbd);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x787a);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Isactive), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet ListPostalCode()
		{
			DataSet dataSet = this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd92c), null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet ListProducts()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd909);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet listServices()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd8e6);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public DataSet Load(string MAC_Address, string Processor_ID, string Computer_Model, bool bUSA)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbCompanySettings::Load(System.String,System.String,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
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
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9757);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9782);
				SqlParameter sqlParameter = new SqlParameter(str1, MAC_Address);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x979b);
				SqlParameter sqlParameter1 = new SqlParameter(str2, Processor_ID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x97b6);
				SqlParameter sqlParameter2 = new SqlParameter(str3, Computer_Model);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x97d5);
				DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str4, (object)bUSA), null, null, null, null, null);
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

		public DataSet ReferralTypesList()
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xda6e), null, null, null, null, null, null, null, null, null);
			dataSet = dataSet1;
			DataTableCollection tables = dataSet.Tables;
			DataTable item = tables[0];
			DataRow dataRow = item.NewRow();
			DataRow dataRow1 = dataRow;
			dataRow1[0] = -1;
			dataRow1[1] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd974);
			DataTableCollection dataTableCollection = dataSet.Tables;
			DataTable dataTable = dataTableCollection[0];
			DataRowCollection rows = dataTable.Rows;
			rows.InsertAt(dataRow1, 0);
			dataRow1 = null;
			return dataSet;
		}

		public bool RestoreDB(string dir)
		{
			bool flag;
			try
			{
				string connectionMaster = this.ConnectionMaster;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9ece);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9fb2);
				int num = this.ADOFillNonQuery(connectionMaster, CommandType.Text, string.Concat(str, dir, str1), null, null, null, null, null, null, null);
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

		public DataSet RoomList(int store)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdac4);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)store), null, null, null, null, null, null, null, null);
			return dataSet1;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool Save(int ID, int Store_Number, int Drawer_Number, string Name, string Address, string City, string WebAddress, string State, string Zip, string Email, string Phone, string MAC_Address, string Processor_ID, string Computer_Model, bool Emp_Sec, decimal Tax1, decimal Tax2, decimal Tax3, string Monday_Open, string Monday_Close, bool Monday_bClosed, string Tuesday_Open, string Tuesday_Close, bool Tuesday_bClosed, string Wednesday_Open, string Wednesday_Close, bool Wednesday_bClosed, string Thursday_Open, string Thursday_Close, bool Thursday_bClosed, string Friday_Open, string Friday_Close, bool Friday_bClosed, string Saturday_Open, string Saturday_Close, bool Saturday_bClosed, string Sunday_Open, string Sunday_Close, bool Sunday_bClosed, bool bEnforce24HourRule, bool bAllowClientFingerPrint, bool bAllowEmployeeID, bool bRequireClientPhoto, bool bTaxablePackages, bool bTaxableProducts, bool bTaxableServices, int DefaultTanningDuration, bool bUseDiscountProtection, decimal MaxDiscountPercentage, string ReceiptPrinterName, string ReportPrinterName, bool bPrintLogoOnReceipts, bool bBCScanner, bool bMagReader, bool bFingerprintScanner, bool bWebCamera, int Cash_Drawer_Types, string Cash_Drawer_Port, string Cash_Drawer_Baud, int Keytag_Type, string Keytag_Port, string Customer_Display_Name, int CC_Processor_Type, string CC_Merchant_Number, string CC_Processor_Code, string CC_TimeOut, string CC_Text1, string CC_Text2, string CC_EXE_Location, bool CC_bNumberRequired, bool CC_bAuthRequired, string EMail_Address, string SMTP_Server, string SMTP_Port, bool bSMTP_Authentication_Required, string SMTP_Username, string SMTP_Password, string SMTP_Authentication_Types, string QB_File_Location, string QB_Undeposited_Funds_Account, string QB_Sales_Tax_Payable_Account, string QB_Sales_Income_Account, string QB_Sales_Tax_Payable_Vendor, string Release_Form_Location, int BCScanner_Type, string BCScanner_Port, decimal MiniTanAge, bool ShowNews, bool bAllowEmployeeFingerPrint, bool bSSL, string Country, bool bPin, string Pinport, string tax1name, string tax2name, string tax3name, bool Tax1Up, bool Tax2Up, bool Tax3Up, string CashierName, string CashierPassword, string pserver, string bserver, string wspwd, string txtConsentTemplateLocation, string txtContractTemplateLocation, decimal txtParentPresentAge, bool chkPwdRequireMixed, bool chkPwdRequireAlphuNum, int txtPwdMinLength, int txtCCDaysRetained, bool chkBackupNotify, int mtxtBackupDays, bool chkPrintTipBox, bool chkProductTax1, bool chkProductTax2, bool chkProductTax3, bool chkServiceTax1, bool chkServiceTax2, bool chkServiceTax3, bool chkStartTimerQueue, string timername, string QB_Tax2_Payable_Account, string QB_Tax2_Payable_Vendor, string QB_Tax3_Payable_Account, string QB_Tax3_Payable_Vendor, string ENotice_Send_To, string ENotice_CC_To, bool ENotice_bDirtyBed, short ENotice_MaxMins, short ENotice_Delay, bool ENotice_bSummaries, string ENotice_SendTime, bool ENotice_bNewClients, bool ENotice_bVisits, bool ENotice_bRefund, bool ENotice_bSales, string Twitter_AuthCode, string Twitter_PinCode, string Twitter_ScreenName, string Twitter_UserID, string Twitter_AccessKey, string Twitter_AccessSecret, string Facebook_accesstoken, string Facebook_UserID, string Facebook_UserName, string Facebook_UserLink, bool Twitter_bSendInvite, bool Facebook_bSendInvite, short Appointment_Duration_Type, bool bRequirePasswordExpiration, int ACH_Processor_Type, string ACH_Merchant, decimal ACH_NSF_Fees, string ACH_Files_Location, decimal CC_NSF_Fees, bool bEncrypt, string ACHHostName, string ACHIPPort, bool bCouponAfterTax, string strReceiptFooter, bool bAppointmentEmail, bool bRounding, string YelpLink, bool bYelpSendAfterTan, bool bYelpSendNewClients, short iYelpDelay, int OAB_ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbCompanySettings::Save(System.Int32,System.Int32,System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Decimal,System.Decimal,System.Decimal,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Boolean,System.Decimal,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.Decimal,System.Boolean,System.Boolean,System.Boolean,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Decimal,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Boolean,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Int16,System.Int16,System.Boolean,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.Int16,System.Boolean,System.Int32,System.String,System.Decimal,System.String,System.Decimal,System.Boolean,System.String,System.String,System.Boolean,System.String,System.Boolean,System.Boolean,System.String,System.Boolean,System.Boolean,System.Int16,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean Save(System.Int32,System.Int32,System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Decimal,System.Decimal,System.Decimal,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Boolean,System.Decimal,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.String,System.String,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32,System.String,System.Decimal,System.Boolean,System.Boolean,System.Boolean,System.String,System.Boolean,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Decimal,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Boolean,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Int16,System.Int16,System.Boolean,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,System.Boolean,System.Int16,System.Boolean,System.Int32,System.String,System.Decimal,System.String,System.Decimal,System.Boolean,System.String,System.String,System.Boolean,System.String,System.Boolean,System.Boolean,System.String,System.Boolean,System.Boolean,System.Int16,System.Int32)
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
		public bool SaveNewCompanyInfo(string MAC_Address, string Processor_ID, string Computer_Model)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbCompanySettings::SaveNewCompanyInfo(System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveNewCompanyInfo(System.String,System.String,System.String)
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
		public bool SaveZout(DateTime zout, string MAC_Address, string Processor_ID, string Computer_Model, int locnum, int drawer)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd810);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.DateTime, 4);
			sqlParameter[0].Value = zout;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = locnum;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa715);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.NVarChar, 50);
			sqlParameter[2].Value = MAC_Address;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa72c);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.NVarChar, 50);
			sqlParameter[3].Value = Processor_ID;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x854a);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[4].Value = drawer;
			sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x97b6), SqlDbType.NVarChar, 50);
			sqlParameter[5].Value = Computer_Model;
			try
			{
				string connection = this.Connection;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd81b);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str5, sqlParameter);
				flag = true;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				AssemblyInfo info = _cef4fffd9795b6af60f35514532347eb4.Info;
				string productName = info.ProductName;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd836);
				string[] mACAddress = new string[] { MAC_Address, null, null, null, null };
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9cda);
				mACAddress[1] = str7;
				mACAddress[2] = Processor_ID;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9cda);
				mACAddress[3] = str8;
				mACAddress[4] = Computer_Model;
				string str9 = string.Concat(mACAddress);
				(new frmError(exception, productName, str6, str9)).ShowDialog();
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool ShrinkDB()
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdf15);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null);
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

		public DataSet SkinTypesList()
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xda9d);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			dataSet = dataSet1;
			DataRow dataRow = dataSet.Tables[0].NewRow();
			DataRow dataRow1 = dataRow;
			dataRow1[0] = -1;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd974);
			dataRow1[1] = str1;
			dataSet.Tables[0].Rows.InsertAt(dataRow1, 0);
			dataRow1 = null;
			return dataSet;
		}

		public DataSet SQLServerMemory()
		{
			DataSet dataSet;
			DataSet dataSet1 = new DataSet();
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xdb04);
				DataSet dataSet2 = this.ADOFilldataset(connection, CommandType.Text, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet2;
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
			return this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b5a), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7680), country), null, null, null, null, null, null, null, null);
		}

		public DataSet StoreList(bool bAllowALL = false)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd955);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			dataSet = dataSet1;
			if (bAllowALL)
			{
				DataRow dataRow = dataSet.Tables[0].NewRow();
				DataRow dataRow1 = dataRow;
				dataRow1[0] = -1;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd974);
				dataRow1[1] = str1;
				DataTableCollection tables = dataSet.Tables;
				DataTable item = tables[0];
				DataRowCollection rows = item.Rows;
				rows.InsertAt(dataRow1, 0);
				dataRow1 = null;
			}
			return dataSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool TimerQueueRunning(int LocNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbCompanySettings::TimerQueueRunning(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean TimerQueueRunning(System.Int32)
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

		public int TotalClientReceiveEmail(string parm1, string parm2 = "", string parm3 = "")
		{
			int num;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd855);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd890);
				SqlParameter sqlParameter = new SqlParameter(str1, parm1);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd89d);
				SqlParameter sqlParameter1 = new SqlParameter(str2, parm2);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd8aa);
				int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, parm3), null, null, null, null, null, null));
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

		public bool UPdateQBData(int saleID, string QBID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe958);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe977);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)saleID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe986);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, QBID), null, null, null, null, null);
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

		public bool UpdateTaxes(int Itemtype, int TaxNum, bool IsOn)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7cb);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7e8);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)Itemtype);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe7fb);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)TaxNum);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe80a);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, (object)IsOn), null, null, null, null);
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

		public bool UpdateTimeClockQBData(string QB, int timeinID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe90d);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe93e);
				SqlParameter sqlParameter = new SqlParameter(str1, QB);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe945);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)timeinID), null, null, null, null, null);
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

		public DataSet ZoutDrawer(DateTime dtStart, int LocNum, int drawer, DateTime dtEnd)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbCompanySettings::ZoutDrawer(System.DateTime,System.Int32,System.Int32,System.DateTime)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet ZoutDrawer(System.DateTime,System.Int32,System.Int32,System.DateTime)
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