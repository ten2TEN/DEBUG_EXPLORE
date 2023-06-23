using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;

namespace SqlLibrary
{
	public class dbEmployee : SqlBase
	{
		private DbLocation c233604abeca67a6e6b798fdea78cdf5f;

		public dbEmployee()
		{
			this.c233604abeca67a6e6b798fdea78cdf5f = new DbLocation();
		}

		public DataSet ActiveEmployeeList(int HomeStore = 0)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbEmployee::ActiveEmployeeList(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet ActiveEmployeeList(System.Int32)
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

		public string checkClockIns(string ID, int storenum)
		{
			string str;
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10dcb);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e79);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str1, new SqlParameter(str2, ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65), (object)storenum), null, null, null, null, null, null, null);
				str = Conversions.ToString(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str3 = Conversions.ToString(false);
				str = str3;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public bool CheckEmpNumberExists(int ID, string EmpNumber)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbEmployee::CheckEmpNumberExists(System.Int32,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean CheckEmpNumberExists(System.Int32,System.String)
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

		public int checkPasswordHistory(string ID, string pwd)
		{
			int integer;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf5a1);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf33c);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, pwd), null, null, null, null, null, null, null);
				integer = Conversions.ToInteger(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				integer = 2;
				ProjectData.ClearProjectError();
			}
			return integer;
		}

		public bool ClockInOut(string ID, string pwd, int StoreNum, bool PasswordOn)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10d7e);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e79), ID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf33c);
				SqlParameter sqlParameter1 = new SqlParameter(str1, pwd);
				SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65), (object)StoreNum);
				SqlParameter sqlParameter3 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10da9), (object)PasswordOn);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10dc0);
				DateTime now = DateAndTime.Now;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str2, (object)now), null, null);
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

		public decimal ClockIsIn(string ID, string pwd, int StoreNum, bool pon)
		{
			decimal num;
			try
			{
				DataSet dataSet = new DataSet();
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10e95);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e79);
				SqlParameter sqlParameter = new SqlParameter(str1, ID);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf33c), pwd);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)StoreNum);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10da9);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str3, (object)pon), null, null, null, null, null);
				DataTableCollection tables = dataSet1.Tables;
				DataRow item = tables[0].Rows[0];
				object obj = item[0];
				num = Conversions.ToDecimal(obj.ToString());
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = decimal.Zero;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static byte[] ConvertToByteArray(Bitmap value)
		{
			byte[] numArray;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				ImageFormat bmp = ImageFormat.Bmp;
				value.Save(memoryStream, bmp);
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
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b79);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
		}

		public bool CreateEmployeeSalesGoals(string EMPID, string Year)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf3ef);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0), EMPID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf395);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, Year), null, null, null, null, null, null, null);
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

		public bool DeleteEmployeeByID(int ID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf787);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null);
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

		public bool DeleteEmployeeNotes(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10f18);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null);
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

		public bool DeleteEmployeeSalesGoal(string EMPID, string Year)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf4a9);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0);
				SqlParameter sqlParameter = new SqlParameter(str1, EMPID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf395);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, Year), null, null, null, null, null);
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

		public bool deleteFingerPrint(int EmployeeID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf7ed);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf648);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)EmployeeID), null, null, null, null, null, null);
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

		public bool DeleteTimeClock(int ID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xfc5b);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null);
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

		public bool DeleteTraining(int ID, bool IsDeleteTrainingType = false)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c5b);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c7e);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)IsDeleteTrainingType), null, null, null, null, null);
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

		public DataSet EmployeeNoticeDetail(int NoticeID)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1073b);
			string str1 = Conversions.ToString(NoticeID);
			string str2 = string.Concat(str, str1);
			string str3 = str2;
			string connection = this.Connection;
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.Text, str3, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet EmployeeNoticeDetailbyEmpID(int EmpID)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10865);
			string str1 = str;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x109f3);
			string str3 = Conversions.ToString(EmpID);
			str1 = string.Concat(str1, str2, str3, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8eaf));
			string connection = this.Connection;
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.Text, str1, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet EmployeeNoticeList()
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x106c6);
			string str1 = str;
			string connection = this.Connection;
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.Text, str1, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public bool EmployeeNoticeReadUpdate(int DetailID)
		{
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10a5a);
			string str1 = Conversions.ToString(DetailID);
			string str2 = string.Concat(str, str1);
			string connection = this.Connection;
			return this.ADOFillNonQuery(connection, CommandType.Text, str2, null, null, null, null, null, null, null) != 0;
		}

		public DataSet GetEmployeeByFinger(int ID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10e29);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
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

		public int GetEmployeeIDByEmpNumber(string EmpNumber)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbEmployee::GetEmployeeIDByEmpNumber(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 GetEmployeeIDByEmpNumber(System.String)
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

		public string GetEmployeeNameByEmpNumber(string EmpNum)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10cf5);
			dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10ce0), EmpNum), null, null, null, null, null, null, null, null);
			DataTableCollection tables = dataSet.Tables;
			DataTable item = tables[0];
			DataRowCollection rows = item.Rows;
			int count = rows.Count;
			if (count == 0)
			{
				return "";
			}
			DataTableCollection dataTableCollection = dataSet.Tables;
			DataTable dataTable = dataTableCollection[0];
			DataRowCollection dataRowCollection = dataTable.Rows;
			object obj = dataRowCollection[0][0];
			string str1 = Conversions.ToString(obj);
			return str1;
		}

		public DataSet GetExpiryDate(string name)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf756);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6a25);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, name), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet GetFingerPrints()
		{
			DataSet dataSet;
			try
			{
				DataSet dataSet1 = this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10e60), null, null, null, null, null, null, null, null, null);
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

		public int GetLastEmployeeID()
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbEmployee::GetLastEmployeeID()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 GetLastEmployeeID()
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

		public DataSet GetTimeClockStats(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf607);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf648);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
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
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf867);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null, null, null);
				flag = Conversions.ToBoolean(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public SqlDataReader LoadEmployee_Notes(int ID)
		{
			SqlDataReader sqlDataReader = this.ADOFillReader(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10f43), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf648), (object)ID), null, null, null, null, null, null);
			return sqlDataReader;
		}

		public DataSet LoadEmployeeByEmpID(string empID)
		{
			DataSet dataSet = this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1045b), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), empID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadEmployeeById(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf694);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
		}

		public string LoadEmployeeNameByID(string ID, string pwd, bool IsPwdVisible, string empid, int loc_num)
		{
			// 
			// Current member / type: System.String SqlLibrary.dbEmployee::LoadEmployeeNameByID(System.String,System.String,System.Boolean,System.String,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String LoadEmployeeNameByID(System.String,System.String,System.Boolean,System.String,System.Int32)
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

		public DataSet LoadEmployeePrevNextByID(int ID, bool isPrev, int Loc_NUm)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf6b9);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5dfc);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)isPrev), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b), (object)Loc_NUm), null, null, null, null, null, null);
		}

		public DataSet LoadEmployeeSalesGoals(string EMPID, string Year)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbEmployee::LoadEmployeeSalesGoals(System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet LoadEmployeeSalesGoals(System.String,System.String)
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

		public DataSet LoadEmployeeSalesGoalsSummary(int LocNum, int GoalDurationType)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf466);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)LocNum);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6917);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)GoalDurationType), null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadSalesGoalsRankingTimeCLock()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf416);
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

		public DataSet LoadStoreSalesGoals(int LocNum, int GoalDurationType)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf445);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)LocNum);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6917);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)GoalDurationType), null, null, null, null, null, null, null);
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

		public SqlDataReader LoadTime_Clock(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf5d0);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlDataReader sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null);
			return sqlDataReader;
		}

		public DataSet LoadTimeClock(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf5d0);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadTraining(int ID)
		{
			return this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf65f), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
		}

		public bool SaveEmployeeNotes(int NoteID, int EmployeeID, string Notes, string EmpName, bool IsNew, int LocNum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbEmployee::SaveEmployeeNotes(System.Int32,System.Int32,System.String,System.String,System.Boolean,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveEmployeeNotes(System.Int32,System.Int32,System.String,System.String,System.Boolean,System.Int32)
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

		public bool SaveEmployeeSalesGoals(int EmpID, DateTime dtGoal, decimal Product_Goal, decimal Package_Goal, decimal Service_Goal, decimal Upcharge_Goal, decimal GiftCard_Goal)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[7];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = EmpID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf4e4), SqlDbType.Date);
			sqlParameter[1].Value = dtGoal;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf4f3);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.Decimal);
			sqlParameter[2].Value = Product_Goal;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf50e), SqlDbType.Decimal);
			sqlParameter[3].Value = Package_Goal;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf529);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.Decimal);
			sqlParameter[4].Value = Service_Goal;
			sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf544), SqlDbType.Decimal);
			sqlParameter[5].Value = Upcharge_Goal;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf561);
			sqlParameter[6] = new SqlParameter(str3, SqlDbType.Decimal);
			sqlParameter[6].Value = GiftCard_Goal;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf57e);
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

		public int SaveInfo(int ID, string FirstName, string MiddleInitial, string LastName, string EmployeeID, string Address, string City, string ucboState, string EMail, string PhoneHome, string Zip, string SSN, string EmergencyName, string EmergencyAddress, string EmergencyCity, string ucboecState, string EmergencyZip, string EmergencyPhoneHome, string EmergencyPhoneCell, DateTime dtHired, DateTime dtReviewed, DateTime? dtTerminated, bool chkRehire, bool chkTerminated, bool bhourly, double PayRate, bool chkEMailMarketing, bool chkEditPackages, bool chkDeleteClients, bool chkOverrideBeds, bool chkVacationHold, bool chkReportsClient, bool chkOpenDrawer, bool chkReportsSales, bool chkEmployeeScreen, bool chkSupplierScreen, bool chkPackageScreen, bool chkProductScreen, bool chkBackupDatabase, bool chkBedScreen, bool chkCategoryScreen, bool chkGiftCertificateScreen, bool chkSystemToolsScreen, bool chkToolsOptionsScreen, bool chkRefundScreen, string Relation, DateTime DOB, double Prdcommission, double Pkgcommission, string County, string country, string pwd, bool Transfer, Bitmap Image, int Home_Store_Number, bool chkServiceScreen, Bitmap img2, bool canceleft, bool TimerQueue, bool bDrawerCount, string CellPhone, bool chkEFTProcess, string ECCounty, string ECCountry, bool bEFT, bool bNotes, bool bVisit, string qb, bool chkLockedOut, bool chkFacebook, bool chkTwitter, bool chkCoupon, bool bDashboard, bool bSalesGoals, bool bClientRewards, bool bBookable)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbEmployee::SaveInfo(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.DateTime,System.DateTime,System.Nullable`1<System.DateTime>,System.Boolean,System.Boolean,System.Boolean,System.Double,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String,System.DateTime,System.Double,System.Double,System.String,System.String,System.String,System.Boolean,System.Drawing.Bitmap,System.Int32,System.Boolean,System.Drawing.Bitmap,System.Boolean,System.Boolean,System.Boolean,System.String,System.Boolean,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 SaveInfo(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.DateTime,System.DateTime,System.Nullable<System.DateTime>,System.Boolean,System.Boolean,System.Boolean,System.Double,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String,System.DateTime,System.Double,System.Double,System.String,System.String,System.String,System.Boolean,System.Drawing.Bitmap,System.Int32,System.Boolean,System.Drawing.Bitmap,System.Boolean,System.Boolean,System.Boolean,System.String,System.Boolean,System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
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

		public int SaveNotice(object NoticeSub, object Notice, object NoticeID, object bDelete)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbEmployee::SaveNotice(System.Object,System.Object,System.Object,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 SaveNotice(System.Object,System.Object,System.Object,System.Object)
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

		public int SaveNoticeDetail(object EmpID, object NoticeID, object dtread)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbEmployee::SaveNoticeDetail(System.Object,System.Object,System.Object)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 SaveNoticeDetail(System.Object,System.Object,System.Object)
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

		public bool SaveTimeClock(int EmpID, decimal Wage, DateTime TimeIN, DateTime TimeOut, double Duration, int ID, int LocNum)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[7];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = EmpID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10aea);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Wage;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10afb);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.DateTime, 4);
			sqlParameter[3].Value = TimeIN;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b0a);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.DateTime, 4);
			sqlParameter[4].Value = TimeOut;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8336);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Decimal, 5);
			sqlParameter[5].Value = Duration;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[6] = new SqlParameter(str6, SqlDbType.Int, 8);
			sqlParameter[6].Value = LocNum;
			try
			{
				string connection = this.Connection;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b1b);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str7, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str8 = exception.ToString();
				Interaction.MsgBox(str8, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveTraining(int EmpID, string TrainingTypes, DateTime trainingDate, string License, int ID, DateTime dtExpiry)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0), SqlDbType.Int, 8), null, null, null, null, null };
			sqlParameter[0].Value = EmpID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10be3), SqlDbType.NVarChar, 0xff);
			sqlParameter[1].Value = TrainingTypes;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c00);
			sqlParameter[2] = new SqlParameter(str, SqlDbType.DateTime, 4);
			sqlParameter[2].Value = trainingDate;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c1b);
			sqlParameter[3] = new SqlParameter(str1, SqlDbType.NVarChar, 50);
			sqlParameter[3].Value = License;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8);
			sqlParameter[4].Value = ID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f9f);
			sqlParameter[5] = new SqlParameter(str2, SqlDbType.DateTime, 4);
			sqlParameter[5].Value = dtExpiry;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10c2c), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str3 = exception.ToString();
				Interaction.MsgBox(str3, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveTrainingType(int TrainingTypeID, string TrainingName, int Month, int day, int year)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[5];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b73);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.NVarChar, 0xff);
			sqlParameter[0].Value = TrainingName;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b8e);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = Month;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe897);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[2].Value = day;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf395);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[3].Value = year;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b9b), SqlDbType.Int, 8);
			sqlParameter[4].Value = TrainingTypeID;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10bba);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
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

		public DataSet SearchEmployee(string FirstName, string MI, string LastName, string PhoneHome, string StoreNum, bool IsDemo)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbEmployee::SearchEmployee(System.String,System.String,System.String,System.String,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet SearchEmployee(System.String,System.String,System.String,System.String,System.String,System.Boolean)
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

		public DataSet SearchEmployeeByFinger(int ID, bool IsDemo)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbEmployee::SearchEmployeeByFinger(System.Int32,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet SearchEmployeeByFinger(System.Int32,System.Boolean)
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

		public DataSet StateList(string country)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b5a);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7680);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, country), null, null, null, null, null, null, null, null);
		}

		public DataSet TrainingTypeList()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x10b3c);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public bool Update_fingerPrint(int emp_ID, byte[] blob_write, string blobID, int locnum, int drawernum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbEmployee::Update_fingerPrint(System.Int32,System.Byte[],System.String,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean Update_fingerPrint(System.Int32,System.Byte[],System.String,System.Int32,System.Int32)
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

		public bool UpdatePassword(string empid, string emppwd)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf82a);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf849);
				SqlParameter sqlParameter = new SqlParameter(str1, empid);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf858);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, emppwd), null, null, null, null, null, null, null);
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				bool flag1 = Conversions.ToBoolean(objectValue);
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
	}
}