using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlLibrary
{
	public class dbAppointment : SqlBase
	{
		public dbAppointment()
		{
		}

		public bool DeleteAppointment(int ID, int companyid)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5993);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = companyid;
			try
			{
				string connection = this.Connection;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5c7f);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str2, sqlParameter);
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

		public bool DeleteAppointmentService(int ID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[1];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5ca8), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public int GetAppointmentLastID()
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5cdf);
			dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			DataTable item = dataSet.Tables[0];
			DataRowCollection rows = item.Rows;
			object obj = rows[0][0];
			int integer = Conversions.ToInteger(obj);
			return integer;
		}

		public int InsertAppointment(DateTime startdate, int Length, int BedID, int RoomNum, int ClientID, string ClientName, int storeNum, int comanyid)
		{
			int integer;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b01);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5962), (object)startdate);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5977);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)Length);
				SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5986), (object)BedID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
				SqlParameter sqlParameter3 = new SqlParameter(str2, (object)RoomNum);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				SqlParameter sqlParameter4 = new SqlParameter(str3, (object)ClientID);
				SqlParameter sqlParameter5 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e), ClientName);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				SqlParameter sqlParameter6 = new SqlParameter(str4, (object)storeNum);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b78);
				SqlParameter sqlParameter7 = new SqlParameter(str5, (object)0);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b93);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, sqlParameter7, new SqlParameter(str6, (object)comanyid));
				integer = Conversions.ToInteger(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str7 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str7, MsgBoxStyle.OkOnly, null);
				integer = 0;
				ProjectData.ClearProjectError();
			}
			return integer;
		}

		public int InsertAppointmentService(DateTime startdate, DateTime Enddate, int ownerID, int ClientID, string ClientName, int storeNum, int PandsID, string PandsName, bool bRecurr, int RecurType, DateTime RecurEnd, byte[] SerialData)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[12];
			sqlParameter[0] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5962), SqlDbType.DateTime, 4);
			sqlParameter[0].Value = startdate;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5ba8), SqlDbType.DateTime, 4);
			sqlParameter[1].Value = Enddate;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5bb9);
			sqlParameter[2] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[2].Value = ownerID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5bca);
			sqlParameter[3] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[3].Value = PandsID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[4].Value = ClientID;
			sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e), SqlDbType.NVarChar, 50);
			sqlParameter[5].Value = ClientName;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
			sqlParameter[6] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[6].Value = storeNum;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5bdb);
			sqlParameter[7] = new SqlParameter(str4, SqlDbType.NVarChar, 50);
			sqlParameter[7].Value = PandsName;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5bf0);
			sqlParameter[8] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[8].Value = RecurType;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5c05);
			sqlParameter[9] = new SqlParameter(str6, SqlDbType.DateTime, 4);
			sqlParameter[9].Value = RecurEnd;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5c18);
			sqlParameter[10] = new SqlParameter(str7, SqlDbType.Bit);
			sqlParameter[10].Value = bRecurr;
			sqlParameter[11] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5c29), SqlDbType.VarBinary);
			sqlParameter[11].Value = SerialData;
			try
			{
				string connection = this.Connection;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5c46);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str8, sqlParameter);
				int integer = Conversions.ToInteger(obj);
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str9 = exception.ToString();
				Interaction.MsgBox(str9, MsgBoxStyle.OkOnly, null);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public dsAppointment LoadAppointmentByID(int id)
		{
			dsAppointment _dsAppointment = new dsAppointment();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x58b4);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(1);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x58e1);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, _dsAppointment, str1, new SqlParameter(str2, (object)id), null, null, null, null, null);
			return _dsAppointment;
		}

		public dsAppointment LoadAppointments(int storeNum, DateTime dt, bool IncludingFuture, int NumberOfDaysToLoad)
		{
			dsAppointment _dsAppointment = new dsAppointment();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5650);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(1);
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)storeNum);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			SqlParameter sqlParameter1 = new SqlParameter(str2, (object)dt);
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x568b);
			SqlParameter sqlParameter2 = new SqlParameter(str3, (object)IncludingFuture);
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x56ac);
			this.ADOFilldataset(connection, CommandType.StoredProcedure, str, _dsAppointment, str1, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str4, (object)NumberOfDaysToLoad), null, null);
			return _dsAppointment;
		}

		public DataSet LoadAppointments_Service(int storeNum, DateTime dt, int NumberOfDaysToLoad)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x56c7);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)storeNum);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			SqlParameter sqlParameter1 = new SqlParameter(str2, (object)dt);
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x56ac);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, (object)NumberOfDaysToLoad), null, null, null, null, null, null);
			return (DataSet)dataSet;
		}

		public DataSet LoadApptStores()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x56fc);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.Text, str, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadBeds(int storeNum, bool bSmallSalon)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x58e8);
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)storeNum);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5913);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)bSmallSalon), null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadOwners(int storeNum, bool bSmallSalon)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x592c);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)storeNum);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5913);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)bSmallSalon), null, null, null, null, null, null, null);
			return dataSet;
		}

		public bool UpdateAppointment(int ID, DateTime startdate, int Length, int BedID, int companyid)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbAppointment::UpdateAppointment(System.Int32,System.DateTime,System.Int32,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean UpdateAppointment(System.Int32,System.DateTime,System.Int32,System.Int32,System.Int32)
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

		public bool UpdateAppointmentService(int ID, DateTime startdate, DateTime EndDate, int OwnerID, string OwnerName)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbAppointment::UpdateAppointmentService(System.Int32,System.DateTime,System.DateTime,System.Int32,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean UpdateAppointmentService(System.Int32,System.DateTime,System.DateTime,System.Int32,System.String)
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