using A;
using Microsoft.ApplicationBlocks.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;

namespace TimerObjects
{
	public class SqlBase
	{
		private string c764459387bd136d535f4a56782f12efc;

		private string ce30e0eb73281ad0cd1fdb07283325c64;

		private string cec9c93dead17e61b6e5805deaef67851;

		private string c6ee129aae3262e118a883f7593b00251;

		private string cbfc6ddcc76755a3fc333bf14254e0b32;

		public string Connection
		{
			get
			{
				DbLocation dbLocation = new DbLocation();
				dbLocation.SetCryptValues();
				dbLocation.CryptLoad();
				string str = dbLocation.db;
				this.Server = str;
				string userName = dbLocation.UserName;
				this.UserID = userName;
				this.Password = dbLocation.Password;
				string port = dbLocation.Port;
				this.Port = port;
				string[] userID = new string[10];
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x250a);
				userID[0] = str1;
				string server = this.Server;
				userID[1] = server;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2519);
				userID[2] = str2;
				string port1 = this.Port;
				userID[3] = port1;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x251c);
				userID[4] = str3;
				userID[5] = dbLocation.dbName;
				userID[6] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2531);
				userID[7] = this.UserID;
				userID[8] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x253c);
				string password = this.Password;
				userID[9] = password;
				string str4 = string.Concat(userID);
				return str4;
			}
		}

		public string ConnectionMaster
		{
			get
			{
				DbLocation dbLocation = new DbLocation();
				dbLocation.SetCryptValues();
				dbLocation.CryptLoad();
				string str = dbLocation.db;
				this.Server = str;
				this.UserID = dbLocation.UserName;
				string password = dbLocation.Password;
				this.Password = password;
				string port = dbLocation.Port;
				this.Port = port;
				string str1 = dbLocation.dbName;
				this.Database = str1;
				string[] strArrays = new string[] { c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x250a), this.Server, c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2519), this.Port, null, null, null, null };
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2547);
				strArrays[4] = str2;
				string userID = this.UserID;
				strArrays[5] = userID;
				strArrays[6] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x253c);
				string password1 = this.Password;
				strArrays[7] = password1;
				string str3 = string.Concat(strArrays);
				return str3;
			}
		}

		public string Database
		{
			get
			{
				return this.ce30e0eb73281ad0cd1fdb07283325c64;
			}
			set
			{
				this.ce30e0eb73281ad0cd1fdb07283325c64 = value;
			}
		}

		public string Password
		{
			get
			{
				return this.c6ee129aae3262e118a883f7593b00251;
			}
			set
			{
				this.c6ee129aae3262e118a883f7593b00251 = value;
			}
		}

		public string Port
		{
			get
			{
				return this.cbfc6ddcc76755a3fc333bf14254e0b32;
			}
			set
			{
				this.cbfc6ddcc76755a3fc333bf14254e0b32 = value;
			}
		}

		public string Server
		{
			get
			{
				return this.c764459387bd136d535f4a56782f12efc;
			}
			set
			{
				this.c764459387bd136d535f4a56782f12efc = value;
			}
		}

		public string UserID
		{
			get
			{
				return this.cec9c93dead17e61b6e5805deaef67851;
			}
			set
			{
				this.cec9c93dead17e61b6e5805deaef67851 = value;
			}
		}

		public SqlBase()
		{
		}

		public bool CreateDB()
		{
			bool flag;
			try
			{
				string[] password = new string[8];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x250a);
				password[0] = str;
				string server = this.Server;
				password[1] = server;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2519);
				password[2] = str1;
				string port = this.Port;
				password[3] = port;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2547);
				password[4] = str2;
				string userID = this.UserID;
				password[5] = userID;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x253c);
				password[6] = str3;
				password[7] = this.Password;
				string str4 = string.Concat(password);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x26be);
				int num = SqlHelper.ExecuteNonQuery(str4, CommandType.StoredProcedure, str5);
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

		public DataSet getDatabases(string server, string uid, string pwd, string port, string dbname)
		{
			// 
			// Current member / type: System.Data.DataSet TimerObjects.SqlBase::getDatabases(System.String,System.String,System.String,System.String,System.String)
			// File path: C:\Users\ten2T\Downloads\TanTrak\Source\Repack\Scripts\Scripts\TimerObjects.dll
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Data.DataSet getDatabases(System.String,System.String,System.String,System.String,System.String)
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

		public bool IsConnect(string server, string uid, string pwd, string port, string dbName)
		{
			bool flag;
			try
			{
				string[] strArrays = new string[10];
				string str = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x250a);
				strArrays[0] = str;
				strArrays[1] = server;
				strArrays[2] = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2519);
				strArrays[3] = port;
				string str1 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x251c);
				strArrays[4] = str1;
				strArrays[5] = dbName;
				string str2 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2531);
				strArrays[6] = str2;
				strArrays[7] = uid;
				string str3 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x253c);
				strArrays[8] = str3;
				strArrays[9] = pwd;
				string str4 = string.Concat(strArrays);
				string str5 = c509d0298614329a40be24aa683d5ad1d.c2a612a176ab45500f820316f6e1b7149(0x2572);
				DataSet dataSet = SqlHelper.ExecuteDataset(str4, CommandType.StoredProcedure, str5);
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