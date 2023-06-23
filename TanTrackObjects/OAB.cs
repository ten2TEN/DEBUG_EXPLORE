using SqlLibrary;
using System;
using System.Data;

namespace TanTrackObjects
{
	public class OAB
	{
		private dbOAB c159fce105a6ad06c71422bf493aa6e90;

		public bool bOABEnabled
		{
			get;
			set;
		}

		public string companyGUID
		{
			get;
			set;
		}

		public string connCentral
		{
			get;
			set;
		}

		public string connMaster
		{
			get;
			set;
		}

		public OAB()
		{
			this.c159fce105a6ad06c71422bf493aa6e90 = new dbOAB();
		}

		public DataSet Check_Activation(string strCompanyGUID, string strCompanyPhone)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Check_Activation(strCompanyGUID, strCompanyPhone);
		}

		public DataSet Create_Appointment_On_OAB(int Appointment_ID, DateTime Start_Date, int Length, int Tantrack_Bed_ID, int OAB_Bed_ID, int Loc_Num, int TanTrack_Client_ID)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet dataSet = _dbOAB.Create_Appointment_On_OAB(Appointment_ID, Start_Date, Length, Tantrack_Bed_ID, OAB_Bed_ID, Loc_Num, TanTrack_Client_ID, str);
			return dataSet;
		}

		public DataSet Create_Bed_On_OAB(int TanTrack_Id, string Name, int Max_Usage_Minutes, int Room_Number, int Loc_Num, string Bed_Type, int iDelay)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet dataSet = _dbOAB.Create_Bed_On_OAB(TanTrack_Id, Name, Max_Usage_Minutes, Room_Number, Loc_Num, Bed_Type, iDelay, str);
			return dataSet;
		}

		public DataSet Create_Client_On_OAB(int ID, string First_Name, string Last_Name, string Home_Phone, string Cell_Phone, string Work_Phone, string EMail, bool bAllow_EMail)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet dataSet = _dbOAB.Create_Client_On_OAB(ID, First_Name, Last_Name, Home_Phone, Cell_Phone, Work_Phone, EMail, bAllow_EMail, str);
			return dataSet;
		}

		public DataSet Delete_Appointment_From_OAB(int Tantrack_ID, int OAB_ID)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet dataSet = _dbOAB.Delete_Appointment_From_OAB(Tantrack_ID, OAB_ID, str);
			return dataSet;
		}

		public DataSet Delete_Bed_From_OAB(int TanTrack_ID, int OAB_ID)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			return _dbOAB.Delete_Bed_From_OAB(TanTrack_ID, OAB_ID, str);
		}

		public DataSet Delete_Client_From_OAB(int TanTrack_ID, int OAB_ID)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet dataSet = _dbOAB.Delete_Client_From_OAB(TanTrack_ID, OAB_ID, str);
			return dataSet;
		}

		public DataSet Get_Appointments_For_Tantrack(int Loc_Num)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet appointmentsForTantrack = _dbOAB.Get_Appointments_For_Tantrack(Loc_Num, str);
			return appointmentsForTantrack;
		}

		public DataSet Get_Appointments_To_Create_on_OAB(int Loc_Num)
		{
			DataSet appointmentsToCreateOnOAB = this.c159fce105a6ad06c71422bf493aa6e90.Get_Appointments_To_Create_on_OAB(Loc_Num);
			return appointmentsToCreateOnOAB;
		}

		public DataSet Get_Appointments_To_Delete_From_OAB(int Loc_Num)
		{
			DataSet appointmentsToDeleteFromOAB = this.c159fce105a6ad06c71422bf493aa6e90.Get_Appointments_To_Delete_From_OAB(Loc_Num);
			return appointmentsToDeleteFromOAB;
		}

		public DataSet Get_Appointments_To_Update_on_OAB(int Loc_Num)
		{
			DataSet appointmentsToUpdateOnOAB = this.c159fce105a6ad06c71422bf493aa6e90.Get_Appointments_To_Update_on_OAB(Loc_Num);
			return appointmentsToUpdateOnOAB;
		}

		public DataSet Get_Beds_To_Create_on_OAB(int Loc_Num)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Get_Beds_To_Create_on_OAB(Loc_Num);
		}

		public DataSet Get_Beds_To_Delete_From_OAB(int Loc_Num)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Get_Beds_To_Delete_From_OAB(Loc_Num);
		}

		public DataSet Get_Beds_To_Update_on_OAB(int Loc_Num)
		{
			DataSet bedsToUpdateOnOAB = this.c159fce105a6ad06c71422bf493aa6e90.Get_Beds_To_Update_on_OAB(Loc_Num);
			return bedsToUpdateOnOAB;
		}

		public DataSet Get_Clients_To_Create_on_OAB(int Loc_Num)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Get_Clients_To_Create_on_OAB(Loc_Num);
		}

		public DataSet Get_Clients_To_Delete_From_OAB(int Loc_Num)
		{
			DataSet clientsToDeleteFromOAB = this.c159fce105a6ad06c71422bf493aa6e90.Get_Clients_To_Delete_From_OAB(Loc_Num);
			return clientsToDeleteFromOAB;
		}

		public DataSet Get_Clients_To_Update_on_OAB(int Loc_Num)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Get_Clients_To_Update_on_OAB(Loc_Num);
		}

		public DataSet Get_CompanyInfo_For_OAB(int Tantrack_ID)
		{
			DataSet companyInfoForOAB = this.c159fce105a6ad06c71422bf493aa6e90.Get_CompanyInfo_For_OAB(Tantrack_ID);
			return companyInfoForOAB;
		}

		public void Get_ConnectionOABMaster(int OAB_ID)
		{
			// 
			// Current member / type: System.Void TanTrackObjects.OAB::Get_ConnectionOABMaster(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TanTrackObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void Get_ConnectionOABMaster(System.Int32)
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
			DataSet dataSet = this.c159fce105a6ad06c71422bf493aa6e90.IsGoodStanding(OAB_ID);
			return dataSet;
		}

		public bool IsOABDatabase(string conString)
		{
			bool flag = this.c159fce105a6ad06c71422bf493aa6e90.IsOABDatabase(conString);
			return flag;
		}

		public bool OAB_Cleanup_Appointments_On_OAB(DateTime Current_Server_Time)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			bool flag = _dbOAB.OAB_Cleanup_Appointments_On_OAB(Current_Server_Time, str);
			return flag;
		}

		public DataSet Update_Appointment_On_OAB(int Appointment_ID, DateTime Start_Date, int Length, int Tantrack_Bed_ID, int OAB_Bed_ID, int Loc_Num, int OAB_ID)
		{
			DataSet dataSet = this.c159fce105a6ad06c71422bf493aa6e90.Update_Appointment_On_OAB(Appointment_ID, Start_Date, Length, Tantrack_Bed_ID, OAB_Bed_ID, Loc_Num, OAB_ID, this.connMaster);
			return dataSet;
		}

		public bool Update_Appointment_Row_After_Sync(int OAB_Appointment_ID, int Tantrack_Appointment_ID, bool bSynced)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			return _dbOAB.Update_Appointment_Row_After_Sync(OAB_Appointment_ID, Tantrack_Appointment_ID, bSynced, str);
		}

		public bool Update_Appointment_Row_OAB_ID(int Tantrack_ID, int OAB_ID, bool bOAB_Synced, int OAB_Client_ID)
		{
			bool flag = this.c159fce105a6ad06c71422bf493aa6e90.Update_Appointment_Row_OAB_ID(Tantrack_ID, OAB_ID, bOAB_Synced, OAB_Client_ID);
			return flag;
		}

		public DataSet Update_Bed_On_OAB(int OAB_ID, string Name, int Max_Usage_Minutes, int Room_Number, int Loc_Num, string Bed_Type, int iDelay, int TanTrack_ID)
		{
			DataSet dataSet = this.c159fce105a6ad06c71422bf493aa6e90.Update_Bed_On_OAB(OAB_ID, Name, Max_Usage_Minutes, Room_Number, Loc_Num, Bed_Type, iDelay, TanTrack_ID, this.connMaster);
			return dataSet;
		}

		public bool Update_Bed_Row_OAB_ID(int TanTrack_ID, int OAB_ID, bool bOAB_Synced)
		{
			bool flag = this.c159fce105a6ad06c71422bf493aa6e90.Update_Bed_Row_OAB_ID(TanTrack_ID, OAB_ID, bOAB_Synced);
			return flag;
		}

		public DataSet Update_Client_On_OAB(int ID, string First_Name, string Last_Name, string Home_Phone, string Cell_Phone, string Work_Phone, string EMail, bool bAllow_EMail, int OAB_ID)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			DataSet dataSet = _dbOAB.Update_Client_On_OAB(ID, First_Name, Last_Name, Home_Phone, Cell_Phone, Work_Phone, EMail, bAllow_EMail, OAB_ID, str);
			return dataSet;
		}

		public bool Update_Client_Row_OAB_ID(int TanTrack_ID, int OAB_ID, bool bOAB_Synced)
		{
			bool flag = this.c159fce105a6ad06c71422bf493aa6e90.Update_Client_Row_OAB_ID(TanTrack_ID, OAB_ID, bOAB_Synced);
			return flag;
		}

		public bool Update_CompanyInformation_With_OAB_ID(int TanTrack_Company_Information_ID, int OAB_Company_Information_ID)
		{
			return this.c159fce105a6ad06c71422bf493aa6e90.Update_CompanyInformation_With_OAB_ID(TanTrack_Company_Information_ID, OAB_Company_Information_ID);
		}

		public DataSet UpdateCompanyInfo_on_OAB(int TanTrack_ID, int Store_Number, string Company_Name, string Company_Address, string Company_City, string Company_State, string Company_Zip, string Company_Country, string Company_Phone, string Company_EMail, string Company_Web, DateTime Monday_Open, DateTime Monday_Close, bool Monday_bClosed, DateTime Tuesday_Open, DateTime Tuesday_Close, bool Tuesday_bClosed, DateTime Wednesday_Open, DateTime Wednesday_Close, bool Wednesday_bClosed, DateTime Thursday_Open, DateTime Thursday_Close, bool Thursday_bClosed, DateTime Friday_Open, DateTime Friday_Close, bool Friday_bClosed, DateTime Saturday_Open, DateTime Saturday_Close, bool Saturday_bClosed, DateTime Sunday_Open, DateTime Sunday_Close, bool Sunday_bClosed, string EMail_Address, string SMTP_Server, string SMTP_Port, string bSMTP_Authentication_Required, string SMTP_Username, string SMTP_Password, string SMTP_Authentication_Type, bool bSSL, int OAB_ID)
		{
			dbOAB _dbOAB = this.c159fce105a6ad06c71422bf493aa6e90;
			string str = this.connMaster;
			string str1 = this.companyGUID;
			DataSet dataSet = _dbOAB.UpdateCompanyInfo_on_OAB(TanTrack_ID, Store_Number, Company_Name, Company_Address, Company_City, Company_State, Company_Zip, Company_Country, Company_Phone, Company_EMail, Company_Web, Monday_Open, Monday_Close, Monday_bClosed, Tuesday_Open, Tuesday_Close, Tuesday_bClosed, Wednesday_Open, Wednesday_Close, Wednesday_bClosed, Thursday_Open, Thursday_Close, Thursday_bClosed, Friday_Open, Friday_Close, Friday_bClosed, Saturday_Open, Saturday_Close, Saturday_bClosed, Sunday_Open, Sunday_Close, Sunday_bClosed, EMail_Address, SMTP_Server, SMTP_Port, bSMTP_Authentication_Required, SMTP_Username, SMTP_Password, SMTP_Authentication_Type, bSSL, OAB_ID, str, str1);
			return dataSet;
		}
	}
}