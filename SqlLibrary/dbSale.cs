using A;
using ErrorHandler;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SqlLibrary
{
	public class dbSale : SqlBase
	{
		public dbSale()
		{
		}

		public DataSet CategoryList()
		{
			// 
			// Current member / type: System.Data.DataSet SqlLibrary.dbSale::CategoryList()
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet CategoryList()
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

		public bool CCReqResp(string Req, string Resp, int store, int drawer)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[4];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8536);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.NVarChar, 0x3e8);
				sqlParameter[0].Value = Req;
				sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x853f), SqlDbType.NVarChar, 0x3e8);
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

		public object Create_ClientSalesAverages_SummaryData(DateTime dtStart, DateTime dtEnd, int LocNum, decimal PriceLow, decimal PriceHigh, bool bIncludeAllSales)
		{
			object obj;
			try
			{
				SqlConnection sqlConnection = new SqlConnection();
				SqlCommand sqlCommand = new SqlCommand();
				SqlParameter[] sqlParameter = new SqlParameter[7];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d31);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.Date);
				sqlParameter[0].Value = dtStart;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7d48);
				sqlParameter[1] = new SqlParameter(str1, SqlDbType.Date);
				sqlParameter[1].Value = dtEnd;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e42);
				sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal);
				sqlParameter[2].Value = PriceLow;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e11);
				sqlParameter[3] = new SqlParameter(str3, SqlDbType.Decimal);
				sqlParameter[3].Value = PriceHigh;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7df6);
				sqlParameter[4] = new SqlParameter(str4, SqlDbType.Int);
				sqlParameter[4].Value = LocNum;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7e71);
				sqlParameter[5] = new SqlParameter(str5, SqlDbType.Int);
				sqlParameter[5].Value = bIncludeAllSales;
				string connection = this.Connection;
				sqlConnection.ConnectionString = connection;
				sqlConnection.Open();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.Add(sqlParameter[0]);
				SqlParameter sqlParameter1 = sqlCommand.Parameters.Add(sqlParameter[1]);
				SqlParameter sqlParameter2 = sqlCommand.Parameters.Add(sqlParameter[2]);
				SqlParameterCollection parameters = sqlCommand.Parameters;
				SqlParameter sqlParameter3 = parameters.Add(sqlParameter[3]);
				SqlParameterCollection sqlParameterCollection = sqlCommand.Parameters;
				SqlParameter sqlParameter4 = sqlParameterCollection.Add(sqlParameter[4]);
				SqlParameterCollection parameters1 = sqlCommand.Parameters;
				SqlParameter sqlParameter5 = parameters1.Add(sqlParameter[5]);
				sqlCommand.Connection = sqlConnection;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13497);
				sqlCommand.CommandText = str6;
				sqlCommand.CommandTimeout = 0x12c;
				int num = sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
				obj = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				obj = false;
				ProjectData.ClearProjectError();
			}
			return obj;
		}

		public bool Create_SalesAveragesData(DateTime dtStart, DateTime dtEnd, int LocNum, int RequestLocNum)
		{
			bool flag;
			try
			{
				SqlConnection sqlConnection = new SqlConnection();
				SqlCommand sqlCommand = new SqlCommand();
				SqlParameter[] sqlParameter = new SqlParameter[4];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7457);
				sqlParameter[0] = new SqlParameter(str, SqlDbType.Date);
				sqlParameter[0].Value = dtStart;
				sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9579), SqlDbType.Date);
				sqlParameter[1].Value = dtEnd;
				sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int);
				sqlParameter[2].Value = LocNum;
				sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x134f0), SqlDbType.Int);
				sqlParameter[3].Value = RequestLocNum;
				string connection = this.Connection;
				sqlConnection.ConnectionString = connection;
				sqlConnection.Open();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.Add(sqlParameter[0]);
				SqlParameterCollection parameters = sqlCommand.Parameters;
				parameters.Add(sqlParameter[1]);
				SqlParameterCollection sqlParameterCollection = sqlCommand.Parameters;
				SqlParameter sqlParameter1 = sqlParameterCollection.Add(sqlParameter[2]);
				SqlParameterCollection parameters1 = sqlCommand.Parameters;
				SqlParameter sqlParameter2 = parameters1.Add(sqlParameter[3]);
				sqlCommand.Connection = sqlConnection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1350d);
				sqlCommand.CommandText = str1;
				sqlCommand.CommandTimeout = 0x12c;
				int num = sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
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

		public bool DeleteEFT(int EFTQueueID, bool bAll)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = EFTQueueID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x90d8), SqlDbType.Bit);
			sqlParameter[1].Value = bAll;
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x90e3);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter);
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

		public bool Deletesale(int SaleID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14631);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a62);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)SaleID), null, null, null, null, null, null);
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

		public bool FreezeClientPacakge(int EFTQueueID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1394d), SqlDbType.Int, 8) };
			sqlParameter[0].Value = EFTQueueID;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14466), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public DataSet FrozenPackageList(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1373e);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public bool GenerateClientHistoricData(int StoreNumber)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14096);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)StoreNumber), null, null, null, null, null, null);
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

		public DataSet GetClientEmail(int ClientID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x138af);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ClientID), null, null, null, null, null, null, null, null);
				dataSet = (DataSet)dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public SqlDataReader GetEFT_Payments(int LocNum, int Part, decimal tax1, decimal tax2, decimal tax3)
		{
			SqlDataReader sqlDataReader;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x140d1);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71c9);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)Part);
				SqlParameter sqlParameter2 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4), (object)tax1);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df);
				sqlDataReader = this.ADOFillReader(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str2, (object)tax2), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea), (object)tax3), null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str3 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str3, MsgBoxStyle.OkOnly, null);
				sqlDataReader = null;
				ProjectData.ClearProjectError();
			}
			return sqlDataReader;
		}

		public DataSet GetEFTACH_Payments(int LocNum, decimal tax1, decimal tax2, decimal tax3, DateTime dtDue)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14108);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)LocNum);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)tax1);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)tax2);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str4, (object)tax3), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14139), (object)dtDue), null, null, null, null);
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

		public DataSet GETEFTACHPaymentsProcessed(int LocNum, decimal tax1, decimal tax2, decimal tax3, int TopN)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14146);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), (object)LocNum);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)tax1);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)tax2);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea);
				SqlParameter sqlParameter3 = new SqlParameter(str3, (object)tax3);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14189);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, new SqlParameter(str4, (object)TopN), null, null, null, null);
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

		public DataSet GetEFTPayments(int LocNum, decimal tax1, decimal tax2, decimal tax3, bool bACH = false)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14041);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)LocNum);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71d4), (object)tax1);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71df);
				SqlParameter sqlParameter2 = new SqlParameter(str2, (object)tax2);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x71ea);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str3, (object)tax3), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1406c), (object)bACH), null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str4 = exception.ToString();
				Interaction.MsgBox(str4, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public decimal getGiftAmount(string SerialNumber)
		{
			decimal zero;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13858);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f4c);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, SerialNumber), null, null, null, null, null, null, null, null);
				decimal num = Conversions.ToDecimal(obj);
				zero = num;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				zero = decimal.Zero;
				ProjectData.ClearProjectError();
			}
			return zero;
		}

		public string getGiftID(string SerialNumber)
		{
			string str;
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13879);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str1, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5f4c), SerialNumber), null, null, null, null, null, null, null, null);
				string str2 = Conversions.ToString(obj);
				str = str2;
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

		public string GetLastProductDate(int ClientID)
		{
			// 
			// Current member / type: System.String SqlLibrary.dbSale::GetLastProductDate(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String GetLastProductDate(System.Int32)
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

		public string GetLastProductName(int ClientID)
		{
			// 
			// Current member / type: System.String SqlLibrary.dbSale::GetLastProductName(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.String GetLastProductName(System.Int32)
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

		public DataTable GetPandSbySKU(string sku, int storenum)
		{
			DataTable dataTable;
			try
			{
				DataSet dataSet = new DataSet();
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1464c);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13405);
				SqlParameter sqlParameter = new SqlParameter(str1, sku);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)storenum), null, null, null, null, null, null, null);
				DataTableCollection tables = dataSet1.Tables;
				DataTable item = tables[0];
				dataTable = item;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataTable = null;
				ProjectData.ClearProjectError();
			}
			return dataTable;
		}

		public int getPandSID(string SKU)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x12206);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1216d);
			DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, SKU), null, null, null, null, null, null, null, null);
			DataTableCollection tables = dataSet1.Tables;
			DataTable item = tables[0];
			DataRowCollection rows = item.Rows;
			DataRow dataRow = rows[0];
			object obj = dataRow[0];
			int integer = Conversions.ToInteger(obj);
			return integer;
		}

		public int GetSaleID(int ClientID, int SalePersonID, decimal SubTotal, int LocNum)
		{
			int integer;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13edd);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ClientID);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139b2), (object)SalePersonID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e5b);
				SqlParameter sqlParameter2 = new SqlParameter(str1, (object)SubTotal);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, new SqlParameter(str2, (object)LocNum), null, null, null, null, null);
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

		public decimal getTax1()
		{
			decimal zero;
			try
			{
				decimal num = Conversions.ToDecimal(this.ADOFillScalar(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13819), null, null, null, null, null, null, null, null, null));
				zero = num;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				zero = decimal.Zero;
				ProjectData.ClearProjectError();
			}
			return zero;
		}

		public decimal getTax2()
		{
			decimal zero;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1382e);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				decimal num = Conversions.ToDecimal(obj);
				zero = num;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				zero = decimal.Zero;
				ProjectData.ClearProjectError();
			}
			return zero;
		}

		public decimal getTax3()
		{
			decimal zero;
			try
			{
				string connection = this.Connection;
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13843), null, null, null, null, null, null, null, null, null);
				decimal num = Conversions.ToDecimal(obj);
				zero = num;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				zero = decimal.Zero;
				ProjectData.ClearProjectError();
			}
			return zero;
		}

		public bool GiftCertificateExist(string SerialNumber)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::GiftCertificateExist(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean GiftCertificateExist(System.String)
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

		public bool HasFrozenEFT(int ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::HasFrozenEFT(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean HasFrozenEFT(System.Int32)
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

		public bool IsACHFileUsed(string File_Name)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::IsACHFileUsed(System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean IsACHFileUsed(System.String)
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

		public bool isEFTRefunded(int ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::isEFTRefunded(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean isEFTRefunded(System.Int32)
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

		public bool isPackageUsed(int ID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::isPackageUsed(System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean isPackageUsed(System.Int32)
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

		public DataSet LoadItem(int id, string serialnum = null)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14493);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			SqlParameter sqlParameter = new SqlParameter(str1, (object)id);
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1216d);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, serialnum), null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadPandSTaxes(string PandSID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13898);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), PandSID), null, null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadSaleItems(int ClientID, DateTime dt)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1392a);
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ClientID);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5684);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)dt), null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadTop(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13474);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet PackageNameList(string ID, int ClientID, bool bDemo = false)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x136a6);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, ID);
				SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), (object)ClientID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str2, (object)bDemo), null, null, null, null, null, null);
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

		public DataSet PackageSKUList(string ID, int ClientID, bool bDemo = false)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x136a6);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str2, (object)ClientID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d), (object)bDemo), null, null, null, null, null, null);
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

		public DataSet PandSList(int ID, int storeNum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14612);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65), (object)storeNum), null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str2 = exception.ToString();
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x77ac);
				bool flag = str2.Contains(str3);
				if (flag)
				{
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xe629);
					Interaction.MsgBox(str4, MsgBoxStyle.OkOnly, null);
				}
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public int PandSType(string SKU)
		{
			int integer;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x145f3);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1216d);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, SKU), null, null, null, null, null, null, null, null);
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

		public bool ProcessVacationHold(int StoreNumber)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14077);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)StoreNumber), null, null, null, null, null, null);
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

		public DataSet ProductNameList(string ID, int storeNum, bool bDemo = false)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13652);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				SqlParameter sqlParameter1 = new SqlParameter(str2, (object)storeNum);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str3, (object)bDemo), null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet ProductSKUList(string ID, int storeNum, bool bdemo = false)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1367d);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), ID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)storeNum), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d), (object)bdemo), null, null, null, null, null, null);
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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public int Save_Sale(int ClientID, int SalePersonID, decimal Tax1, decimal Tax2, decimal Tax3, decimal SubTotal, string SalePerson, string ClientName, int LocNum, int DrawNum, int CompanyID, bool bUsedtSale, DateTime dtSale)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[13];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ClientID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139b2), SqlDbType.Int, 8);
			sqlParameter[1].Value = SalePersonID;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa756), SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Tax1;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa761);
			sqlParameter[3] = new SqlParameter(str1, SqlDbType.Decimal, 5);
			sqlParameter[3].Value = Tax2;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa76c), SqlDbType.Decimal, 5);
			sqlParameter[4].Value = Tax3;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e5b);
			sqlParameter[5] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[5].Value = SubTotal;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139cd);
			sqlParameter[6] = new SqlParameter(str3, SqlDbType.NVarChar, 100);
			sqlParameter[6].Value = SalePerson;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e);
			sqlParameter[7] = new SqlParameter(str4, SqlDbType.NVarChar, 100);
			sqlParameter[7].Value = ClientName;
			sqlParameter[8] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
			sqlParameter[8].Value = LocNum;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139e4);
			sqlParameter[9] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[9].Value = DrawNum;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139f9);
			sqlParameter[10] = new SqlParameter(str6, SqlDbType.Int, 8);
			sqlParameter[10].Value = CompanyID;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13eb7);
			sqlParameter[11] = new SqlParameter(str7, SqlDbType.Bit);
			sqlParameter[11].Value = bUsedtSale;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13ece);
			sqlParameter[12] = new SqlParameter(str8, SqlDbType.DateTime);
			sqlParameter[12].Value = dtSale;
			try
			{
				string connection = this.Connection;
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e6e), sqlParameter);
				int integer = Conversions.ToInteger(obj);
				num = integer;
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				Exception exception = exception2;
				try
				{
					string productName = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996.Info.ProductName;
					string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a37);
					string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a42);
					(new frmError(exception, productName, str9, str10)).ShowDialog();
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public bool SaveCardprocess(bool bapproved, string last4, decimal amt, string response, int ClientID, int EFTID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[6];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9127);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.NVarChar, 5);
			sqlParameter[0].Value = last4;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7477), SqlDbType.Decimal, 5);
			sqlParameter[1].Value = amt;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9134), SqlDbType.NVarChar, 0xff);
			sqlParameter[2].Value = response;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[3] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[3].Value = ClientID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9147);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[4].Value = EFTID;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9154);
			sqlParameter[5] = new SqlParameter(str3, SqlDbType.Bit, 2);
			sqlParameter[5].Value = bapproved;
			try
			{
				string connection = this.Connection;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x9169);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str4, sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str5 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str5, MsgBoxStyle.OkOnly, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x918e));
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveClientPackage(int PandSID, string ItemName, int GiftID, double Qty, string Description, int PerformerID, string Performer, double Total, double Tax, int ClientID, string PandSName, int PayMonth, double setupFee, int LocNum, int SaleID, int? Expiry_Months, int? Expiry_Days, DateTime? dtForced, int? Start_Type_ID, int? End_Type_ID, DateTime? exp, bool bRollover, bool bActivate_First_Use, DateTime? dtStartForced)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::SaveClientPackage(System.Int32,System.String,System.Int32,System.Double,System.String,System.Int32,System.String,System.Double,System.Double,System.Int32,System.String,System.Int32,System.Double,System.Int32,System.Int32,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.Nullable`1<System.DateTime>,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.Nullable`1<System.DateTime>,System.Boolean,System.Boolean,System.Nullable`1<System.DateTime>)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveClientPackage(System.Int32,System.String,System.Int32,System.Double,System.String,System.Int32,System.String,System.Double,System.Double,System.Int32,System.String,System.Int32,System.Double,System.Int32,System.Int32,System.Nullable<System.Int32>,System.Nullable<System.Int32>,System.Nullable<System.DateTime>,System.Nullable<System.Int32>,System.Nullable<System.Int32>,System.Nullable<System.DateTime>,System.Boolean,System.Boolean,System.Nullable<System.DateTime>)
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

		public bool SaveEFTPayment(int ClientID, string clientName, int packageID, string PackageName, DateTime dueDate, decimal amt, decimal Tax1, decimal Tax2, decimal Tax3, bool bProcesseD, int SaleID, string str, int LocNum, DateTime dtPackageExpire)
		{
			bool flag;
			try
			{
				SqlParameter[] sqlParameter = new SqlParameter[11];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
				sqlParameter[0] = new SqlParameter(str1, SqlDbType.Int, 8);
				sqlParameter[0].Value = ClientID;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13ef6);
				sqlParameter[1] = new SqlParameter(str2, SqlDbType.NVarChar, 100);
				sqlParameter[1].Value = clientName;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f0d);
				sqlParameter[2] = new SqlParameter(str3, SqlDbType.Int, 8);
				sqlParameter[2].Value = packageID;
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x73e5);
				sqlParameter[3] = new SqlParameter(str4, SqlDbType.NVarChar, 50);
				sqlParameter[3].Value = PackageName;
				sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f22), SqlDbType.DateTime, 4);
				sqlParameter[4].Value = dueDate;
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7477);
				sqlParameter[5] = new SqlParameter(str5, SqlDbType.Decimal, 5);
				sqlParameter[5].Value = amt;
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f33);
				sqlParameter[6] = new SqlParameter(str6, SqlDbType.Bit, 2);
				sqlParameter[6].Value = bProcesseD;
				string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a62);
				sqlParameter[7] = new SqlParameter(str7, SqlDbType.Int, 8);
				sqlParameter[7].Value = SaleID;
				sqlParameter[8] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8ee4), SqlDbType.NVarChar, 100);
				sqlParameter[8].Value = str;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				sqlParameter[9] = new SqlParameter(str8, SqlDbType.Int, 8);
				sqlParameter[9].Value = LocNum;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f4a);
				sqlParameter[10] = new SqlParameter(str9, SqlDbType.DateTime, 4);
				sqlParameter[10].Value = dtPackageExpire;
				this.ADOFillNonQuery(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f6b), sqlParameter);
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

		public bool SaveEFTPaymentStatus(int EFTQueueID, string Status)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[2];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1394d);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = EFTQueueID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14428);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.NVarChar, 100);
			sqlParameter[1].Value = Status;
			try
			{
				try
				{
					string connection = this.Connection;
					int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14437), sqlParameter);
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
			}
			finally
			{
				sqlParameter = null;
			}
			return flag;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool SaveEFTQueueItem(int PandSID, double Qty, double Total, double Tax1, double Tax2, double Tax3, int ClientID, string PandSName, int ClientPackageID, int EFTQueueID, int SaleID, bool bApprove, string Status, string Upload_File_name)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[14];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x677e);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = PandSID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7411);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Decimal, 5);
			sqlParameter[1].Value = Qty;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a55);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Total;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa756);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Decimal, 5);
			sqlParameter[3].Value = Tax1;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa761);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Decimal, 5);
			sqlParameter[4].Value = Tax2;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa76c);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Decimal, 5);
			sqlParameter[5].Value = Tax3;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[6] = new SqlParameter(str6, SqlDbType.Int, 8);
			sqlParameter[6].Value = ClientID;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7fb2);
			sqlParameter[7] = new SqlParameter(str7, SqlDbType.NVarChar, 100);
			sqlParameter[7].Value = PandSName;
			sqlParameter[8] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7429), SqlDbType.Int, 8);
			sqlParameter[8].Value = ClientPackageID;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1394d);
			sqlParameter[9] = new SqlParameter(str8, SqlDbType.Int, 8);
			sqlParameter[9].Value = EFTQueueID;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a62);
			sqlParameter[10] = new SqlParameter(str9, SqlDbType.Int, 8);
			sqlParameter[10].Value = SaleID;
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13964);
			sqlParameter[11] = new SqlParameter(str10, SqlDbType.Bit, 2);
			sqlParameter[11].Value = bApprove;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13977);
			sqlParameter[12] = new SqlParameter(str11, SqlDbType.NVarChar, 100);
			sqlParameter[12].Value = Status;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a71);
			sqlParameter[13] = new SqlParameter(str12, SqlDbType.NVarChar, 200);
			sqlParameter[13].Value = Upload_File_name;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a94), sqlParameter);
				flag = true;
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				Exception exception = exception2;
				try
				{
					cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
					AssemblyInfo info = _cef4fffd9795b6af60f35514532347eb4.Info;
					string productName = info.ProductName;
					string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a37);
					string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a42);
					DialogResult dialogResult = (new frmError(exception, productName, str13, str14)).ShowDialog();
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool SaveEFTQueueItemACH(int ClientPackageID, int EFTQueueID, bool bApprove, string Status, string Import_File_name, string ReferenceNum, string AuthNum, int ClientID, int SalePersonID, decimal tax1, decimal tax2, decimal tax3, string SalePerson, int LocNum, int DrawerNum, int CompanyID, string Description)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[17];
			sqlParameter[0] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7429), SqlDbType.Int, 8);
			sqlParameter[0].Value = ClientPackageID;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1394d);
			sqlParameter[1] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[1].Value = EFTQueueID;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13964), SqlDbType.Bit, 2);
			sqlParameter[2].Value = bApprove;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13977);
			sqlParameter[3] = new SqlParameter(str1, SqlDbType.NVarChar, 100);
			sqlParameter[3].Value = Status;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13907);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.NVarChar, 200);
			sqlParameter[4].Value = Import_File_name;
			sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13986), SqlDbType.NVarChar, 100);
			sqlParameter[5].Value = AuthNum;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13997);
			sqlParameter[6] = new SqlParameter(str3, SqlDbType.NVarChar, 100);
			sqlParameter[6].Value = ReferenceNum;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[7] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[7].Value = ClientID;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139b2);
			sqlParameter[8] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[8].Value = SalePersonID;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa756);
			sqlParameter[9] = new SqlParameter(str6, SqlDbType.Decimal, 5);
			sqlParameter[9].Value = tax1;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa761);
			sqlParameter[10] = new SqlParameter(str7, SqlDbType.Decimal, 5);
			sqlParameter[10].Value = tax2;
			sqlParameter[11] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa76c), SqlDbType.Decimal, 5);
			sqlParameter[11].Value = tax3;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139cd);
			sqlParameter[12] = new SqlParameter(str8, SqlDbType.NVarChar, 100);
			sqlParameter[12].Value = SalePerson;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[13] = new SqlParameter(str9, SqlDbType.Int, 8);
			sqlParameter[13].Value = LocNum;
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139e4);
			sqlParameter[14] = new SqlParameter(str10, SqlDbType.Int, 8);
			sqlParameter[14].Value = DrawerNum;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139f9);
			sqlParameter[15] = new SqlParameter(str11, SqlDbType.Int, 8);
			sqlParameter[15].Value = CompanyID;
			sqlParameter[16] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xf204), SqlDbType.NVarChar, 100);
			sqlParameter[16].Value = Description;
			try
			{
				string connection = this.Connection;
				string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a0e);
				this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str12, sqlParameter);
				flag = true;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				string productName = _cef4fffd9795b6af60f35514532347eb4.Info.ProductName;
				string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a37);
				string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a42);
				DialogResult dialogResult = (new frmError(exception, productName, str13, str14)).ShowDialog();
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveGiftDetail(int GiftID, string Serial_Number, decimal Amount, int Client_ID, string Client_Name, short Trans_Type, int Trans_ID, int Loc_Num, short Area_ID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[9];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13b47);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = GiftID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14194), SqlDbType.NVarChar, 30);
			sqlParameter[1].Value = Serial_Number;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8594);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Amount;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x141b1), SqlDbType.Int, 8);
			sqlParameter[3].Value = Client_ID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x973e);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.NVarChar, 250);
			sqlParameter[4].Value = Client_Name;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x141c6);
			sqlParameter[5] = new SqlParameter(str3, SqlDbType.TinyInt);
			sqlParameter[5].Value = Trans_Type;
			sqlParameter[6] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x141dd), SqlDbType.Int, 8);
			sqlParameter[6].Value = Trans_ID;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5e0b);
			sqlParameter[7] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[7].Value = Loc_Num;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x141f0);
			sqlParameter[8] = new SqlParameter(str5, SqlDbType.Int, 8);
			sqlParameter[8].Value = Area_ID;
			try
			{
				try
				{
					string connection = this.Connection;
					string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14201);
					object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str6, sqlParameter);
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
			}
			finally
			{
				sqlParameter = null;
			}
			return flag;
		}

		public bool SaveItem(int PandSID, string ItemName, string GiftID, double Qty, string Description, int PerformerID, string Performer, double Total, double Tax, int ClientID, string PandSName, int PayMonth, double setupFee, int LocNum, int CompanyID, int saleid, decimal Tax1, decimal Tax2, decimal Tax3, int CouponID, string CouponName, int Discount_Type, int Discount_Item_Type, decimal Amount, int? Expiry_Months, int? Expiry_Days, DateTime? dtForced, int? Start_Type_ID, int? End_Type_ID, DateTime? exp, bool bRollover, DateTime? dtStartForced)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::SaveItem(System.Int32,System.String,System.String,System.Double,System.String,System.Int32,System.String,System.Double,System.Double,System.Int32,System.String,System.Int32,System.Double,System.Int32,System.Int32,System.Int32,System.Decimal,System.Decimal,System.Decimal,System.Int32,System.String,System.Int32,System.Int32,System.Decimal,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.Nullable`1<System.DateTime>,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.Nullable`1<System.DateTime>,System.Boolean,System.Nullable`1<System.DateTime>)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveItem(System.Int32,System.String,System.String,System.Double,System.String,System.Int32,System.String,System.Double,System.Double,System.Int32,System.String,System.Int32,System.Double,System.Int32,System.Int32,System.Int32,System.Decimal,System.Decimal,System.Decimal,System.Int32,System.String,System.Int32,System.Int32,System.Decimal,System.Nullable<System.Int32>,System.Nullable<System.Int32>,System.Nullable<System.DateTime>,System.Nullable<System.Int32>,System.Nullable<System.Int32>,System.Nullable<System.DateTime>,System.Boolean,System.Nullable<System.DateTime>)
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
		public bool SavePayment(string Type, string ReferenceNum, string Expiry, decimal Amount, string AuthNum, string GiftNum, string NameOnCard, string Response, string TroutD, string Result, string CCType, decimal cashvalue, bool bswiped, decimal Tip, int SaleID, decimal RoundedAmount, string RefNum = "", bool IsClientScreen = false)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::SavePayment(System.String,System.String,System.String,System.Decimal,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Decimal,System.Boolean,System.Decimal,System.Int32,System.Decimal,System.String,System.Boolean)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SavePayment(System.String,System.String,System.String,System.Decimal,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Decimal,System.Boolean,System.Decimal,System.Int32,System.Decimal,System.String,System.Boolean)
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

		public int SaveRefund(int ClientID, int SalePersonID, decimal Tax1, decimal Tax2, decimal Tax3, decimal SubTotal, string SalePerson, string ClientName, int LocNum, int DrawerNum, int CompanyID, bool bRefund = true)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[12];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ClientID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139b2);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = SalePersonID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa756);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Tax1;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa761);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Decimal, 5);
			sqlParameter[3].Value = Tax2;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa76c);
			sqlParameter[4] = new SqlParameter(str4, SqlDbType.Decimal, 5);
			sqlParameter[4].Value = Tax3;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e5b);
			sqlParameter[5] = new SqlParameter(str5, SqlDbType.Decimal, 5);
			sqlParameter[5].Value = SubTotal;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139cd);
			sqlParameter[6] = new SqlParameter(str6, SqlDbType.NVarChar, 100);
			sqlParameter[6].Value = SalePerson;
			sqlParameter[7] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e), SqlDbType.NVarChar, 100);
			sqlParameter[7].Value = ClientName;
			sqlParameter[8] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
			sqlParameter[8].Value = LocNum;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139e4);
			sqlParameter[9] = new SqlParameter(str7, SqlDbType.Int, 8);
			sqlParameter[9].Value = DrawerNum;
			sqlParameter[10] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139f9), SqlDbType.Int, 8);
			sqlParameter[10].Value = CompanyID;
			sqlParameter[11] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14230), SqlDbType.Bit, 2);
			sqlParameter[11].Value = bRefund;
			try
			{
				try
				{
					string connection = this.Connection;
					string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14241);
					object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str8, sqlParameter);
					int integer = Conversions.ToInteger(obj);
					num = integer;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					string str9 = exception.ToString();
					MsgBoxResult msgBoxResult = Interaction.MsgBox(str9, MsgBoxStyle.OkOnly, null);
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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool SaveRefundItem(int SaleDetailID, double Qty, double Total, double Tax1, double Tax2, double Tax3, int SaleID, int perfID, string perfName, bool Inventory)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[10];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13dad);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = SaleDetailID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7411), SqlDbType.Decimal, 5);
			sqlParameter[1].Value = Qty;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a55);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Total;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa756);
			sqlParameter[3] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[3].Value = Tax1;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa761);
			sqlParameter[4] = new SqlParameter(str3, SqlDbType.Decimal, 5);
			sqlParameter[4].Value = Tax2;
			sqlParameter[5] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa76c), SqlDbType.Decimal, 5);
			sqlParameter[5].Value = Tax3;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a62);
			sqlParameter[6] = new SqlParameter(str4, SqlDbType.Int, 8);
			sqlParameter[6].Value = SaleID;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13b56);
			sqlParameter[7] = new SqlParameter(str5, SqlDbType.Decimal, 5);
			sqlParameter[7].Value = perfID;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13dc8);
			sqlParameter[8] = new SqlParameter(str6, SqlDbType.NVarChar, 100);
			sqlParameter[8].Value = perfName;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13de5);
			sqlParameter[9] = new SqlParameter(str7, SqlDbType.Bit, 2);
			sqlParameter[9].Value = Inventory;
			try
			{
				string connection = this.Connection;
				string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13dfa);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str8, sqlParameter);
				flag = true;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				cef4fffd9795b6af60f35514532347eb4 _cef4fffd9795b6af60f35514532347eb4 = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996;
				AssemblyInfo info = _cef4fffd9795b6af60f35514532347eb4.Info;
				string productName = info.ProductName;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e23);
				string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e32);
				DialogResult dialogResult = (new frmError(exception, productName, str9, str10)).ShowDialog();
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public bool SaveRefundPayment(string Type, string ReferenceNum, string Expiry, decimal Amount, string AuthNum, string GiftNum, string NameOnCard, string Response, string TroutD, string Result, string CCType, decimal cashvalue, bool bswiped, decimal Tip, int clientid, string clientname, int locnum, int SaleID, bool binsertGiftDetail, string RefNum = "")
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::SaveRefundPayment(System.String,System.String,System.String,System.Decimal,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Decimal,System.Boolean,System.Decimal,System.Int32,System.String,System.Int32,System.Int32,System.Boolean,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveRefundPayment(System.String,System.String,System.String,System.Decimal,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Decimal,System.Boolean,System.Decimal,System.Int32,System.String,System.Int32,System.Int32,System.Boolean,System.String)
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
		public bool SaveSale(int ClientID, int SalePersonID, decimal Tax1, decimal Tax2, decimal Tax3, decimal SubTotal, string SalePerson, string ClientName, int LocNum, int DrawNum, int CompanyID)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[11];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ClientID;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139b2);
			sqlParameter[1] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[1].Value = SalePersonID;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa756);
			sqlParameter[2] = new SqlParameter(str2, SqlDbType.Decimal, 5);
			sqlParameter[2].Value = Tax1;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa761);
			sqlParameter[3] = new SqlParameter(str3, SqlDbType.Decimal, 5);
			sqlParameter[3].Value = Tax2;
			sqlParameter[4] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xa76c), SqlDbType.Decimal, 5);
			sqlParameter[4].Value = Tax3;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e5b);
			sqlParameter[5] = new SqlParameter(str4, SqlDbType.Decimal, 5);
			sqlParameter[5].Value = SubTotal;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139cd);
			sqlParameter[6] = new SqlParameter(str5, SqlDbType.NVarChar, 100);
			sqlParameter[6].Value = SalePerson;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b4e);
			sqlParameter[7] = new SqlParameter(str6, SqlDbType.NVarChar, 100);
			sqlParameter[7].Value = ClientName;
			sqlParameter[8] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675), SqlDbType.Int, 8);
			sqlParameter[8].Value = LocNum;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139e4);
			sqlParameter[9] = new SqlParameter(str7, SqlDbType.Int, 8);
			sqlParameter[9].Value = DrawNum;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x139f9);
			sqlParameter[10] = new SqlParameter(str8, SqlDbType.Int, 8);
			sqlParameter[10].Value = CompanyID;
			try
			{
				string connection = this.Connection;
				string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e6e);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str9, sqlParameter);
				flag = true;
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				Exception exception = exception2;
				try
				{
					AssemblyInfo info = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996.Info;
					string productName = info.ProductName;
					string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a37);
					frmError _frmError = new frmError(exception, productName, str10, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a42));
					DialogResult dialogResult = _frmError.ShowDialog();
					_frmError = null;
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public int SaveSaleXML(string xmlSales)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[1];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e8b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Xml);
			SqlParameter sqlParameter1 = sqlParameter[0];
			string str1 = xmlSales.ToString();
			sqlParameter1.Value = str1;
			try
			{
				try
				{
					string connection = this.Connection;
					string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13e94);
					object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str2, sqlParameter);
					int integer = Conversions.ToInteger(obj);
					num = integer;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					string str3 = exception.ToString();
					Interaction.MsgBox(str3, MsgBoxStyle.OkOnly, null);
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

		public bool SaveUpgradePackage(int PandSID, decimal Balance, decimal Tax1, decimal Tax2, decimal Tax3, decimal ClientID, int ClientPakcageID, int BucketID, int RoomNumber, int Qty, int Duration, int LocNum, int CouponID, string CouponName, int Discount_Type, int Discount_Item_Type, decimal Amount, bool bStoreUpcharge, int SaleID)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSale::SaveUpgradePackage(System.Int32,System.Decimal,System.Decimal,System.Decimal,System.Decimal,System.Decimal,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.String,System.Int32,System.Int32,System.Decimal,System.Boolean,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveUpgradePackage(System.Int32,System.Decimal,System.Decimal,System.Decimal,System.Decimal,System.Decimal,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.String,System.Int32,System.Int32,System.Decimal,System.Boolean,System.Int32)
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

		public DataSet ServiceNameList(string ID, bool bDemo = false, int performerID = 0)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x136d1);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), ID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d);
				SqlParameter sqlParameter1 = new SqlParameter(str1, (object)bDemo);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x136fc);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str2, (object)performerID), null, null, null, null, null, null);
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

		public DataSet ServicePerformer(int ID)
		{
			DataSet dataSet = new DataSet();
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13544);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
			DataTable item = dataSet.Tables[0];
			DataRow dataRow = item.NewRow();
			DataRow dataRow1 = dataRow;
			dataRow1[0] = 0;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x4fb6);
			dataRow1[1] = str2;
			DataTableCollection tables = dataSet.Tables;
			DataTable dataTable = tables[0];
			DataRowCollection rows = dataTable.Rows;
			rows.InsertAt(dataRow1, 0);
			dataRow1 = null;
			return dataSet;
		}

		public DataSet ServiceSKUList(string ID, bool bDemo = false)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13715);
				SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), ID);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x710d);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, new SqlParameter(str1, (object)bDemo), null, null, null, null, null, null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool UpdateClientToken(int clientid, string token)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b3b), SqlDbType.Int, 8), null };
			sqlParameter[0].Value = clientid;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1376d), SqlDbType.NVarChar, 100);
			sqlParameter[1].Value = token;
			try
			{
				string connection = this.Connection;
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1377a), sqlParameter);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str, MsgBoxStyle.OkOnly, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13793));
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public bool UpdateEFTPayment(int EFTQueueID, bool bApprove, string status, int clientid, int LocNum, string DelThisFunction)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[] { new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1394d), SqlDbType.Int, 8), null, null, null, null };
			sqlParameter[0].Value = EFTQueueID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13964), SqlDbType.Bit, 2);
			sqlParameter[1].Value = bApprove;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13977);
			sqlParameter[2] = new SqlParameter(str, SqlDbType.NVarChar, 100);
			sqlParameter[2].Value = status;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13f9c);
			sqlParameter[3] = new SqlParameter(str1, SqlDbType.Int, 8);
			sqlParameter[3].Value = clientid;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.Int, 8);
			sqlParameter[4].Value = LocNum;
			try
			{
				string connection = this.Connection;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13faf);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str3, sqlParameter);
				flag = true;
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				Exception exception = exception2;
				try
				{
					AssemblyInfo info = c0dd4fc6869fba3aacef6b22faaca2a82.cb296b1c82b13ff219c49aa2497e71996.Info;
					string productName = info.ProductName;
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a37);
					frmError _frmError = new frmError(exception, productName, str4, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x13a42));
					DialogResult dialogResult = _frmError.ShowDialog();
					_frmError = null;
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
	}
}