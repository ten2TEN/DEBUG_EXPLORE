using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SqlLibrary
{
	public class dbWaiting : SqlBase
	{
		public dbWaiting()
		{
		}

		public bool DeleteCustomer(int ID)
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14a50);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null);
				flag = num != 0;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
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
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				sqlParameter[1] = new SqlParameter(str2, SqlDbType.Int, 8);
				sqlParameter[1].Value = StoreNum;
				string connection = this.Connection;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b58);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str3, sqlParameter);
				string str4 = Conversions.ToString(obj);
				str = str4;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str5 = Conversions.ToString(0);
				str = str5;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public DataSet Load(int storeNum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1499b);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)storeNum), null, null, null, null, null, null, null, null);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				string str2 = exception.ToString();
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7956);
				bool flag = str2.Contains(str3);
				if (!flag)
				{
					string str4 = exception.ToString();
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0xd6c5);
					bool flag1 = str4.Contains(str5);
					if (!flag1)
					{
						string str6 = exception.ToString();
						Interaction.MsgBox(str6, MsgBoxStyle.OkOnly, null);
					}
					else
					{
						string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x149ce);
						MsgBoxResult msgBoxResult = Interaction.MsgBox(str7, MsgBoxStyle.OkOnly, null);
					}
				}
				else
				{
					string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7965);
					Interaction.MsgBox(str8, MsgBoxStyle.OkOnly, null);
				}
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadBedStatus(int storeNum)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14a29);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5675);
				dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)storeNum), null, null, null, null, null, null, null, null);
			}
			catch (IOException oException)
			{
				ProjectData.SetProjectError(oException);
				string message = oException.Message;
				Interaction.MsgBox(message, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			catch (DataException dataException)
			{
				ProjectData.SetProjectError(dataException);
				string message1 = dataException.Message;
				MsgBoxResult msgBoxResult = Interaction.MsgBox(message1, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string message2 = exception.Message;
				MsgBoxResult msgBoxResult1 = Interaction.MsgBox(message2, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool StopBed(int ID, string Status, int StoreNum, int clientID, int duration, int clientpkgID, string timer = "")
		{
			bool flag;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14a7b);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
				SqlParameter sqlParameter = new SqlParameter(str1, (object)ID);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14428);
				SqlParameter sqlParameter1 = new SqlParameter(str2, Status);
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b65);
				SqlParameter sqlParameter2 = new SqlParameter(str3, (object)StoreNum);
				string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7f0c);
				SqlParameter sqlParameter3 = new SqlParameter(str4, (object)clientID);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14a90);
				SqlParameter sqlParameter4 = new SqlParameter(str5, (object)duration);
				string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14aa3);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, new SqlParameter(str6, (object)clientpkgID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14abc), timer));
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
	}
}