using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlLibrary
{
	public class dbCategory : SqlBase
	{
		public dbCategory()
		{
		}

		public bool AddCategory(string name)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6a25), SqlDbType.NVarChar, 50)
			{
				Value = name
			};
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6db6);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null);
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

		public bool AddReferal(string name)
		{
			bool flag;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6a25);
			SqlParameter sqlParameter = new SqlParameter(str, SqlDbType.NVarChar, 50)
			{
				Value = name
			};
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d76);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null);
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

		public bool AddSkin(string name)
		{
			bool flag;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6a25);
			SqlParameter sqlParameter = new SqlParameter(str, SqlDbType.NVarChar, 50)
			{
				Value = name
			};
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d99);
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

		public DataSet CategoryList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d51);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cf9);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public bool DeleteCategory(int ID)
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
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e1f), sqlParameter, null, null, null, null, null, null);
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

		public bool DeleteReferal(int ID)
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
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6dd3), sqlParameter, null, null, null, null, null, null);
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

		public bool DeleteSkinType(int ID)
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
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6dfc);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = exception.ToString();
				Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public int IsCategoryInUse(int ID)
		{
			int integer;
			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6eb3);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null, null, null);
				integer = Conversions.ToInteger(obj);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = exception.ToString();
				Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				integer = -1;
				ProjectData.ClearProjectError();
			}
			return integer;
		}

		public int IsReferalInUse(int ID)
		{
			int num;
			SqlParameter sqlParameter = new SqlParameter();
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter = new SqlParameter(str, SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e42);
				object obj = this.ADOFillScalar(connection, CommandType.StoredProcedure, str1, sqlParameter, null, null, null, null, null, null, null, null);
				int integer = Conversions.ToInteger(obj);
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str2 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str2, MsgBoxStyle.OkOnly, null);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public int IsSkinInUse(int ID)
		{
			int num;
			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e96);
				int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str, sqlParameter, null, null, null, null, null, null, null, null));
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = exception.ToString();
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public bool Reassign(int ID, int NewID, string ReassignType)
		{
			bool flag;
			SqlParameter[] sqlParameter = new SqlParameter[3];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e65);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e72), SqlDbType.Int, 8);
			sqlParameter[1].Value = NewID;
			sqlParameter[2] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6917), SqlDbType.NVarChar, 10);
			sqlParameter[2].Value = ReassignType;
			try
			{
				string connection = this.Connection;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6e7f);
				int num = this.ADOFillNonQuery(connection, CommandType.StoredProcedure, str1, sqlParameter);
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

		public DataSet ReferralList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cd4);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (SqlException sqlException)
			{
				ProjectData.SetProjectError(sqlException);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cf9);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cf9);
				Interaction.MsgBox(str2, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}

		public DataSet SkinTypeList()
		{
			DataSet dataSet;
			try
			{
				string connection = this.Connection;
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6d2c);
				DataSet dataSet1 = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
				dataSet = dataSet1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x6cf9);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(str1, MsgBoxStyle.OkOnly, null);
				dataSet = null;
				ProjectData.ClearProjectError();
			}
			return dataSet;
		}
	}
}