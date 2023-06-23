using A;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SqlLibrary
{
	public class dbHome : SqlBase
	{
		private SqlParameter[] cd955ea14127f673c1e77e436c7b2d31e;

		public dbHome()
		{
		}

		public DataSet Check_Remote_Status(string phone)
		{
			DataSet dataSet;
			try
			{
				string str = this[false];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110f4);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
				DataSet dataSet1 = this.ADOFilldataset(str, CommandType.StoredProcedure, str1, new SqlParameter(str2, phone), null, null, null, null, null, null, null, null);
				object obj = dataSet1;
				this.bBackupHomeConnection = false;
				dataSet = (DataSet)obj;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					string str3 = this[true];
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110f4);
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
					object obj1 = this.ADOFilldataset(str3, CommandType.StoredProcedure, str4, new SqlParameter(str5, phone), null, null, null, null, null, null, null, null);
					this.bBackupHomeConnection = true;
					dataSet = (DataSet)obj1;
					ProjectData.ClearProjectError();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					dataSet = null;
					ProjectData.ClearProjectError();
				}
			}
			return dataSet;
		}

		public DataSet CheckLStatus(string phone, string name, string Mac)
		{
			DataSet dataSet;
			try
			{
				string str = this[false];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1108b);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
				SqlParameter sqlParameter = new SqlParameter(str2, phone);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110ac);
				SqlParameter sqlParameter1 = new SqlParameter(str3, name);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa715);
				DataSet dataSet1 = this.ADOFilldataset(str, CommandType.StoredProcedure, str1, sqlParameter, sqlParameter1, new SqlParameter(str4, Mac), null, null, null, null, null, null);
				object obj = dataSet1;
				this.bBackupHomeConnection = false;
				dataSet = (DataSet)obj;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					string str5 = this[true];
					string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1108b);
					SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708), phone);
					SqlParameter sqlParameter3 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110ac), name);
					string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa715);
					DataSet dataSet2 = this.ADOFilldataset(str5, CommandType.StoredProcedure, str6, sqlParameter2, sqlParameter3, new SqlParameter(str7, Mac), null, null, null, null, null, null);
					object obj1 = dataSet2;
					this.bBackupHomeConnection = true;
					dataSet = (DataSet)obj1;
					ProjectData.ClearProjectError();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					dataSet = null;
					ProjectData.ClearProjectError();
				}
			}
			return dataSet;
		}

		public DataSet CheckPiracy(string phone)
		{
			DataSet dataSet;
			try
			{
				string str = this[false];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10fee);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
				object obj = this.ADOFilldataset(str, CommandType.StoredProcedure, str1, new SqlParameter(str2, phone), null, null, null, null, null, null, null, null);
				this.bBackupHomeConnection = false;
				dataSet = (DataSet)obj;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					string str3 = this[true];
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10fee);
					DataSet dataSet1 = this.ADOFilldataset(str3, CommandType.StoredProcedure, str4, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708), phone), null, null, null, null, null, null, null, null);
					object obj1 = dataSet1;
					this.bBackupHomeConnection = true;
					dataSet = (DataSet)obj1;
					ProjectData.ClearProjectError();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					dataSet = null;
					ProjectData.ClearProjectError();
				}
			}
			return dataSet;
		}

		public DataSet CheckSupportStatus(string phone)
		{
			DataSet dataSet;
			try
			{
				string str = this[false];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110c7);
				DataSet dataSet1 = this.ADOFilldataset(str, CommandType.StoredProcedure, str1, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708), phone), null, null, null, null, null, null, null, null);
				object obj = dataSet1;
				this.bBackupHomeConnection = false;
				dataSet = (DataSet)obj;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					string str2 = this[true];
					string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x110c7);
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
					DataSet dataSet2 = this.ADOFilldataset(str2, CommandType.StoredProcedure, str3, new SqlParameter(str4, phone), null, null, null, null, null, null, null, null);
					object obj1 = dataSet2;
					this.bBackupHomeConnection = true;
					dataSet = (DataSet)obj1;
					ProjectData.ClearProjectError();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					dataSet = null;
					ProjectData.ClearProjectError();
				}
			}
			return dataSet;
		}

		public DataSet LoadNews(DateTime ExeDate, string verNum)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbHome::LoadNews(System.DateTime,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadNews(System.DateTime,System.String)
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

		public DataSet LoadSupport(DateTime ExeDate, string verNum)
		{
			DataSet dataSet;
			if (this.bBackupHomeConnection)
			{
				return null;
			}
			try
			{
				string str = this[false];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10f6a);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10f85);
				dataSet = this.ADOFilldataset(str, CommandType.StoredProcedure, str1, new SqlParameter(str2, (object)ExeDate), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10f96), verNum), null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				this.bBackupHomeConnection = true;
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool UpdateVersion(string version, DateTime dtEXE, DateTime dt, string Phone)
		{
			bool flag;
			try
			{
				string str = this[false];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1100f);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11036), version);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11047);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)dtEXE);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11054);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)dt);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
				SqlParameter sqlParameter3 = new SqlParameter(str4, Phone);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11073);
				Screen primaryScreen = Screen.PrimaryScreen;
				string str6 = primaryScreen.Bounds.Width.ToString();
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11088);
				Screen screen = Screen.PrimaryScreen;
				Rectangle bounds = screen.Bounds;
				int height = bounds.Height;
				int num = height;
				string str8 = string.Concat(str6, str7, num.ToString());
				int num1 = this.ADOFillNonQuery(str, CommandType.StoredProcedure, str1, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str5, str8), null, null);
				this.bBackupHomeConnection = false;
				flag = true;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					string str9 = this[true];
					string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1100f);
					string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11036);
					SqlParameter sqlParameter4 = new SqlParameter(str11, version);
					string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11047);
					SqlParameter sqlParameter5 = new SqlParameter(str12, (object)dtEXE);
					string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11054);
					SqlParameter sqlParameter6 = new SqlParameter(str13, (object)dt);
					string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa708);
					SqlParameter sqlParameter7 = new SqlParameter(str14, Phone);
					string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11073);
					Screen primaryScreen1 = Screen.PrimaryScreen;
					int width = primaryScreen1.Bounds.Width;
					string str16 = width.ToString();
					string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11088);
					Rectangle rectangle = Screen.PrimaryScreen.Bounds;
					int height1 = rectangle.Height;
					string str18 = height1.ToString();
					string str19 = string.Concat(str16, str17, str18);
					int num2 = this.ADOFillNonQuery(str9, CommandType.StoredProcedure, str10, sqlParameter4, sqlParameter5, sqlParameter6, sqlParameter7, new SqlParameter(str15, str19), null, null);
					this.bBackupHomeConnection = true;
					flag = true;
					ProjectData.ClearProjectError();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			return flag;
		}
	}
}