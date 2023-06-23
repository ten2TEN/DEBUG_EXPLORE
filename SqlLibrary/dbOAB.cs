using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlLibrary
{
	public class dbOAB : SqlBase
	{
		public dbOAB()
		{
		}

		public bool Allow_Bookable_Or_Unbookable_Online_Beds(int Loc_Num, bool bBookable)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11fa1);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115a4), (object)Loc_Num), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11f96), (object)bBookable), null, null, null, null, null);
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

		public bool Allow_Bookable_Or_Unbookable_Online_Clients(int Loc_Num, bool bBookable)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11f31);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115a4);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)Loc_Num);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11f96);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)bBookable), null, null, null, null, null);
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

		public DataSet Check_Activation(string strCompanyGUID, string strCompanyPhone)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbOAB::Check_Activation(System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet Check_Activation(System.String,System.String)
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

		public DataSet Create_Appointment_On_OAB(int Appointment_ID, DateTime Start_Date, int Length, int Tantrack_Bed_ID, int OAB_Bed_ID, int Loc_Num, int TanTrack_Client_ID, string OABMasterConnection)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c96);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11cd3), (object)Appointment_ID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d31);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)Start_Date);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5977);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)Length);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11cf2);
				SqlParameter sqlParameter3 = new SqlParameter(str3, (object)Tantrack_Bed_ID);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d13);
				SqlParameter sqlParameter4 = new SqlParameter(str4, (object)OAB_Bed_ID);
				SqlParameter sqlParameter5 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651), (object)Loc_Num);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d2a);
				dataSet = this.ADOFilldataset(OABMasterConnection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, new SqlParameter(str5, (object)TanTrack_Client_ID), null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet Create_Bed_On_OAB(int TanTrack_Id, string Name, int Max_Usage_Minutes, int Room_Number, int Loc_Num, string Bed_Type, int iDelay, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11662);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11685);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)TanTrack_Id);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d27);
				SqlParameter sqlParameter1 = new SqlParameter(str2, Name);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1169e);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)Max_Usage_Minutes);
				SqlParameter sqlParameter3 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x116c3), (object)Room_Number);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				SqlParameter sqlParameter4 = new SqlParameter(str4, (object)Loc_Num);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x116dc);
				SqlParameter sqlParameter5 = new SqlParameter(str5, Bed_Type);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6033);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, null, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, new SqlParameter(str6, (object)iDelay), null);
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

		public DataSet Create_Client_On_OAB(int ID, string First_Name, string Last_Name, string Home_Phone, string Cell_Phone, string Work_Phone, string EMail, bool bAllow_EMail, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1183b);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11864);
				SqlParameter sqlParameter1 = new SqlParameter(str2, First_Name);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1187b);
				SqlParameter sqlParameter2 = new SqlParameter(str3, Last_Name);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11890);
				SqlParameter sqlParameter3 = new SqlParameter(str4, Home_Phone);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118a7);
				SqlParameter sqlParameter4 = new SqlParameter(str5, Cell_Phone);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118be);
				SqlParameter sqlParameter5 = new SqlParameter(str6, Work_Phone);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x885d);
				SqlParameter sqlParameter6 = new SqlParameter(str7, EMail);
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118d5);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, null, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, new SqlParameter(str8, (object)bAllow_EMail));
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

		public DataSet Delete_Appointment_From_OAB(int Tantrack_ID, int OAB_ID, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d84);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Tantrack_ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2), (object)OAB_ID), null, null, null, null, null, null, null);
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

		public DataSet Delete_Bed_From_OAB(int TanTrack_ID, int OAB_ID, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x117d1);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)TanTrack_ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)OAB_ID), null, null, null, null, null, null, null);
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

		public DataSet Delete_Client_From_OAB(int TanTrack_ID, int OAB_ID, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x119ea);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)TanTrack_ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, null, sqlParameter, new SqlParameter(str2, (object)OAB_ID), null, null, null, null, null, null);
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

		public bool Force_Resync_All(int Loc_Num)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12000);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115a4);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null);
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

		public DataSet Get_Appointments_For_Tantrack(int Loc_Num, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c4d);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public DataSet Get_Appointments_To_Create_on_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11a78);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public bool Get_Appointments_To_Create_Or_Update_On_OAB(int Loc_Num)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11a13);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115a4);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null);
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

		public DataSet Get_Appointments_To_Delete_From_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11b1a);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public DataSet Get_Appointments_To_Update_on_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11ac9);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public DataSet Get_Beds_To_Create_on_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11610);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool Get_Beds_To_Create_Or_Update_On_OAB(int Loc_Num)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1154f);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115a4);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null);
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

		public DataSet Get_Beds_To_Delete_From_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1178c);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651), (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public DataSet Get_Beds_To_Update_on_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11728);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public DataSet Get_Clients_To_Create_on_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				DataSet dataSet1 = this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x117f4), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651), (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public bool Get_Clients_To_Create_Or_Update_On_OAB(int Loc_Num)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115b5);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x115a4);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null);
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

		public DataSet Get_Clients_To_Delete_From_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11960);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
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

		public DataSet Get_Clients_To_Update_on_OAB(int Loc_Num)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118f0);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)Loc_Num), null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet Get_CompanyInfo_For_OAB(int TanTrack_ID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11b6f);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11bae);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)TanTrack_ID), null, null, null, null, null, null, null, null);
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

		public string Get_OABMasterConnection(string CentralCompanyID, string strCompanyPhone)
		{
			// 
			// Current member / type: System.String SqlLibrary.dbOAB::Get_OABMasterConnection(System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String Get_OABMasterConnection(System.String,System.String)
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

		public DataSet IsGoodStanding(int OAB_ID)
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbOAB::IsGoodStanding(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet IsGoodStanding(System.Int32)
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

		public bool IsOABDatabase(string conString)
		{
			bool flag = this.IsDatabase(conString);
			return flag;
		}

		public bool OAB_Cleanup_Appointments_On_OAB(DateTime Current_Server_Time, string OABMasterConnString)
		{
			bool flag;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11bed);
				int num = this.ADOFillNonQuery(OABMasterConnString, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11c32), (object)Current_Server_Time), null, null, null, null, null, null);
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

		public DataSet Update_Appointment_On_OAB(int Appointment_ID, DateTime Start_Date, int Length, int Tantrack_Bed_ID, int OAB_Bed_ID, int Loc_Num, int OAB_ID, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d51);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11cd3);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)Appointment_ID);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d31), (object)Start_Date);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5977);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)Length);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11cf2);
				SqlParameter sqlParameter3 = new SqlParameter(str3, (object)Tantrack_Bed_ID);
				SqlParameter sqlParameter4 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11d13), (object)OAB_Bed_ID);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				SqlParameter sqlParameter5 = new SqlParameter(str4, (object)Loc_Num);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, new SqlParameter(str5, (object)OAB_ID), null, null);
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

		public bool Update_Appointment_Row_After_Sync(int OAB_Appointment_ID, int Tantrack_Appointment_ID, bool bSynced, string OABMasterConnString)
		{
			bool flag;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11e1d);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11e6e);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)OAB_Appointment_ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11e95);
				int num = this.ADOFillNonQuery(OABMasterConnString, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)Tantrack_Appointment_ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11ec6), (object)bSynced), null, null, null, null);
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

		public bool Update_Appointment_Row_OAB_ID(int Tantrack_ID, int OAB_ID, bool bOAB_Synced, int OAB_Client_ID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11db7);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)Tantrack_ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)OAB_ID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6189);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)bOAB_Synced);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11e00);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str4, (object)OAB_Client_ID), null, null, null);
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

		public DataSet Update_Bed_On_OAB(int OAB_ID, string Name, int Max_Usage_Minutes, int Room_Number, int Loc_Num, string Bed_Type, int iDelay, int TanTrack_ID, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11769);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)OAB_ID);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d27), Name);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1169e);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)Max_Usage_Minutes);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x116c3);
				SqlParameter sqlParameter3 = new SqlParameter(str3, (object)Room_Number);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11651);
				SqlParameter sqlParameter4 = new SqlParameter(str4, (object)Loc_Num);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x116dc);
				SqlParameter sqlParameter5 = new SqlParameter(str5, Bed_Type);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6033);
				SqlParameter sqlParameter6 = new SqlParameter(str6, (object)iDelay);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11685);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, null, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, new SqlParameter(str7, (object)TanTrack_ID));
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

		public bool Update_Bed_Row_OAB_ID(int Tantrack_ID, int OAB_ID, bool bOAB_Synced)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x116ef);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5), (object)Tantrack_ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2), (object)OAB_ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6189), (object)bOAB_Synced), null, null, null, null);
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

		public DataSet Update_Client_On_OAB(int ID, string First_Name, string Last_Name, string Home_Phone, string Cell_Phone, string Work_Phone, string EMail, bool bAllow_EMail, int OAB_ID, string OABMasterConnString)
		{
			DataSet dataSet;
			try
			{
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11937);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11864);
				SqlParameter sqlParameter1 = new SqlParameter(str1, First_Name);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1187b);
				SqlParameter sqlParameter2 = new SqlParameter(str2, Last_Name);
				SqlParameter sqlParameter3 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11890), Home_Phone);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118a7);
				SqlParameter sqlParameter4 = new SqlParameter(str3, Cell_Phone);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118be);
				SqlParameter sqlParameter5 = new SqlParameter(str4, Work_Phone);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x885d);
				SqlParameter sqlParameter6 = new SqlParameter(str5, EMail);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x118d5);
				SqlParameter sqlParameter7 = new SqlParameter(str6, (object)bAllow_EMail);
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, sqlParameter7, new SqlParameter(str7, (object)OAB_ID));
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

		public bool Update_Client_Row_OAB_ID(int Tantrack_ID, int OAB_ID, bool bOAB_Synced)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x119ab);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)Tantrack_ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)OAB_ID);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6189);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, (object)bOAB_Synced), null, null, null, null);
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

		public bool Update_CompanyInformation_With_OAB_ID(int TanTrack_Company_Information_ID, int OAB_Company_Information_ID)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1147e), SqlDbType.Int, 8), null };
				sqlParameter[0].Value = TanTrack_Company_Information_ID;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x114bf);
				sqlParameter[1] = new SqlParameter(str, SqlDbType.Int, 8);
				sqlParameter[1].Value = OAB_Company_Information_ID;
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x114f6);
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

		public DataSet UpdateCompanyInfo_on_OAB(int TanTrack_ID, int Store_Number, string Company_Name, string Company_Address, string Company_City, string Company_State, string Company_Zip, string Company_Country, string Company_Phone, string Company_EMail, string Company_Web, DateTime Monday_Open, DateTime Monday_Close, bool Monday_bClosed, DateTime Tuesday_Open, DateTime Tuesday_Close, bool Tuesday_bClosed, DateTime Wednesday_Open, DateTime Wednesday_Close, bool Wednesday_bClosed, DateTime Thursday_Open, DateTime Thursday_Close, bool Thursday_bClosed, DateTime Friday_Open, DateTime Friday_Close, bool Friday_bClosed, DateTime Saturday_Open, DateTime Saturday_Close, bool Saturday_bClosed, DateTime Sunday_Open, DateTime Sunday_Close, bool Sunday_bClosed, string EMail_Address, string SMTP_Server, string SMTP_Port, string bSMTP_Authentication_Required, string SMTP_Username, string SMTP_Password, string SMTP_Authentication_Type, bool bSSL, int OAB_ID, string OABMasterConnString, string Company_GUID)
		{
			DataSet dataSet;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[41];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112e5);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
				sqlParameter[0].Value = TanTrack_ID;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7df6);
				sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
				sqlParameter[1].Value = Store_Number;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x112fe);
				sqlParameter[2] = new SqlParameter(str2, SqlDbType.NVarChar, 50);
				sqlParameter[2].Value = Company_Name;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11319);
				sqlParameter[3] = new SqlParameter(str3, SqlDbType.NVarChar, 50);
				sqlParameter[3].Value = Company_Address;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1133a);
				sqlParameter[4] = new SqlParameter(str4, SqlDbType.NVarChar, 50);
				sqlParameter[4].Value = Company_City;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11355);
				sqlParameter[5] = new SqlParameter(str5, SqlDbType.NVarChar, 25);
				sqlParameter[5].Value = Company_State;
				sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11372), SqlDbType.NVarChar, 15);
				sqlParameter[6].Value = Company_Zip;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1138b);
				sqlParameter[7] = new SqlParameter(str6, SqlDbType.NVarChar, 50);
				sqlParameter[7].Value = Company_EMail;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x113a8);
				sqlParameter[8] = new SqlParameter(str7, SqlDbType.NVarChar, 50);
				sqlParameter[8].Value = Company_Web;
				sqlParameter[9] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x113c1), SqlDbType.NVarChar, 40);
				sqlParameter[9].Value = Company_Country;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x113e2);
				sqlParameter[10] = new SqlParameter(str8, SqlDbType.NVarChar, 25);
				sqlParameter[10].Value = Company_Phone;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xae72);
				sqlParameter[11] = new SqlParameter(str9, SqlDbType.NVarChar, 50);
				SqlParameter sqlParameter1 = sqlParameter[11];
				string str10 = EMail_Address.Trim();
				sqlParameter1.Value = str10;
				string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xae8f);
				sqlParameter[12] = new SqlParameter(str11, SqlDbType.NVarChar, 50);
				sqlParameter[12].Value = SMTP_Server;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xaea8);
				sqlParameter[13] = new SqlParameter(str12, SqlDbType.NVarChar, 10);
				SqlParameter sqlParameter2 = sqlParameter[13];
				string str13 = SMTP_Port.Trim();
				sqlParameter2.Value = str13;
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xaebd);
				sqlParameter[14] = new SqlParameter(str14, SqlDbType.Bit, 2);
				sqlParameter[14].Value = bSMTP_Authentication_Required;
				string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xaefa);
				sqlParameter[15] = new SqlParameter(str15, SqlDbType.NVarChar, 50);
				sqlParameter[15].Value = SMTP_Username;
				string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xaf17);
				sqlParameter[16] = new SqlParameter(str16, SqlDbType.NVarChar, 50);
				sqlParameter[16].Value = SMTP_Password;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xaf34);
				sqlParameter[17] = new SqlParameter(str17, SqlDbType.NVarChar, 10);
				sqlParameter[17].Value = SMTP_Authentication_Type;
				string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa777);
				sqlParameter[18] = new SqlParameter(str18, SqlDbType.DateTime, 4);
				sqlParameter[18].Value = Monday_Open;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa790);
				sqlParameter[19] = new SqlParameter(str19, SqlDbType.DateTime, 4);
				sqlParameter[19].Value = Monday_Close;
				string str20 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa7ab);
				sqlParameter[20] = new SqlParameter(str20, SqlDbType.Bit, 2);
				sqlParameter[20].Value = Monday_bClosed;
				sqlParameter[21] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xb134), SqlDbType.Bit, 2);
				sqlParameter[21].Value = bSSL;
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa7ff);
				sqlParameter[22] = new SqlParameter(str21, SqlDbType.DateTime, 4);
				sqlParameter[22].Value = Tuesday_Open;
				string str22 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa81a);
				sqlParameter[23] = new SqlParameter(str22, SqlDbType.DateTime, 4);
				sqlParameter[23].Value = Tuesday_Close;
				string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa837);
				sqlParameter[24] = new SqlParameter(str23, SqlDbType.Bit, 2);
				sqlParameter[24].Value = Tuesday_bClosed;
				string str24 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa858);
				sqlParameter[25] = new SqlParameter(str24, SqlDbType.DateTime, 4);
				sqlParameter[25].Value = Wednesday_Open;
				string str25 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa877);
				sqlParameter[26] = new SqlParameter(str25, SqlDbType.DateTime, 4);
				sqlParameter[26].Value = Wednesday_Close;
				string str26 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa898);
				sqlParameter[27] = new SqlParameter(str26, SqlDbType.Bit, 2);
				sqlParameter[27].Value = Wednesday_bClosed;
				string str27 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa8bd);
				sqlParameter[28] = new SqlParameter(str27, SqlDbType.DateTime, 4);
				sqlParameter[28].Value = Thursday_Open;
				string str28 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa8da);
				sqlParameter[29] = new SqlParameter(str28, SqlDbType.DateTime, 4);
				sqlParameter[29].Value = Thursday_Close;
				string str29 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa8f9);
				sqlParameter[30] = new SqlParameter(str29, SqlDbType.Bit, 2);
				sqlParameter[30].Value = Thursday_bClosed;
				string str30 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa91c);
				sqlParameter[31] = new SqlParameter(str30, SqlDbType.DateTime, 4);
				sqlParameter[31].Value = Friday_Open;
				string str31 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa935);
				sqlParameter[32] = new SqlParameter(str31, SqlDbType.DateTime, 4);
				sqlParameter[32].Value = Friday_Close;
				string str32 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa950);
				sqlParameter[33] = new SqlParameter(str32, SqlDbType.Bit, 2);
				sqlParameter[33].Value = Friday_bClosed;
				string str33 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa96f);
				sqlParameter[34] = new SqlParameter(str33, SqlDbType.DateTime, 4);
				sqlParameter[34].Value = Saturday_Open;
				string str34 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa98c);
				sqlParameter[35] = new SqlParameter(str34, SqlDbType.DateTime, 4);
				sqlParameter[35].Value = Saturday_Close;
				string str35 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa9ab);
				sqlParameter[36] = new SqlParameter(str35, SqlDbType.Bit, 2);
				sqlParameter[36].Value = Saturday_bClosed;
				sqlParameter[37] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa9ce), SqlDbType.DateTime, 4);
				sqlParameter[37].Value = Sunday_Open;
				string str36 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa9e7);
				sqlParameter[38] = new SqlParameter(str36, SqlDbType.DateTime, 4);
				sqlParameter[38].Value = Sunday_Close;
				string str37 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xaa02);
				sqlParameter[39] = new SqlParameter(str37, SqlDbType.Bit, 2);
				sqlParameter[39].Value = Sunday_bClosed;
				string str38 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x113ff);
				sqlParameter[40] = new SqlParameter(str38, SqlDbType.NVarChar, 50);
				sqlParameter[40].Value = Company_GUID;
				string str39 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11424);
				DataSet dataSet1 = this.ADOFilldataset(OABMasterConnString, CommandType.StoredProcedure, str39, sqlParameter);
				dataSet = dataSet1;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				string str40 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x11455);
				string message = exception.Message;
				string str41 = string.Concat(str40, message);
				Interaction.MsgBox(str41, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}
	}
}