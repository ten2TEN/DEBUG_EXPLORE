using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlLibrary
{
	public class dbBucket : SqlBase
	{
		public dbBucket()
		{
		}

		public DataSet LoadBucketbyID(int BucketID)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cb3);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6982);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)BucketID), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (SqlException sqlException1)
			{
				ProjectData.SetProjectError(sqlException1);
				SqlException sqlException = sqlException1;
				if (!sqlException.ToString().Contains(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6bb3)))
				{
					string str2 = sqlException.ToString();
					MsgBoxResult msgBoxResult = Interaction.MsgBox(str2, MsgBoxStyle.OkOnly, null);
				}
				else
				{
					MsgBoxResult msgBoxResult1 = Interaction.MsgBox(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6bc6), MsgBoxStyle.Critical, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6c82));
				}
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet LoadBucketbyName(string name)
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b77);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6b9c);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, name), null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (SqlException sqlException1)
			{
				ProjectData.SetProjectError(sqlException1);
				SqlException sqlException = sqlException1;
				string str2 = sqlException.ToString();
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6bb3);
				if (!str2.Contains(str3))
				{
					MsgBoxResult msgBoxResult = Interaction.MsgBox(sqlException.ToString(), MsgBoxStyle.OkOnly, null);
				}
				else
				{
					string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6bc6);
					string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6c82);
					MsgBoxResult msgBoxResult1 = Interaction.MsgBox(str4, MsgBoxStyle.Critical, str5);
				}
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}
	}
}