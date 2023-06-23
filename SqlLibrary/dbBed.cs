using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlLibrary
{
	public class dbBed : SqlBase
	{
		private SqlParameter[] cd955ea14127f673c1e77e436c7b2d31e;

		public dbBed()
		{
		}

		public DataSet BedTypeList()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d7a);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet BedTypeSearchList()
		{
			DataSet dataSet = new DataSet();
			DataSet dataSet1 = this.ADOFilldataset(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d7a), null, null, null, null, null, null, null, null, null);
			dataSet = dataSet1;
			DataTableCollection tables = dataSet.Tables;
			DataTable item = tables[0];
			DataRow dataRow = item.NewRow();
			DataRow dataRow1 = dataRow;
			dataRow1[0] = "";
			DataTableCollection dataTableCollection = dataSet.Tables;
			DataTable dataTable = dataTableCollection[0];
			dataTable.Rows.InsertAt(dataRow1, 0);
			dataRow1 = null;
			return dataSet;
		}

		public bool DeleteBed(int ID)
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
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d9d), sqlParameter, null, null, null, null, null, null);
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

		public bool DeleteBucket(int ID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6922);
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

		public bool DeleteMaintenance(int ID)
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
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x65f3);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str2 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str2, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool DeleteUV(int id)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6733);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)id), null, null, null, null, null, null);
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

		public decimal GetAverageDuration(int BedID)
		{
			// 
			// Current member / type: System.Decimal SqlLibrary.dbBed::GetAverageDuration(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Decimal GetAverageDuration(System.Int32)
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

		public int getBedID(string name, string store, int max)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e47);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e5e);
			SqlParameter sqlParameter = new SqlParameter(str1, name);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e71);
			dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, store), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e7e), (object)max), null, null, null, null, null, null);
			DataTableCollection tables = dataSet.Tables;
			DataTable item = tables[0];
			DataRow dataRow = item.Rows[0];
			object obj = dataRow[0];
			return Conversions.ToInteger(obj);
		}

		public int GetBedRowCount_NotSynced(string Loc_Num)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5eb0);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
			object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, Loc_Num), null, null, null, null, null, null, null, null);
			int integer = Conversions.ToInteger(obj);
			return integer;
		}

		public string GetBedStatus(int RoomNum, int StoreNum)
		{
			string str;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[2];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
				sqlParameter[0] = new SqlParameter(str1, SqlDbType.Int, 8);
				sqlParameter[0].Value = RoomNum;
				sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
				sqlParameter[1].Value = StoreNum;
				string connection = this.Connection;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b58);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str2, sqlParameter);
				str = Conversions.ToString(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str3 = Conversions.ToString(0);
				str = str3;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public DataSet GetbucketList(int type)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x68f6);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6917), (object)type), null, null, null, null, null, null, null, null);
		}

		public int getGetBed_OAB_ID(int Bed_ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5ee7);
			int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f08), (object)Bed_ID), null, null, null, null, null, null, null, null));
			return integer;
		}

		public int GetLastBed(int locnum)
		{
			// 
			// Current member / type: System.Int32 SqlLibrary.dbBed::GetLastBed(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Int32 GetLastBed(System.Int32)
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

		public DataSet GetUVReading(string ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x65af);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, ID), null, null, null, null, null, null, null, null);
		}

		public DataSet GetUVStat(string ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x65d4);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public bool IsBedUsedByBucket(int ID)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e87);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			DataTableCollection tables = dataSet1.Tables;
			DataTable item = tables[0];
			int count = item.Rows.Count;
			if (count > 0)
			{
				return true;
			}
			return false;
		}

		public bool IsBucketInUse(int ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbBed::IsBucketInUse(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean IsBucketInUse(System.Int32)
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

		public DataSet IsRoomInUse(int RoomNum, int LocNum)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x68d9);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)RoomNum);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null, null, null);
			return dataSet;
		}

		public int IsRoomNumberInUse(int RoomNum, int LocNum)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x68b0);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)RoomNum);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)LocNum), null, null, null, null, null, null, null));
			return integer;
		}

		public DataSet Load(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5db6);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public SqlDataReader Load_Buckets(int BedID, int RoomNum)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x653e);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5986);
				SqlDataReader sqlDataReader1 = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)BedID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a), (object)RoomNum), null, null, null, null, null);
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

		public DataSet LoadBedPackage(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66b7);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadBedStat(string ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6588);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadBuckets(int BedID, int RoomNum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x653e);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5986), (object)BedID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)RoomNum), null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadByRoomNumber(int RoomNum, int LocNum)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e1c);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b2a);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)RoomNum), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum), null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadMaintenance(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x655f);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadPrevNextBed(int ID, bool isPrev, int LocNum)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5dd1);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
			SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5dfc), (object)isPrev);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str2, (object)LocNum), null, null, null, null, null, null);
			return dataSet;
		}

		public SqlDataReader LoadVisit(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6513);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlDataReader sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null);
			return sqlDataReader;
		}

		public DataSet LoadVisitHistory(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6513);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
		}

		public int SaveBedInfo(int ID, string Name, bool OutOfService, string Brand, string Model, string SerialNum, string btmSerialNum, int year, int BedNum, string TopAcryllic, string BtmAcryllic, int LocNum, string BedType, DateTime dtPlaceUse, bool bTimer, int MinUseMinute, int MaxUseMinute, decimal Minutes, decimal Points, int PreTanDelay, int ControllerID, int UnitID, bool bAllowAppointments, decimal Purchased_Price, decimal PricePL_Face, decimal PricePL_Canopy, decimal PricePL_Base, decimal WattagePL_Face, decimal WattagePL_Canopy, decimal WattagePL_Base, bool bBookable_Online, bool bOAB_Synced, int OAB_ID)
		{
			int integer;
			SqlParameter[] sqlParameter = new SqlParameter[32];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d27);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.NVarChar, 50);
			sqlParameter[1].Value = Name;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f17);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Bit, 2);
			sqlParameter[2].Value = OutOfService;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f32);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.NVarChar, 30);
			sqlParameter[3].Value = Brand;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f3f), SqlDbType.NVarChar, 30);
			sqlParameter[4].Value = Model;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f4c);
			sqlParameter[5] = new SqlParameter(str4, SqlDbType.NVarChar, 30);
			sqlParameter[5].Value = SerialNum;
			sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f61), SqlDbType.NVarChar, 30);
			sqlParameter[6].Value = btmSerialNum;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f7c);
			sqlParameter[7] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[7].Value = year;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f87);
			sqlParameter[8] = new SqlParameter(str6, SqlDbType.Int, 8);
			sqlParameter[8].Value = BedNum;
			sqlParameter[9] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f96), SqlDbType.NVarChar, 50);
			sqlParameter[9].Value = TopAcryllic;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5faf);
			sqlParameter[10] = new SqlParameter(str7, SqlDbType.NVarChar, 50);
			sqlParameter[10].Value = BtmAcryllic;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[11] = new SqlParameter(str8, SqlDbType.Int, 8);
			sqlParameter[11].Value = LocNum;
			sqlParameter[12] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d5a), SqlDbType.NVarChar, 50);
			sqlParameter[12].Value = BedType;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fc8);
			sqlParameter[13] = new SqlParameter(str9, SqlDbType.DateTime, 4);
			sqlParameter[13].Value = dtPlaceUse;
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fdf);
			sqlParameter[14] = new SqlParameter(str10, SqlDbType.Bit, 2);
			sqlParameter[14].Value = bTimer;
			sqlParameter[15] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5fee), SqlDbType.Int, 8);
			sqlParameter[15].Value = MinUseMinute;
			sqlParameter[16] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6009), SqlDbType.Int, 8);
			sqlParameter[16].Value = MaxUseMinute;
			sqlParameter[17] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6024), SqlDbType.Decimal, 5);
			sqlParameter[17].Value = Points;
			sqlParameter[18] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6033), SqlDbType.Int, 8);
			sqlParameter[18].Value = PreTanDelay;
			sqlParameter[19] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6042), SqlDbType.Int, 8);
			sqlParameter[19].Value = ControllerID;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x605b);
			sqlParameter[20] = new SqlParameter(str11, SqlDbType.Int, 8);
			sqlParameter[20].Value = UnitID;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6068);
			sqlParameter[21] = new SqlParameter(str12, SqlDbType.Bit, 2);
			sqlParameter[21].Value = bAllowAppointments;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x608f);
			sqlParameter[22] = new SqlParameter(str13, SqlDbType.Decimal);
			sqlParameter[22].Value = Purchased_Price;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x60b0);
			sqlParameter[23] = new SqlParameter(str14, SqlDbType.Decimal);
			sqlParameter[23].Value = PricePL_Face;
			string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x60cb);
			sqlParameter[24] = new SqlParameter(str15, SqlDbType.Decimal);
			sqlParameter[24].Value = PricePL_Canopy;
			sqlParameter[25] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x60ea), SqlDbType.Decimal);
			sqlParameter[25].Value = PricePL_Base;
			sqlParameter[26] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6105), SqlDbType.Decimal);
			sqlParameter[26].Value = WattagePL_Face;
			string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6124);
			sqlParameter[27] = new SqlParameter(str16, SqlDbType.Decimal);
			sqlParameter[27].Value = WattagePL_Canopy;
			sqlParameter[28] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6147), SqlDbType.Decimal);
			sqlParameter[28].Value = WattagePL_Base;
			sqlParameter[29] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6166), SqlDbType.Bit, 2);
			sqlParameter[29].Value = bBookable_Online;
			string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6189);
			sqlParameter[30] = new SqlParameter(str17, SqlDbType.Int, 8);
			sqlParameter[30].Value = bOAB_Synced;
			string str18 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61a2);
			sqlParameter[31] = new SqlParameter(str18, SqlDbType.Int, 8);
			sqlParameter[31].Value = OAB_ID;
			try
			{
				string connection = this.Connection;
				string str19 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61b1);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str19, sqlParameter);
				integer = Conversions.ToInteger(obj);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				string str20 = exception.ToString();
				string str21 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x61d2);
				if (!str20.Contains(str21))
				{
					string str22 = exception.ToString();
					MsgBoxResult msgBoxResult = Interaction.MsgBox(str22, MsgBoxStyle.OkOnly, null);
				}
				else
				{
					string str23 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6209);
					MsgBoxResult msgBoxResult1 = Interaction.MsgBox(str23, MsgBoxStyle.OkOnly, null);
				}
				integer = 0;
				ProjectData.ClearProjectError();
			}
			return integer;
		}

		public bool SaveBedPackage(int BedID, bool chk, decimal Charge, int PandSID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[4];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5986);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = BedID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6758);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Bit, 2);
			sqlParameter[1].Value = chk;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6761);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Money, 9);
			sqlParameter[2].Value = Charge;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x677e);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[3].Value = PandSID;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x678f);
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

		public bool SaveBucket(int ID, string name, int type)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbBed::SaveBucket(System.Int32,System.String,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveBucket(System.Int32,System.String,System.Int32)
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

		public bool SaveBucketCharge(int ID, decimal upcharge, decimal Multiplier, bool IsSelected, bool IsUpgrade, bool IsDowngrade, int Type, int bedid, int roomnum, decimal Store_UpCharge)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[10];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6941);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Decimal, 5);
			sqlParameter[1].Value = upcharge;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6954);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Multiplier;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x696b);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Bit, 2);
			sqlParameter[3].Value = IsSelected;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6982);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[4].Value = Type;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6995);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[5].Value = bedid;
			sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x69a2), SqlDbType.Int, 8);
			sqlParameter[6].Value = roomnum;
			sqlParameter[7] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x69b3), SqlDbType.Decimal, 5);
			sqlParameter[7].Value = Store_UpCharge;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x69d0);
			sqlParameter[8] = new SqlParameter(str6, SqlDbType.Bit, 2);
			sqlParameter[8].Value = IsUpgrade;
			sqlParameter[9] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x69e5), SqlDbType.Bit, 2);
			sqlParameter[9].Value = IsDowngrade;
			try
			{
				string connection = this.Connection;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x69fe);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str7, sqlParameter);
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

		public bool SaveBulbInfo(int ID, bool FaceTanner, int NumberFacialBulbs, int ChangeFaceHours, string FacialManufacturer, string FacialBrand, string FacialModelNumber, int ChangeBulbHours, int NumberTopBulbs, string TopManufacturer, string TopBrand, string TopModelNumber, int NumberBottomBulbs, string BottomManufacturer, string BottomBrand, string BottomModelNumber, int CurrentFaceHour, int CurrentTopHour, DateTime LastChangedFace, DateTime LastChangedtop, int LocNum, int RoomNumber = 0)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbBed::SaveBulbInfo(System.Int32,System.Boolean,System.Int32,System.Int32,System.String,System.String,System.String,System.Int32,System.Int32,System.String,System.String,System.String,System.Int32,System.String,System.String,System.String,System.Int32,System.Int32,System.DateTime,System.DateTime,System.Int32,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveBulbInfo(System.Int32,System.Boolean,System.Int32,System.Int32,System.String,System.String,System.String,System.Int32,System.Int32,System.String,System.String,System.String,System.Int32,System.String,System.String,System.String,System.Int32,System.Int32,System.DateTime,System.DateTime,System.Int32,System.Int32)
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

		public bool SaveMaintenance(int ID, int BedID, DateTime dtmaintenance, int vendorID, string description, bool isNew)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbBed::SaveMaintenance(System.Int32,System.Int32,System.DateTime,System.Int32,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveMaintenance(System.Int32,System.Int32,System.DateTime,System.Int32,System.String,System.Boolean)
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

		public bool SaveSolution(int BedID, string ses1, string ses2, string ses3, string ses4, string ses5, string ses6, string min1, string min2, string min3, string min4, string min5, string min6, string solutionDate)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbBed::SaveSolution(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveSolution(System.Int32,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)
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

		public bool SaveUV(int ID, DateTime dt, double Top, double Bottom, string EmpId, string EmpName)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5986);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.DateTime, 4);
			sqlParameter[1].Value = dt;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66d8), SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Top;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66e1);
			sqlParameter[3] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[3].Value = Bottom;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66f0);
			sqlParameter[4] = new SqlParameter(str3, SqlDbType.Int, 8);
			sqlParameter[4].Value = EmpId;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x66fd);
			sqlParameter[5] = new SqlParameter(str4, SqlDbType.NVarChar, 100);
			sqlParameter[5].Value = EmpName;
			try
			{
				string connection = this.Connection;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x670e);
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

		public DataSet SearchBed(string name, string num, string store, string type, bool IsDemo, bool bSmallSalon)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d0e);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d27);
			SqlParameter sqlParameter = new SqlParameter(str1, name);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d32);
			SqlParameter sqlParameter1 = new SqlParameter(str2, num);
			SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d41), store);
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d5a);
			SqlParameter sqlParameter3 = new SqlParameter(str3, type);
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d6b);
			SqlParameter sqlParameter4 = new SqlParameter(str4, (object)IsDemo);
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5913);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, new SqlParameter(str5, (object)bSmallSalon), null, null, null);
			return dataSet;
		}

		public bool UpdateTanBed(int roomnum, int storenum, bool IsDeleted, bool IsAdded)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6af7);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x69a2), (object)roomnum);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)storenum);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b32);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)IsDeleted);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b47);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str3, (object)IsAdded), null, null, null);
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

		public DataSet VendorList()
		{
			string connection = this.Connection;
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6696), null, null, null, null, null, null, null, null, null);
			return dataSet;
		}
	}
}