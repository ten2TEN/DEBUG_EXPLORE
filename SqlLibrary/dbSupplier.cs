using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlLibrary
{
	public class dbSupplier : SqlBase
	{
		private SqlParameter[] cd955ea14127f673c1e77e436c7b2d31e;

		public dbSupplier()
		{
		}

		public DataSet CountryList()
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b79);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, null, null, null, null, null, null, null, null, null);
		}

		public bool DeleteNote(int ID)
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
				int num = this.ADOFillNonQuery(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14970), sqlParameter, null, null, null, null, null, null);
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

		public bool DeleteSupplier(int ID)
		{
			bool flag;
			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), SqlDbType.Int, 8)
			{
				Value = ID
			};
			try
			{
				int num = this.ADOFillNonQuery(this.Connection, CommandType.StoredProcedure, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14834), sqlParameter, null, null, null, null, null, null);
				flag = true;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				string str = exception.ToString();
				Interaction.MsgBox(str, MsgBoxStyle.OkOnly, null);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public DataSet Load(string ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x147b3);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, ID), null, null, null, null, null, null, null, null);
			return dataSet;
		}

		public DataSet LoadNotes(int ID)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1480d);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(str1, (object)ID), null, null, null, null, null, null, null, null);
		}

		public DataSet LoadSupplierPrevNext(string ID, bool IsPrev)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x147d8);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b), ID), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x122f4), (object)IsPrev), null, null, null, null, null, null, null);
			return dataSet;
		}

		public int Save(int ID, string Name, string Address, string City, string WebAddress, string State, string Zip, string Firstname, string Lastname, string Email, string TollFree, string Direct, string Cell, string Fax, string Creditlimit, string NetTerms, string AccountNum, string ext, string Country, string County)
		{
			int num;
			SqlParameter[] sqlParameter = new SqlParameter[21];
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x595b);
			sqlParameter[0] = new SqlParameter(str, SqlDbType.Int, 8);
			sqlParameter[0].Value = ID;
			sqlParameter[1] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d27), SqlDbType.NVarChar, 50);
			sqlParameter[1].Value = Name;
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x75cb);
			sqlParameter[2] = new SqlParameter(str1, SqlDbType.NVarChar, 50);
			sqlParameter[2].Value = Address;
			sqlParameter[3] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x75dc), SqlDbType.NVarChar, 50);
			sqlParameter[3].Value = City;
			string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14857);
			sqlParameter[4] = new SqlParameter(str2, SqlDbType.NVarChar, 50);
			sqlParameter[4].Value = WebAddress;
			string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x75e7);
			sqlParameter[5] = new SqlParameter(str3, SqlDbType.NVarChar, 50);
			sqlParameter[5].Value = State;
			string str4 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x75f4);
			sqlParameter[6] = new SqlParameter(str4, SqlDbType.NVarChar, 10);
			sqlParameter[6].Value = Zip;
			string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e08);
			sqlParameter[7] = new SqlParameter(str5, SqlDbType.NVarChar, 30);
			sqlParameter[7].Value = Firstname;
			string str6 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e1d);
			sqlParameter[8] = new SqlParameter(str6, SqlDbType.NVarChar, 30);
			sqlParameter[8].Value = Lastname;
			string str7 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x75fd);
			sqlParameter[9] = new SqlParameter(str7, SqlDbType.NVarChar, 50);
			sqlParameter[9].Value = Email;
			string str8 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x1486e);
			sqlParameter[10] = new SqlParameter(str8, SqlDbType.NVarChar, 50);
			sqlParameter[10].Value = TollFree;
			string str9 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14881);
			sqlParameter[11] = new SqlParameter(str9, SqlDbType.NVarChar, 50);
			sqlParameter[11].Value = Direct;
			string str10 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x75c0);
			sqlParameter[12] = new SqlParameter(str10, SqlDbType.NVarChar, 15);
			sqlParameter[12].Value = Cell;
			string str11 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14890);
			sqlParameter[13] = new SqlParameter(str11, SqlDbType.NVarChar, 50);
			sqlParameter[13].Value = Fax;
			sqlParameter[14] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14899), SqlDbType.NVarChar, 50);
			sqlParameter[14].Value = Creditlimit;
			sqlParameter[15] = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x148b2), SqlDbType.NVarChar, 50);
			sqlParameter[15].Value = NetTerms;
			string str12 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x148c5);
			sqlParameter[16] = new SqlParameter(str12, SqlDbType.NVarChar, 50);
			sqlParameter[16].Value = AccountNum;
			string str13 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7640);
			sqlParameter[17] = new SqlParameter(str13, SqlDbType.NVarChar, 50);
			sqlParameter[17].Value = ext;
			string str14 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7680);
			sqlParameter[18] = new SqlParameter(str14, SqlDbType.NVarChar, 50);
			sqlParameter[18].Value = Country;
			string str15 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x76af);
			sqlParameter[19] = new SqlParameter(str15, SqlDbType.NVarChar, 50);
			sqlParameter[19].Value = County;
			string str16 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5b78);
			sqlParameter[20] = new SqlParameter(str16, SqlDbType.Int, 8);
			sqlParameter[20].Value = 0;
			try
			{
				string connection = this.Connection;
				string str17 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x148dc);
				int integer = Conversions.ToInteger(this.ADOFillScalar(connection, CommandType.StoredProcedure, str17, sqlParameter));
				num = integer;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MsgBoxResult msgBoxResult = Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public bool SaveNotes(int NoteID, int SupplierID, string Notes, string EmpName, bool IsNew, int locnum)
		{
			// 
			// Current member / type: System.Boolean SqlLibrary.dbSupplier::SaveNotes(System.Int32,System.Int32,System.String,System.String,System.Boolean,System.Int32)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\SqlLibrary.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Boolean SaveNotes(System.Int32,System.Int32,System.String,System.String,System.Boolean,System.Int32)
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

		public DataSet SearchSupplier(string Name, string Firstname, string LastName, string PhoneArea, bool IsDemo)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x14790);
			SqlParameter sqlParameter = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d27), Name);
			SqlParameter sqlParameter1 = new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e08), Firstname);
			string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x8e1d);
			DataSet dataSet = this.ADOFilldataset(connection, CommandType.StoredProcedure, str, sqlParameter, sqlParameter1, new SqlParameter(str1, LastName), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7a97), PhoneArea), new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x5d6b), (object)IsDemo), null, null, null, null);
			return dataSet;
		}

		public DataSet StateList(string country)
		{
			string connection = this.Connection;
			string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7b5a);
			return this.ADOFilldataset(connection, CommandType.StoredProcedure, str, new SqlParameter(c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x7680), country), null, null, null, null, null, null, null, null);
		}
	}
}